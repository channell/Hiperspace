# readme
```mermaid
classDiagram
    class ERP.Location.Address {
        # Id  : Int32
        + Street  : String
        + Town  : String
        + City  : String
        + County  : String
        + Country  : ERP.Location.Country
        + PostalCode  : String
        + Valid  = (((Country == null) || (PostalCode == null)) ? false : true)
    }
    ERP.Location.Address --> ERP.Location.Country
    class ERP.Location.Country {
        # Id  : Int16
        + Name  : String
        + ShippingCharge  : Decimal
        + Valid  = ((Name == null) ? false : true)
    }
    class ERP.Location.Store {
        + Name  : String
        + StoreSales (Store = this) : ERP.Sales.Order
    }
    ERP.Location.Store --|> ERP.Location.Address
    class ERP.Finance.Tarriff {
        # From  : ERP.Location.Country
        # To  : ERP.Location.Country
        + Tax  : ERP.Finance.Tax
        + Valid  = ((((From == null) || (To == null)) || (Tax == null)) ? false : true)
    }
    ERP.Finance.Tarriff --> ERP.Location.Country
    ERP.Finance.Tarriff --> ERP.Location.Country
    ERP.Finance.Tarriff --> ERP.Finance.Tax
    class ERP.Finance.Tax {
        # Id  : Int16
        + Name  : String
        + Rate  : Decimal
        + Valid  = (((Name == null) || (Rate == null)) ? false : true)
    }
    class ERP.Finance.Shipping {
        # From  : ERP.Location.Country
        # To  : ERP.Location.Country
        + Fee  : Decimal
        + Valid  = ((((From == null) || (To == null)) || (Fee == null)) ? false : true)
    }
    ERP.Finance.Shipping --> ERP.Location.Country
    ERP.Finance.Shipping --> ERP.Location.Country
    class ERP.Products.Product {
        # Id  : Int32
        + Name  : String
        + Tax  : ERP.Finance.Tax
        + Supplier  : ERP.Client.Customer
        + Shipping  : Decimal
        + Valid  = (((((Name == null) || (Tax == null)) || (Supplier == null)) || (Shipping == null)) ? false : true)
        + Price () : ERP.Products.Price
        + Rate () = Tax?.Rate
    }
    ERP.Products.Product --> ERP.Finance.Tax
    ERP.Products.Product --> ERP.Client.Customer
    ERP.Products.Product o-- ERP.Products.Price
    class ERP.Products.Price {
        + Name  : String
        + Sell  : Decimal
        + Buy  : Decimal
        + Valid  = ((((Name == null) || (Sell == null)) || (Buy == null)) ? false : true)
    }
    class ERP.Client.Customer {
        # Id  : Int32
        + Name  : String
        + BillTo  : ERP.Location.Address
        + ShipTo  : ERP.Location.Address
        + Valid  = ((((((Name == null) || (BillTo == null)) || (BillTo?.Valid == false)) || (ShipTo == null)) || (ShipTo?.Valid == false)) ? false : true)
        + CustomerOrders (Customer = this) : ERP.Sales.Order
    }
    ERP.Client.Customer --> ERP.Location.Address
    ERP.Client.Customer --> ERP.Location.Address
    class ERP.Sales.Salesperson {
        # Id  : Int16
        + Name  : String
        + CommissionRate  = 0.0m
        + Valid  = ((Name == null) ? false : true)
        + Sales (Salesperson = this) : ERP.Sales.Order
    }
    class ERP.Sales.OrderLine {
        # LineNumber  : Int16
        + Product  : ERP.Products.Product
        + Units  : Decimal
        + Valid  = (((Product == null) || (Units == null)) ? false : true)
        + Price () = (Product?.Price?.Sell * Units)
        + Cost () = ((Product?.Price?.Buy * Units) + Product?.Shipping)
        + Shipping () = Product?.Shipping
        + Tax () = (Product?.Rate * Units)
    }
    ERP.Sales.OrderLine --> ERP.Products.Product
    class ERP.Sales.Order {
        # OrderNumber  : Int32
        + Customer  : ERP.Client.Customer
        + Store  : ERP.Location.Store
        + Salesperson  : ERP.Sales.Salesperson
        + Lines  : Set~ERP.Sales.OrderLine~
        + Valid  = (((((((Customer == null) || (changed(Customer) == true)) || (Store == null)) || (_changeStore == true)) || (count(Lines.LineNumber) == 0)) || (_changeLines == true)) ? false : true)
        + Invoiced () = ((Invoice == null) ? true : false)
        + _changeStore () = (((changed(Store) == true) && (Invoiced == true)) ? true : false)
        + _changeLines () = (((changedLines(this) == true) && (Invoiced == true)) ? true : false)
        + Tariff (From = Store?.Country, To = Customer?.BillTo?.Country) : ERP.Finance.Tarriff
        + Shipping (From = Store?.Country, To = Customer?.ShipTo?.Country) : ERP.Finance.Shipping
        + Total () = sum(Lines.Price)
        + ShippingCost () = ((Shipping == null) ? sum(Lines.Shipping) : (sum(Lines.Shipping) + max(Shipping.Fee)))
        + SalesTax () = sum(Lines.Tax)
        + TariffTax () = ((Tariff == null) ? 0.0m : (max(Tariff.Tax.Rate) * Total))
        + Bill () = (((Total + ShippingCost) + SalesTax) + TariffTax)
        + Cost () = sum(Lines.Cost)
        + Commission () = ((Salesperson == null) ? 0.0m : (Profit * Salesperson?.CommissionRate))
        + Profit () = ((0.0m + Total) - Cost)
        + Invoice () : ERP.Sales.Invoice
    }
    ERP.Sales.Order --> ERP.Client.Customer
    ERP.Sales.Order --> ERP.Location.Store
    ERP.Sales.Order --> ERP.Sales.Salesperson
    ERP.Sales.Order o-- ERP.Sales.Invoice
    class ERP.Sales.Invoice {
        + TaxDate  : DateTime
        + Total  : Decimal
        + ShippingCost  : Decimal
        + SalesTax  : Decimal
        + TariffTax  : Decimal
        + Cost  : Decimal
        + Profit  : Decimal
        + Commission  : Decimal
        + Bill () = ((((0.0m + Total) + ShippingCost) + SalesTax) + TariffTax)
    }
```

---

## Entity ERP.Location.Address


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||||
|+|Street|String||||
|+|Town|String||||
|+|City|String||||
|+|County|String||||
|+|Country|ERP.Location.Country||||
|+|PostalCode|String||||
||Valid||||(((Country == null) \|\| (PostalCode == null)) ? false : true)|

---

## Entity ERP.Location.Country


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int16||||
|+|Name|String||||
|+|ShippingCharge|Decimal||||
||Valid||||((Name == null) ? false : true)|

---

## Entity ERP.Location.Store


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Name|String||||
||StoreSales|ERP.Sales.Order|||Store = this|

---

## Entity ERP.Finance.Tarriff


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|ERP.Location.Country||||
|#|To|ERP.Location.Country||||
|+|Tax|ERP.Finance.Tax||||
||Valid||||((((From == null) \|\| (To == null)) \|\| (Tax == null)) ? false : true)|

---

## Entity ERP.Finance.Tax


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int16||||
|+|Name|String||||
|+|Rate|Decimal||||
||Valid||||(((Name == null) \|\| (Rate == null)) ? false : true)|

---

## Entity ERP.Finance.Shipping


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|ERP.Location.Country||||
|#|To|ERP.Location.Country||||
|+|Fee|Decimal||||
||Valid||||((((From == null) \|\| (To == null)) \|\| (Fee == null)) ? false : true)|

---

## Entity ERP.Products.Product


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||||
|+|Name|String||||
|+|Tax|ERP.Finance.Tax||||
|+|Supplier|ERP.Client.Customer||||
|+|Shipping|Decimal||||
||Valid||||(((((Name == null) \|\| (Tax == null)) \|\| (Supplier == null)) \|\| (Shipping == null)) ? false : true)|
|+|Price|ERP.Products.Price||||
||Rate||||Tax?.Rate|

---

## Aspect ERP.Products.Price


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Name|String||||
|+|Sell|Decimal||||
|+|Buy|Decimal||||
||Valid||||((((Name == null) \|\| (Sell == null)) \|\| (Buy == null)) ? false : true)|

---

## Entity ERP.Client.Customer


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||||
|+|Name|String||||
|+|BillTo|ERP.Location.Address||||
|+|ShipTo|ERP.Location.Address||||
||Valid||||((((((Name == null) \|\| (BillTo == null)) \|\| (BillTo?.Valid == false)) \|\| (ShipTo == null)) \|\| (ShipTo?.Valid == false)) ? false : true)|
||CustomerOrders|ERP.Sales.Order|||Customer = this|

---

## Entity ERP.Sales.Salesperson


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int16||||
|+|Name|String||||
||CommissionRate||||0.0m|
||Valid||||((Name == null) ? false : true)|
||Sales|ERP.Sales.Order|||Salesperson = this|

---

## Value ERP.Sales.OrderLine


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|LineNumber|Int16||||
|+|Product|ERP.Products.Product||||
|+|Units|Decimal||||
||Valid||||(((Product == null) \|\| (Units == null)) ? false : true)|
||Price||||(Product?.Price?.Sell * Units)|
||Cost||||((Product?.Price?.Buy * Units) + Product?.Shipping)|
||Shipping||||Product?.Shipping|
||Tax||||(Product?.Rate * Units)|

---

## Entity ERP.Sales.Order
    An order placed by a customer for delivery    <remarks>the store and customer can not be changed once it has been invoiced </remarks>

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|OrderNumber|Int32||||
|+|Customer|ERP.Client.Customer||||
|+|Store|ERP.Location.Store||||
|+|Salesperson|ERP.Sales.Salesperson||||
|+|Lines|Set<ERP.Sales.OrderLine>|all the order lines included in the order|||
||Valid||||(((((((Customer == null) \|\| (changed(Customer) == true)) \|\| (Store == null)) \|\| (_changeStore == true)) \|\| (count(Lines.LineNumber) == 0)) \|\| (_changeLines == true)) ? false : true)|
||Invoiced||||((Invoice == null) ? true : false)|
||_changeStore||||(((changed(Store) == true) && (Invoiced == true)) ? true : false)|
||_changeLines||||(((changedLines(this) == true) && (Invoiced == true)) ? true : false)|
||Tariff|ERP.Finance.Tarriff|optional tarriff for this order - ommision implies tarriff free trade||From = Store?.Country, To = Customer?.BillTo?.Country|
||Shipping|ERP.Finance.Shipping|optional internnational shipping sharges ||From = Store?.Country, To = Customer?.ShipTo?.Country|
||Total||total value of the order for all lines||sum(Lines.Price)|
||ShippingCost||Shipping cost can only be calculated once we know if the order is international||((Shipping == null) ? sum(Lines.Shipping) : (sum(Lines.Shipping) + max(Shipping.Fee)))|
||SalesTax||||sum(Lines.Tax)|
||TariffTax||||((Tariff == null) ? 0.0m : (max(Tariff.Tax.Rate) * Total))|
||Bill||Bill price sent to the customer||(((Total + ShippingCost) + SalesTax) + TariffTax)|
||Cost||The cost of sourcing the products for the order||sum(Lines.Cost)|
||Commission||||((Salesperson == null) ? 0.0m : (Profit * Salesperson?.CommissionRate))|
||Profit||Gross profit from order, less costs and Commission||((0.0m + Total) - Cost)|
|+|Invoice|ERP.Sales.Invoice|the optional invoice aspect with coists and tax frozen |||

---

## Aspect ERP.Sales.Invoice
    Frozen value of order 

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|TaxDate|DateTime||||
|+|Total|Decimal||||
|+|ShippingCost|Decimal||||
|+|SalesTax|Decimal||||
|+|TariffTax|Decimal||||
|+|Cost|Decimal||||
|+|Profit|Decimal||||
|+|Commission|Decimal||||
||Bill||||((((0.0m + Total) + ShippingCost) + SalesTax) + TariffTax)|

