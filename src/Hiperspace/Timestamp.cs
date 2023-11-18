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
            if (this == other) return true;
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
            return base.GetHashCode();
        }

        public int CompareTo(Timestamp other)
        {
            if (this < other) return -1;
            if (this > other) return 1;
            return 0;
        }

        public static bool operator ==(Timestamp left, Timestamp right)
        {
            if (left != right) return false;
            return true;
        }
        public static bool operator !=(Timestamp left, Timestamp right)
        {
            return !(left == right);
        }
        public static bool operator <(Timestamp left, Timestamp right)
        {
            return left < right;
        }
        public static bool operator >(Timestamp left, Timestamp right)
        {
            return left > right;
        }
    }
}
