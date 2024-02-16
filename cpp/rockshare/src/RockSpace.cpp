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

		if (!(rc = DB::Open(options, request.path(), &db)).ok())
		{
			try
			{
				options.compression = CompressionType::kNoCompression;
				if (!(rc = DB::Open(options, request.path(), &db)).ok())
				{
					throw RocksExcpetion(rc.ToString());
				}
			}
			catch (exception&)
			{
				throw RocksExcpetion(rc.ToString());
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
			unique_ptr<Value> ret(new Value());
			ret->set_content(value);
			ret->set_state (ResponseState::Skip);
			return move(ret);
		}

		if (!(rc = _db->Put(WriteOptions(), key, Slice(request.value()))).ok())
		{
			throw RocksExcpetion(rc.ToString());
		}
		unique_ptr<Value> ret(new Value());
		ret->set_content(request.value());
		ret->set_state(ResponseState::Skip);
		return move(ret);
	}

	unique_ptr<Values> RockSpace::BatchBind(const BatchBindRequest& request)
	{
		auto value = request.value();
		unique_ptr<Values> result(new Values);
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
		unique_ptr<Values> result(new Values);
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
			unique_ptr<ValueVersion> v(new ValueVersion());
			v->set_content(current->content());
			v->set_state(ResponseState::Skip);
			return move(v);
		}
		if (current->content().length() != 0 && current->content() == request.value())
		{
			unique_ptr<ValueVersion> v(new ValueVersion());
			v->set_content(current->content());
			v->set_state(ResponseState::Skip);
			return move(v);
		}

		rocksdb::Status s;
		if (!(s = _db->Put(WriteOptions(), Slice(key), Slice(request.value()))).ok())
		{
			throw RocksExcpetion(s.ToString());
		}
		unique_ptr<ValueVersion> v(new ValueVersion());
		v->set_content(current->content());
		v->set_state(ResponseState::Ok);
		return move(v);
	}

	unique_ptr<Values> RockSpace::Find(const FindRequest& request)
	{
		unique_ptr<Values> result(new Values);
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
	unique_ptr<ValueVersions> RockSpace::Find(const FindVersionRequest& request)
	{
		unique_ptr<ValueVersions> result(new ValueVersions());
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

	unique_ptr<Value> RockSpace::Get(const KeyRequest& request)
	{
		unique_ptr<Value> result(new Value());
		rocksdb::Status s;
		string value;
		if (!(s = _db->Get(ReadOptions(), Slice(request.key()), &value)).ok())
		{
			throw RocksExcpetion(s.ToString());
		}
		result->set_allocated_content(&value);
		return move(result);
	}
	unique_ptr<ValueVersion> RockSpace::Get(const KeyVersionRequest& request)
	{
		unique_ptr<ValueVersion> result(new ValueVersion);
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
						unique_ptr<ValueVersion> result(new ValueVersion());
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
			unique_ptr<ValueVersion> result(new ValueVersion());
			result->set_content(toString(lastvalue));
			result->set_state(ResponseState::Ok);
			result->set_allocated_version(toTimeStamp(lastversion));
			return move(result);
		}
		return move(result);
	}

	unique_ptr<VersionHistory> RockSpace::GetVersions(const KeyRequest& request)
	{
		unique_ptr<VersionHistory> result(new VersionHistory);
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
}