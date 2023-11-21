using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparx.EA
{
    public partial class ConnectorConstraints
    {
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
        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string DBConstraint 
        {
            get => Constraint ?? string.Empty;
            set => Constraint = value;
        }
    }
}
