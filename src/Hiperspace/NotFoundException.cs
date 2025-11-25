// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Exception thrown from Get() functions where the value cannot be found
    /// </summary>
    /// <remarks>
    /// Distinguish Notfound error from IO errors
    /// </remarks>
    public class NotFoundException : MutationException
    {
        public NotFoundException() : base() { }
        public NotFoundException(string type) : base($"{type} not found") { }
        public NotFoundException(string type, Exception inner) : base($"{type} not found", inner) { }
    }
}
