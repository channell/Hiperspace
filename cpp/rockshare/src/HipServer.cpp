// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
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

	HipServer::HipServer(const string port, const string path, unique_ptr<SpacePool>& pool)
	{
		_pool = move(pool);
		_path = path;
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
			if (path.empty())
			{
				cout << LogTime() << " Open " << path << endl;
				_pool->Open(request);
			}
			else
			{
				auto req = google::protobuf::Arena::CreateMessage<OpenRequest>(request->GetArena());
				req->CopyFrom(*request);
				auto fullpath = _path + path;
				req->set_path(fullpath);		// add the prefix if there is one
				cout << LogTime() << " Open " << fullpath << endl;
				_pool->Open(req);
			}
			response->set_tokenid(request->token().tokenid());
			return grpc::Status::OK;
		}
		catch (MutationException me)
		{
			cout << LogTime() << "\tMutationException " << me.what() << endl;
			return grpc::Status(grpc::StatusCode::CANCELLED, me.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::CANCELLED, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
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
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::Bind(ServerContext* context, const BindRequest* request, Value* response)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " Bind " << endl;
#endif // DEBUG
			auto space = _pool->Find(request->token());
			auto result = space->Bind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::BatchBind(ServerContext* context, const BatchBindRequest* request, Values* response)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " BatchBind " << endl;
#endif
			auto space = _pool->Find(request->token());
			auto result = space->BatchBind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::Find(ServerContext* context, const FindRequest* request, grpc::ServerWriter<KeyValue>* writer)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " Find " << endl;
#endif
			auto callback = [&](const KeyValue& kv) { writer->Write(kv); };
			auto space = _pool->Find(request->token());
			space->FindAsync(*request, callback);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}

	grpc::Status HipServer::Get(ServerContext* context, const KeyRequest* request, Value* response)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " Get " << endl;
#endif
			auto space = _pool->Find(request->token());
			auto result = space->Get(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}


	grpc::Status HipServer::BindVersion(ServerContext* context, const BindVersionRequest* request, Value* response)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " BindVersion " << endl;
#endif
			auto space = _pool->Find(request->token());
			auto result = space->Bind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::BatchVersionBind(ServerContext* context, const BatchBindVersionRequest* request, Values* response)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " BatchVersionBind " << endl;
#endif
			auto space = _pool->Find(request->token());
			auto result = space->BatchBind(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}

	grpc::Status HipServer::GetVersion(ServerContext* context, const KeyVersionRequest* request, ValueVersion* response)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " GetVersion " << endl;
#endif
			auto space = _pool->Find(request->token());
			auto result = space->Get(*request);
			response->CopyFrom(*result);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
	grpc::Status HipServer::FindVersion(::grpc::ServerContext* context, const ::Hiperspace::FindVersionRequest* request, ::grpc::ServerWriter< ::Hiperspace::KeyValueVersion>* writer)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " FindVersion " << endl;
#endif
			auto token = request->token().tokenid();
			auto space = _pool->Find(request->token());
			auto callback = [&](const KeyValueVersion& kv) { writer->Write(kv); };
			space->FindAsync(*request, callback);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}


	::grpc::Status HipServer::GetVersions(::grpc::ServerContext* context, const ::Hiperspace::KeyRequest* request, ::grpc::ServerWriter< ::Hiperspace::ValueVersion>* writer)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " GetVersions " << endl;
#endif
			auto space = _pool->Find(request->token());
			auto callback = [&](const ValueVersion& kv) { writer->Write(kv); };
			space->GetVersionsAsync(*request, callback);
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}

	}
	::grpc::Status HipServer::FindIndex(::grpc::ServerContext* context, const ::Hiperspace::FindRequest* request, ::grpc::ServerWriter< ::Hiperspace::KeyValue>* writer)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " Find " << endl;
#endif
			auto space = _pool->Find(request->token());
			auto result = space->FindIndex(*request);
			auto content = result->content();
			for (auto i = begin(content); i != end(content); i++)
			{
				writer->Write(*i);
			}
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}

	::grpc::Status HipServer::FindIndexVersion(::grpc::ServerContext* context, const ::Hiperspace::FindVersionRequest* request, ::grpc::ServerWriter< ::Hiperspace::KeyValueVersion>* writer)
	{
		try
		{
#ifdef DEBUG
			cout << LogTime() << " FindVersion " << endl;
#endif
			auto token = request->token().tokenid();
			auto space = _pool->Find(request->token());
			auto result = space->FindIndex(*request);
			auto content = result->content();
			for (auto i = begin(content); i != end(content); i++)
			{
				writer->Write(*i);
			}
			return grpc::Status::OK;
		}
		catch (ProtocolException pe)
		{
			cout << LogTime() << "\tProtocolException" << pe.what() << endl;
			return grpc::Status(grpc::StatusCode::FAILED_PRECONDITION, pe.what());
		}
		catch (RocksException re)
		{
			cout << LogTime() << "\tRocksException" << re.what() << endl;
			return grpc::Status(grpc::StatusCode::DATA_LOSS, re.what());
		}
		catch (exception e)
		{
			cout << LogTime() << "\tException" << e.what() << endl;
			return grpc::Status(grpc::StatusCode::INTERNAL, e.what());
		}
	}
}