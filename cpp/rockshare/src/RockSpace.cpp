// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#include "RockSpace.h"
#include "HipException.h"
#include <boost/endian/conversion.hpp>
#include <boost/endian.hpp>
#include <type_traits>
#include <span>
#include <cstddef>
#include <google/protobuf/arena.h>

using namespace rocksdb;
using namespace boost;
using namespace std;
using google::protobuf::Timestamp;

namespace Hiperspace
{
	RockSpace::RockSpace(OpenRequest& request)
	{
		Options options;
		options.create_if_missing = true;
		options.error_if_exists = false;

		if (request.compression())
		{
			options.compression = CompressionType::kSnappyCompression;
		}

		DB* db;
		rocksdb::Status rc;

		if (!(rc = request.read() ?  DB::OpenForReadOnly(options, request.path(), &db) : DB::Open(options, request.path(), &db)).ok())
		{
			try
			{
				options.compression = CompressionType::kNoCompression;
				if (!(rc = request.read() ? DB::OpenForReadOnly(options, request.path(), &db) : DB::Open(options, request.path(), &db)).ok())
				{
					throw RocksException(rc.ToString());
				}
			}
			catch (exception&)
			{
				throw RocksException(rc.ToString());
			}
		}

		if (!request.metamodel().empty())
		{
			char meta[2]{ '\0','\0' };
			auto key = Slice(meta, sizeof(meta));
			string value;
			auto model = request.metamodel();
			rc = db->Get(ReadOptions(), key, &value);
			if (rc.ok() && value == model || value == "")		// need to check why meta-data is not retrieved
			{
				_db.reset(db);
				return;
			}
			else
			{
				throw MutationException();
			}
		}

		_db.reset(db);
	}

	RockSpace::~RockSpace()
	{
		_db->Flush(FlushOptions());
		_db->Close();
	}

	Slice RockSpace::toVersion(const string& source, Timestamp version, string& buffer)
	{
		Slice slices[3];

		slices[0] = Slice("\0", 1);
		slices[1] = source;

		int64_t ver = RockSpace::MaxValue - fromTimeStamp(version);
		auto big = boost::endian::native_to_big(ver);
		slices[2] = Slice((char*)&big, sizeof(uint64_t));

		const struct SliceParts parts(slices, 3);
		Slice slice(parts, &buffer);
		return slice;
	}
	
	Slice RockSpace::toVersion(const string& source, uint64_t version, string& buffer)
	{
		Slice slices[3];

		slices[0] = Slice("\0", 1);
		slices[1] = source;

		auto big = boost::endian::native_to_big(version);
		slices[2] = Slice((char*)&big, sizeof(uint64_t));

		const struct SliceParts parts(slices, 3);
		Slice slice(parts, &buffer);
		return slice;
	}

	inline Slice stripVersion(Slice source)
	{
		source.remove_prefix(1);
		source.remove_suffix(sizeof(uint64_t));
		return source;
	}

	Timestamp* RockSpace::toTimeStamp(int64_t source)
	{
		Timestamp* ts = new Timestamp();
		auto ver = source - Origin;
		int64_t seconds = ver / TicksPerSecond;
		int32_t nanos = (ver - (seconds * TicksPerSecond)) * 100;
		ts->set_seconds(seconds);
		ts->set_nanos(nanos);
		return ts; // NB will be released by grpc
	}

	int64_t RockSpace::fromTimeStamp(const Timestamp& source)
	{
		int64_t seconds = source.seconds();
		int32_t nanos = source.nanos();

		int64_t ver =
			(seconds * 10000000LL) +
			(nanos / 100) +
			RockSpace::Origin;

		return ver;
	}

	int64_t RockSpace::extractVersion(Slice source)
	{
		char* keypoint = const_cast<char*>(source.data()) + source.size() - sizeof(uint64_t);
		uint64_t keyver = *((uint64_t*)keypoint);
		auto var = RockSpace::MaxValue - boost::endian::big_to_native(keyver);
		return var;
	}

	unique_ptr<Value> RockSpace::Bind(const BindRequest& request)
	{
		rocksdb::Status rc;
		auto key = Slice(request.key());
		string value;
		if (_db->Get(ReadOptions(), key, &value).ok())
		{
			auto ret = make_unique<Value>();
			ret->set_content(value);
			ret->set_state (ResponseState::Skip);
			return move(ret);
		}

		if (!(rc = _db->Put(WriteOptions(), key, Slice(request.value()))).ok())
		{
			throw RocksException(rc.ToString());
		}
		unique_ptr<Value> ret(google::protobuf::Arena::CreateMessage<Value>(request.GetArena()));
		ret->set_content(request.value());
		ret->set_state(ResponseState::Skip);
		return move(ret);
	}

	unique_ptr<Values> RockSpace::BatchBind(const BatchBindRequest& request)
	{
		auto value = request.value();
		auto result = make_unique<Values>();
		for (auto i = begin(value); i != end(value); i++)
		{
			auto value = Bind(*i);
			KeyValue* row = result->add_content();
			row->set_key(i->key());
			row->set_value(value->content());
		}
		return move(result);
	}
	unique_ptr<Values> RockSpace::BatchBind(const BatchBindVersionRequest& request)
	{
		auto value = request.value();
		unique_ptr<Values> result(google::protobuf::Arena::CreateMessage<Values>(request.GetArena()));
		for (auto i = begin(value); i != end(value); i++)
		{
			auto value = Bind(*i);
			KeyValue* row = result->add_content();
			row->set_key(i->key());
			row->set_value(value->content());
		}
		return move(result);
	}

	unique_ptr<ValueVersion> RockSpace::Bind(const BindVersionRequest& request)
	{
		string keyBuffer;
		auto key = toVersion(request.key(), request.version(), keyBuffer);

		KeyVersionRequest req;
 		req.set_key(request.key());
		req.set_allocated_version(new Timestamp(request.version()));
		auto current = Get(req);
		Timestamp curentVersion = current->version();

		if (curentVersion.seconds() == request.version().seconds() &&
			curentVersion.nanos() == request.version().nanos())
		{
			unique_ptr<ValueVersion> v(google::protobuf::Arena::CreateMessage<ValueVersion>(request.GetArena()));
			v->set_content(current->content());
			v->set_state(ResponseState::Skip);
			return move(v);
		}
		if (current->content().length() != 0 && current->content() == request.value())
		{
			unique_ptr<ValueVersion> v(google::protobuf::Arena::CreateMessage<ValueVersion>(request.GetArena()));
			v->set_content(current->content());
			v->set_state(ResponseState::Skip);
			return move(v);
		}

		rocksdb::Status s;
		if (!(s = _db->Put(WriteOptions(), Slice(key), Slice(request.value()))).ok())
		{
			throw RocksException(s.ToString());
		}
		unique_ptr<ValueVersion> v(google::protobuf::Arena::CreateMessage<ValueVersion>(request.GetArena()));
		v->set_content(current->content());
		v->set_state(ResponseState::Ok);
		return move(v);
	}

	unique_ptr<Values> RockSpace::Find(const FindRequest& request)
	{
		unique_ptr<Values> result(google::protobuf::Arena::CreateMessage<Values>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));

		auto begin = Slice(request.begin());
		auto end = request.end();
		iter->Seek(Slice(request.begin()));

		while (iter->Valid())
		{
			auto key = toString(iter->key());
			if (key < end)
			{
				auto value = toString(iter->value());
				auto val = result->add_content();
				val->set_key(key);
				val->set_value(value);
			}
		}
		return move(result);
	}

	void RockSpace::FindAsync(const FindRequest& request, function<void(const KeyValue&)> callback)
	{
		unique_ptr<Values> result(google::protobuf::Arena::CreateMessage<Values>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));

		auto begin = Slice(request.begin());
		auto end = request.end();
		iter->Seek(Slice(request.begin()));

		while (iter->Valid())
		{
			auto key = toString(iter->key());
			if (key < end)
			{
				auto value = toString(iter->value());
				auto val(google::protobuf::Arena::CreateMessage<KeyValue>(request.GetArena()));
				val->set_key(key);
				val->set_value(value);
				callback(*val);
			}
		}
	}

	unique_ptr<ValueVersions> RockSpace::Find(const FindVersionRequest& request)
	{
		unique_ptr<ValueVersions> result(google::protobuf::Arena::CreateMessage<ValueVersions>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));

		string beginBuff;
		string endBuff;
		auto begin = toVersion(request.begin(), RockSpace::MinValue, beginBuff);
		auto end  = toVersion(request.end(), RockSpace::MaxValue, endBuff);

		string lastkey;
		string lastvalue;
		int64_t lastversion = 0;
		bool hasLast = false;

		iter->Seek(begin);
		while (iter->Valid())
		{
			auto key = iter->key();
			if (key.compare(end) < 1)
			{
				auto t = toString(key);
				auto keypart = stripVersion(key);
				if (lastkey.empty() || keypart == lastkey)
				{
					auto ver = extractVersion(key);
					if ((request.has_version() && ver < fromTimeStamp(request.version()) && ver > lastversion) || (!request.has_version() && lastversion == 0))
					{
						lastkey = toString(keypart);
						lastversion = ver;
						lastvalue = toString(iter->value());
						hasLast = true;
					}
				}
				else if (lastversion != 0 && hasLast)
				{
					auto row = result->add_content();
					row->set_key(lastkey);
					row->set_value(lastvalue);
					row->set_allocated_version(toTimeStamp(lastversion));

					lastkey = toString(keypart);
					lastversion = extractVersion(key);
					lastvalue = toString(iter->value());
				}
			}
			else
				break;
			iter->Next();
		}
		if (hasLast)
		{
			auto row = result->add_content();
			row->set_key(lastkey);
			row->set_value(lastvalue);
			row->set_allocated_version(toTimeStamp(lastversion));
		}
		return move(result);
	}

	void RockSpace::FindAsync(const FindVersionRequest& request, function<void(const KeyValueVersion&)> callback)
	{
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));

		string beginBuff;
		string endBuff;
		auto begin = toVersion(request.begin(), RockSpace::MinValue, beginBuff);
		auto end = toVersion(request.end(), RockSpace::MaxValue, endBuff);

		string lastkey;
		string lastvalue;
		int64_t lastversion = 0;
		bool hasLast = false;

		iter->Seek(begin);
		while (iter->Valid())
		{
			auto key = iter->key();
			if (key.compare(end) < 1)
			{
				auto t = toString(key);
				auto keypart = stripVersion(key);
				if (lastkey.empty() || keypart == lastkey)
				{
					auto ver = extractVersion(key);
					if ((request.has_version() && ver < fromTimeStamp(request.version()) && ver > lastversion) || (!request.has_version() && lastversion == 0))
					{
						lastkey = toString(keypart);
						lastversion = ver;
						lastvalue = toString(iter->value());
						hasLast = true;
					}
				}
				else if (lastversion != 0 && hasLast)
				{
					auto row(google::protobuf::Arena::CreateMessage<KeyValueVersion>(request.GetArena()));
					row->set_key(lastkey);
					row->set_value(lastvalue);
					row->set_allocated_version(toTimeStamp(lastversion));
					callback(*row);

					lastkey = toString(keypart);
					lastversion = extractVersion(key);
					lastvalue = toString(iter->value());
				}
			}
			else
				break;
			iter->Next();
		}
		if (hasLast)
		{
			auto row(google::protobuf::Arena::CreateMessage<KeyValueVersion>(request.GetArena()));
			row->set_key(lastkey);
			row->set_value(lastvalue);
			row->set_allocated_version(toTimeStamp(lastversion));
			callback(*row);
		}
	}


	unique_ptr<Values> RockSpace::FindIndex(const FindRequest& request)
	{
		unique_ptr<Values> result(google::protobuf::Arena::CreateMessage<Values>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));
		unique_ptr<Iterator> getiter(_db->NewIterator(ReadOptions()));

		auto begin = Slice(request.begin());
		auto end = request.end();
		iter->Seek(Slice(request.begin()));

		while (iter->Valid())
		{
			auto key = toString(iter->key());
			if (key < end)
			{
				getiter->Seek(iter->value());
				if (getiter->Valid())
				{
					auto value = toString(getiter->value());
					auto val = result->add_content();
					val->set_key(key);
					val->set_value(value);
				}
			}
		}
		return move(result);
	}

	void RockSpace::FindIndexAsync(const FindRequest& request, function<void(const KeyValue&)> callback)
	{
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));
		unique_ptr<Iterator> getiter(_db->NewIterator(ReadOptions()));

		auto begin = Slice(request.begin());
		auto end = request.end();
		iter->Seek(Slice(request.begin()));

		while (iter->Valid())
		{
			auto key = toString(iter->key());
			if (key < end)
			{
				getiter->Seek(iter->value());
				if (getiter->Valid())
				{
					auto value = toString(getiter->value());
					auto val(google::protobuf::Arena::CreateMessage<KeyValue>(request.GetArena()));
					val->set_key(key);
					val->set_value(value);
					callback(*val);
				}
			}
		}
	}

	unique_ptr<ValueVersions> RockSpace::FindIndex(const FindVersionRequest& request)
	{
		unique_ptr<ValueVersions> result(google::protobuf::Arena::CreateMessage<ValueVersions>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));
		unique_ptr<Iterator> getiter(_db->NewIterator(ReadOptions()));

		string beginBuff;
		string endBuff;
		auto begin = toVersion(request.begin(), RockSpace::MinValue, beginBuff);
		auto end = toVersion(request.end(), RockSpace::MaxValue, endBuff);

		string lastkey;
		string lastvalue;
		int64_t lastversion = 0;
		bool hasLast = false;

		iter->Seek(begin);
		while (iter->Valid())
		{
			auto key = iter->key();
			if (key.compare(end) < 1)
			{
				auto t = toString(key);
				auto keypart = stripVersion(key);
				if (lastkey.empty() || keypart == lastkey)
				{
					auto ver = extractVersion(key);
					if ((request.has_version() && ver < fromTimeStamp(request.version()) && ver > lastversion) || (!request.has_version() && lastversion == 0))
					{
						lastkey = toString(keypart);
						lastversion = ver;
						lastvalue = toString(iter->value());
						hasLast = true;
					}
				}
				else if (lastversion != 0 && hasLast)
				{
					auto getkey(google::protobuf::Arena::CreateMessage<KeyVersionRequest>(request.GetArena()));
					auto ts(google::protobuf::Arena::CreateMessage<Timestamp>(request.GetArena()));
					if (request.has_version())
					{
						ts->CopyFrom(request.version());
						getkey->set_allocated_version(ts);
					}
					getkey->set_key(lastvalue);
					auto value = Get(*getkey);
					auto row = result->add_content();
					row->set_key(lastvalue);
					row->set_value(value->content());
					ts->CopyFrom(value->version());
					row->set_allocated_version(ts);

					lastkey = toString(keypart);
					lastversion = extractVersion(key);
					lastvalue = toString(iter->value());
				}
			}
			else
				break;
			iter->Next();
		}
		if (hasLast)
		{
			auto getkey(google::protobuf::Arena::CreateMessage<KeyVersionRequest>(request.GetArena()));
			getkey->set_key(lastvalue);
			auto ts(google::protobuf::Arena::CreateMessage<Timestamp>(request.GetArena()));
			if (request.has_version())
			{
				ts->CopyFrom(request.version());
				getkey->set_allocated_version(ts);
			}
			auto value = Get(*getkey);
			auto row = result->add_content();
			row->set_key(lastvalue);
			row->set_value(value->content());
			ts->CopyFrom(value->version());
			row->set_allocated_version(ts);
		}
		return move(result);
	}

	void RockSpace::FindIndexAsync(const FindVersionRequest& request, function<void(const KeyValueVersion&)> callback)
	{
		unique_ptr<ValueVersions> result(google::protobuf::Arena::CreateMessage<ValueVersions>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));
		unique_ptr<Iterator> getiter(_db->NewIterator(ReadOptions()));

		string beginBuff;
		string endBuff;
		auto begin = toVersion(request.begin(), RockSpace::MinValue, beginBuff);
		auto end = toVersion(request.end(), RockSpace::MaxValue, endBuff);

		string lastkey;
		string lastvalue;
		int64_t lastversion = 0;
		bool hasLast = false;

		iter->Seek(begin);
		while (iter->Valid())
		{
			auto key = iter->key();
			if (key.compare(end) < 1)
			{
				auto t = toString(key);
				auto keypart = stripVersion(key);
				if (lastkey.empty() || keypart == lastkey)
				{
					auto ver = extractVersion(key);
					if ((request.has_version() && ver < fromTimeStamp(request.version()) && ver > lastversion) || (!request.has_version() && lastversion == 0))
					{
						lastkey = toString(keypart);
						lastversion = ver;
						lastvalue = toString(iter->value());
						hasLast = true;
					}
				}
				else if (lastversion != 0 && hasLast)
				{
					auto getkey(google::protobuf::Arena::CreateMessage<KeyVersionRequest>(request.GetArena()));
					auto ts(google::protobuf::Arena::CreateMessage<Timestamp>(request.GetArena()));
					if (request.has_version())
					{
						ts->CopyFrom(request.version());
						getkey->set_allocated_version(ts);
					}
					getkey->set_key(lastvalue);
					auto value = Get(*getkey);
					auto row(google::protobuf::Arena::CreateMessage<KeyValueVersion>(request.GetArena()));
					row->set_key(lastvalue);
					row->set_value(value->content());
					ts->CopyFrom(value->version());
					row->set_allocated_version(ts);
					callback(*row);

					lastkey = toString(keypart);
					lastversion = extractVersion(key);
					lastvalue = toString(iter->value());
				}
			}
			else
				break;
			iter->Next();
		}
		if (hasLast)
		{
			auto getkey(google::protobuf::Arena::CreateMessage<KeyVersionRequest>(request.GetArena()));
			getkey->set_key(lastvalue);
			auto ts(google::protobuf::Arena::CreateMessage<Timestamp>(request.GetArena()));
			if (request.has_version())
			{
				ts->CopyFrom(request.version());
				getkey->set_allocated_version(ts);
			}
			auto value = Get(*getkey);
			auto row(google::protobuf::Arena::CreateMessage<KeyValueVersion>(request.GetArena()));
			row->set_key(lastvalue);
			row->set_value(value->content());
			ts->CopyFrom(value->version());
			row->set_allocated_version(ts);
			callback(*row);
		}
	}

	unique_ptr<Value> RockSpace::Get(const KeyRequest& request)
	{
		unique_ptr<Value> result(google::protobuf::Arena::CreateMessage<Value>(request.GetArena()));
		rocksdb::Status s;
		string value;
		if (!(s = _db->Get(ReadOptions(), Slice(request.key()), &value)).ok())
		{
			throw RocksException(s.ToString());
		}
		result->set_allocated_content(&value);
		return move(result);
	}
	unique_ptr<ValueVersion> RockSpace::Get(const KeyVersionRequest& request)
	{
		unique_ptr<ValueVersion> result(google::protobuf::Arena::CreateMessage<ValueVersion>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));

		string beginBuff;
		auto begin = toVersion(request.key(), RockSpace::MinValue, beginBuff);

		string lastkey;
		string lastvalue;
		int64_t lastversion = 0;
		bool hasLast = false;
		auto requestVer = fromTimeStamp(request.version());

		iter->Seek(begin);
		while (iter->Valid())
		{
			auto keypart = stripVersion(iter->key());
			if (keypart.compare(request.key()) == 0)
			{
				if (lastkey.empty() || keypart == lastkey)
				{
					auto ver = extractVersion(iter->key());
					if (request.has_version())
					{
						if (ver <= requestVer && ver > lastversion)
						{
							lastkey = toString(keypart);
							lastversion = ver;
							lastvalue = toString(iter->value());
							hasLast = true;
						}
					}
					else
					{
						unique_ptr<ValueVersion> result(google::protobuf::Arena::CreateMessage<ValueVersion>(request.GetArena()));
						result->set_content(toString(iter->value()));
						result->set_allocated_version(toTimeStamp(lastversion));
						return move(result);
					}
				}
			}
			else
				break;
			iter->Next();
		}
		if (hasLast)
		{
			unique_ptr<ValueVersion> result(google::protobuf::Arena::CreateMessage<ValueVersion>(request.GetArena()));
			result->set_content(toString(lastvalue));
			result->set_state(ResponseState::Ok);
			result->set_allocated_version(toTimeStamp(lastversion));
			return move(result);
		}
		return move(result);
	}

	unique_ptr<VersionHistory> RockSpace::GetVersions(const KeyRequest& request)
	{
		unique_ptr<VersionHistory> result(google::protobuf::Arena::CreateMessage<VersionHistory>(request.GetArena()));
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));

		string beginBuff;
		string endBuff;
		auto begin = toVersion(request.key(), RockSpace::MinValue, beginBuff);
		auto end = toVersion(request.key(), RockSpace::MaxValue, endBuff);

		FindRequest findRequest;
		findRequest.set_begin(toString(begin));
		findRequest.set_end(toString(end));

		auto response = Find(findRequest);

		for (auto iter = response->content().begin(); iter != response->content().end(); iter++)
		{
			auto row = result->add_content();
			row->set_content(iter->value());
			auto lastversion = extractVersion(iter->key());
			row->set_allocated_version(toTimeStamp(lastversion));
		}
		return move(result);
	}
	void RockSpace::GetVersionsAsync(const KeyRequest& request, function<void(const ValueVersion&)> callback) 
	{
		unique_ptr<Iterator> iter(_db->NewIterator(ReadOptions()));

		string beginBuff;
		string endBuff;
		auto begin = toVersion(request.key(), RockSpace::MinValue, beginBuff);
		auto end = toVersion(request.key(), RockSpace::MaxValue, endBuff);

		FindRequest findRequest;
		findRequest.set_begin(toString(begin));
		findRequest.set_end(toString(end));

		auto response = Find(findRequest);

		for (auto iter = response->content().begin(); iter != response->content().end(); iter++)
		{
			auto row(google::protobuf::Arena::CreateMessage<ValueVersion>(request.GetArena()));
			row->set_content(iter->value());
			auto lastversion = extractVersion(iter->key());
			row->set_allocated_version(toTimeStamp(lastversion));
			callback(*row);
		}
	}
}