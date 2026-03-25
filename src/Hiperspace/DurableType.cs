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
        /// <remarks>
        /// {1}, {1|model}
        /// </remarks>
        MetaModel = 1,

        /// <summary>
        /// Specifies that the element is the  meta-map used for conversion of keys between TLV and TVL for scan <see cref="Meta.MetaMap"/>
        /// </summary>
        /// <remarks>
        /// {2}, {2|MetaMap}
        /// </remarks>
        MetaMap = 2,

        /// <summary>
        /// Specifies that the element is a fingerprint for the client Domain space to avoid need to merge domain MetaMap with stored version
        /// </summary>
        /// <remarks>
        /// {3|fingerprint}, {}
        /// </remarks>
        Fingerprint = 3,

        /// <summary>
        /// Specifies that the element is immutable and cannot be modified after creation. the value contains the timestamp
        /// </summary>
        /// <remarks>
        /// {4|key}, {4|value|AsAt|transaction}
        /// </remarks>
        Immutable = 4,

        /// <summary>
        /// Specifies that the element is versioned and key contains the timestamp of the change
        /// </summary>
        /// <remarks>
        /// {5|key|AsAt}, {5|value|transaction}
        /// </remarks>
        Versioned = 5,

        /// <summary>
        /// Specifies that the element is value contains a vector space for coordinate, common in RAG search for in AI integrations 
        /// multi-dimensional space.
        /// </summary>
        /// <remarks>
        /// {5|key|AsAt}, {5|Vector|transaction}
        /// </remarks>
        VectorSpace = 6,

        /// <summary>
        /// Specifies that the element value is a mutable sequence number for a key
        /// </summary>
        /// <remarks>
        /// {7|key}, {7|number}
        /// </remarks>
        Sequence = 7,

        /// <summary>
        /// Specifies that the key is compose of a transaction identifier (+keypart) and value contains the key of the element within the transaction
        /// </summary>
        /// <remarks>
        /// {8|transaction|key}, {8|key}
        /// </remarks>
        Transaction = 8,

        /// <summary>
        /// Specifies that the key is a transaction checkpoint for database recovery after restart
        /// </summary>
        /// <remarks>
        /// {9}, {9|transaction}
        /// </remarks>
        Checkpoint = 9,
    }
}
