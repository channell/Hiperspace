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
        public static implicit operator Guid(Identity identity) => identity.Value;
    }
}
