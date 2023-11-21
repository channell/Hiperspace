namespace Sparx.EA
{
    public partial class Connector
    {
        [Column("Start_Object_ID")]
        public int? StartElementId
        {
            get
            {
                if (StartElement.HasValue)
                    return StartElement.Value.Key.Id;
                return null;
            }
            set
            {
                StartElement = new(new() { Id = value });
            }
        }

        [Column("End_Object_ID")]
        public int? EndElementId
        {
            get
            {
                if (EndElement.HasValue)
                    return EndElement.Value.Key.Id;
                return null;
            }
            set
            {
                EndElement = new(new() { Id = value });
            }
        }
    }
}
