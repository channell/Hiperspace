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
#include <tbb/spin_mutex.h>
#include <thread>

using namespace std;
using rocksdb::DB;
using tbb::concurrent_hash_map;
using tbb::spin_mutex;

namespace Hiperspace
{
	// Pooled connections to hierspace files, with a background thread to close expired connections
	class SpacePool
	{
	private:
		// Hashmap to a set of hyperspace files. 
		concurrent_hash_map <string, shared_ptr<SpaceConnection>> _stores;
		// Hash map of current active sessions. 
		concurrent_hash_map <string, shared_ptr<SpaceConnection>> _sessions;

		// Flag for graceful shutdown. 
		bool _alive = true;
		// Time out for sessions. 
		chrono::seconds _ttl;
		// Background thread to check for timed out sessions. 
		unique_ptr<std::thread> _timer;

	public:
		// Threadproc for timer. 
		void CheckTime() noexcept;
		SpacePool(chrono::seconds ttl);
		~SpacePool();
		// Open a new session, and open file if not already open. 
		shared_ptr<SpaceConnection> Open(const OpenRequest* request);
		// Gracefully closed the session without waiting for timeout. 
		void Close(const Token* token);
		// Find the session handle for the token provided in the bind/find/get call. 
		shared_ptr<SpaceConnection> Find(const Token& token);
	};
}