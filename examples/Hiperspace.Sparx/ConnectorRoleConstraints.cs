using Microsoft.EntityFrameworkCore;

namespace Sparx.EA
{
    [PrimaryKey(nameof(ConnectorId), nameof(Constraint), nameof(ConnectorEnd), nameof(ConstraintType))]
    public partial class ConnectorRoleConstraints
    {
        [JsonIgnore]
        [Column("ConnectorID")]
        public int? ConnectorId
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
        public virtual Connector DBConnector
        {
            get
            {
                return owner!.Value.Value!;
            }
            set
            {
                owner = new(new() { Id = value?.Id }, value);
            }
        }
    }
}
