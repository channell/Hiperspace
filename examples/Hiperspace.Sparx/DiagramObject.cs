namespace Sparx.EA
{
    public partial class DiagramObject
    {
        [Column("DiagramID")]
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
        [Column("Object_ID")]
        public int ElementId
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
        public Element? DBElement
        {
            get
            {
                return Element?.Value;
            }
            set
            {
                if (value != null)
                    Element = new(value._key, value);
            }
        }
        public Diagram? DBDiagram
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
