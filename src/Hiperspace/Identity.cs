// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using ProtoBuf;

namespace Hiperspace
{
    [ProtoContract]
    public struct Identity
    {
        [ProtoMember(2)]
        public Guid Value { get; set; }
        public Identity()
        {
            Value = Guid.NewGuid();
        }
        public Identity(Guid guid)
        {
            Value = guid;
        }
        public static implicit operator Guid(Identity identity) => identity.Value;
    }
}
