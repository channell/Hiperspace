# readme
```mermaid
classDiagram
    class Togaf.Organization {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Parent  : Togaf.Organization
        + Income_Cube (CubeSlice = "20", Organization = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "20", Organization = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "20", Organization = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + Children (Parent = this) : Togaf.Organization
        + Motivates (MotivatedBy = this) : Togaf.Business.Driver
        + Contains (In = this) : Togaf.Business.Actor
        + Functions (For = this) : Togaf.Business.Function
        + Uses (By = this) : Togaf.Business.Capability
        + Produces (By = this) : Togaf.Business.Product
        + Governs (OwnedBy = this) : Togaf.Service
        + SameName (Name = Name) : Togaf.Organization
    }
    class Togaf.Service {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + OwnedBy  : Togaf.Organization
        + Income_Cube (CubeSlice = "35", Service = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "35", Service = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "35", Service = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.ServiceVectorSpace
        + Principle () : Togaf.ServicePrinciple
        + Constraint () : Togaf.ServiceConstraint
        + Assumption () : Togaf.ServiceAssumption
        + Requirement () : Togaf.ServiceRequirement
        + Location () : Togaf.ServiceLocation
        + Gap () : Togaf.ServiceGap
        + WorkPackage () : Togaf.ServiceWorkPackage
        + Measures (Tracks = this) : Togaf.Business.Measure
        + Triggers (Trigger = this) : Togaf.Business.Event
        + UsedBy (Uses = this) : Togaf.Business.Activity
        + Provides (Provider = this) : Togaf.Data.Entity
        + ProvidedBy (Realizes = this) : Togaf.Application.System
        + SameName (Name = Name) : Togaf.Service
    }
    class Togaf.Complexity {
        # Organization  : Togaf.Organization
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Product  : Togaf.Business.Product
        # Event  : Togaf.Business.Event
        # Process  : Togaf.Business.Process
        # Service  : Togaf.Service
        # System  : Togaf.Application.System
        # Platform  : Togaf.Technology.Platform
        # Host  : Togaf.Technology.Host
        + Deleted  = false
        + E  : Decimal
        + N  : Decimal
        + P  : Decimal
        + M () = ((E - N) + (2 * P))
        + Host_Dimension () = Host
        + Event_Dimension () = Process?.Starts?.Event
        + System_Dimension () = System
        + Service_Dimension () = Host?.Platform?.Serves
        + Process_Dimension () = Process
        + Product_Dimension () = Process?.Provides
        + Platform_Dimension () = Host?.Platform
        + Function_Dimension () = Process?.Decomposes
        + Capability_Dimension () = Process?.Realizes?.Enables
        + Organization_Dimension () = Host?.Platform?.Serves?.OwnedBy
    }
    class Togaf.Complexity_Cube {
        # CubeSlice  : String
        # ContextLabel  : String
        # Host  : Togaf.Technology.Host
        # Event  : Togaf.Business.Event
        # System  : Togaf.Application.System
        # Service  : Togaf.Service
        # Process  : Togaf.Business.Process
        # Product  : Togaf.Business.Product
        # Platform  : Togaf.Technology.Platform
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Organization  : Togaf.Organization
        + E  : Decimal
        + N  : Decimal
        + P  : Decimal
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + M () = ((E - N) + (2 * P))
    }
    class Togaf.Complexity_Fact {
        # ContextLabel  : String
        # Host  : Togaf.Technology.Host
        # Event  : Togaf.Business.Event
        # System  : Togaf.Application.System
        # Service  : Togaf.Service
        # Process  : Togaf.Business.Process
        # Product  : Togaf.Business.Product
        # Platform  : Togaf.Technology.Platform
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Organization  : Togaf.Organization
        + E  : Decimal
        + N  : Decimal
        + P  : Decimal
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + M () = ((E - N) + (2 * P))
    }
    class Togaf.Business.Function {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + For  : Togaf.Organization
        + Parent  : Togaf.Business.Function
        + Delivers  : Togaf.Business.Capability
        + Income_Cube (CubeSlice = "101", Function = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "101", Function = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "101", Function = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.FunctionVectorSpace
        + Principle () : Togaf.Business.FunctionPrinciple
        + Constraint () : Togaf.Business.FunctionConstraint
        + Assumption () : Togaf.Business.FunctionAssumption
        + Requirement () : Togaf.Business.FunctionRequirement
        + Location () : Togaf.Business.FunctionLocation
        + Gap () : Togaf.Business.FunctionGap
        + WorkPackage () : Togaf.Business.FunctionWorkPackage
        + Children (Parent = this) : Togaf.Business.Function
        + Orchestrates (Decomposes = this) : Togaf.Business.Process
        + Involves (Involves = this) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Function
    }
    class Togaf.Business.Capability {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + By  : Togaf.Organization
        + Parent  : Togaf.Business.Capability
        + Income_Cube (CubeSlice = "116", Capability = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "116", Capability = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "116", Capability = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.CapabilityVectorSpace
        + Principle () : Togaf.Business.CapabilityPrinciple
        + Constraint () : Togaf.Business.CapabilityConstraint
        + Assumption () : Togaf.Business.CapabilityAssumption
        + Requirement () : Togaf.Business.CapabilityRequirement
        + Location () : Togaf.Business.CapabilityLocation
        + Gap () : Togaf.Business.CapabilityGap
        + WorkPackage () : Togaf.Business.CapabilityWorkPackage
        + Children (Parent = this) : Togaf.Business.Capability
        + Operated (Operates = this) : Togaf.Business.Process
        + Delivered (Delivers = this) : Togaf.Business.Function
        + EnabledBy (Enables = this) : Togaf.Business.ValueStream
        + Related (Enables = this) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Capability
    }
    class Togaf.Business.Product {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + By  : Togaf.Organization
        + Parent  : Togaf.Business.Product
        + Income_Cube (CubeSlice = "128", Product = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "128", Product = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "128", Product = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ProductVectorSpace
        + Principle () : Togaf.Business.ProductPrinciple
        + Constraint () : Togaf.Business.ProductConstraint
        + Assumption () : Togaf.Business.ProductAssumption
        + Requirement () : Togaf.Business.ProductRequirement
        + Location () : Togaf.Business.ProductLocation
        + Gap () : Togaf.Business.ProductGap
        + WorkPackage () : Togaf.Business.ProductWorkPackage
        + Children (Parent = this) : Togaf.Business.Product
        + ProvidedBy (Provides = this) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.Product
    }
    class Togaf.Business.Event {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Type  : Togaf.Business.EventType
        + Trigger  : Togaf.Service
        + Income_Cube (CubeSlice = "187", Event = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "187", Event = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "187", Event = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.EventVectorSpace
        + Principle () : Togaf.Business.EventPrinciple
        + Constraint () : Togaf.Business.EventConstraint
        + Assumption () : Togaf.Business.EventAssumption
        + Requirement () : Togaf.Business.EventRequirement
        + Location () : Togaf.Business.EventLocation
        + Gap () : Togaf.Business.EventGap
        + WorkPackage () : Togaf.Business.EventWorkPackage
        + Activities (Event = this) : Togaf.Business.Activity
        + SameName (Name = Name) : Togaf.Business.Event
    }
    class Togaf.Business.Process {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Decomposes  : Togaf.Business.Function
        + Starts  : Togaf.Business.Activity
        + Operates  : Togaf.Business.Capability
        + Provides  : Togaf.Business.Product
        + Governed  : Togaf.Business.Control
        + Realizes  : Togaf.Business.ValueStream
        + Income_Cube (CubeSlice = "198", Process = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "198", Process = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "198", Process = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ProcessVectorSpace
        + Principle () : Togaf.Business.ProcessPrinciple
        + Constraint () : Togaf.Business.ProcessConstraint
        + Assumption () : Togaf.Business.ProcessAssumption
        + Requirement () : Togaf.Business.ProcessRequirement
        + Location () : Togaf.Business.ProcessLocation
        + Gap () : Togaf.Business.ProcessGap
        + WorkPackage () : Togaf.Business.ProcessWorkPackage
        + Steps (Part = this) : Togaf.Business.Activity
        + SameName (Name = Name) : Togaf.Business.Process
    }
    class Togaf.Application.System {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Realizes  : Togaf.Service
        + Platform  : Togaf.Technology.Platform
        + Income_Cube (CubeSlice = "537", System = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "537", System = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "537", System = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Application.SystemVectorSpace
        + Principle () : Togaf.Application.SystemPrinciple
        + Constraint () : Togaf.Application.SystemConstraint
        + Assumption () : Togaf.Application.SystemAssumption
        + Requirement () : Togaf.Application.SystemRequirement
        + Location () : Togaf.Application.SystemLocation
        + Gap () : Togaf.Application.SystemGap
        + WorkPackage () : Togaf.Application.SystemWorkPackage
        + SystemUsage (System = this) : Togaf.Data.Usage
        + ImplementedBy (Implements = this) : Togaf.Application.Component
        + SameName (Name = Name) : Togaf.Application.System
    }
    class Togaf.Technology.Platform {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Serves  : Togaf.Service
        + Income_Cube (CubeSlice = "617", Platform = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "617", Platform = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "617", Platform = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Technology.PlatformVectorSpace
        + Principle () : Togaf.Technology.PlatformPrinciple
        + Constraint () : Togaf.Technology.PlatformConstraint
        + Assumption () : Togaf.Technology.PlatformAssumption
        + Requirement () : Togaf.Technology.PlatformRequirement
        + Location () : Togaf.Technology.PlatformLocation
        + Gap () : Togaf.Technology.PlatformGap
        + WorkPackage () : Togaf.Technology.PlatformWorkPackage
        + Hosts (Platform = this) : Togaf.Application.System
        + Defines (Platform = this) : Togaf.Technology.Host
        + SameName (Name = Name) : Togaf.Technology.Platform
    }
    class Togaf.Technology.Host {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Platform  : Togaf.Technology.Platform
        + Income_Cube (CubeSlice = "629", Host = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = "629", Host = this, ContextLabel = contextlabel(this)) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = "629", Host = this, ContextLabel = contextlabel(this)) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Technology.HostVectorSpace
        + Principle () : Togaf.Technology.HostPrinciple
        + Constraint () : Togaf.Technology.HostConstraint
        + Assumption () : Togaf.Technology.HostAssumption
        + Requirement () : Togaf.Technology.HostRequirement
        + Location () : Togaf.Technology.HostLocation
        + Gap () : Togaf.Technology.HostGap
        + WorkPackage () : Togaf.Technology.HostWorkPackage
        + Hosts (Host = this) : Togaf.Application.Component
        + Instances (Host = this) : Togaf.Technology.Instance
    }
    class Togaf.Financial.Income_Cube {
        # CubeSlice  : String
        # ContextLabel  : String
        # Host  : Togaf.Technology.Host
        # Event  : Togaf.Business.Event
        # System  : Togaf.Application.System
        # Service  : Togaf.Service
        # Process  : Togaf.Business.Process
        # Product  : Togaf.Business.Product
        # Platform  : Togaf.Technology.Platform
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Organization  : Togaf.Organization
        + RevX  : Decimal
        + CapX  : Decimal
        + OpeX  : Decimal
        + Hours  : Int64
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
    }
    class Togaf.Financial.Cost {
        # Organization  : Togaf.Organization
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Product  : Togaf.Business.Product
        # Event  : Togaf.Business.Event
        # Process  : Togaf.Business.Process
        # Service  : Togaf.Service
        # System  : Togaf.Application.System
        # Platform  : Togaf.Technology.Platform
        # Host  : Togaf.Technology.Host
        + Deleted  = false
        + RevX  : Decimal
        + CapX  : Decimal
        + OpeX  : Decimal
        + Hours  : Int64
        + Host_Dimension () = Host
        + Event_Dimension () = Process?.Starts?.Event
        + System_Dimension () = System
        + Service_Dimension () = Host?.Platform?.Serves
        + Process_Dimension () = Process
        + Product_Dimension () = Process?.Provides
        + Platform_Dimension () = Host?.Platform
        + Function_Dimension () = Process?.Decomposes
        + Capability_Dimension () = Process?.Realizes?.Enables
        + Organization_Dimension () = Host?.Platform?.Serves?.OwnedBy
    }
    class Togaf.Financial.Income {
        # Organization  : Togaf.Organization
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Product  : Togaf.Business.Product
        # Event  : Togaf.Business.Event
        # Process  : Togaf.Business.Process
        # Service  : Togaf.Service
        # System  : Togaf.Application.System
        # Platform  : Togaf.Technology.Platform
        # Host  : Togaf.Technology.Host
        + Deleted  = false
        + RevX  : Decimal
        + CapX  : Decimal
        + OpeX  : Decimal
        + Hours  : Int64
        + Host_Dimension () = Host
        + Event_Dimension () = Process?.Starts?.Event
        + System_Dimension () = System
        + Service_Dimension () = Host?.Platform?.Serves
        + Process_Dimension () = Process
        + Product_Dimension () = Process?.Provides
        + Platform_Dimension () = Host?.Platform
        + Function_Dimension () = Process?.Decomposes
        + Capability_Dimension () = Process?.Realizes?.Enables
        + Organization_Dimension () = Host?.Platform?.Serves?.OwnedBy
    }
    class Togaf.Financial.Income_Fact {
        # ContextLabel  : String
        # Host  : Togaf.Technology.Host
        # Event  : Togaf.Business.Event
        # System  : Togaf.Application.System
        # Service  : Togaf.Service
        # Process  : Togaf.Business.Process
        # Product  : Togaf.Business.Product
        # Platform  : Togaf.Technology.Platform
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Organization  : Togaf.Organization
        + RevX  : Decimal
        + CapX  : Decimal
        + OpeX  : Decimal
        + Hours  : Int64
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
    }
    class Togaf.Financial.Cost_Cube {
        # CubeSlice  : String
        # ContextLabel  : String
        # Host  : Togaf.Technology.Host
        # Event  : Togaf.Business.Event
        # System  : Togaf.Application.System
        # Service  : Togaf.Service
        # Process  : Togaf.Business.Process
        # Product  : Togaf.Business.Product
        # Platform  : Togaf.Technology.Platform
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Organization  : Togaf.Organization
        + RevX  : Decimal
        + CapX  : Decimal
        + OpeX  : Decimal
        + Hours  : Int64
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
    }
    class Togaf.Financial.Cost_Fact {
        # ContextLabel  : String
        # Host  : Togaf.Technology.Host
        # Event  : Togaf.Business.Event
        # System  : Togaf.Application.System
        # Service  : Togaf.Service
        # Process  : Togaf.Business.Process
        # Product  : Togaf.Business.Product
        # Platform  : Togaf.Technology.Platform
        # Function  : Togaf.Business.Function
        # Capability  : Togaf.Business.Capability
        # Organization  : Togaf.Organization
        + RevX  : Decimal
        + CapX  : Decimal
        + OpeX  : Decimal
        + Hours  : Int64
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
    }
```

---

## EntityImpl Togaf.Organization


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Parent|Togaf.Organization||AlternateIndex()||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "20", Organization = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "20", Organization = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "20", Organization = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||Children|Togaf.Organization|||Parent = this|
||Motivates|Togaf.Business.Driver|||MotivatedBy = this|
||Contains|Togaf.Business.Actor|||In = this|
||Functions|Togaf.Business.Function|||For = this|
||Uses|Togaf.Business.Capability|||By = this|
||Produces|Togaf.Business.Product|||By = this|
||Governs|Togaf.Service|||OwnedBy = this|
||SameName|Togaf.Organization|||Name = Name|

---

## EntityImpl Togaf.Service


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|OwnedBy|Togaf.Organization||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "35", Service = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "35", Service = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "35", Service = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.ServiceVectorSpace||||
|+|Principle|Togaf.ServicePrinciple||||
|+|Constraint|Togaf.ServiceConstraint||||
|+|Assumption|Togaf.ServiceAssumption||||
|+|Requirement|Togaf.ServiceRequirement||||
|+|Location|Togaf.ServiceLocation||||
|+|Gap|Togaf.ServiceGap||||
|+|WorkPackage|Togaf.ServiceWorkPackage||||
||Measures|Togaf.Business.Measure|||Tracks = this|
||Triggers|Togaf.Business.Event|||Trigger = this|
||UsedBy|Togaf.Business.Activity|||Uses = this|
||Provides|Togaf.Data.Entity|||Provider = this|
||ProvidedBy|Togaf.Application.System|||Realizes = this|
||SameName|Togaf.Service|||Name = Name|

---

## EntityImpl Togaf.Complexity


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Organization|Togaf.Organization||||
|#|Function|Togaf.Business.Function||||
|#|Capability|Togaf.Business.Capability||||
|#|Product|Togaf.Business.Product||||
|#|Event|Togaf.Business.Event||||
|#|Process|Togaf.Business.Process||||
|#|Service|Togaf.Service||||
|#|System|Togaf.Application.System||||
|#|Platform|Togaf.Technology.Platform||||
|#|Host|Togaf.Technology.Host||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|E|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|N|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|P|Decimal||CubeMeasure(Aggregate?.Sum)||
||M|Some(Decimal)||CubeExtent()|((E - N) + (2 * P))|
||Host_Dimension|Some(Togaf.Technology.Host)|||Host|
||Event_Dimension|Some(Togaf.Business.Event)|||Process?.Starts?.Event|
||System_Dimension|Some(Togaf.Application.System)|||System|
||Service_Dimension|Some(Togaf.Service)|||Host?.Platform?.Serves|
||Process_Dimension|Some(Togaf.Business.Process)|||Process|
||Product_Dimension|Some(Togaf.Business.Product)|||Process?.Provides|
||Platform_Dimension|Some(Togaf.Technology.Platform)|||Host?.Platform|
||Function_Dimension|Some(Togaf.Business.Function)|||Process?.Decomposes|
||Capability_Dimension|Some(Togaf.Business.Capability)|||Process?.Realizes?.Enables|
||Organization_Dimension|Some(Togaf.Organization)|||Host?.Platform?.Serves?.OwnedBy|

---

## EntityImpl Togaf.Complexity_Cube


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|CubeSlice|String||||
|#|ContextLabel|String||||
|#|Host|Togaf.Technology.Host||CubeDimensionReference()||
|#|Event|Togaf.Business.Event||CubeDimensionReference()||
|#|System|Togaf.Application.System||CubeDimensionReference()||
|#|Service|Togaf.Service||CubeDimensionReference()||
|#|Process|Togaf.Business.Process||CubeDimensionReference()||
|#|Product|Togaf.Business.Product||CubeDimensionReference()||
|#|Platform|Togaf.Technology.Platform||CubeDimensionReference()||
|#|Function|Togaf.Business.Function||CubeDimensionReference()||
|#|Capability|Togaf.Business.Capability||CubeDimensionReference()||
|#|Organization|Togaf.Organization||CubeDimensionReference()||
|+|E|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|N|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|P|Decimal||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||M|Some(Decimal)||CubeExtent()|((E - N) + (2 * P))|

---

## EntityImpl Togaf.Complexity_Fact


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ContextLabel|String||||
|#|Host|Togaf.Technology.Host||CubeDimensionReference()||
|#|Event|Togaf.Business.Event||CubeDimensionReference()||
|#|System|Togaf.Application.System||CubeDimensionReference()||
|#|Service|Togaf.Service||CubeDimensionReference()||
|#|Process|Togaf.Business.Process||CubeDimensionReference()||
|#|Product|Togaf.Business.Product||CubeDimensionReference()||
|#|Platform|Togaf.Technology.Platform||CubeDimensionReference()||
|#|Function|Togaf.Business.Function||CubeDimensionReference()||
|#|Capability|Togaf.Business.Capability||CubeDimensionReference()||
|#|Organization|Togaf.Organization||CubeDimensionReference()||
|+|E|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|N|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|P|Decimal||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||M|Some(Decimal)||CubeExtent()|((E - N) + (2 * P))|

---

## EntityImpl Togaf.Business.Function


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|For|Togaf.Organization||AlternateIndex()||
|+|Parent|Togaf.Business.Function||||
|+|Delivers|Togaf.Business.Capability||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "101", Function = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "101", Function = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "101", Function = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.FunctionVectorSpace||||
|+|Principle|Togaf.Business.FunctionPrinciple||||
|+|Constraint|Togaf.Business.FunctionConstraint||||
|+|Assumption|Togaf.Business.FunctionAssumption||||
|+|Requirement|Togaf.Business.FunctionRequirement||||
|+|Location|Togaf.Business.FunctionLocation||||
|+|Gap|Togaf.Business.FunctionGap||||
|+|WorkPackage|Togaf.Business.FunctionWorkPackage||||
||Children|Togaf.Business.Function|||Parent = this|
||Orchestrates|Togaf.Business.Process|||Decomposes = this|
||Involves|Togaf.Business.CourseOfAction|||Involves = this|
||SameName|Togaf.Business.Function|||Name = Name|

---

## EntityImpl Togaf.Business.Capability


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|By|Togaf.Organization||||
|+|Parent|Togaf.Business.Capability||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "116", Capability = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "116", Capability = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "116", Capability = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.CapabilityVectorSpace||||
|+|Principle|Togaf.Business.CapabilityPrinciple||||
|+|Constraint|Togaf.Business.CapabilityConstraint||||
|+|Assumption|Togaf.Business.CapabilityAssumption||||
|+|Requirement|Togaf.Business.CapabilityRequirement||||
|+|Location|Togaf.Business.CapabilityLocation||||
|+|Gap|Togaf.Business.CapabilityGap||||
|+|WorkPackage|Togaf.Business.CapabilityWorkPackage||||
||Children|Togaf.Business.Capability|||Parent = this|
||Operated|Togaf.Business.Process|||Operates = this|
||Delivered|Togaf.Business.Function|||Delivers = this|
||EnabledBy|Togaf.Business.ValueStream|||Enables = this|
||Related|Togaf.Business.CourseOfAction|||Enables = this|
||SameName|Togaf.Business.Capability|||Name = Name|

---

## EntityImpl Togaf.Business.Product


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|By|Togaf.Organization||||
|+|Parent|Togaf.Business.Product||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "128", Product = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "128", Product = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "128", Product = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ProductVectorSpace||||
|+|Principle|Togaf.Business.ProductPrinciple||||
|+|Constraint|Togaf.Business.ProductConstraint||||
|+|Assumption|Togaf.Business.ProductAssumption||||
|+|Requirement|Togaf.Business.ProductRequirement||||
|+|Location|Togaf.Business.ProductLocation||||
|+|Gap|Togaf.Business.ProductGap||||
|+|WorkPackage|Togaf.Business.ProductWorkPackage||||
||Children|Togaf.Business.Product|||Parent = this|
||ProvidedBy|Togaf.Business.Process|||Provides = this|
||SameName|Togaf.Business.Product|||Name = Name|

---

## EntityImpl Togaf.Business.Event


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Type|Togaf.Business.EventType||||
|+|Trigger|Togaf.Service||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "187", Event = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "187", Event = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "187", Event = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.EventVectorSpace||||
|+|Principle|Togaf.Business.EventPrinciple||||
|+|Constraint|Togaf.Business.EventConstraint||||
|+|Assumption|Togaf.Business.EventAssumption||||
|+|Requirement|Togaf.Business.EventRequirement||||
|+|Location|Togaf.Business.EventLocation||||
|+|Gap|Togaf.Business.EventGap||||
|+|WorkPackage|Togaf.Business.EventWorkPackage||||
||Activities|Togaf.Business.Activity|||Event = this|
||SameName|Togaf.Business.Event|||Name = Name|

---

## EntityImpl Togaf.Business.Process


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Decomposes|Togaf.Business.Function||||
|+|Starts|Togaf.Business.Activity||||
|+|Operates|Togaf.Business.Capability||||
|+|Provides|Togaf.Business.Product||||
|+|Governed|Togaf.Business.Control||||
|+|Realizes|Togaf.Business.ValueStream||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "198", Process = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "198", Process = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "198", Process = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ProcessVectorSpace||||
|+|Principle|Togaf.Business.ProcessPrinciple||||
|+|Constraint|Togaf.Business.ProcessConstraint||||
|+|Assumption|Togaf.Business.ProcessAssumption||||
|+|Requirement|Togaf.Business.ProcessRequirement||||
|+|Location|Togaf.Business.ProcessLocation||||
|+|Gap|Togaf.Business.ProcessGap||||
|+|WorkPackage|Togaf.Business.ProcessWorkPackage||||
||Steps|Togaf.Business.Activity|||Part = this|
||SameName|Togaf.Business.Process|||Name = Name|

---

## EntityImpl Togaf.Application.System


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Realizes|Togaf.Service||||
|+|Platform|Togaf.Technology.Platform||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "537", System = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "537", System = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "537", System = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Application.SystemVectorSpace||||
|+|Principle|Togaf.Application.SystemPrinciple||||
|+|Constraint|Togaf.Application.SystemConstraint||||
|+|Assumption|Togaf.Application.SystemAssumption||||
|+|Requirement|Togaf.Application.SystemRequirement||||
|+|Location|Togaf.Application.SystemLocation||||
|+|Gap|Togaf.Application.SystemGap||||
|+|WorkPackage|Togaf.Application.SystemWorkPackage||||
||SystemUsage|Togaf.Data.Usage|||System = this|
||ImplementedBy|Togaf.Application.Component|||Implements = this|
||SameName|Togaf.Application.System|||Name = Name|

---

## EntityImpl Togaf.Technology.Platform


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Serves|Togaf.Service||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "617", Platform = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "617", Platform = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "617", Platform = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Technology.PlatformVectorSpace||||
|+|Principle|Togaf.Technology.PlatformPrinciple||||
|+|Constraint|Togaf.Technology.PlatformConstraint||||
|+|Assumption|Togaf.Technology.PlatformAssumption||||
|+|Requirement|Togaf.Technology.PlatformRequirement||||
|+|Location|Togaf.Technology.PlatformLocation||||
|+|Gap|Togaf.Technology.PlatformGap||||
|+|WorkPackage|Togaf.Technology.PlatformWorkPackage||||
||Hosts|Togaf.Application.System|||Platform = this|
||Defines|Togaf.Technology.Host|||Platform = this|
||SameName|Togaf.Technology.Platform|||Name = Name|

---

## EntityImpl Togaf.Technology.Host


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Platform|Togaf.Technology.Platform||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "629", Host = this, ContextLabel = contextlabel(this)|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "629", Host = this, ContextLabel = contextlabel(this)|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "629", Host = this, ContextLabel = contextlabel(this)|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Technology.HostVectorSpace||||
|+|Principle|Togaf.Technology.HostPrinciple||||
|+|Constraint|Togaf.Technology.HostConstraint||||
|+|Assumption|Togaf.Technology.HostAssumption||||
|+|Requirement|Togaf.Technology.HostRequirement||||
|+|Location|Togaf.Technology.HostLocation||||
|+|Gap|Togaf.Technology.HostGap||||
|+|WorkPackage|Togaf.Technology.HostWorkPackage||||
||Hosts|Togaf.Application.Component|||Host = this|
||Instances|Togaf.Technology.Instance|||Host = this|

---

## EntityImpl Togaf.Financial.Income_Cube


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|CubeSlice|String||||
|#|ContextLabel|String||||
|#|Host|Togaf.Technology.Host||CubeDimensionReference()||
|#|Event|Togaf.Business.Event||CubeDimensionReference()||
|#|System|Togaf.Application.System||CubeDimensionReference()||
|#|Service|Togaf.Service||CubeDimensionReference()||
|#|Process|Togaf.Business.Process||CubeDimensionReference()||
|#|Product|Togaf.Business.Product||CubeDimensionReference()||
|#|Platform|Togaf.Technology.Platform||CubeDimensionReference()||
|#|Function|Togaf.Business.Function||CubeDimensionReference()||
|#|Capability|Togaf.Business.Capability||CubeDimensionReference()||
|#|Organization|Togaf.Organization||CubeDimensionReference()||
|+|RevX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|CapX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|OpeX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|Hours|Int64||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|

---

## EntityImpl Togaf.Financial.Cost


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Organization|Togaf.Organization||||
|#|Function|Togaf.Business.Function||||
|#|Capability|Togaf.Business.Capability||||
|#|Product|Togaf.Business.Product||||
|#|Event|Togaf.Business.Event||||
|#|Process|Togaf.Business.Process||||
|#|Service|Togaf.Service||||
|#|System|Togaf.Application.System||||
|#|Platform|Togaf.Technology.Platform||||
|#|Host|Togaf.Technology.Host||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|RevX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|CapX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|OpeX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|Hours|Int64||CubeMeasure(Aggregate?.Sum)||
||Host_Dimension|Some(Togaf.Technology.Host)|||Host|
||Event_Dimension|Some(Togaf.Business.Event)|||Process?.Starts?.Event|
||System_Dimension|Some(Togaf.Application.System)|||System|
||Service_Dimension|Some(Togaf.Service)|||Host?.Platform?.Serves|
||Process_Dimension|Some(Togaf.Business.Process)|||Process|
||Product_Dimension|Some(Togaf.Business.Product)|||Process?.Provides|
||Platform_Dimension|Some(Togaf.Technology.Platform)|||Host?.Platform|
||Function_Dimension|Some(Togaf.Business.Function)|||Process?.Decomposes|
||Capability_Dimension|Some(Togaf.Business.Capability)|||Process?.Realizes?.Enables|
||Organization_Dimension|Some(Togaf.Organization)|||Host?.Platform?.Serves?.OwnedBy|

---

## EntityImpl Togaf.Financial.Income


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Organization|Togaf.Organization||||
|#|Function|Togaf.Business.Function||||
|#|Capability|Togaf.Business.Capability||||
|#|Product|Togaf.Business.Product||||
|#|Event|Togaf.Business.Event||||
|#|Process|Togaf.Business.Process||||
|#|Service|Togaf.Service||||
|#|System|Togaf.Application.System||||
|#|Platform|Togaf.Technology.Platform||||
|#|Host|Togaf.Technology.Host||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|RevX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|CapX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|OpeX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|Hours|Int64||CubeMeasure(Aggregate?.Sum)||
||Host_Dimension|Some(Togaf.Technology.Host)|||Host|
||Event_Dimension|Some(Togaf.Business.Event)|||Process?.Starts?.Event|
||System_Dimension|Some(Togaf.Application.System)|||System|
||Service_Dimension|Some(Togaf.Service)|||Host?.Platform?.Serves|
||Process_Dimension|Some(Togaf.Business.Process)|||Process|
||Product_Dimension|Some(Togaf.Business.Product)|||Process?.Provides|
||Platform_Dimension|Some(Togaf.Technology.Platform)|||Host?.Platform|
||Function_Dimension|Some(Togaf.Business.Function)|||Process?.Decomposes|
||Capability_Dimension|Some(Togaf.Business.Capability)|||Process?.Realizes?.Enables|
||Organization_Dimension|Some(Togaf.Organization)|||Host?.Platform?.Serves?.OwnedBy|

---

## EntityImpl Togaf.Financial.Income_Fact


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ContextLabel|String||||
|#|Host|Togaf.Technology.Host||CubeDimensionReference()||
|#|Event|Togaf.Business.Event||CubeDimensionReference()||
|#|System|Togaf.Application.System||CubeDimensionReference()||
|#|Service|Togaf.Service||CubeDimensionReference()||
|#|Process|Togaf.Business.Process||CubeDimensionReference()||
|#|Product|Togaf.Business.Product||CubeDimensionReference()||
|#|Platform|Togaf.Technology.Platform||CubeDimensionReference()||
|#|Function|Togaf.Business.Function||CubeDimensionReference()||
|#|Capability|Togaf.Business.Capability||CubeDimensionReference()||
|#|Organization|Togaf.Organization||CubeDimensionReference()||
|+|RevX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|CapX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|OpeX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|Hours|Int64||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|

---

## EntityImpl Togaf.Financial.Cost_Cube


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|CubeSlice|String||||
|#|ContextLabel|String||||
|#|Host|Togaf.Technology.Host||CubeDimensionReference()||
|#|Event|Togaf.Business.Event||CubeDimensionReference()||
|#|System|Togaf.Application.System||CubeDimensionReference()||
|#|Service|Togaf.Service||CubeDimensionReference()||
|#|Process|Togaf.Business.Process||CubeDimensionReference()||
|#|Product|Togaf.Business.Product||CubeDimensionReference()||
|#|Platform|Togaf.Technology.Platform||CubeDimensionReference()||
|#|Function|Togaf.Business.Function||CubeDimensionReference()||
|#|Capability|Togaf.Business.Capability||CubeDimensionReference()||
|#|Organization|Togaf.Organization||CubeDimensionReference()||
|+|RevX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|CapX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|OpeX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|Hours|Int64||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|

---

## EntityImpl Togaf.Financial.Cost_Fact


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ContextLabel|String||||
|#|Host|Togaf.Technology.Host||CubeDimensionReference()||
|#|Event|Togaf.Business.Event||CubeDimensionReference()||
|#|System|Togaf.Application.System||CubeDimensionReference()||
|#|Service|Togaf.Service||CubeDimensionReference()||
|#|Process|Togaf.Business.Process||CubeDimensionReference()||
|#|Product|Togaf.Business.Product||CubeDimensionReference()||
|#|Platform|Togaf.Technology.Platform||CubeDimensionReference()||
|#|Function|Togaf.Business.Function||CubeDimensionReference()||
|#|Capability|Togaf.Business.Capability||CubeDimensionReference()||
|#|Organization|Togaf.Organization||CubeDimensionReference()||
|+|RevX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|CapX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|OpeX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|Hours|Int64||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|

