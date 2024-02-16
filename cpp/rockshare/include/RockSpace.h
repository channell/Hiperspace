// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#pragma once
#include <rocksdb/db.h>
#include "Hiperspace.pb.h"
#include <zlib.h>
#include <grpc/status.h>

using namespace std;
using rocksdb::DB;
using namespace rocksdb;
using namespace google::protobuf;

namespace Hiperspace
{
	//
	// Access to the functionality of RocksDB through familiar interface
	//
	class RockSpace
	{
	private:
		//
		// reference to the rockDB connection, help opt ofor the lifecycle of the RockSpace
		//
		unique_ptr<rocksdb::DB> _db;

		//
		// Max value of a uint64 inported from .NET
		//
		const uint64_t MaxValue = 18446744073709551615LL;

		// 
		// Min value of a uint
		//
		const uint64_t MinValue = 0LL;

		//
		// the unix origin 01/01/1970 adjusted to 01/01/0001
		//
		const int64_t Origin = 621355968000000000L;

		//
		// Clock ticks per second
		// 
		const int64_t TicksPerSecond = 10000000LL;
		// 
		// concatinate the source key, version number using buffer
		//
		Slice toVersion(const string& source, Timestamp version, string& buffer);

		// 
		// concatinate the source key, version number (high or low value) for find using buffer
		//
		Slice toVersion(const string& source, uint64_t version, string& buffer);

		//
		// convert the rocks slice to a string that can be returned by grpc
		//
		inline string toString(Slice source)
		{
			return string(source.data(), source.size());
		}

		//
		// Convert the Hiperspace version number to a google timestamp
		// !! the Timestamp object will be released by grpc
		//
		Timestamp* toTimeStamp(int64_t source);

		//
		// Convert protobuf timestamp to a hiperspace version
		//
		int64_t fromTimeStamp(const Timestamp& source);


		//
		// extract the timestamp from the rocksDB Slice
		//
		int64_t extractVersion(Slice source);

	public:
		//
		// Create a new RocksDB context using a grpc request
		//
		RockSpace(OpenRequest& request);
		~RockSpace();

		unique_ptr<Value> Bind(const BindRequest& request);
		unique_ptr<ValueVersion> Bind(const BindVersionRequest& request);

		unique_ptr<Values> BatchBind(const BatchBindRequest& request);
		unique_ptr<Values> BatchBind(const BatchBindVersionRequest& request);

		unique_ptr<Values> Find(const FindRequest& request);
		unique_ptr<ValueVersions> Find(const FindVersionRequest& request);

		unique_ptr<Value> Get(const KeyRequest& request);
		unique_ptr<ValueVersion> Get(const KeyVersionRequest& request);

		unique_ptr<VersionHistory> GetVersions(const KeyRequest& request);
	};
}