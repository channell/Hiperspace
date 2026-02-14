using Hiperspace;
using System.Runtime.CompilerServices;

namespace API
{
    public partial class CustomerActivity : IMessage
    {
        public Task<IMessage> InvokeAsync(CancellationToken token = default)
        {
            ArgumentNullException.ThrowIfNull(Customer, "Customer parameter is required.");

            var customerTree = new List<Acc.Customer>();
            var accounts = new List<Acc.Account>();
            var cube = new List<Acc.Transaction_Cube>();
            var sectors = new HashSet<Acc.Sector>();

            customerTree.Add(Customer!);
            customerTree.AddRange(Children(Customer));
            foreach (var customer in customerTree)
            {
                accounts.AddRange(customer.Accounts);
            }
            foreach (var cust in customerTree)
            {
                if (cust.Sector is not null)
                    sectors.Add(cust.Sector);
            }

            return Task.FromResult<IMessage>(new CustomerActivity(this)
            {
                CustomerTree = customerTree,
                Accounts = accounts,
                Cube = cube,
                Sector = sectors.ToList()
            });
        }

        private IEnumerable<Acc.Customer> Children(Acc.Customer? customer)
        {
            if (customer is null) yield break;
            foreach (var child in customer.Children)
            {
                yield return child;
                foreach (var grandChild in Children(child))
                {
                    yield return grandChild;
                }
            }
        }

        private void Drilldowns
            (Acc.Transaction_Cube? source
            , List<Acc.Transaction_Cube> cube)
        {
            if (source is null) return;
            cube.Add(source);
        }

        public async IAsyncEnumerable<IMessage> InvokeStreamAsync([EnumeratorCancellation] CancellationToken token = default)
        {
            yield return await InvokeAsync(token);
        }
    }
}
