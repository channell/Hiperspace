namespace Sparx.EA
{
    public partial class ElementMetrics
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
        [Column("Metric", Order = 1)]
        [StringLength(255)]
        public string DBMetric
        {
            get => Metric ?? string.Empty;
            set => Metric = value;
        }
    }
}
