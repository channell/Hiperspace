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
		explicit MutationException(const string& msg) 
		{
			_msg = msg;
		}
		virtual const char* what() const noexcept override 
		{
			return _msg.c_str();
		}
	};

	// Exception caused by a IO error in Rocks DB. 
	class RocksException : public exception
	{
	private:
		string _msg;

	public:
		explicit RocksException() : exception() { }
		explicit RocksException(string msg) 
		{
			_msg = msg;
		}
		virtual const char* what() const noexcept override
		{
			return _msg.c_str();
		}
	};

	// Error throne when the session has timed out or failed validation. requires reconnect.  
	class ProtocolException : public exception
	{
	private:
		string _msg;

	public:
		explicit ProtocolException() : exception() { }
		explicit ProtocolException(string msg) 
		{
			_msg = msg;
		}
		virtual const char* what() const noexcept override
		{
			return _msg.c_str();
		}
	};
}