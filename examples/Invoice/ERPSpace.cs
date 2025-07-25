using ERP.Finance;
using ERP.Location;
using ERP.Products;
using ERP.Sales;
using Hiperspace;

namespace ERP
{
    public partial class ERPSpace
    {
        private static Horizon[] constraints = new Horizon[]
        {
            new Horizon<Address>        (i => i.Valid == true),
            new Horizon<Country>        (i => i.Valid == true),
            new Horizon<Tarriff>        (i => i.Valid == true),
            new Horizon<Tax>            (i => i.Valid == true),
            new Horizon<Shipping>       (i => i.Valid == true),
            new Horizon<Product>        (i => i.Valid == true),
            new Horizon<ProductPrice>   (i => i.Valid == true),
            new Horizon<Shipping>       (i => i.Valid == true),
            new Horizon<Salesperson>    (i => i.Valid == true),
            new Horizon<Order>          (i => i.Valid == true),
        };

        public override Horizon[]? Horizon { get => base.Horizon == null ? constraints : constraints.Union(base.Horizon).ToArray(); init => base.Horizon = value; }

        public ERPSpace(HiperSpace space, DateTime? AsAt = null, DateTime? DeltaFrom = null) 
            : this(space, null, AsAt, DeltaFrom)        
        { }

    }
    internal static class ERPFunctions
    {
        public static bool Changed<V>(V? v) where V : ElementVersion<V>, new()
        {
            if (v != null)
            {
                var c = v?.SetSpace?.Get(v);
                if (c != null && v != c) return true;
            }
            return false;
        }
        public static bool ChangedLines(Order order)
        {
            var c = order.SetSpace?.Get(order);
            if (c != null)
            {
                var lines = c.Lines;
                if (lines != null && order.Lines != null)
                { 
                    return lines.SequenceEqual(order.Lines);
                }
            }
            return false;
        }
    }
}
