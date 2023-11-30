namespace Sparx.EA
{
    public partial class ElementOperations
    {
        [Key,Column("OperationID"), DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int OperationId 
        {
            get => Id!.Value;
            set => Id = value;
        }    

        [JsonIgnore]
        [Column("Object_ID")]
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
        [JsonIgnore]
        public virtual Element? DBElement
        {
            get
            {
                if (owner != null)
                    return owner.Value.Value;
                return default;
            }
            set
            {
                if (value != null)
                    owner = new(new() { Id = value.Id }, value);
            }
        }
        [JsonIgnore]
        public virtual ICollection<ElementOperationsParameters> DBParameters
        {
            get => Parameters;
            set => Parameters.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementOperationsPostCondiitons> DBPostCondiitons
        {
            get => PostCondiitons;
            set => PostCondiitons.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementOperationsPreConditions> DBPreConditions
        {
            get => PreConditions;
            set => PreConditions.UnionWith(value);
        }
        [JsonIgnore]
        public virtual ICollection<ElementOperationsTags> DBTags
        {
            get => Tags;
            set => Tags.UnionWith(value);
        }
    }
}
