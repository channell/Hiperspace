namespace Sparx.EA
{
    public partial class ElementFiles
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
        [Key]
        [Column("FileName", Order = 1)]
        [StringLength(255)]
        public string DBFileName
        {
            get => FileName ?? string.Empty;
            set => FileName = value;
        }
    }
}
