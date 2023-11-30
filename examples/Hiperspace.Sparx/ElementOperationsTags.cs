using Microsoft.EntityFrameworkCore;

namespace Sparx.EA
{
    [PrimaryKey(nameof(PropertyId))]
    public partial class ElementOperationsTags
    {
        [Key, Column( "PropertyID" ), DatabaseGenerated(DatabaseGeneratedOption.Identity )]
        public int PropertyId 
        {
            get => Id!.Value;
            set => Id = value;
        }

        [JsonIgnore]
        [Column("ElementID")]
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
        [JsonIgnore]
        [NotMapped]
        public virtual ElementOperations? DBOperation
        {
            get
            {
                if (owner != null)
                    return owner.Value.Value;
                return null;
            }
            set
            {
                owner = new(new() { Id = value?.Id }, value);
            }
        }
    }
}
