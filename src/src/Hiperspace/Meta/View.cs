// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------

#if NET8_0_OR_GREATER
using ProtoBuf;
#endif

namespace Hiperspace.Meta
{
#if NET8_0_OR_GREATER
    [ProtoContract]
#endif
    [System.Diagnostics.DebuggerDisplay("View Relation {Name} {Source}")]
    public struct View
    {
#if NET8_0_OR_GREATER
        [ProtoMember(1)]
#endif
        public string Name { get; set; }
#if NET8_0_OR_GREATER
        [ProtoMember(2)]
#endif
        public ViewRelation[]? Mapping { get; set; }
    }
}
