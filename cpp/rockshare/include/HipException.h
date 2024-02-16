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