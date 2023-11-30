namespace Sparx.EA
{
    public partial class ElementRequirements
    {
        [Column("Object_ID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ObjectId
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
        public virtual Element? DBElement
        {
            get
            {
                if (owner != null)
                    return owner.Value.Value;
                return null;
            }
            set
            {
                if (value != null)
                    owner = new(new() { Id = value?.Id }, value);
            }
        }
    }
}
