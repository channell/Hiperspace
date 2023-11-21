namespace Sparx.EA
{
    public partial class DiagramLink
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
        [Column("ConnectorID")]
        public int ConnectorId
        {
            get
            {
                if (Connector.HasValue)
                    return Connector.Value.Key.Id ?? default;
                return default;
            }
            set
            {
                Connector = new(new() { Id = value });
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
