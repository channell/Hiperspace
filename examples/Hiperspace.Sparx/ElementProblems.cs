namespace Sparx.EA
{
    public partial class ElementProblems
    {
        [Key]
        [Column("Object_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DBElementId
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
        [Column("Problem", Order = 1)]
        [StringLength(255)]
        public string DBProblem
        {
            get => Problem ?? string.Empty;
            set => Problem = value;
        }
        [Key]
        [Column("ProblemType", Order = 1)]
        [StringLength(255)]
        public string DBProblemType
        {
            get => ProblemType ?? string.Empty;
            set => ProblemType = value;
        }
    }
}
