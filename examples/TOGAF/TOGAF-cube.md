# TOGAF-cube
```mermaid
classDiagram
    class Togaf.Application.System {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Realizes  : Togaf.Service
        + Platform  : Togaf.Technology.Platform
        + Income_Cube (CubeSlice = """537""", System = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """537""", System = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """537""", System = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Application.SystemVectorSpace
        + Principle () : Togaf.Application.SystemPrinciple
        + Constraint () : Togaf.Application.SystemConstraint
        + Assumption () : Togaf.Application.SystemAssumption
        + Requirement () : Togaf.Application.SystemRequirement
        + Location () : Togaf.Application.SystemLocation
        + Gap () : Togaf.Application.SystemGap
        + WorkPackage () : Togaf.Application.SystemWorkPackage
        + SystemUsage (System = ) : Togaf.Data.Usage
        + ImplementedBy (Implements = ) : Togaf.Application.Component
        + SameName (Name = Name) : Togaf.Application.System
    }
    Togaf.Application.System --> Togaf.Service
    Togaf.Application.System --> Togaf.Technology.Platform
    class Togaf.Business.Capability {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + By  : Togaf.Organization
        + Parent  : Togaf.Business.Capability
        + Income_Cube (CubeSlice = """116""", Capability = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """116""", Capability = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """116""", Capability = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.CapabilityVectorSpace
        + Principle () : Togaf.Business.CapabilityPrinciple
        + Constraint () : Togaf.Business.CapabilityConstraint
        + Assumption () : Togaf.Business.CapabilityAssumption
        + Requirement () : Togaf.Business.CapabilityRequirement
        + Location () : Togaf.Business.CapabilityLocation
        + Gap () : Togaf.Business.CapabilityGap
        + WorkPackage () : Togaf.Business.CapabilityWorkPackage
        + Children (Parent = ) : Togaf.Business.Capability
        + Operated (Operates = ) : Togaf.Business.Process
        + Delivered (Delivers = ) : Togaf.Business.Function
        + EnabledBy (Enables = ) : Togaf.Business.ValueStream
        + Related (Enables = ) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Capability
    }
    Togaf.Business.Capability --> Togaf.Organization
    class Togaf.Business.Event {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Type  : Togaf.Business.EventType
        + Trigger  : Togaf.Service
        + Income_Cube (CubeSlice = """187""", Event = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """187""", Event = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """187""", Event = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.EventVectorSpace
        + Principle () : Togaf.Business.EventPrinciple
        + Constraint () : Togaf.Business.EventConstraint
        + Assumption () : Togaf.Business.EventAssumption
        + Requirement () : Togaf.Business.EventRequirement
        + Location () : Togaf.Business.EventLocation
        + Gap () : Togaf.Business.EventGap
        + WorkPackage () : Togaf.Business.EventWorkPackage
        + Activities (Event = ) : Togaf.Business.Activity
        + SameName (Name = Name) : Togaf.Business.Event
    }
    Togaf.Business.Event --> Togaf.Service
    class Togaf.Business.Function {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + For  : Togaf.Organization
        + Parent  : Togaf.Business.Function
        + Delivers  : Togaf.Business.Capability
        + Income_Cube (CubeSlice = """101""", Function = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """101""", Function = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """101""", Function = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.FunctionVectorSpace
        + Principle () : Togaf.Business.FunctionPrinciple
        + Constraint () : Togaf.Business.FunctionConstraint
        + Assumption () : Togaf.Business.FunctionAssumption
        + Requirement () : Togaf.Business.FunctionRequirement
        + Location () : Togaf.Business.FunctionLocation
        + Gap () : Togaf.Business.FunctionGap
        + WorkPackage () : Togaf.Business.FunctionWorkPackage
        + Children (Parent = ) : Togaf.Business.Function
        + Orchestrates (Decomposes = ) : Togaf.Business.Process
        + Involves (Involves = ) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Function
    }
    Togaf.Business.Function --> Togaf.Organization
    Togaf.Business.Function --> Togaf.Business.Capability
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
        + Income_Cube (CubeSlice = """198""", Process = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """198""", Process = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """198""", Process = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ProcessVectorSpace
        + Principle () : Togaf.Business.ProcessPrinciple
        + Constraint () : Togaf.Business.ProcessConstraint
        + Assumption () : Togaf.Business.ProcessAssumption
        + Requirement () : Togaf.Business.ProcessRequirement
        + Location () : Togaf.Business.ProcessLocation
        + Gap () : Togaf.Business.ProcessGap
        + WorkPackage () : Togaf.Business.ProcessWorkPackage
        + Steps (Part = ) : Togaf.Business.Activity
        + SameName (Name = Name) : Togaf.Business.Process
    }
    Togaf.Business.Process --> Togaf.Business.Function
    Togaf.Business.Process --> Togaf.Business.Capability
    Togaf.Business.Process --> Togaf.Business.Product
    class Togaf.Business.Product {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + By  : Togaf.Organization
        + Parent  : Togaf.Business.Product
        + Income_Cube (CubeSlice = """128""", Product = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """128""", Product = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """128""", Product = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ProductVectorSpace
        + Principle () : Togaf.Business.ProductPrinciple
        + Constraint () : Togaf.Business.ProductConstraint
        + Assumption () : Togaf.Business.ProductAssumption
        + Requirement () : Togaf.Business.ProductRequirement
        + Location () : Togaf.Business.ProductLocation
        + Gap () : Togaf.Business.ProductGap
        + WorkPackage () : Togaf.Business.ProductWorkPackage
        + Children (Parent = ) : Togaf.Business.Product
        + ProvidedBy (Provides = ) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.Product
    }
    Togaf.Business.Product --> Togaf.Organization
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
    Togaf.Complexity --> Togaf.Organization
    Togaf.Complexity --> Togaf.Business.Function
    Togaf.Complexity --> Togaf.Business.Capability
    Togaf.Complexity --> Togaf.Business.Product
    Togaf.Complexity --> Togaf.Business.Event
    Togaf.Complexity --> Togaf.Business.Process
    Togaf.Complexity --> Togaf.Service
    Togaf.Complexity --> Togaf.Application.System
    Togaf.Complexity --> Togaf.Technology.Platform
    Togaf.Complexity --> Togaf.Technology.Host
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
        + CubeDimensions () = cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + DrillDowns() () = drilldownEdges()
        + M () = ((E - N) + (2 * P))
    }
    Togaf.Complexity_Cube --> Togaf.Technology.Host
    Togaf.Complexity_Cube --> Togaf.Business.Event
    Togaf.Complexity_Cube --> Togaf.Application.System
    Togaf.Complexity_Cube --> Togaf.Service
    Togaf.Complexity_Cube --> Togaf.Business.Process
    Togaf.Complexity_Cube --> Togaf.Business.Product
    Togaf.Complexity_Cube --> Togaf.Technology.Platform
    Togaf.Complexity_Cube --> Togaf.Business.Function
    Togaf.Complexity_Cube --> Togaf.Business.Capability
    Togaf.Complexity_Cube --> Togaf.Organization
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
    Togaf.Financial.Cost --> Togaf.Organization
    Togaf.Financial.Cost --> Togaf.Business.Function
    Togaf.Financial.Cost --> Togaf.Business.Capability
    Togaf.Financial.Cost --> Togaf.Business.Product
    Togaf.Financial.Cost --> Togaf.Business.Event
    Togaf.Financial.Cost --> Togaf.Business.Process
    Togaf.Financial.Cost --> Togaf.Service
    Togaf.Financial.Cost --> Togaf.Application.System
    Togaf.Financial.Cost --> Togaf.Technology.Platform
    Togaf.Financial.Cost --> Togaf.Technology.Host
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
        + CubeDimensions () = cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + DrillDowns() () = drilldownEdges()
    }
    Togaf.Financial.Cost_Cube --> Togaf.Technology.Host
    Togaf.Financial.Cost_Cube --> Togaf.Business.Event
    Togaf.Financial.Cost_Cube --> Togaf.Application.System
    Togaf.Financial.Cost_Cube --> Togaf.Service
    Togaf.Financial.Cost_Cube --> Togaf.Business.Process
    Togaf.Financial.Cost_Cube --> Togaf.Business.Product
    Togaf.Financial.Cost_Cube --> Togaf.Technology.Platform
    Togaf.Financial.Cost_Cube --> Togaf.Business.Function
    Togaf.Financial.Cost_Cube --> Togaf.Business.Capability
    Togaf.Financial.Cost_Cube --> Togaf.Organization
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
    Togaf.Financial.Income --> Togaf.Organization
    Togaf.Financial.Income --> Togaf.Business.Function
    Togaf.Financial.Income --> Togaf.Business.Capability
    Togaf.Financial.Income --> Togaf.Business.Product
    Togaf.Financial.Income --> Togaf.Business.Event
    Togaf.Financial.Income --> Togaf.Business.Process
    Togaf.Financial.Income --> Togaf.Service
    Togaf.Financial.Income --> Togaf.Application.System
    Togaf.Financial.Income --> Togaf.Technology.Platform
    Togaf.Financial.Income --> Togaf.Technology.Host
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
        + CubeDimensions () = cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + DrillDowns() () = drilldownEdges()
    }
    Togaf.Financial.Income_Cube --> Togaf.Technology.Host
    Togaf.Financial.Income_Cube --> Togaf.Business.Event
    Togaf.Financial.Income_Cube --> Togaf.Application.System
    Togaf.Financial.Income_Cube --> Togaf.Service
    Togaf.Financial.Income_Cube --> Togaf.Business.Process
    Togaf.Financial.Income_Cube --> Togaf.Business.Product
    Togaf.Financial.Income_Cube --> Togaf.Technology.Platform
    Togaf.Financial.Income_Cube --> Togaf.Business.Function
    Togaf.Financial.Income_Cube --> Togaf.Business.Capability
    Togaf.Financial.Income_Cube --> Togaf.Organization
    class Togaf.Organization {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Parent  : Togaf.Organization
        + Income_Cube (CubeSlice = """20""", Organization = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """20""", Organization = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """20""", Organization = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + Children (Parent = ) : Togaf.Organization
        + Motivates (MotivatedBy = ) : Togaf.Business.Driver
        + Contains (In = ) : Togaf.Business.Actor
        + Functions (For = ) : Togaf.Business.Function
        + Uses (By = ) : Togaf.Business.Capability
        + Produces (By = ) : Togaf.Business.Product
        + Governs (OwnedBy = ) : Togaf.Service
        + SameName (Name = Name) : Togaf.Organization
    }
    class Togaf.Service {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + OwnedBy  : Togaf.Organization
        + Income_Cube (CubeSlice = """35""", Service = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """35""", Service = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """35""", Service = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.ServiceVectorSpace
        + Principle () : Togaf.ServicePrinciple
        + Constraint () : Togaf.ServiceConstraint
        + Assumption () : Togaf.ServiceAssumption
        + Requirement () : Togaf.ServiceRequirement
        + Location () : Togaf.ServiceLocation
        + Gap () : Togaf.ServiceGap
        + WorkPackage () : Togaf.ServiceWorkPackage
        + Measures (Tracks = ) : Togaf.Business.Measure
        + Triggers (Trigger = ) : Togaf.Business.Event
        + UsedBy (Uses = ) : Togaf.Business.Activity
        + Provides (Provider = ) : Togaf.Data.Entity
        + ProvidedBy (Realizes = ) : Togaf.Application.System
        + SameName (Name = Name) : Togaf.Service
    }
    Togaf.Service --> Togaf.Organization
    class Togaf.Technology.Host {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Platform  : Togaf.Technology.Platform
        + Income_Cube (CubeSlice = """629""", Host = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """629""", Host = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """629""", Host = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Technology.HostVectorSpace
        + Principle () : Togaf.Technology.HostPrinciple
        + Constraint () : Togaf.Technology.HostConstraint
        + Assumption () : Togaf.Technology.HostAssumption
        + Requirement () : Togaf.Technology.HostRequirement
        + Location () : Togaf.Technology.HostLocation
        + Gap () : Togaf.Technology.HostGap
        + WorkPackage () : Togaf.Technology.HostWorkPackage
        + Hosts (Host = ) : Togaf.Application.Component
        + Instances (Host = ) : Togaf.Technology.Instance
    }
    Togaf.Technology.Host --> Togaf.Technology.Platform
    class Togaf.Technology.Platform {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Serves  : Togaf.Service
        + Income_Cube (CubeSlice = """617""", Platform = this, ContextLabel = contextlabel()) : Togaf.Financial.Income_Cube
        + Cost_Cube (CubeSlice = """617""", Platform = this, ContextLabel = contextlabel()) : Togaf.Financial.Cost_Cube
        + Complexity_Cube (CubeSlice = """617""", Platform = this, ContextLabel = contextlabel()) : Togaf.Complexity_Cube
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Technology.PlatformVectorSpace
        + Principle () : Togaf.Technology.PlatformPrinciple
        + Constraint () : Togaf.Technology.PlatformConstraint
        + Assumption () : Togaf.Technology.PlatformAssumption
        + Requirement () : Togaf.Technology.PlatformRequirement
        + Location () : Togaf.Technology.PlatformLocation
        + Gap () : Togaf.Technology.PlatformGap
        + WorkPackage () : Togaf.Technology.PlatformWorkPackage
        + Hosts (Platform = ) : Togaf.Application.System
        + Defines (Platform = ) : Togaf.Technology.Host
        + SameName (Name = Name) : Togaf.Technology.Platform
    }
    Togaf.Technology.Platform --> Togaf.Service
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl Togaf.Application.System


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Realizes|Togaf.Service||||
|+|Platform|Togaf.Technology.Platform||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """537""", System = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """537""", System = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """537""", System = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Application.SystemVectorSpace||||
|+|Principle|Togaf.Application.SystemPrinciple||||
|+|Constraint|Togaf.Application.SystemConstraint||||
|+|Assumption|Togaf.Application.SystemAssumption||||
|+|Requirement|Togaf.Application.SystemRequirement||||
|+|Location|Togaf.Application.SystemLocation||||
|+|Gap|Togaf.Application.SystemGap||||
|+|WorkPackage|Togaf.Application.SystemWorkPackage||||
||SystemUsage|Togaf.Data.Usage|||System = |
||ImplementedBy|Togaf.Application.Component|||Implements = |
||SameName|Togaf.Application.System|||Name = Name|

---

## EntityImpl Togaf.Business.Capability


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|By|Togaf.Organization||||
|+|Parent|Togaf.Business.Capability||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """116""", Capability = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """116""", Capability = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """116""", Capability = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.CapabilityVectorSpace||||
|+|Principle|Togaf.Business.CapabilityPrinciple||||
|+|Constraint|Togaf.Business.CapabilityConstraint||||
|+|Assumption|Togaf.Business.CapabilityAssumption||||
|+|Requirement|Togaf.Business.CapabilityRequirement||||
|+|Location|Togaf.Business.CapabilityLocation||||
|+|Gap|Togaf.Business.CapabilityGap||||
|+|WorkPackage|Togaf.Business.CapabilityWorkPackage||||
||Children|Togaf.Business.Capability|||Parent = |
||Operated|Togaf.Business.Process|||Operates = |
||Delivered|Togaf.Business.Function|||Delivers = |
||EnabledBy|Togaf.Business.ValueStream|||Enables = |
||Related|Togaf.Business.CourseOfAction|||Enables = |
||SameName|Togaf.Business.Capability|||Name = Name|

---

## EntityImpl Togaf.Business.Event


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Type|Togaf.Business.EventType||||
|+|Trigger|Togaf.Service||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """187""", Event = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """187""", Event = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """187""", Event = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.EventVectorSpace||||
|+|Principle|Togaf.Business.EventPrinciple||||
|+|Constraint|Togaf.Business.EventConstraint||||
|+|Assumption|Togaf.Business.EventAssumption||||
|+|Requirement|Togaf.Business.EventRequirement||||
|+|Location|Togaf.Business.EventLocation||||
|+|Gap|Togaf.Business.EventGap||||
|+|WorkPackage|Togaf.Business.EventWorkPackage||||
||Activities|Togaf.Business.Activity|||Event = |
||SameName|Togaf.Business.Event|||Name = Name|

---

## EntityImpl Togaf.Business.Function


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|For|Togaf.Organization||AlternateIndex()||
|+|Parent|Togaf.Business.Function||||
|+|Delivers|Togaf.Business.Capability||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """101""", Function = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """101""", Function = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """101""", Function = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.FunctionVectorSpace||||
|+|Principle|Togaf.Business.FunctionPrinciple||||
|+|Constraint|Togaf.Business.FunctionConstraint||||
|+|Assumption|Togaf.Business.FunctionAssumption||||
|+|Requirement|Togaf.Business.FunctionRequirement||||
|+|Location|Togaf.Business.FunctionLocation||||
|+|Gap|Togaf.Business.FunctionGap||||
|+|WorkPackage|Togaf.Business.FunctionWorkPackage||||
||Children|Togaf.Business.Function|||Parent = |
||Orchestrates|Togaf.Business.Process|||Decomposes = |
||Involves|Togaf.Business.CourseOfAction|||Involves = |
||SameName|Togaf.Business.Function|||Name = Name|

---

## EntityImpl Togaf.Business.Process


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Decomposes|Togaf.Business.Function||||
|+|Starts|Togaf.Business.Activity||||
|+|Operates|Togaf.Business.Capability||||
|+|Provides|Togaf.Business.Product||||
|+|Governed|Togaf.Business.Control||||
|+|Realizes|Togaf.Business.ValueStream||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """198""", Process = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """198""", Process = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """198""", Process = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ProcessVectorSpace||||
|+|Principle|Togaf.Business.ProcessPrinciple||||
|+|Constraint|Togaf.Business.ProcessConstraint||||
|+|Assumption|Togaf.Business.ProcessAssumption||||
|+|Requirement|Togaf.Business.ProcessRequirement||||
|+|Location|Togaf.Business.ProcessLocation||||
|+|Gap|Togaf.Business.ProcessGap||||
|+|WorkPackage|Togaf.Business.ProcessWorkPackage||||
||Steps|Togaf.Business.Activity|||Part = |
||SameName|Togaf.Business.Process|||Name = Name|

---

## EntityImpl Togaf.Business.Product


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|By|Togaf.Organization||||
|+|Parent|Togaf.Business.Product||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """128""", Product = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """128""", Product = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """128""", Product = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ProductVectorSpace||||
|+|Principle|Togaf.Business.ProductPrinciple||||
|+|Constraint|Togaf.Business.ProductConstraint||||
|+|Assumption|Togaf.Business.ProductAssumption||||
|+|Requirement|Togaf.Business.ProductRequirement||||
|+|Location|Togaf.Business.ProductLocation||||
|+|Gap|Togaf.Business.ProductGap||||
|+|WorkPackage|Togaf.Business.ProductWorkPackage||||
||Children|Togaf.Business.Product|||Parent = |
||ProvidedBy|Togaf.Business.Process|||Provides = |
||SameName|Togaf.Business.Product|||Name = Name|

---

## EntityImpl Togaf.Complexity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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
|+|Facts|Int64|Number of Facts this Cube/Fact is calculated from|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||CubeDimensions|Some(Int32)|||cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||DrillDowns()|Some(global::System.Collections.Generic.HashSet<Hiperspace.Edge>)|Drilldown to Edges||drilldownEdges()|
||M|Some(Decimal)||CubeExtent()|((E - N) + (2 * P))|

---

## EntityImpl Togaf.Financial.Cost


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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

## EntityImpl Togaf.Financial.Cost_Cube


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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
|+|Facts|Int64|Number of Facts this Cube/Fact is calculated from|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||CubeDimensions|Some(Int32)|||cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||DrillDowns()|Some(global::System.Collections.Generic.HashSet<Hiperspace.Edge>)|Drilldown to Edges||drilldownEdges()|

---

## EntityImpl Togaf.Financial.Income


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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

## EntityImpl Togaf.Financial.Income_Cube


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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
|+|Facts|Int64|Number of Facts this Cube/Fact is calculated from|||
||CubeName|Some(String)|||cubename(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||CubeDimensions|Some(Int32)|||cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)|
||DrillDowns()|Some(global::System.Collections.Generic.HashSet<Hiperspace.Edge>)|Drilldown to Edges||drilldownEdges()|

---

## EntityImpl Togaf.Organization


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Parent|Togaf.Organization||AlternateIndex()||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """20""", Organization = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """20""", Organization = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """20""", Organization = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||Children|Togaf.Organization|||Parent = |
||Motivates|Togaf.Business.Driver|||MotivatedBy = |
||Contains|Togaf.Business.Actor|||In = |
||Functions|Togaf.Business.Function|||For = |
||Uses|Togaf.Business.Capability|||By = |
||Produces|Togaf.Business.Product|||By = |
||Governs|Togaf.Service|||OwnedBy = |
||SameName|Togaf.Organization|||Name = Name|

---

## EntityImpl Togaf.Service


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|OwnedBy|Togaf.Organization||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """35""", Service = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """35""", Service = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """35""", Service = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.ServiceVectorSpace||||
|+|Principle|Togaf.ServicePrinciple||||
|+|Constraint|Togaf.ServiceConstraint||||
|+|Assumption|Togaf.ServiceAssumption||||
|+|Requirement|Togaf.ServiceRequirement||||
|+|Location|Togaf.ServiceLocation||||
|+|Gap|Togaf.ServiceGap||||
|+|WorkPackage|Togaf.ServiceWorkPackage||||
||Measures|Togaf.Business.Measure|||Tracks = |
||Triggers|Togaf.Business.Event|||Trigger = |
||UsedBy|Togaf.Business.Activity|||Uses = |
||Provides|Togaf.Data.Entity|||Provider = |
||ProvidedBy|Togaf.Application.System|||Realizes = |
||SameName|Togaf.Service|||Name = Name|

---

## EntityImpl Togaf.Technology.Host


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Platform|Togaf.Technology.Platform||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """629""", Host = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """629""", Host = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """629""", Host = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Technology.HostVectorSpace||||
|+|Principle|Togaf.Technology.HostPrinciple||||
|+|Constraint|Togaf.Technology.HostConstraint||||
|+|Assumption|Togaf.Technology.HostAssumption||||
|+|Requirement|Togaf.Technology.HostRequirement||||
|+|Location|Togaf.Technology.HostLocation||||
|+|Gap|Togaf.Technology.HostGap||||
|+|WorkPackage|Togaf.Technology.HostWorkPackage||||
||Hosts|Togaf.Application.Component|||Host = |
||Instances|Togaf.Technology.Instance|||Host = |

---

## EntityImpl Togaf.Technology.Platform


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Serves|Togaf.Service||||
||Income_Cube|Togaf.Financial.Income_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """617""", Platform = this, ContextLabel = contextlabel()|
||Cost_Cube|Togaf.Financial.Cost_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """617""", Platform = this, ContextLabel = contextlabel()|
||Complexity_Cube|Togaf.Complexity_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = """617""", Platform = this, ContextLabel = contextlabel()|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Technology.PlatformVectorSpace||||
|+|Principle|Togaf.Technology.PlatformPrinciple||||
|+|Constraint|Togaf.Technology.PlatformConstraint||||
|+|Assumption|Togaf.Technology.PlatformAssumption||||
|+|Requirement|Togaf.Technology.PlatformRequirement||||
|+|Location|Togaf.Technology.PlatformLocation||||
|+|Gap|Togaf.Technology.PlatformGap||||
|+|WorkPackage|Togaf.Technology.PlatformWorkPackage||||
||Hosts|Togaf.Application.System|||Platform = |
||Defines|Togaf.Technology.Host|||Platform = |
||SameName|Togaf.Technology.Platform|||Name = Name|

