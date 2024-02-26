// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#pragma once
#include <stdexcept>
#include <string>

using namespace std;

namespace Hiperspace
{
	// Exception thrown when the meta model is incompatible with the stored model in the file
	class MutationException : public exception
	{
	private:
		string _msg;
	public:
		explicit MutationException() : exception() { }
		explicit MutationException(string& msg) : exception(msg.c_str())
		{
			_msg = msg;
		}
	};

	// Exception caused by a IO error in Rocks DB. 
	class RocksExcpetion : public exception
	{
	private:
		string _msg;

	public:
		explicit RocksExcpetion() : exception() { }
		explicit RocksExcpetion(string msg) : exception(msg.c_str())
		{
			_msg = msg;
		}
	};

	// Error throne when the session has timed out or failed validation. requires reconnect.  
	class ProtocolExcepetion : public exception
	{
	private:
		string _msg;

	public:
		explicit ProtocolExcepetion() : exception() { }
		explicit ProtocolExcepetion(string msg) : exception(msg.c_str())
		{
			_msg = msg;
		}
	};
}