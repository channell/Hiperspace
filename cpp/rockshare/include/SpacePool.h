// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#pragma once
#include "SpaceConnection.h"
#include <unordered_map>
#include <rocksdb/db.h>

#include "Hiperspace.pb.h"
#include <tbb/task.h>
#include <tbb/concurrent_hash_map.h>
#include "Token.h"
#include <tbb/spin_mutex.h>
#include <thread>

using namespace std;
using rocksdb::DB;
using tbb::concurrent_hash_map;
using tbb::spin_mutex;

namespace Hiperspace
{
	class SpacePool
	{
	private:
		concurrent_hash_map <string, shared_ptr<SpaceConnection>> _stores;
		concurrent_hash_map <string, shared_ptr<SpaceConnection>> _sessions;

		spin_mutex _lock;
		bool _alive = true;
		chrono::seconds _ttl;
		unique_ptr<std::thread> _timer;

	public:
		void CheckTime() noexcept;
		SpacePool(chrono::seconds ttl);
		~SpacePool();
		shared_ptr<SpaceConnection> Open(const OpenRequest* request);
		void Close(const Token* token);
		shared_ptr<SpaceConnection> Find(const Token& token);
	};
}