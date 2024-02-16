// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

#include "HipServer.h"
#include "HipException.h"

#include <iostream>
#include <memory>
#include <string>
#include <fmt/core.h>

#include <grpcpp/grpcpp.h>
#include <grpcpp/health_check_service_interface.h>
#include <grpcpp/ext/proto_server_reflection_plugin.h>

using rocksdb::Options;

namespace Hiperspace
{
	string LogTime()
	{
		time_t now = time(0);
		struct tm tms;
		char buff[80];
		tms = *localtime(&now);
		strftime(buff, sizeof(buff), "%Y-%m-%d.%X", &tms);
		return buff;
	}

	HipServer::HipServer(const string port, unique_ptr<SpacePool>& pool)
	{
		_pool = move(pool);
		_address = fmt::format("0.0.0.0:{0}", port);
	}

	void HipServer::Run()
	{
		ServerBuilder builder;
		builder.AddListeningPort(_address, grpc::InsecureServerCredentials());
		builder.RegisterService(this);
		std::unique_ptr<Server> server(builder.BuildAndStart());
		fmt::println("Server listening on {0}", _address);
		server->Wait();
	}

	grpc::Status HipServer::Open(ServerContext* context, const OpenRequest* request, Token* response)
	{
		try
		{
			const Token& token = request->token();
			const string path = request->path();

			cout << LogTime() << " Open " << path << endl;
			_pool->Open(request);
			response->CopyFrom(request->token());
			return grpc::Status::OK;
		}
		catch (MutationException me)
		{
			cout << LogTime() << "\tMutationException " << me.what() << endl;
			return grpc::Status(grpc::StatusCode::CANCELLED, me.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::CANCELLED, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::Close(ServerContext* context, const Token* request, Token* response)
	{
		try
		{
			cout << LogTime() << " Close " << endl;
			_pool->Close(request);
			return grpc::Status::OK;
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::Bind(ServerContext* context, const BindRequest* request, Value* response)
	{
		try
		{
			cout << LogTime() << " Bind " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->Bind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::BatchBind(ServerContext* context, const BatchBindRequest* request, Values* response)
	{
		try
		{
			cout << LogTime() << " BatchBind " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->BatchBind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::Find(ServerContext* context, const FindRequest* request, Values* response)
	{
		try
		{
			cout << LogTime() << " Find " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->Find(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::Get(ServerContext* context, const KeyRequest* request, Value* response)
	{
		try
		{
			cout << LogTime() << " Get " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->Get(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::BindVersion(ServerContext* context, const BindVersionRequest* request, ValueVersion* response)
	{
		try
		{
			cout << LogTime() << " BindVersion " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->Bind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::BatchVersionBind(ServerContext* context, const BatchBindVersionRequest* request, Values* response)
	{
		try
		{
			cout << LogTime() << " BatchVersionBind " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->BatchBind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::FindVersion(ServerContext* context, const FindVersionRequest* request, ValueVersions* response)
	{
		try
		{
			cout << LogTime() << " FindVersion " << endl;
			auto token = request->token().tokenid();
			auto space = _pool->Find(request->token());
			auto result = space->Find(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::GetVersion(ServerContext* context, const KeyVersionRequest* request, ValueVersion* response)
	{
		try
		{
			cout << LogTime() << " GetVersion " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->Get(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::GetVersions(ServerContext* context, const KeyRequest* request, VersionHistory* response)
	{
		try
		{
			cout << LogTime() << " GetVersions " << endl;
			auto space = _pool->Find(request->token());
			auto result = space->GetVersions(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolExcepetion pe)
		{
			cout << LogTime() << "\tProtocolExcepetion " << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksExcpetion re)
		{
			cout << LogTime() << "\tRocksExcpetion " << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tExcpetion " << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
}