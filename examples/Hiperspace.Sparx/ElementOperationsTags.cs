namespace Sparx.EA
{
    public partial class ElementOperationsTags
    {
        [Key]
        [Column("ElementID", Order = 0)]
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
    }
}
