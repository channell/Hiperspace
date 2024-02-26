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
#include "RockSpace.h"
#include <tbb/spin_mutex.h>
#include <tbb/spin_rw_mutex.h>

using namespace std;
using rocksdb::DB;
using tbb::spin_rw_mutex;

namespace Hiperspace
{
	// connection to the rocks DB that can be re-opened 
	class SpaceConnection
	{
	private:
		unique_ptr<RockSpace> _space;
		clock_t _clock;
		// Spinlock to prevent close of connections while rocks is currently being used
		spin_rw_mutex _mux;
		// Reopen the connexion if it has been closed due to time out. 
		void Open();

	public:
		// Copy of the GRPC open request used for reconnection. 
		unique_ptr<OpenRequest> Context;

		SpaceConnection(const OpenRequest* request);

		const clock_t& getClock() { return _clock; }

		//
		// Interface functions defined in hiperspace protophile. 
		//
		void Close();
		
		unique_ptr<Value> Bind(const BindRequest& request);
		unique_ptr<ValueVersion> Bind(const BindVersionRequest& request);

		unique_ptr<Values> BatchBind(const BatchBindRequest& request);
		unique_ptr<Values> BatchBind(const BatchBindVersionRequest& request);

		unique_ptr<Values> Find(const FindRequest& request);
		unique_ptr<ValueVersions> Find(const FindVersionRequest& request);
		unique_ptr<Values> FindIndex(const FindRequest& request);
		unique_ptr<ValueVersions> FindIndex(const FindVersionRequest& request);

		unique_ptr<Value> Get(const KeyRequest& request);
		unique_ptr<ValueVersion> Get(const KeyVersionRequest& request);

		unique_ptr<VersionHistory> GetVersions(const KeyRequest& request);
	};
}