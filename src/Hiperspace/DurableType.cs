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
        /// {1}, {model}
        /// </remarks>
        MetaModel = 1,

        /// <summary>
        /// Specifies that the element is the  meta-map used for conversion of keys between TLV and TVL for scan <see cref="Meta.MetaMap"/>
        /// </summary>
        /// <remarks>
        /// {2}, {MetaMap}
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
        /// {4|key}, {AsAt|value}
        /// </remarks>
        Immutable = 4,

        /// <summary>
        /// Specifies that the element is immutable and cannot be modified after creation. the value contains the timestamp
        /// </summary>
        /// <remarks>
        /// {5|key}, {AsAt|transaction|value}
        /// </remarks>
        ImmutableTransaction = 5,

        /// <summary>
        /// Specifies that the element is versioned and key contains the timestamp of the change
        /// </summary>
        /// <remarks>
        /// {6|key|AsAt}, {value}
        /// </remarks>
        Versioned = 6,

        /// <summary>
        /// Specifies that the element is versioned and key contains the timestamp of the change
        /// </summary>
        /// <remarks>
        /// {7|key|AsAt}, {transaction|value}
        /// </remarks>
        VersionedTransaction = 7,

        /// <summary>
        /// Specifies that the element is value contains a vector space for coordinate, common in RAG search for in AI integrations 
        /// multi-dimensional space.
        /// </summary>
        /// <remarks>
        /// {8|key|AsAt}, {transaction|Vector}
        /// </remarks>
        VectorSpace = 8,

        /// <summary>
        /// Specifies that the element value is a mutable sequence number for a key
        /// </summary>
        /// <remarks>
        /// {9|key}, {number}
        /// </remarks>
        Sequence = 9,

        /// <summary>
        /// Specifies that the key is compose of a transaction identifier (+keypart) and value contains the key of the element within the transaction
        /// </summary>
        /// <remarks>
        /// {10|transaction|key}, {key}
        /// </remarks>
        Transaction = 10,

        /// <summary>
        /// Logs the end (commit/rollback) of a transaction 
        /// </summary>
        /// <remarks>
        /// used in recovery to backout any transactions (since checkpoint) that were not committed and 
        /// for calculation change content
        /// {11|transaction}, {timestamp, commit (true/false}
        /// </remarks>
        TransactionEnd = 11,

        /// <summary>
        /// Optionally Logs the start of a transaction with audit information, and parent transaction
        /// </summary>
        /// <remarks>
        /// NB Transactions are implicitly started when new to the lock manager
        /// {12|transaction}, {timestamp, parent-transaction, audit-message}
        /// </remarks>
        TransactionStart = 12,

        /// <summary>
        /// Specifies the highest transaction that completed for transaction recovery after a restart
        /// </summary>
        /// <remarks>
        /// {13}, {transaction}
        /// </remarks>
        Checkpoint = 13,
    }
}
