using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sparx.EA
{
    [PrimaryKey(nameof(OperationId), nameof(PreCondition))]
    public partial class ElementOperationsPreConditions
    {
        [JsonIgnore]
        [Column("OperationID")]
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
