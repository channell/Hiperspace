// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2024 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#pragma once

using namespace std;

#include "Hiperspace.pb.h"
#include <unordered_set>

namespace Hiperspace
{
	struct TokenExtension
	{
		size_t operator() (const Token& t) const noexcept
		{
			return std::hash<string>{}(t.tokenid());
		}

		size_t operator() (const Token& lhs, const Token& rhs) const
		{
			return (lhs.tokenid() == rhs.tokenid());
		}

		static size_t hash(const Token& t)
		{
			return std::hash<string>{}(t.tokenid());
		}

		static bool equal(const Token& lhs, const Token& rhs)
		{
			return (lhs.tokenid() == rhs.tokenid());
		}
	};
}