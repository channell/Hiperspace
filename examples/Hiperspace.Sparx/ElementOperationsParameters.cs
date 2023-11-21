namespace Sparx.EA
{
    public partial class ElementOperationsParameters
    {
        [Key]
        [Column("OperationID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperationId
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
        [Column("Name", Order = 1)]
        [StringLength(255)]
        public string DBName
        {
            get => Name ?? string.Empty;
            set => Name = value;
        }
    }
}
