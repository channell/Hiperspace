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
        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
        public bool Equals(Identity? other)
        {
            if (other == null)
                return false;
            return (Value == other.Value.Value);
        }
        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            if (other is Identity) return Equals((Identity)other);
            return false;
        }
        public int CompareTo(Identity? other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            if (Value < other.Value.Value)
                return -1;
            else if (Value> other.Value.Value)
                return 1;
            else
                return 0;
        }
        public static bool operator ==(Identity left, Identity right)
        {
            if (left.Equals(right)) return true;
            return false;
        }
        public static bool operator !=(Identity left, Identity right)
        {
            if (left.Equals(right)) return false;
            return true;
        }
        public static bool operator <(Identity left, Identity right)
        {
            if (left.Value < right.Value) return true;
            return false;
        }
        public static bool operator >(Identity left, Identity right)
        {
            if (left.Value > right.Value) return true;
            return false;
        }

        public static implicit operator Guid(Identity identity) => identity.Value;
    }
}
