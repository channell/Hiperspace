using Hiperspace;
using System.Runtime.CompilerServices;

namespace API
{
    public partial class CustomerCube : IMessage
    {
        public Task<IMessage> InvokeAsync(CancellationToken token = default)
        {
            ArgumentNullException.ThrowIfNull(Customer, "Customer parameter is required.");

            var customerTree = new List<Acc.Customer>();
            var accounts = new List<Acc.Account>();
            var cube = new List<Acc.Transaction_Cube>();
            var drill = new List<Acc.Transaction_CubeDrillDown>();
            var sectors = new HashSet<Acc.Sector>();

            customerTree.Add(Customer!);
            customerTree.AddRange(Children(Customer));
            foreach (var customer in customerTree)
            {
                accounts.AddRange(customer.Accounts);
            }
            Drilldowns(Customer.Transaction_Cube, cube, drill);
            foreach (var cust in customerTree)
            {
                if (cust.Sector != null)
                    sectors.Add(cust.Sector);
            }

            return Task.FromResult<IMessage>(new CustomerCube(this)
            {
                CustomerTree = customerTree,
                Accounts = accounts,
                Cube = cube,
                Drilldown = drill,
                Sector = sectors.ToList()
            });
        }

        private IEnumerable<Acc.Customer> Children (Acc.Customer? customer)
        {
            if (customer == null) yield break;
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
            , List<Acc.Transaction_Cube> cube 
            , List<Acc.Transaction_CubeDrillDown> drill)
        {
            if (source == null) return;
            cube.Add(source);
            foreach (var item in source.DrillDown)
            {
                drill.Add(item);
                if (item.To != null)
                    Drilldowns(item.To, cube, drill);
            }
        }

        public async IAsyncEnumerable<IMessage> InvokeStreamAsync([EnumeratorCancellation]CancellationToken token = default)
        {
            yield return await InvokeAsync(token);
        }
    }
}
