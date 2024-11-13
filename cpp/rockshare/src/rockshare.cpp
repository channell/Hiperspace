// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

#include "rockshare.h"
#include "HipServer.h"
#include "SpacePool.h"

#include <fmt/core.h>
#include <iostream>

using namespace std;
using namespace Hiperspace;
namespace po = boost::program_options;

int main(int argc, char** argv)
{
	try
	{
		po::options_description desc("Rockshare options");
		desc.add_options()
			("help", "help info")
			("port", po::value<int>(), "port for grpc endpoint")
			("ttl", po::value<int>(), "time-to-live before lazy close of session in seconds")
			("path", po::value<string>(), "root path to be used for all paths passed to this share");

		po::variables_map vm;
		po::store(po::parse_command_line(argc, argv, desc), vm);
		po::notify(vm);

		if (vm.count("help"))
		{
			cout 
				<< desc
				<< endl;
			return 0;
		}
#ifdef NORMAL
		if (vm.count("port") == 0)
		{
			cout 
				<< endl
				<< "ERROR: port is required"
				<< endl
				<< desc;
			return 1;
		}
		auto port = fmt::format("{0}", vm["port"].as<int>());

		std::string path = vm.count("path") ? vm["path"].as<string>() : "";
#else
		auto port = "4242";
		std::string path = "/Hiperspace/";
#endif // NORMAL

		chrono::seconds ttl = 
			vm.count("ttl") ?
			chrono::seconds(vm["ttl"].as<int>()) :
			60s;

		cout
			<< "Service starting"		<< endl
			<< "Port: " << port			<< endl
			<< "Path: " << path			<< endl	
			<< "TTL: " << ttl.count()	<< endl	
			;

		unique_ptr<SpacePool> space(new SpacePool(ttl));
		unique_ptr<HipServer> service(new HipServer(port, path, space));
		service->Run();

		cout
			<< "Service exit"
			<< endl;

		return 0;
	}
	catch (exception& e)
	{
		cerr
			<< "EXCEPTION: "
			<< e.what()
			<< endl;
		return 2;
	}
	catch (...)
	{
		cerr
			<< "UNKNOWN ERROR "
			<< endl;
		return 3;
	}
}
