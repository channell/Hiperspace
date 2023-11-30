
namespace Sparx.EA
{
    public partial class Attribute
    {
        [JsonIgnore]
        public virtual Element? DBElement
        {
            get
            {
                return Element?.Value;
            }
            set
            {
                if (value != null)
                    Element = new(new() { Id = value?.Id }, value);
            }
        }
        [Column("Object_ID")]
        [JsonIgnore]
        public int ObjectId
        {
            get
            {
                if (Element != null)
                    return Element.Value.Key.Id ?? default;
                return default;
            }
            set
            {
                Element = new(new() { Id = value });
            }
        }
    }

}
