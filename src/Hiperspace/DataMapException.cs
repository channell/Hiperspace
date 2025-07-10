// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    public class DataMapException : Exception
    {
        public Type Type { get; init; }
        public byte[] Key { get; init; }

        public DataMapException(Type type, byte[] key, Exception cause) : base($"The element can not be deserialised with the current map", cause) 
        { 
            Type = type;
            Key = key;
        }
    }
}
