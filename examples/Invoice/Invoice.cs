using ERP.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Sales
{
    public partial class OrderInvoice
    {
        /// <summary>
        /// Snapshot the order financials
        /// </summary>
        /// <param name="order"></param>
        public OrderInvoice(Order order) 
        { 
            Commission = order.Commission;
            Cost = order.Cost;
            Total = order.Total;
            Profit = order.Profit;
            SalesTax = order.SalesTax;
            ShippingCost = order.ShippingCost;
            TariffTax = order.TariffTax;
            Total = order.Total;
            TaxDate = DateTime.UtcNow.Date;
        }
    }
}
