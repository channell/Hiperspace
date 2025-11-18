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
    /// Element base classes are mutable to allow them to be used with Element Framework and initialiisers
    /// but are locked as soon as they are added to a hiperspace
    /// </summary>
    public class MutationException : Exception
    {
        public MutationException() : base() { }
        public MutationException(string message) : base(message) { }
        public MutationException(string message, Exception inner) : base(message, inner) { }
    }
    public class ValueMutationException : MutationException
    {
        public ValueMutationException() : base() { }
        public ValueMutationException(string type) : base($"{type} cannot be changed once bound to a Space") { }
        public ValueMutationException(string type, Exception inner) : base($"{type} cannot be changed once bound to a Space", inner) { }
    }
}
