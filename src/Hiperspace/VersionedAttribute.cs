namespace Hiperspace
{
    [AttributeUsage(AttributeTargets.Field| AttributeTargets.Class)]
    public class VersionedAttribute : Attribute
    {
        public VersionedAttribute() : base() { }
    }
}
