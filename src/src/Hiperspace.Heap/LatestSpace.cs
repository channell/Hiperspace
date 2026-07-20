// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace.Meta;
using System.Buffers.Binary;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Hiperspace.Heap
{
    [Obsolete("Use CacheHeapSpace instead")]
    public class LatestSpace : CacheHeapSpace 
    {
        [Obsolete("Use CacheHeapSpace instead")]
        public LatestSpace() : base() { }
    }
}
