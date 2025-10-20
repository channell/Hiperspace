using Hiperspace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acc
{

    public partial class AccSpace
    {
        private static SortedDictionary<string, Horizon[]> Roles = new()
        {
            {
                "", new Horizon[] // default role
                {
                    new Horizon<Customer> (p => p.Deleted == false),
                    new Horizon<Account> (p => p.Deleted == false),
                    new Horizon<Balance> (p => p.Deleted == false),
                    new Horizon<Transaction> (p => p.Deleted == false),
                }
            },
            {
                "read", new Horizon[]
                {
                    new Horizon<Customer> (p => p.Deleted == false),
                    new Horizon<Account> (p => p.Deleted == false),
                    new Horizon<Balance> (p => p.Deleted == false),
                    new Horizon<Transaction> (p => p.Deleted == false),
                }
            },
            {
                "WRITE", new Horizon[]
                {
                }
            }
        };

        public static Horizon[] constraints =
        [
            new Horizon<Acc.Transaction>(r => r.At > r?.owner?.Balance?.When && 
                                                               r.Amount != null &&
                                                               r.owner != null),
            new Horizon<Acc.Customer> (c => c.Name != null),
            new Horizon<Acc.Account>(a => a.Title != null),
            new Horizon<Acc.Balance>(b => b.When != null && b.Current != null)
        ];

        public override Horizon[]? Horizon { get => base.Horizon == null ? constraints : constraints.Union(base.Horizon).ToArray(); init => base.Horizon = value; }
        public static AccSpace Make (HiperSpace space) { return new AccSpace (space); }

    }

    public partial class Account
    {
        public void Rollup ()
        {
            var when = Transactions.Select(t => t.At).Max();
            Balance = new Balance { When = when, Current = this.CurrentBalance };
        }
    }
}
