// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#pragma once
#include <iostream>
#include <memory>
#include <string>

#include <grpcpp/grpcpp.h>
#include <grpcpp/health_check_service_interface.h>
#include <grpcpp/ext/proto_server_reflection_plugin.h>

#include <rocksdb/db.h>

#include "Hiperspace.pb.h"
#include "Hiperspace.grpc.pb.h"
#include "SpacePool.h"

using grpc::Server;
using grpc::ServerBuilder;
using grpc::ServerContext;
using grpc::Status;
using rocksdb::DB;
using namespace std;

namespace Hiperspace
{
    // Class implementing the hiperspace proto interface 
	class HipServer final: public RemoteServer::Service
	{

    private:
        string _address;
		string _path;

        //  connections to hiperspaces are pooled for reuse between sessions. 
        unique_ptr<SpacePool> _pool;

    public:
        // Created from main entry point with a reference to the space pool. 
        HipServer(string port, string path, unique_ptr<SpacePool>& pool);
        // Run the service until cancellation 
        void Run();

        //
        // Interface functions defined in the hiperspace proto file. 
        //
        grpc::Status Open(ServerContext* context, const OpenRequest* request, Token* response) override;
        grpc::Status Close(ServerContext* context, const Token* request, Token* response) override;
        grpc::Status Bind(ServerContext* context, const BindRequest* request, Value* response) override;
        grpc::Status BatchBind(ServerContext* context, const BatchBindRequest* request, Values* response) override;
        grpc::Status Find(ServerContext* context, const FindRequest* request, grpc::ServerWriter<KeyValue>* writer) override;
        grpc::Status Get(ServerContext* context, const KeyRequest* request, Value* response) override;
        grpc::Status BindVersion(ServerContext* context, const BindVersionRequest* request, Value* response) override;
        grpc::Status BatchVersionBind(ServerContext* context, const BatchBindVersionRequest* request, Values* response) override;
        grpc::Status FindVersion(::grpc::ServerContext* context, const ::Hiperspace::FindVersionRequest* request, ::grpc::ServerWriter< ::Hiperspace::KeyValueVersion>* writer) override;
        grpc::Status GetVersion(ServerContext* context, const KeyVersionRequest* request, ValueVersion* response) override;
        grpc::Status GetVersions(::grpc::ServerContext* context, const ::Hiperspace::KeyRequest* request, ::grpc::ServerWriter< ::Hiperspace::ValueVersion>* writer) override;
        grpc::Status FindIndex(::grpc::ServerContext* context, const ::Hiperspace::FindRequest* request, ::grpc::ServerWriter< ::Hiperspace::KeyValue>* writer) override;
        grpc::Status FindIndexVersion(::grpc::ServerContext* context, const ::Hiperspace::FindVersionRequest* request, ::grpc::ServerWriter< ::Hiperspace::KeyValueVersion>* writer) override;
    };
}