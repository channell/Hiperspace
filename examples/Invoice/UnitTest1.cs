using Hiperspace.Rocks;
using ERP;
using ERP.Location;
using ERP.Client;
using Xunit.Priority;
using FluentAssertions;
using ERP.Products;
using Hiperspace.Heap;
using Hiperspace;
using ProtoBuf;
using System.Runtime.CompilerServices;

namespace Invoice
{
    [DefaultPriority(0)]
    [TestCaseOrderer(PriorityOrderer.Name, PriorityOrderer.Assembly)]
    public class UnitTest1
    {
        private HiperSpace _hiperspace;
        private ERPSpace _space;

        public UnitTest1 ()
        {
            //var fn = DateTime.Now.Ticks.ToString();
            //if (!Directory.Exists("./rockstest")) Directory.CreateDirectory("./rockstest");
            //if (Directory.Exists($"./rockstest/{fn}")) Directory.Delete($"./rockstest/{fn}", true);
            //if (!Directory.Exists(fn)) Directory.CreateDirectory(fn);

            //_hiperspace = new RockSpace(fn, new MetaModel(), true);
            _hiperspace = new HeapSpace();
            _space = new ERPSpace(_hiperspace, null, null);
        }

        [Fact, Priority(1)]
        public void TestCustomer()
        {
            var uk = new Country { Id = 1, Name = "United Kingdom", ShippingCharge = 0m };
            _space.Countrys.Add(uk).Should().BeTrue();

            var address = new Address
            {
                Id = 2,
                Street = "250 Bishopsgate",
                Town = "London",
                County = "Greater London",
                Country = uk,
                PostalCode = "EC2M 4AA"
            };
            _space.Addresss.Add(address).Should().BeTrue();

            var natwest = new Customer
            {
                Id = 3,
                Name = "NatWest",
                BillTo = address,
                ShipTo = address,
            };
            _space.Customers.Add(natwest).Should().BeTrue();

            using (var read = new ERPSpace(_space))
            {
                var cust = read.Customers.Where (c => c.Id == 3).FirstOrDefault();
                cust.Should().NotBeNull("NatWest was added");
                cust!.Name.Should().Be("NatWest", because: "added");
                cust!.ShipTo!.Country!.Name.Should().Be("United Kingdom", because: "Country was referenced");
                cust!.ShipTo!.PostalCode.Should().Be("EC2M 4AA");
                cust!.BillTo!.PostalCode.Should().Be("EC2M 4AA");
            }
        }
        [Fact, Priority(2)]
        public void TestProduct ()
        {
            _space.Taxs.Add(new ERP.Finance.Tax
            {
                Id = 5,
                Name = "Standard VAT",
                Rate = 0.20m,
            }).Should().BeTrue();
            _space.Customers.Add(new Customer
            {
                Id = 5,
                Name = "Internal",
                BillTo = new Address { Id = 2 },
                ShipTo = new Address { Id = 2 },
            }).Should().BeTrue();

            _space.Products.Add(new ERP.Products.Product
            {
                Id = 4,
                Name = "Computer",
                Tax = new ERP.Finance.Tax { Id = 5 },
                Shipping = 20m,
                Price = new ERP.Products.Price
                {
                    Name = "Standard",
                    Sell = 1_000m,
                    Buy = 500m,
                },
                Supplier = new Customer { Id = 5},
            }).Should().BeTrue();
            using (var read = new ERPSpace(_space))
            {
                var prod = read.Products.Where(p => p.Id == 4).First();
                var tax = read.Taxs.Where(p => p.Id == 5).First();
                prod.Tax.Should().NotBeNull().And.Be(tax);
                prod.Tax!.Name.Should().Be("Standard VAT");
                prod.Price!.Buy.Should().Be(500m);
                prod.Price.Sell.Should().Be(1_000m);

                read.Prices.Update (new Price(prod.Price)
                {
                    Buy = 700m
                });

                using (var fresh = new ERPSpace(read))
                {
                    var inflated = fresh.Products.Where(p => p.Id == 4).First().Price;
                    inflated!.Buy.Should().Be(700m);
                    inflated.GetVersions().Count().Should().Be(2);

                    using (var snap = new ERPSpace(_space, inflated.GetVersions().First().AsAt))
                    {
                        var price = snap.Prices.Where(pp => pp.owner == new Product { Id = 4 }).First();
                        price.Buy.Should().Be(500m, because: "date is before inflation");
                    }
                }
            }
        }

        [Fact, Priority(2)]
        public void TestStore()
        {
            _space.Countrys.Add(new Country { Id = 1, Name = "United Kingdom", ShippingCharge = 0m }).Should().BeTrue();

            _space.Stores.Add(new Store
            {
                Id = 1,
                Name = "Bishopsgate",
                Street = "199 Bishopsgate, London",
                Town = "London",
                County = "Greater London",
                Country = new Country { Id = 1 },
                PostalCode = "EC2M 4AA",
            }).Should().BeTrue();

            using (var read = new ERPSpace(_space))
            {
                var country = read.Stores.Get(new Store { Id = 1 })?.Country;
                country!.Name.Should().Be("United Kingdom", because: "was lazy loaded");
            }
        }
        [Fact, Priority(2)]
        public void TestSales()
        {
            _space.Salespersons.Add(new ERP.Sales.Salesperson
            {
                Id = 6,
                Name = "Karl",
                CommissionRate = .05m,
            }).Should().BeTrue();

            using (var read = new ERPSpace(_space))
            {
                var sales = read.Salespersons.Get(new ERP.Sales.Salesperson { Id = 6 });
                sales?.Name.Should().Be("Karl", because: "We just added him");
            }
        }

        [Fact, Priority(3)]
        public void TestOrder ()
        {
            // run the tests that setup the data
            TestCustomer();
            TestProduct();
            TestStore();
            TestSales();
 
            var anorder = new ERP.Sales.Order
            {
                OrderNumber = 42,
                Customer = new Customer { Id = 3 },
                Salesperson = new ERP.Sales.Salesperson { Id = 6 },
                Store = new Store { Id = 1 },
                Lines = new HashSet<ERP.Sales.OrderLine>
                {
                    new ERP.Sales.OrderLine { LineNumber = 1, Product = new Product {Id = 4 }, Units = 10m }
                }
            };
            _space.Orders.Add (new ERP.Sales.Order
            {
                OrderNumber = 42,
                Customer = new Customer { Id = 3},
                Salesperson = new ERP.Sales.Salesperson { Id = 6},
                Store = new Store { Id = 1 },
                Lines = new HashSet<ERP.Sales.OrderLine> 
                { 
                    new ERP.Sales.OrderLine { LineNumber = 1, Product = new Product {Id = 4 }, Units = 10m } 
                }
            }).Should().BeTrue();
            using (var read = new ERPSpace(_space))
            {
                var order = read.Orders.Get(new ERP.Sales.Order{ OrderNumber = 42 });
                order!.Salesperson!.Name.Should().Be("Karl");
                order!.Customer!.Name.Should().Be("NatWest");
                order!.Store!.Name.Should().Be("Bishopsgate");
            }
        }
    }
}