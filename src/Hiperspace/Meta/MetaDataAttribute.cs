namespace Hiperspace.Meta
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class MetaDataAttribute : Attribute
    {
        public MetaModel? Model { get; set; }
        public MetaDataAttribute(Type model)
        {
            Model = Activator.CreateInstance(model) as MetaModel;
        }
    }
}
