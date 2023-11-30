namespace Sparx.EA
{
    public partial class Diagram
    {
        [JsonIgnore]
        public virtual ICollection<DiagramLink> DBDiagramLinks
        {
            get => DiagramLinks;
            set => DiagramLinks.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<DiagramObject> DBParts
        {
            get => Parts;
            set => Parts.UnionWith(value);
        }
    }
}
