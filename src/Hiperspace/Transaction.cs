// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023, 2024, 2025, 2026 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using System.Buffers.Binary;

namespace Hiperspace
{
    /// <summary>
    /// Represents a unique transaction identifier that includes a timestamp and a random component.
    /// </summary>
    /// <remarks>The transaction identifier is composed of a timestamp and a random value, providing
    /// uniqueness and chronological ordering. This struct is useful for scenarios where transactions need to be
    /// uniquely identified and sorted by creation time.
    /// It is based on UUID, but drops the version information in favor of fast Timestamp access
    /// </remarks>
    public struct Transaction
    {
        public long TimeStamp;
        public long Random;

        /// <summary>
        /// Initializes a new instance of the Transaction class with the specified timestamp.
        /// </summary>
        /// <param name="timestamp">The date and time to associate with the transaction. The timestamp is used to generate a unique identifier
        /// for the transaction.</param>
        /// <remarks>This constructor generates a unique identifier for the transaction by combining the
        /// current UTC timestamp with a random value derived from a GUID. The generated values can be used to
        /// ensure transaction uniqueness and ordering.</remarks>
        public Transaction(DateTime timestamp)
        {
#if NET9_0_OR_GREATER
            var bytes = new Span<byte>(Guid.CreateVersion7(timestamp).ToByteArray());
            var slice = bytes.Slice(sizeof(long), sizeof(long));
#else
            var bytes = new Span<byte>(Guid.NewGuid().ToByteArray());
            var slice = bytes.Slice(0, sizeof(long));
#endif
            TimeStamp = timestamp.Ticks;
            Random = BinaryPrimitives.ReadInt64BigEndian(slice);
        }

        /// <summary>
        /// Initializes a new instance of the Transaction class with a unique timestamp and random value.
        /// </summary>
        /// <remarks>This constructor generates a unique identifier for the transaction by combining the
        /// current UTC timestamp with a random value derived from a GUID. The generated values can be used to
        /// ensure transaction uniqueness and ordering.</remarks>
        public Transaction()
        {
#if NET9_0_OR_GREATER
            var bytes = new Span<byte>(Guid.CreateVersion7().ToByteArray());
            var slice = bytes.Slice(sizeof(long), sizeof(long));
#else
            var bytes = new Span<byte>(Guid.NewGuid().ToByteArray());
            var slice = bytes.Slice(0, sizeof(long));
#endif
            TimeStamp = DateTime.UtcNow.Ticks;
            Random = BinaryPrimitives.ReadInt64BigEndian(slice);
        }

        /// <summary>
        /// Gets the date and time represented by the transaction timestamp.
        /// </summary>
        public DateTime DateTime => new DateTime(TimeStamp);
    }
}
