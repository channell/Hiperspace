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
    public struct Timestamp
    {
        [ProtoMember(2)]
        public ProtoBuf.WellKnownTypes.Timestamp Value { get; set; }

        public Timestamp (ProtoBuf.WellKnownTypes.Timestamp value)
        {
            Value = value;
        }
        public Timestamp()
        {
            Value = new ProtoBuf.WellKnownTypes.Timestamp(DateTime.UtcNow);
        }
        public static implicit operator ProtoBuf.WellKnownTypes.Timestamp(Timestamp value)
            => value.Value;
        public static implicit operator DateTime(Timestamp value)
            => value.Value.AsDateTime();

        public bool Equals(Timestamp other)
        {
            if (Value.AsDateTime().Ticks == other.Value.AsDateTime().Ticks) return true;
            return false;
        }
        public override bool Equals(Object? other)
        {
            if (other == null) return false;
            if (other is Timestamp) return Equals((Timestamp)other);
            return false;
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public int CompareTo(Timestamp other)
        {
            if (Value.AsDateTime().Ticks < other.Value.AsDateTime().Ticks) return -1;
            if (Value.AsDateTime().Ticks > other.Value.AsDateTime().Ticks) return 1;
            return 0;
        }

        public static bool operator ==(Timestamp left, Timestamp right)
        {
            if (left.Equals(right)) return true;
            return false;
        }
        public static bool operator !=(Timestamp left, Timestamp right)
        {
            if (left.Equals(right)) return false;
            return true;
        }
        public static bool operator <(Timestamp left, Timestamp right)
        {
            if (left.Value.AsDateTime().Ticks < right.Value.AsDateTime().Ticks) return true;
            return false;
        }
        public static bool operator >(Timestamp left, Timestamp right)
        {
            if (left.Value.AsDateTime().Ticks > right.Value.AsDateTime().Ticks) return true;
            return false;
        }
    }
}
