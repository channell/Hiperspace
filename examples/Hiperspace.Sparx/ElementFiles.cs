using Microsoft.EntityFrameworkCore;

namespace Sparx.EA
{

    [PrimaryKey(nameof(ObjectId), nameof(FileName))]
    public partial class ElementFiles
    {
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
                owner = new(new() { Id = value?.Id }, value);
            }
        }
    }
}
