// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
#nullable enable
using ProtoBuf;

namespace Hiperspace
{


    [ProtoContract]

    public enum TransactionState
    {


        [ProtoEnum]
        Begin = 0,

        [ProtoEnum]
        Commit = 1,

        [ProtoEnum]
        Rollback = 2,

        [ProtoEnum]
        Complete = 4,
    }
}
