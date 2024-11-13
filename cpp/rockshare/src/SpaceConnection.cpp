// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#include "SpaceConnection.h"
using rocksdb::Options;

namespace Hiperspace
{

	SpaceConnection::SpaceConnection(const OpenRequest* request)
	{
		// copy request for owned reference
		Context.reset(new OpenRequest(*request));
		Open();
	}

	inline void SpaceConnection::Open()
	{
		if (_space == nullptr)
			_space.reset(new RockSpace(*Context));
	}
	void SpaceConnection::Close()
	{
		tbb::spin_rw_mutex::scoped_lock lock(_mux, true);
		_space.reset(nullptr);
	}

	unique_ptr<Value> SpaceConnection::Bind(const BindRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->Bind(request);
	}

	unique_ptr<Value> SpaceConnection::Bind(const BindVersionRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->Bind(request);
	}
	unique_ptr<Values> SpaceConnection::BatchBind(const BatchBindRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->BatchBind(request);
	}
	unique_ptr<Values> SpaceConnection::BatchBind(const BatchBindVersionRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->BatchBind(request);
	}

	unique_ptr<Values> SpaceConnection::Find(const FindRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->Find(request);
	}

	void SpaceConnection::FindAsync(const FindRequest& request, function<void(const KeyValue&)> callback)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		_space->FindAsync(request, callback);
	}

	unique_ptr<ValueVersions> SpaceConnection::Find(const FindVersionRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->Find(request);
	}

	void SpaceConnection::FindAsync(const FindVersionRequest& request, function<void(const KeyValueVersion&)> callback)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		_space->FindAsync(request, callback);

	}

	unique_ptr<Values> SpaceConnection::FindIndex(const FindRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->FindIndex(request);
	}

	void SpaceConnection::FindIndexAsync(const FindRequest& request, function<void(const KeyValue&)> callback)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		_space->FindIndexAsync(request, callback);
	}

	unique_ptr<ValueVersions> SpaceConnection::FindIndex(const FindVersionRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->FindIndex(request);
	}
	void SpaceConnection::FindIndexAsync(const FindVersionRequest& request, function<void(const KeyValueVersion&)> callback)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		_space->FindIndexAsync(request, callback);
	}

	unique_ptr<Value> SpaceConnection::Get(const KeyRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->Get(request);
	}
	unique_ptr<ValueVersion> SpaceConnection::Get(const KeyVersionRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->Get(request);
	}

	unique_ptr<VersionHistory> SpaceConnection::GetVersions(const KeyRequest& request)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		return _space->GetVersions(request);
	}
	void SpaceConnection::GetVersionsAsync(const KeyRequest& request, function<void(const ValueVersion&)> callback)
	{
		_clock = clock();
		tbb::spin_rw_mutex::scoped_lock lock(_mux, false);
		Open();
		_space->GetVersionsAsync(request, callback);
	}
}
