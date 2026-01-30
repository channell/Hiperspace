using FluentAssertions;
using Hiperspace.Heap;
using Xunit;
using Xunit.Abstractions;

namespace Cube.Tests
{
    public class Test
    {
        public static T? nvl<T>(T t) where T : struct { return new T?(t); }
        ITestOutputHelper _output;

        private HeapSpace driver;
        private CubeSpace _space;
        public Test(ITestOutputHelper output)
        {
            _output = output;
            driver = new HeapSpace();
            _space = new CubeSpace(driver);
        }
        [Fact]
        public void TestView()
        {
            var book = _space.Books.Bind(new Banking.Book { Id = "Book" }).Value;
            _space.FITrades.Add(new Banking.FI.Trade { Id = "FI", Book = book });
            _space.FXTrades.Add(new Banking.FX.Trade { Id = "FX", Book = book });
            _space.EQTrades.Add(new Banking.EQ.Trade { Id = "FX", Book = book });
            foreach (var t in _space.BankingTrades)
            {
                _output.WriteLine(t.Id);
            }
            _space.BankingTrades.Count().Should().Be(3);
        }
        [Fact]
        public void TestSegment()
        {
            var customer = _space.Customers.Bind(new Customer { Id = "Customer" }).Value;
            var account = _space.Accounts.Bind(new Account { Id = "Account", Customer = customer }).Value;
            var facc = new First.Acc { Account = account };
            customer.FirstAccount = new(facc);
            foreach (var a in customer.Accounts)
            {
                _output.WriteLine(a.Id);
            }
            customer.Accounts.Count().Should().Be(1);
            var af = account.FirstAccount.FirstOrDefault();
            af.Should().NotBeNull();
            Customer? cust = af?.owner?.Customer();
            cust.Should().NotBeNull();
            if (af?.owner?.Is<Customer>() ?? false)
            {
                var c = af.owner.As<Customer>();
                c.Should().NotBeNull();
            }
        }
    }
}