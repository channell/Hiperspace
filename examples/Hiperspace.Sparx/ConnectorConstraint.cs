using Microsoft.EntityFrameworkCore;
using Sparx.Internal;

namespace Sparx.EA
{
    [PrimaryKey(nameof(ConnectorId), nameof(Constraint))]
    public partial class ConnectorConstraints
    {
        [JsonIgnore]
        [Key]
        [Column("ConnectorID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConnectorId
        {
            get
            {
                if (owner != null)
                    return owner.Value.Key.Id ?? default;
                return default;
            }
            set 
            { 
                owner = new (new () { Id = value });
            }
        }
        [JsonIgnore]
        [NotMapped]
        public virtual Connector? DBConnector
        {
            get
            {
                if (owner.HasValue)
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
