// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#include "SpacePool.h"
#include "HipException.h"
#include <fmt/format.h>

using namespace std;
using rocksdb::DB;

namespace Hiperspace
{
	SpacePool::SpacePool(chrono::seconds ttl)
	{
		_ttl = ttl;
		_timer.reset(new thread(&SpacePool::CheckTime, this));
	}
	SpacePool::~SpacePool()
	{
		_alive = false;
		_timer->join();
	}

	void SpacePool::CheckTime() noexcept
	{
		while (_alive)
		{
			this_thread::sleep_for(_ttl);
			{
				clock_t now = clock();
				for (auto i = cbegin(_stores); i != cend(_stores); i++)
				{
					if (i->second != nullptr)
					{
						auto r = i->second;
						auto last = chrono::seconds(now - r->getClock());
						if (last > _ttl)
						{
							r->Close();
						}
					}
				}
			}
		}
	}
	
	shared_ptr<SpaceConnection> SpacePool::Open(const OpenRequest* request)
	{
		concurrent_hash_map <string, shared_ptr<SpaceConnection>>::accessor tokenAccessor;
		if (_sessions.find(tokenAccessor, request->token().tokenid()))
		{
			auto connection = tokenAccessor->second;
			if (connection->Context->path() != request->path())
			{
				throw ProtocolException(fmt::format("Open request reused token for {0} that is already open for {1}", request->path(), connection->Context->path()));
			}
			else
			{
				return connection;
			}
		}

		concurrent_hash_map <string, shared_ptr<SpaceConnection>>::accessor connectionAccessor;
		if (!_stores.find(connectionAccessor, request->path()))
		{
			if (_stores.insert(connectionAccessor, request->path()))
			{
				shared_ptr<SpaceConnection> con(new SpaceConnection(request));
				connectionAccessor->second = con;
			}
			else
			{
				// concurent request
				_stores.find(connectionAccessor, request->path());
			}
		}
		string tokenid = request->token().tokenid();
		_sessions.insert(tokenAccessor, tokenid);
		tokenAccessor->second = connectionAccessor->second;
		return connectionAccessor->second;
	}
	
	void SpacePool::Close(const Token* token)
	{
		_sessions.erase(token->tokenid());
	}
	shared_ptr<SpaceConnection> SpacePool::Find(const Token& token)
	{
		concurrent_hash_map <string, shared_ptr<SpaceConnection>>::accessor tokenAccessor;
		string tokenid = token.tokenid();
		if (_sessions.find(tokenAccessor, tokenid))
		{
			return tokenAccessor->second;
		}
		else
		{
			throw ProtocolException("Token session not found");
		}
	}
}
