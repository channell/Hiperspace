
using ProtoBuf;
using System.Diagnostics.CodeAnalysis;

namespace Hiperspace.Meta
{
    [ProtoContract]
    public struct Field : IEquatable<Field>
    {
        [ProtoMember(1)]
        public string Name {  get; set; }
        [ProtoMember(2)]
        public Name DataType { get; set; }
        [ProtoMember(3)]
        public int Id { get; set; }

        public override bool Equals( object? other)
        {
            if (other is Field value)
                return Equals(value);
            return false;
        }
        public bool Equals(Field other)
        {
            if (!Name.Equals(other.Name)) return false;
            if (!DataType.Equals(other.DataType)) return false;
            if (Id != other.Id) return false;
            return true;
        }
        public override int GetHashCode()
        {
            var hc = new HashCode();
            hc.Add(Name);
            hc.Add(DataType);
            hc.Add(Id);
            return hc.ToHashCode();
        }
    }
}
