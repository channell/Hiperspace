using Microsoft.EntityFrameworkCore;

namespace Sparx.EA
{
    [PrimaryKey (nameof(InstanceId))]
    public partial class DiagramObject
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("Instance_ID")]
        public int InstanceId
        {
            get => Id!.Value;
            set => Id = value;
        }
        [JsonIgnore]
        [Column("Diagram_ID")]
        public int DiagramId
        {
            get
            {
                if (Diagram.HasValue)
                    return Diagram.Value.Key.Id ?? default;
                return default;
            }
            set
            {
                Diagram = new(new() { Id = value });
            }
        }
        
        [JsonIgnore]
        [Column("Object_ID")]
        public int ObjectId
        {
            get
            {
                if (Element.HasValue)
                    return Element.Value.Key.Id ?? default;
                return default;
            }
            set
            {
                Element = new(new() { Id = value });
            }
        }
        
        [JsonIgnore]
        public virtual Element DBElement
        {
            get
            {
                return Element?.Value!;
            }
            set
            {
                if (value != null)
                    Element = new(value._key, value);
            }
        }
        
        [JsonIgnore]
        public virtual Diagram? DBDiagram
        {
            get
            {
                if (Diagram.HasValue)
                    return Diagram.Value.Value;
                return null;
            }
            set
            {
                if (value != null)
                    Diagram = new(value._key, value);
            }
        }
    }
}
