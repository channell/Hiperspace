namespace Sparx.EA
{
    public partial class ElementOperationsPostCondiitons
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
        [Column("PostCondition", Order = 1)]
        [StringLength(255)]
        public string DBPostCondition
        {
            get => PostCondition ?? string.Empty;
            set => PostCondition = value;
        }
    }
}
