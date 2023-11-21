namespace Sparx.EA
{
    public partial class ElementResources
    {
        [Key]
        [Column("Object_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ElementId
        {
            get
            {
                if (owner != null)
                    return owner.Value.Key.Id ?? default;
                return default;
            }
            set
            {
                owner = new(new() { Id = value });
            }
        }
        [Column("Resource", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string DBResource
        {
            get
            {
                if (Resource != null && Resource.Value.Key.Name != null)
                    return Resource.Value.Key.Name;
                return string.Empty;
            }
            set
            {
                Resource = new(new() { Name = value });
            }
        }
    }
}
