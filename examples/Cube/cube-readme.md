
```mermaid
classDiagram

    class Cube.Portfolio {

        # Id  : String

        + Parent  : Cube.Portfolio
        + Tier  : Int32

        + Contract_Fact(CubeSlice = "11", Portfolio = this, ContextLabel = contextlabel(this)) : Cube.Contract_Cube
        + Children (Parent = this) : Cube.Portfolio
    }






 

    class Cube.Country {

        # ISO  : String


        + Contract_Fact(CubeSlice = "13", Country = this, ContextLabel = contextlabel(this)) : Cube.Contract_Cube
        + Instruments (Country = this) : Cube.Instrument
    }






 

    class Cube.Sector {

        # Id  : Int32

        + Name  : String
        + Parent  : Cube.Sector
        + Tier  : Int32

        + Contract_Fact(CubeSlice = "19", Sector = this, ContextLabel = contextlabel(this)) : Cube.Contract_Cube
        + Children (Parent = this) : Cube.Sector
        + Customers (Sector = this) : Cube.Customer
    }






 

    class Cube.Product {

        # Id  : String

        + Parent  : Cube.Product
        + Tier  : Int32

        + Contract_Fact(CubeSlice = "25", Product = this, ContextLabel = contextlabel(this)) : Cube.Contract_Cube
        + Children (Parent = this) : Cube.Product
        + ProductInstruments (Product = this) : Cube.Instrument
    }












 

    class Cube.Contract_Fact{

        # ContextLabel  : String
        # Sector  : Cube.Sector
        # Country  : Cube.Country
        # Product  : Cube.Product
        # Portfolio  : Cube.Portfolio

        + Value  : Decimal
        + StdDev  : Double
        + Deleted  = false
        + Facts  : Int64

        + CubeName () = cubename(Sector,Country,Product,Portfolio)
    }


    Cube.Contract_Fact--> Cube.Portfolio
    Cube.Contract_Fact--> Cube.Sector
    Cube.Contract_Fact--> Cube.Product
    Cube.Contract_Fact--> Cube.Country



 

 

