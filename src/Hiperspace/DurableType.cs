// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    /// <summary>
    /// Specifies the types of elements that is stored in Hiperspace.
    /// </summary>
    public enum DurableType
    {
        /// <summary>
        /// Specifies that the element is the meta-model definition. <see cref="Meta.MetaModel"/>
        /// </summary>
        MetaModel = 1,
        /// <summary>
        /// Specifies that the element is the  meta-map used for conversion of keys between TLV and TVL for scan <see cref="Meta.MetaMap"/>
        /// </summary>
        MetaMap = 2,
        /// <summary>
        /// Specifies that the element is a fingerprint for the client Domian space to avoid need to merge domain MetaMap with stored version
        /// </summary>
        Fingerprint = 3,
        /// <summary>
        /// Specifies that the element is immutable and cannot be modified after creation. the value contains the timestamp
        /// </summary>
        Immutable = 4,
        /// <summary>
        /// Specifies that the element is versioned and key contains the timestamp of the change
        /// </summary>
        Versioned = 5,
        /// <summary>
        /// Specifies that the element is value contains a vector space for coordinate, common in RAG search for in AI integrations 
        /// multi-dimensional space.
        /// </summary>
        VectorSpace = 6,
        /// <summary>
        /// Specifies that the element value is a mutable sequence number for a key
        /// </summary>
        Sequence = 7,
        /// <summary>
        /// Specifies that the key is compose of a transaction identifier (+keypart) and value contains the key of the element within the transaction
        /// </summary>
        Transaction = 8,
        /// <summary>
        /// Specifies that the key is a transaction checkpoint for database recovery after restart
        /// </summary>
        Checkpoint = 9,
    }
}
