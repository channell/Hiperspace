using Hiperspace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc
{
    public partial class AccSpace
    {
        public static Horizon[] constraints =
        [
            new Horizon<Acc.CustomerAccountTransaction>(r => r.At > r?.owner?.Balance?.When && 
                                                               r.Movement != null &&
                                                               r.owner != null),
            new Horizon<Acc.Customer> (c => c.Name != null),
            new Horizon<Acc.CustomerAccount>(a => a.Title != null),
            new Horizon<Acc.CustomerAccountBalance>(b => b.When != null && b.Current != null)
        ];

        public AccSpace(HiperSpace space,  DateTime? AsAt = null) : this(space, constraints, AsAt)
        {

        }
    }

    public partial class CustomerAccount
    {
        public void Rollup ()
        {
            var when = Transactions.Select(t => t.At).Max();
            Balance = new CustomerAccountBalance { When = when, Current = this.CurrentBalance };
        }
    }
}
