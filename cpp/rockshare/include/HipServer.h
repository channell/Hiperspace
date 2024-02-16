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
#include "Token.h"
#include "SpacePool.h"

using grpc::Server;
using grpc::ServerBuilder;
using grpc::ServerContext;
using grpc::Status;
using rocksdb::DB;
using namespace std;

namespace Hiperspace
{
	class HipServer final: public HiServ::Service
	{

    private:
        string _address;

        unique_ptr<SpacePool> _pool;
        unordered_set<Token, TokenExtension, TokenExtension> _tokens;

    public:
        HipServer(string port, unique_ptr<SpacePool>& pool);
        void Run();

        grpc::Status Open(ServerContext* context, const OpenRequest* request, Token* response) override;
        grpc::Status Close(ServerContext* context, const Token* request, Token* response) override;
        grpc::Status Bind(ServerContext* context, const BindRequest* request, Value* response) override;
        grpc::Status BatchBind(ServerContext* context, const BatchBindRequest* request, Values* response) override;
        grpc::Status Find(ServerContext* context, const FindRequest* request, Values* response) override;
        grpc::Status Get(ServerContext* context, const KeyRequest* request, Value* response) override;
        grpc::Status BindVersion(ServerContext* context, const BindVersionRequest* request, ValueVersion* response) override;
        grpc::Status BatchVersionBind(ServerContext* context, const BatchBindVersionRequest* request, Values* response) override;
        grpc::Status FindVersion(ServerContext* context, const FindVersionRequest* request, ValueVersions* response) override;
        grpc::Status GetVersion(ServerContext* context, const KeyVersionRequest* request, ValueVersion* response) override;
        grpc::Status GetVersions(ServerContext* context, const KeyRequest* request, VersionHistory* response) override;

	};
}