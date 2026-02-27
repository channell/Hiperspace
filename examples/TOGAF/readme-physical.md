# readme
```mermaid
classDiagram
    class Hiperspace.VectorSpace {
        # owner  : Any
        + Vector  : Hiperspace.Vector
    }
    Hiperspace.VectorSpace *-- Hiperspace.Vector
    class Graph.Route {
        # Name  : String
        + Rules  : HashSet~Graph.Rule~
    }
    Graph.Route *-- Graph.Rule
    class Graph.Rule {
        # FromType  : String
        # ToType  : String
        # EdgeType  : String
    }
    class Togaf.PathMessage {
        # Node  : Node
        # Route  : Graph.Route
        # Length  : Int32
        # Targets  : HashSet~String~
        + Edges  : HashSet~Graph.HiperEdge~
    }
    Togaf.PathMessage *-- Graph.Route
    Togaf.PathMessage *-- String
    Togaf.PathMessage *-- Graph.HiperEdge
    class Togaf.Edge_ {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
    }
    class Togaf.Edges {
        # From  : Node
        # To  : Node
        # FromTypeName  : String
        # ToTypeName  : String
        + Name  : String
    }
    Togaf.Edges ..|> Togaf.Edge_
    class Togaf.Edges2 {
        # From  : Node
        # To  : Node
        # FromTypeName  : String
        # ToTypeName  : String
        + Name  : String
    }
    Togaf.Edges2 ..|> Togaf.Edge_
    Togaf.Edges2 ..|> Togaf.Edges
    class Togaf.Edges3 {
        # From  : Node
        # To  : Node
        # FromTypeName  : String
        # ToTypeName  : String
        + Name  : String
    }
    Togaf.Edges3 ..|> Togaf.Edge_
    Togaf.Edges3 ..|> Togaf.Edges
    class Togaf.Edges4 {
        # From  : Node
        # To  : Node
        # FromTypeName  : String
        # ToTypeName  : String
        + Name  : String
    }
    Togaf.Edges4 ..|> Togaf.Edge_
    Togaf.Edges4 ..|> Togaf.Edges
    class Togaf.Edges5 {
        # From  : Node
        # To  : Node
        # FromTypeName  : String
        # ToTypeName  : String
        + Name  : String
    }
    Togaf.Edges5 ..|> Togaf.Edge_
    Togaf.Edges5 ..|> Togaf.Edges
    class Togaf.GoalRef {
        + Value  : Togaf.Business.Goal
    }
    Togaf.GoalRef --> Togaf.Business.Goal
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
    Togaf.Organization ..|> Togaf.Edges
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
    Togaf.Service --> Togaf.Organization
    Togaf.Service o-- Togaf.ServiceVectorSpace
    Togaf.Service o-- Togaf.ServicePrinciple
    Togaf.Service o-- Togaf.ServiceConstraint
    Togaf.Service o-- Togaf.ServiceAssumption
    Togaf.Service o-- Togaf.ServiceRequirement
    Togaf.Service o-- Togaf.ServiceLocation
    Togaf.Service o-- Togaf.ServiceGap
    Togaf.Service o-- Togaf.ServiceWorkPackage
    Togaf.Service ..|> Togaf.Edges
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
    class Togaf.ServiceWorkPackage {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.ServiceWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.ServiceWorkPackage ..|> Togaf.Edge_
    class Togaf.ServiceGap {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.ServiceGap ..|> Togaf.Has.Gap
    Togaf.ServiceGap ..|> Togaf.Edges
    class Togaf.ServiceLocation {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.ServiceLocation ..|> Togaf.Has.Location
    Togaf.ServiceLocation ..|> Togaf.Edges
    class Togaf.ServiceRequirement {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.ServiceRequirement ..|> Togaf.Has.Requirement
    Togaf.ServiceRequirement ..|> Togaf.Edges
    class Togaf.ServiceAssumption {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.ServiceAssumption ..|> Togaf.Has.Assumption
    Togaf.ServiceAssumption ..|> Togaf.Edges
    class Togaf.ServiceConstraint {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.ServiceConstraint ..|> Togaf.Has.Constraint
    Togaf.ServiceConstraint ..|> Togaf.Edges
    class Togaf.ServicePrinciple {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.ServicePrinciple ..|> Togaf.Has.Principle
    Togaf.ServicePrinciple ..|> Togaf.Edges
    class Togaf.ServiceVectorSpace {
        # owner  : Togaf.Service
        + Vector  : Hiperspace.Vector
    }
    Togaf.ServiceVectorSpace *-- Hiperspace.Vector
    Togaf.ServiceVectorSpace ..|> Hiperspace.VectorSpace
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
    Togaf.Complexity_Fact --> Togaf.Technology.Host
    Togaf.Complexity_Fact --> Togaf.Business.Event
    Togaf.Complexity_Fact --> Togaf.Application.System
    Togaf.Complexity_Fact --> Togaf.Service
    Togaf.Complexity_Fact --> Togaf.Business.Process
    Togaf.Complexity_Fact --> Togaf.Business.Product
    Togaf.Complexity_Fact --> Togaf.Technology.Platform
    Togaf.Complexity_Fact --> Togaf.Business.Function
    Togaf.Complexity_Fact --> Togaf.Business.Capability
    Togaf.Complexity_Fact --> Togaf.Organization
    class Togaf.Has.Principle {
        # owner  : Any
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  : Boolean
        + ValidBase  : Boolean
    }
    class Togaf.Has.Constraint {
        # owner  : Any
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  : Boolean
        + ValidBase  : Boolean
    }
    class Togaf.Has.Assumption {
        # owner  : Any
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  : Boolean
        + ValidBase  : Boolean
    }
    class Togaf.Has.Requirement {
        # owner  : Any
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  : Boolean
        + ValidBase  : Boolean
    }
    class Togaf.Has.Location {
        # owner  : Any
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  : Boolean
        + ValidBase  : Boolean
    }
    class Togaf.Has.Gap {
        # owner  : Any
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  : Boolean
        + ValidBase  : Boolean
    }
    class Togaf.Has.WorkPackage {
        # owner  : Any
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  : Boolean
        + ValidBase  : Boolean
        + StrategicEdges  : HashSet~Graph.HiperEdge~
        + Goals  : HashSet~Togaf.GoalRef~
    }
    Togaf.Has.WorkPackage *-- Graph.HiperEdge
    Togaf.Has.WorkPackage *-- Togaf.GoalRef
    class Togaf.Has.Activity {
        # owner  : Togaf.Business.Actor
        # A  : Togaf.Business.Activity
        + Comment  : String
    }
    Togaf.Has.Activity --> Togaf.Business.Activity
    Togaf.Has.Activity ..|> Togaf.Edges
    class Togaf.Business.Driver {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + MotivatedBy  : Togaf.Organization
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.DriverVectorSpace
        + Principle () : Togaf.Business.DriverPrinciple
        + Constraint () : Togaf.Business.DriverConstraint
        + Assumption () : Togaf.Business.DriverAssumption
        + Requirement () : Togaf.Business.DriverRequirement
        + Location () : Togaf.Business.DriverLocation
        + Gap () : Togaf.Business.DriverGap
        + WorkPackage () : Togaf.Business.DriverWorkPackage
        + Creates (By = this) : Togaf.Business.Goal
        + SameName (Name = Name) : Togaf.Business.Driver
    }
    Togaf.Business.Driver --> Togaf.Organization
    Togaf.Business.Driver o-- Togaf.Business.DriverVectorSpace
    Togaf.Business.Driver o-- Togaf.Business.DriverPrinciple
    Togaf.Business.Driver o-- Togaf.Business.DriverConstraint
    Togaf.Business.Driver o-- Togaf.Business.DriverAssumption
    Togaf.Business.Driver o-- Togaf.Business.DriverRequirement
    Togaf.Business.Driver o-- Togaf.Business.DriverLocation
    Togaf.Business.Driver o-- Togaf.Business.DriverGap
    Togaf.Business.Driver o-- Togaf.Business.DriverWorkPackage
    Togaf.Business.Driver ..|> Togaf.Edges
    class Togaf.Business.Actor {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + In  : Togaf.Organization
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ActorVectorSpace
        + Principle () : Togaf.Business.ActorPrinciple
        + Constraint () : Togaf.Business.ActorConstraint
        + Assumption () : Togaf.Business.ActorAssumption
        + Requirement () : Togaf.Business.ActorRequirement
        + Location () : Togaf.Business.ActorLocation
        + Gap () : Togaf.Business.ActorGap
        + WorkPackage () : Togaf.Business.ActorWorkPackage
        + Performs () : Togaf.Has.Activity
        + Involved (Involves = this) : Togaf.Business.ValueStream
        + SameName (Name = Name) : Togaf.Business.Actor
    }
    Togaf.Business.Actor --> Togaf.Organization
    Togaf.Business.Actor o-- Togaf.Business.ActorVectorSpace
    Togaf.Business.Actor o-- Togaf.Business.ActorPrinciple
    Togaf.Business.Actor o-- Togaf.Business.ActorConstraint
    Togaf.Business.Actor o-- Togaf.Business.ActorAssumption
    Togaf.Business.Actor o-- Togaf.Business.ActorRequirement
    Togaf.Business.Actor o-- Togaf.Business.ActorLocation
    Togaf.Business.Actor o-- Togaf.Business.ActorGap
    Togaf.Business.Actor o-- Togaf.Business.ActorWorkPackage
    Togaf.Business.Actor o-- Togaf.Has.Activity
    Togaf.Business.Actor ..|> Togaf.Edges
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
    Togaf.Business.Function --> Togaf.Organization
    Togaf.Business.Function --> Togaf.Business.Capability
    Togaf.Business.Function o-- Togaf.Business.FunctionVectorSpace
    Togaf.Business.Function o-- Togaf.Business.FunctionPrinciple
    Togaf.Business.Function o-- Togaf.Business.FunctionConstraint
    Togaf.Business.Function o-- Togaf.Business.FunctionAssumption
    Togaf.Business.Function o-- Togaf.Business.FunctionRequirement
    Togaf.Business.Function o-- Togaf.Business.FunctionLocation
    Togaf.Business.Function o-- Togaf.Business.FunctionGap
    Togaf.Business.Function o-- Togaf.Business.FunctionWorkPackage
    Togaf.Business.Function ..|> Togaf.Edges
    Togaf.Business.Function ..|> Togaf.Edges2
    Togaf.Business.Function ..|> Togaf.Edges3
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
    Togaf.Business.Capability --> Togaf.Organization
    Togaf.Business.Capability o-- Togaf.Business.CapabilityVectorSpace
    Togaf.Business.Capability o-- Togaf.Business.CapabilityPrinciple
    Togaf.Business.Capability o-- Togaf.Business.CapabilityConstraint
    Togaf.Business.Capability o-- Togaf.Business.CapabilityAssumption
    Togaf.Business.Capability o-- Togaf.Business.CapabilityRequirement
    Togaf.Business.Capability o-- Togaf.Business.CapabilityLocation
    Togaf.Business.Capability o-- Togaf.Business.CapabilityGap
    Togaf.Business.Capability o-- Togaf.Business.CapabilityWorkPackage
    Togaf.Business.Capability ..|> Togaf.Edges
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
    Togaf.Business.Product --> Togaf.Organization
    Togaf.Business.Product o-- Togaf.Business.ProductVectorSpace
    Togaf.Business.Product o-- Togaf.Business.ProductPrinciple
    Togaf.Business.Product o-- Togaf.Business.ProductConstraint
    Togaf.Business.Product o-- Togaf.Business.ProductAssumption
    Togaf.Business.Product o-- Togaf.Business.ProductRequirement
    Togaf.Business.Product o-- Togaf.Business.ProductLocation
    Togaf.Business.Product o-- Togaf.Business.ProductGap
    Togaf.Business.Product o-- Togaf.Business.ProductWorkPackage
    Togaf.Business.Product ..|> Togaf.Edges
    Togaf.Business.Product ..|> Togaf.Edges2
    class Togaf.Business.Goal {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + By  : Togaf.Business.Driver
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.GoalVectorSpace
        + Principle () : Togaf.Business.GoalPrinciple
        + Constraint () : Togaf.Business.GoalConstraint
        + Assumption () : Togaf.Business.GoalAssumption
        + Requirement () : Togaf.Business.GoalRequirement
        + Location () : Togaf.Business.GoalLocation
        + Gap () : Togaf.Business.GoalGap
        + WorkPackage () : Togaf.Business.GoalWorkPackage
        + RealizedBy (For = this) : Togaf.Business.Objective
        + Follows (Leads = this) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Goal
    }
    Togaf.Business.Goal --> Togaf.Business.Driver
    Togaf.Business.Goal o-- Togaf.Business.GoalVectorSpace
    Togaf.Business.Goal o-- Togaf.Business.GoalPrinciple
    Togaf.Business.Goal o-- Togaf.Business.GoalConstraint
    Togaf.Business.Goal o-- Togaf.Business.GoalAssumption
    Togaf.Business.Goal o-- Togaf.Business.GoalRequirement
    Togaf.Business.Goal o-- Togaf.Business.GoalLocation
    Togaf.Business.Goal o-- Togaf.Business.GoalGap
    Togaf.Business.Goal o-- Togaf.Business.GoalWorkPackage
    Togaf.Business.Goal ..|> Togaf.Edges
    class Togaf.Business.Objective {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + For  : Togaf.Business.Goal
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ObjectiveVectorSpace
        + Principle () : Togaf.Business.ObjectivePrinciple
        + Constraint () : Togaf.Business.ObjectiveConstraint
        + Assumption () : Togaf.Business.ObjectiveAssumption
        + Requirement () : Togaf.Business.ObjectiveRequirement
        + Location () : Togaf.Business.ObjectiveLocation
        + Gap () : Togaf.Business.ObjectiveGap
        + WorkPackage () : Togaf.Business.ObjectiveWorkPackage
        + Measured (For = this) : Togaf.Business.Measure
        + SameName (Name = Name) : Togaf.Business.Objective
    }
    Togaf.Business.Objective --> Togaf.Business.Goal
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveVectorSpace
    Togaf.Business.Objective o-- Togaf.Business.ObjectivePrinciple
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveConstraint
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveAssumption
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveRequirement
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveLocation
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveGap
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveWorkPackage
    Togaf.Business.Objective ..|> Togaf.Edges
    class Togaf.Business.Measure {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + For  : Togaf.Business.Objective
        + Unit  : String
        + Tracks  : Togaf.Service
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.MeasureVectorSpace
        + Principle () : Togaf.Business.MeasurePrinciple
        + Constraint () : Togaf.Business.MeasureConstraint
        + Assumption () : Togaf.Business.MeasureAssumption
        + Requirement () : Togaf.Business.MeasureRequirement
        + Location () : Togaf.Business.MeasureLocation
        + Gap () : Togaf.Business.MeasureGap
        + WorkPackage () : Togaf.Business.MeasureWorkPackage
        + Observation () : Togaf.History.Measure
        + SameName (Name = Name) : Togaf.Business.Measure
    }
    Togaf.Business.Measure --> Togaf.Business.Objective
    Togaf.Business.Measure --> Togaf.Service
    Togaf.Business.Measure o-- Togaf.Business.MeasureVectorSpace
    Togaf.Business.Measure o-- Togaf.Business.MeasurePrinciple
    Togaf.Business.Measure o-- Togaf.Business.MeasureConstraint
    Togaf.Business.Measure o-- Togaf.Business.MeasureAssumption
    Togaf.Business.Measure o-- Togaf.Business.MeasureRequirement
    Togaf.Business.Measure o-- Togaf.Business.MeasureLocation
    Togaf.Business.Measure o-- Togaf.Business.MeasureGap
    Togaf.Business.Measure o-- Togaf.Business.MeasureWorkPackage
    Togaf.Business.Measure o-- Togaf.History.Measure
    Togaf.Business.Measure ..|> Togaf.Edges
    Togaf.Business.Measure ..|> Togaf.Edges2
    class Togaf.Business.ActivityType {
        Task = 1
        Decision = 2
        Event = 3
    }
    class Togaf.Business.Activity {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + By  : Togaf.Business.Actor
        + Type  : Togaf.Business.ActivityType
        + After  : Togaf.Business.Activity
        + Part  : Togaf.Business.Process
        + Event  : Togaf.Business.Event
        + Uses  : Togaf.Service
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ActivityVectorSpace
        + Principle () : Togaf.Business.ActivityPrinciple
        + Constraint () : Togaf.Business.ActivityConstraint
        + Assumption () : Togaf.Business.ActivityAssumption
        + Requirement () : Togaf.Business.ActivityRequirement
        + Location () : Togaf.Business.ActivityLocation
        + Gap () : Togaf.Business.ActivityGap
        + WorkPackage () : Togaf.Business.ActivityWorkPackage
        + Before (After = this) : Togaf.Business.Activity
        + Originates (Originator = this) : Togaf.Data.Entity
        + SameName (Name = Name) : Togaf.Business.Activity
    }
    Togaf.Business.Activity --> Togaf.Business.Actor
    Togaf.Business.Activity --> Togaf.Business.ActivityType
    Togaf.Business.Activity --> Togaf.Business.Process
    Togaf.Business.Activity --> Togaf.Business.Event
    Togaf.Business.Activity --> Togaf.Service
    Togaf.Business.Activity o-- Togaf.Business.ActivityVectorSpace
    Togaf.Business.Activity o-- Togaf.Business.ActivityPrinciple
    Togaf.Business.Activity o-- Togaf.Business.ActivityConstraint
    Togaf.Business.Activity o-- Togaf.Business.ActivityAssumption
    Togaf.Business.Activity o-- Togaf.Business.ActivityRequirement
    Togaf.Business.Activity o-- Togaf.Business.ActivityLocation
    Togaf.Business.Activity o-- Togaf.Business.ActivityGap
    Togaf.Business.Activity o-- Togaf.Business.ActivityWorkPackage
    Togaf.Business.Activity ..|> Togaf.Edges
    Togaf.Business.Activity ..|> Togaf.Edges2
    Togaf.Business.Activity ..|> Togaf.Edges3
    Togaf.Business.Activity ..|> Togaf.Edges4
    Togaf.Business.Activity ..|> Togaf.Edges5
    class Togaf.Business.EventType {
        Start = 1
        End = 2
        Intermediate = 3
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
    Togaf.Business.Event --> Togaf.Business.EventType
    Togaf.Business.Event --> Togaf.Service
    Togaf.Business.Event o-- Togaf.Business.EventVectorSpace
    Togaf.Business.Event o-- Togaf.Business.EventPrinciple
    Togaf.Business.Event o-- Togaf.Business.EventConstraint
    Togaf.Business.Event o-- Togaf.Business.EventAssumption
    Togaf.Business.Event o-- Togaf.Business.EventRequirement
    Togaf.Business.Event o-- Togaf.Business.EventLocation
    Togaf.Business.Event o-- Togaf.Business.EventGap
    Togaf.Business.Event o-- Togaf.Business.EventWorkPackage
    Togaf.Business.Event ..|> Togaf.Edges
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
    Togaf.Business.Process --> Togaf.Business.Function
    Togaf.Business.Process --> Togaf.Business.Activity
    Togaf.Business.Process --> Togaf.Business.Capability
    Togaf.Business.Process --> Togaf.Business.Product
    Togaf.Business.Process --> Togaf.Business.Control
    Togaf.Business.Process --> Togaf.Business.ValueStream
    Togaf.Business.Process o-- Togaf.Business.ProcessVectorSpace
    Togaf.Business.Process o-- Togaf.Business.ProcessPrinciple
    Togaf.Business.Process o-- Togaf.Business.ProcessConstraint
    Togaf.Business.Process o-- Togaf.Business.ProcessAssumption
    Togaf.Business.Process o-- Togaf.Business.ProcessRequirement
    Togaf.Business.Process o-- Togaf.Business.ProcessLocation
    Togaf.Business.Process o-- Togaf.Business.ProcessGap
    Togaf.Business.Process o-- Togaf.Business.ProcessWorkPackage
    Togaf.Business.Process ..|> Togaf.Edges
    Togaf.Business.Process ..|> Togaf.Edges2
    Togaf.Business.Process ..|> Togaf.Edges3
    Togaf.Business.Process ..|> Togaf.Edges4
    Togaf.Business.Process ..|> Togaf.Edges5
    class Togaf.Business.Control {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + URL  : String
        + PartOf  : Togaf.Business.Control
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ControlVectorSpace
        + Principle () : Togaf.Business.ControlPrinciple
        + Constraint () : Togaf.Business.ControlConstraint
        + Assumption () : Togaf.Business.ControlAssumption
        + Requirement () : Togaf.Business.ControlRequirement
        + Location () : Togaf.Business.ControlLocation
        + Gap () : Togaf.Business.ControlGap
        + WorkPackage () : Togaf.Business.ControlWorkPackage
        + Includes (PartOf = this) : Togaf.Business.Control
        + Governs (Governed = this) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.Control
    }
    Togaf.Business.Control o-- Togaf.Business.ControlVectorSpace
    Togaf.Business.Control o-- Togaf.Business.ControlPrinciple
    Togaf.Business.Control o-- Togaf.Business.ControlConstraint
    Togaf.Business.Control o-- Togaf.Business.ControlAssumption
    Togaf.Business.Control o-- Togaf.Business.ControlRequirement
    Togaf.Business.Control o-- Togaf.Business.ControlLocation
    Togaf.Business.Control o-- Togaf.Business.ControlGap
    Togaf.Business.Control o-- Togaf.Business.ControlWorkPackage
    Togaf.Business.Control ..|> Togaf.Edges
    class Togaf.Business.ValueStream {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + URL  : String
        + Parent  : Togaf.Business.ValueStream
        + Enables  : Togaf.Business.Capability
        + Involves  : Togaf.Business.Actor
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.ValueStreamVectorSpace
        + Principle () : Togaf.Business.ValueStreamPrinciple
        + Constraint () : Togaf.Business.ValueStreamConstraint
        + Assumption () : Togaf.Business.ValueStreamAssumption
        + Requirement () : Togaf.Business.ValueStreamRequirement
        + Location () : Togaf.Business.ValueStreamLocation
        + Gap () : Togaf.Business.ValueStreamGap
        + WorkPackage () : Togaf.Business.ValueStreamWorkPackage
        + Children (Parent = this) : Togaf.Business.ValueStream
        + RealizedBy (Realizes = this) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.ValueStream
    }
    Togaf.Business.ValueStream --> Togaf.Business.Capability
    Togaf.Business.ValueStream --> Togaf.Business.Actor
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamVectorSpace
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamPrinciple
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamConstraint
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamAssumption
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamRequirement
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamLocation
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamGap
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamWorkPackage
    Togaf.Business.ValueStream ..|> Togaf.Edges
    Togaf.Business.ValueStream ..|> Togaf.Edges2
    Togaf.Business.ValueStream ..|> Togaf.Edges3
    class Togaf.Business.CourseOfAction {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + URL  : String
        + Enables  : Togaf.Business.Capability
        + Leads  : Togaf.Business.Goal
        + Involves  : Togaf.Business.Function
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Business.CourseOfActionVectorSpace
        + Principle () : Togaf.Business.CourseOfActionPrinciple
        + Constraint () : Togaf.Business.CourseOfActionConstraint
        + Assumption () : Togaf.Business.CourseOfActionAssumption
        + Requirement () : Togaf.Business.CourseOfActionRequirement
        + Location () : Togaf.Business.CourseOfActionLocation
        + Gap () : Togaf.Business.CourseOfActionGap
        + WorkPackage () : Togaf.Business.CourseOfActionWorkPackage
        + SameName (Name = Name) : Togaf.Business.CourseOfAction
    }
    Togaf.Business.CourseOfAction --> Togaf.Business.Capability
    Togaf.Business.CourseOfAction --> Togaf.Business.Goal
    Togaf.Business.CourseOfAction --> Togaf.Business.Function
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionVectorSpace
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionPrinciple
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionConstraint
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionAssumption
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionRequirement
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionLocation
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionGap
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionWorkPackage
    Togaf.Business.CourseOfAction ..|> Togaf.Edges
    Togaf.Business.CourseOfAction ..|> Togaf.Edges2
    Togaf.Business.CourseOfAction ..|> Togaf.Edges3
    class Togaf.Business.CourseOfActionWorkPackage {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.CourseOfActionWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.CourseOfActionWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.CourseOfActionGap {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CourseOfActionGap ..|> Togaf.Has.Gap
    Togaf.Business.CourseOfActionGap ..|> Togaf.Edges
    class Togaf.Business.CourseOfActionLocation {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CourseOfActionLocation ..|> Togaf.Has.Location
    Togaf.Business.CourseOfActionLocation ..|> Togaf.Edges
    class Togaf.Business.CourseOfActionRequirement {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CourseOfActionRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.CourseOfActionRequirement ..|> Togaf.Edges
    class Togaf.Business.CourseOfActionAssumption {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CourseOfActionAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.CourseOfActionAssumption ..|> Togaf.Edges
    class Togaf.Business.CourseOfActionConstraint {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CourseOfActionConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.CourseOfActionConstraint ..|> Togaf.Edges
    class Togaf.Business.CourseOfActionPrinciple {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CourseOfActionPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.CourseOfActionPrinciple ..|> Togaf.Edges
    class Togaf.Business.CourseOfActionVectorSpace {
        # owner  : Togaf.Business.CourseOfAction
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.CourseOfActionVectorSpace *-- Hiperspace.Vector
    Togaf.Business.CourseOfActionVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.ValueStreamWorkPackage {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.ValueStreamWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.ValueStreamWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.ValueStreamGap {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ValueStreamGap ..|> Togaf.Has.Gap
    Togaf.Business.ValueStreamGap ..|> Togaf.Edges
    class Togaf.Business.ValueStreamLocation {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ValueStreamLocation ..|> Togaf.Has.Location
    Togaf.Business.ValueStreamLocation ..|> Togaf.Edges
    class Togaf.Business.ValueStreamRequirement {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ValueStreamRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.ValueStreamRequirement ..|> Togaf.Edges
    class Togaf.Business.ValueStreamAssumption {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ValueStreamAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.ValueStreamAssumption ..|> Togaf.Edges
    class Togaf.Business.ValueStreamConstraint {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ValueStreamConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.ValueStreamConstraint ..|> Togaf.Edges
    class Togaf.Business.ValueStreamPrinciple {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ValueStreamPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.ValueStreamPrinciple ..|> Togaf.Edges
    class Togaf.Business.ValueStreamVectorSpace {
        # owner  : Togaf.Business.ValueStream
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.ValueStreamVectorSpace *-- Hiperspace.Vector
    Togaf.Business.ValueStreamVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.ControlWorkPackage {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.ControlWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.ControlWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.ControlGap {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ControlGap ..|> Togaf.Has.Gap
    Togaf.Business.ControlGap ..|> Togaf.Edges
    class Togaf.Business.ControlLocation {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ControlLocation ..|> Togaf.Has.Location
    Togaf.Business.ControlLocation ..|> Togaf.Edges
    class Togaf.Business.ControlRequirement {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ControlRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.ControlRequirement ..|> Togaf.Edges
    class Togaf.Business.ControlAssumption {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ControlAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.ControlAssumption ..|> Togaf.Edges
    class Togaf.Business.ControlConstraint {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ControlConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.ControlConstraint ..|> Togaf.Edges
    class Togaf.Business.ControlPrinciple {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ControlPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.ControlPrinciple ..|> Togaf.Edges
    class Togaf.Business.ControlVectorSpace {
        # owner  : Togaf.Business.Control
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.ControlVectorSpace *-- Hiperspace.Vector
    Togaf.Business.ControlVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.ProcessWorkPackage {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.ProcessWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.ProcessWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.ProcessGap {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProcessGap ..|> Togaf.Has.Gap
    Togaf.Business.ProcessGap ..|> Togaf.Edges
    class Togaf.Business.ProcessLocation {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProcessLocation ..|> Togaf.Has.Location
    Togaf.Business.ProcessLocation ..|> Togaf.Edges
    class Togaf.Business.ProcessRequirement {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProcessRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.ProcessRequirement ..|> Togaf.Edges
    class Togaf.Business.ProcessAssumption {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProcessAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.ProcessAssumption ..|> Togaf.Edges
    class Togaf.Business.ProcessConstraint {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProcessConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.ProcessConstraint ..|> Togaf.Edges
    class Togaf.Business.ProcessPrinciple {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProcessPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.ProcessPrinciple ..|> Togaf.Edges
    class Togaf.Business.ProcessVectorSpace {
        # owner  : Togaf.Business.Process
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.ProcessVectorSpace *-- Hiperspace.Vector
    Togaf.Business.ProcessVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.EventWorkPackage {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.EventWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.EventWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.EventGap {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.EventGap ..|> Togaf.Has.Gap
    Togaf.Business.EventGap ..|> Togaf.Edges
    class Togaf.Business.EventLocation {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.EventLocation ..|> Togaf.Has.Location
    Togaf.Business.EventLocation ..|> Togaf.Edges
    class Togaf.Business.EventRequirement {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.EventRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.EventRequirement ..|> Togaf.Edges
    class Togaf.Business.EventAssumption {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.EventAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.EventAssumption ..|> Togaf.Edges
    class Togaf.Business.EventConstraint {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.EventConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.EventConstraint ..|> Togaf.Edges
    class Togaf.Business.EventPrinciple {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.EventPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.EventPrinciple ..|> Togaf.Edges
    class Togaf.Business.EventVectorSpace {
        # owner  : Togaf.Business.Event
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.EventVectorSpace *-- Hiperspace.Vector
    Togaf.Business.EventVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.ActivityWorkPackage {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.ActivityWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.ActivityWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.ActivityGap {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActivityGap ..|> Togaf.Has.Gap
    Togaf.Business.ActivityGap ..|> Togaf.Edges
    class Togaf.Business.ActivityLocation {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActivityLocation ..|> Togaf.Has.Location
    Togaf.Business.ActivityLocation ..|> Togaf.Edges
    class Togaf.Business.ActivityRequirement {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActivityRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.ActivityRequirement ..|> Togaf.Edges
    class Togaf.Business.ActivityAssumption {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActivityAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.ActivityAssumption ..|> Togaf.Edges
    class Togaf.Business.ActivityConstraint {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActivityConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.ActivityConstraint ..|> Togaf.Edges
    class Togaf.Business.ActivityPrinciple {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActivityPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.ActivityPrinciple ..|> Togaf.Edges
    class Togaf.Business.ActivityVectorSpace {
        # owner  : Togaf.Business.Activity
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.ActivityVectorSpace *-- Hiperspace.Vector
    Togaf.Business.ActivityVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.MeasureWorkPackage {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.MeasureWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.MeasureWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.MeasureGap {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.MeasureGap ..|> Togaf.Has.Gap
    Togaf.Business.MeasureGap ..|> Togaf.Edges
    class Togaf.Business.MeasureLocation {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.MeasureLocation ..|> Togaf.Has.Location
    Togaf.Business.MeasureLocation ..|> Togaf.Edges
    class Togaf.Business.MeasureRequirement {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.MeasureRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.MeasureRequirement ..|> Togaf.Edges
    class Togaf.Business.MeasureAssumption {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.MeasureAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.MeasureAssumption ..|> Togaf.Edges
    class Togaf.Business.MeasureConstraint {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.MeasureConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.MeasureConstraint ..|> Togaf.Edges
    class Togaf.Business.MeasurePrinciple {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.MeasurePrinciple ..|> Togaf.Has.Principle
    Togaf.Business.MeasurePrinciple ..|> Togaf.Edges
    class Togaf.Business.MeasureVectorSpace {
        # owner  : Togaf.Business.Measure
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.MeasureVectorSpace *-- Hiperspace.Vector
    Togaf.Business.MeasureVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.ObjectiveWorkPackage {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.ObjectiveWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.ObjectiveWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.ObjectiveGap {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ObjectiveGap ..|> Togaf.Has.Gap
    Togaf.Business.ObjectiveGap ..|> Togaf.Edges
    class Togaf.Business.ObjectiveLocation {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ObjectiveLocation ..|> Togaf.Has.Location
    Togaf.Business.ObjectiveLocation ..|> Togaf.Edges
    class Togaf.Business.ObjectiveRequirement {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ObjectiveRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.ObjectiveRequirement ..|> Togaf.Edges
    class Togaf.Business.ObjectiveAssumption {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ObjectiveAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.ObjectiveAssumption ..|> Togaf.Edges
    class Togaf.Business.ObjectiveConstraint {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ObjectiveConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.ObjectiveConstraint ..|> Togaf.Edges
    class Togaf.Business.ObjectivePrinciple {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ObjectivePrinciple ..|> Togaf.Has.Principle
    Togaf.Business.ObjectivePrinciple ..|> Togaf.Edges
    class Togaf.Business.ObjectiveVectorSpace {
        # owner  : Togaf.Business.Objective
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.ObjectiveVectorSpace *-- Hiperspace.Vector
    Togaf.Business.ObjectiveVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.GoalWorkPackage {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.GoalWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.GoalWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.GoalGap {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.GoalGap ..|> Togaf.Has.Gap
    Togaf.Business.GoalGap ..|> Togaf.Edges
    class Togaf.Business.GoalLocation {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.GoalLocation ..|> Togaf.Has.Location
    Togaf.Business.GoalLocation ..|> Togaf.Edges
    class Togaf.Business.GoalRequirement {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.GoalRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.GoalRequirement ..|> Togaf.Edges
    class Togaf.Business.GoalAssumption {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.GoalAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.GoalAssumption ..|> Togaf.Edges
    class Togaf.Business.GoalConstraint {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.GoalConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.GoalConstraint ..|> Togaf.Edges
    class Togaf.Business.GoalPrinciple {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.GoalPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.GoalPrinciple ..|> Togaf.Edges
    class Togaf.Business.GoalVectorSpace {
        # owner  : Togaf.Business.Goal
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.GoalVectorSpace *-- Hiperspace.Vector
    Togaf.Business.GoalVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.ProductWorkPackage {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.ProductWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.ProductWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.ProductGap {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProductGap ..|> Togaf.Has.Gap
    Togaf.Business.ProductGap ..|> Togaf.Edges
    class Togaf.Business.ProductLocation {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProductLocation ..|> Togaf.Has.Location
    Togaf.Business.ProductLocation ..|> Togaf.Edges
    class Togaf.Business.ProductRequirement {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProductRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.ProductRequirement ..|> Togaf.Edges
    class Togaf.Business.ProductAssumption {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProductAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.ProductAssumption ..|> Togaf.Edges
    class Togaf.Business.ProductConstraint {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProductConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.ProductConstraint ..|> Togaf.Edges
    class Togaf.Business.ProductPrinciple {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ProductPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.ProductPrinciple ..|> Togaf.Edges
    class Togaf.Business.ProductVectorSpace {
        # owner  : Togaf.Business.Product
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.ProductVectorSpace *-- Hiperspace.Vector
    Togaf.Business.ProductVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.CapabilityWorkPackage {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.CapabilityWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.CapabilityWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.CapabilityGap {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CapabilityGap ..|> Togaf.Has.Gap
    Togaf.Business.CapabilityGap ..|> Togaf.Edges
    class Togaf.Business.CapabilityLocation {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CapabilityLocation ..|> Togaf.Has.Location
    Togaf.Business.CapabilityLocation ..|> Togaf.Edges
    class Togaf.Business.CapabilityRequirement {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CapabilityRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.CapabilityRequirement ..|> Togaf.Edges
    class Togaf.Business.CapabilityAssumption {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CapabilityAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.CapabilityAssumption ..|> Togaf.Edges
    class Togaf.Business.CapabilityConstraint {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CapabilityConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.CapabilityConstraint ..|> Togaf.Edges
    class Togaf.Business.CapabilityPrinciple {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.CapabilityPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.CapabilityPrinciple ..|> Togaf.Edges
    class Togaf.Business.CapabilityVectorSpace {
        # owner  : Togaf.Business.Capability
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.CapabilityVectorSpace *-- Hiperspace.Vector
    Togaf.Business.CapabilityVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.FunctionWorkPackage {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.FunctionWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.FunctionWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.FunctionGap {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.FunctionGap ..|> Togaf.Has.Gap
    Togaf.Business.FunctionGap ..|> Togaf.Edges
    class Togaf.Business.FunctionLocation {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.FunctionLocation ..|> Togaf.Has.Location
    Togaf.Business.FunctionLocation ..|> Togaf.Edges
    class Togaf.Business.FunctionRequirement {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.FunctionRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.FunctionRequirement ..|> Togaf.Edges
    class Togaf.Business.FunctionAssumption {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.FunctionAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.FunctionAssumption ..|> Togaf.Edges
    class Togaf.Business.FunctionConstraint {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.FunctionConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.FunctionConstraint ..|> Togaf.Edges
    class Togaf.Business.FunctionPrinciple {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.FunctionPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.FunctionPrinciple ..|> Togaf.Edges
    class Togaf.Business.FunctionVectorSpace {
        # owner  : Togaf.Business.Function
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.FunctionVectorSpace *-- Hiperspace.Vector
    Togaf.Business.FunctionVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.ActorWorkPackage {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.ActorWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.ActorWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.ActorGap {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActorGap ..|> Togaf.Has.Gap
    Togaf.Business.ActorGap ..|> Togaf.Edges
    class Togaf.Business.ActorLocation {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActorLocation ..|> Togaf.Has.Location
    Togaf.Business.ActorLocation ..|> Togaf.Edges
    class Togaf.Business.ActorRequirement {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActorRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.ActorRequirement ..|> Togaf.Edges
    class Togaf.Business.ActorAssumption {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActorAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.ActorAssumption ..|> Togaf.Edges
    class Togaf.Business.ActorConstraint {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActorConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.ActorConstraint ..|> Togaf.Edges
    class Togaf.Business.ActorPrinciple {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.ActorPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.ActorPrinciple ..|> Togaf.Edges
    class Togaf.Business.ActorVectorSpace {
        # owner  : Togaf.Business.Actor
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.ActorVectorSpace *-- Hiperspace.Vector
    Togaf.Business.ActorVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Business.DriverWorkPackage {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Business.DriverWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Business.DriverWorkPackage ..|> Togaf.Edge_
    class Togaf.Business.DriverGap {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.DriverGap ..|> Togaf.Has.Gap
    Togaf.Business.DriverGap ..|> Togaf.Edges
    class Togaf.Business.DriverLocation {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.DriverLocation ..|> Togaf.Has.Location
    Togaf.Business.DriverLocation ..|> Togaf.Edges
    class Togaf.Business.DriverRequirement {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.DriverRequirement ..|> Togaf.Has.Requirement
    Togaf.Business.DriverRequirement ..|> Togaf.Edges
    class Togaf.Business.DriverAssumption {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.DriverAssumption ..|> Togaf.Has.Assumption
    Togaf.Business.DriverAssumption ..|> Togaf.Edges
    class Togaf.Business.DriverConstraint {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.DriverConstraint ..|> Togaf.Has.Constraint
    Togaf.Business.DriverConstraint ..|> Togaf.Edges
    class Togaf.Business.DriverPrinciple {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Business.DriverPrinciple ..|> Togaf.Has.Principle
    Togaf.Business.DriverPrinciple ..|> Togaf.Edges
    class Togaf.Business.DriverVectorSpace {
        # owner  : Togaf.Business.Driver
        + Vector  : Hiperspace.Vector
    }
    Togaf.Business.DriverVectorSpace *-- Hiperspace.Vector
    Togaf.Business.DriverVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.History.Measure {
        # owner  : Togaf.Business.Measure
        # At  : DateTime
        + Value  : Decimal
    }
    class Togaf.Data.Entity {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Originator  : Togaf.Business.Activity
        + Provider  : Togaf.Service
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Data.EntityVectorSpace
        + Principle () : Togaf.Data.EntityPrinciple
        + Constraint () : Togaf.Data.EntityConstraint
        + Assumption () : Togaf.Data.EntityAssumption
        + Requirement () : Togaf.Data.EntityRequirement
        + Location () : Togaf.Data.EntityLocation
        + Gap () : Togaf.Data.EntityGap
        + WorkPackage () : Togaf.Data.EntityWorkPackage
        + Logical (Encapsulate = this) : Togaf.Data.Logical
        + DataUsage (Entity = this) : Togaf.Data.Usage
        + SameName (Name = Name) : Togaf.Data.Entity
    }
    Togaf.Data.Entity --> Togaf.Business.Activity
    Togaf.Data.Entity --> Togaf.Service
    Togaf.Data.Entity o-- Togaf.Data.EntityVectorSpace
    Togaf.Data.Entity o-- Togaf.Data.EntityPrinciple
    Togaf.Data.Entity o-- Togaf.Data.EntityConstraint
    Togaf.Data.Entity o-- Togaf.Data.EntityAssumption
    Togaf.Data.Entity o-- Togaf.Data.EntityRequirement
    Togaf.Data.Entity o-- Togaf.Data.EntityLocation
    Togaf.Data.Entity o-- Togaf.Data.EntityGap
    Togaf.Data.Entity o-- Togaf.Data.EntityWorkPackage
    Togaf.Data.Entity ..|> Togaf.Edges
    Togaf.Data.Entity ..|> Togaf.Edges3
    class Togaf.Data.Usage {
        # Id  : Guid
        # Entity  : Togaf.Data.Entity
        # System  : Togaf.Application.System
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Comment  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + SameName (Name = Name) : Togaf.Data.Usage
    }
    Togaf.Data.Usage --> Togaf.Data.Entity
    Togaf.Data.Usage --> Togaf.Application.System
    Togaf.Data.Usage ..|> Togaf.Edges
    Togaf.Data.Usage ..|> Togaf.Edges3
    class Togaf.Data.Logical {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Encapsulate  : Togaf.Data.Entity
        + Component  : Togaf.Application.Component
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Data.LogicalVectorSpace
        + Principle () : Togaf.Data.LogicalPrinciple
        + Constraint () : Togaf.Data.LogicalConstraint
        + Assumption () : Togaf.Data.LogicalAssumption
        + Requirement () : Togaf.Data.LogicalRequirement
        + Location () : Togaf.Data.LogicalLocation
        + Gap () : Togaf.Data.LogicalGap
        + WorkPackage () : Togaf.Data.LogicalWorkPackage
        + Instantiate (Instantiate = this) : Togaf.Data.Physical
        + SameName (Name = Name) : Togaf.Data.Logical
    }
    Togaf.Data.Logical --> Togaf.Data.Entity
    Togaf.Data.Logical --> Togaf.Application.Component
    Togaf.Data.Logical o-- Togaf.Data.LogicalVectorSpace
    Togaf.Data.Logical o-- Togaf.Data.LogicalPrinciple
    Togaf.Data.Logical o-- Togaf.Data.LogicalConstraint
    Togaf.Data.Logical o-- Togaf.Data.LogicalAssumption
    Togaf.Data.Logical o-- Togaf.Data.LogicalRequirement
    Togaf.Data.Logical o-- Togaf.Data.LogicalLocation
    Togaf.Data.Logical o-- Togaf.Data.LogicalGap
    Togaf.Data.Logical o-- Togaf.Data.LogicalWorkPackage
    Togaf.Data.Logical ..|> Togaf.Edges
    Togaf.Data.Logical ..|> Togaf.Edges2
    class Togaf.Data.Physical {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Instantiate  : Togaf.Data.Logical
        + Deployed  : Togaf.Application.Deployed
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Data.PhysicalVectorSpace
        + Principle () : Togaf.Data.PhysicalPrinciple
        + Constraint () : Togaf.Data.PhysicalConstraint
        + Assumption () : Togaf.Data.PhysicalAssumption
        + Requirement () : Togaf.Data.PhysicalRequirement
        + Location () : Togaf.Data.PhysicalLocation
        + Gap () : Togaf.Data.PhysicalGap
        + WorkPackage () : Togaf.Data.PhysicalWorkPackage
        + SameName (Name = Name) : Togaf.Data.Physical
    }
    Togaf.Data.Physical --> Togaf.Data.Logical
    Togaf.Data.Physical --> Togaf.Application.Deployed
    Togaf.Data.Physical o-- Togaf.Data.PhysicalVectorSpace
    Togaf.Data.Physical o-- Togaf.Data.PhysicalPrinciple
    Togaf.Data.Physical o-- Togaf.Data.PhysicalConstraint
    Togaf.Data.Physical o-- Togaf.Data.PhysicalAssumption
    Togaf.Data.Physical o-- Togaf.Data.PhysicalRequirement
    Togaf.Data.Physical o-- Togaf.Data.PhysicalLocation
    Togaf.Data.Physical o-- Togaf.Data.PhysicalGap
    Togaf.Data.Physical o-- Togaf.Data.PhysicalWorkPackage
    Togaf.Data.Physical ..|> Togaf.Edges
    Togaf.Data.Physical ..|> Togaf.Edges2
    class Togaf.Data.PhysicalWorkPackage {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Data.PhysicalWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Data.PhysicalWorkPackage ..|> Togaf.Edge_
    class Togaf.Data.PhysicalGap {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.PhysicalGap ..|> Togaf.Has.Gap
    Togaf.Data.PhysicalGap ..|> Togaf.Edges
    class Togaf.Data.PhysicalLocation {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.PhysicalLocation ..|> Togaf.Has.Location
    Togaf.Data.PhysicalLocation ..|> Togaf.Edges
    class Togaf.Data.PhysicalRequirement {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.PhysicalRequirement ..|> Togaf.Has.Requirement
    Togaf.Data.PhysicalRequirement ..|> Togaf.Edges
    class Togaf.Data.PhysicalAssumption {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.PhysicalAssumption ..|> Togaf.Has.Assumption
    Togaf.Data.PhysicalAssumption ..|> Togaf.Edges
    class Togaf.Data.PhysicalConstraint {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.PhysicalConstraint ..|> Togaf.Has.Constraint
    Togaf.Data.PhysicalConstraint ..|> Togaf.Edges
    class Togaf.Data.PhysicalPrinciple {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.PhysicalPrinciple ..|> Togaf.Has.Principle
    Togaf.Data.PhysicalPrinciple ..|> Togaf.Edges
    class Togaf.Data.PhysicalVectorSpace {
        # owner  : Togaf.Data.Physical
        + Vector  : Hiperspace.Vector
    }
    Togaf.Data.PhysicalVectorSpace *-- Hiperspace.Vector
    Togaf.Data.PhysicalVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Data.LogicalWorkPackage {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Data.LogicalWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Data.LogicalWorkPackage ..|> Togaf.Edge_
    class Togaf.Data.LogicalGap {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.LogicalGap ..|> Togaf.Has.Gap
    Togaf.Data.LogicalGap ..|> Togaf.Edges
    class Togaf.Data.LogicalLocation {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.LogicalLocation ..|> Togaf.Has.Location
    Togaf.Data.LogicalLocation ..|> Togaf.Edges
    class Togaf.Data.LogicalRequirement {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.LogicalRequirement ..|> Togaf.Has.Requirement
    Togaf.Data.LogicalRequirement ..|> Togaf.Edges
    class Togaf.Data.LogicalAssumption {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.LogicalAssumption ..|> Togaf.Has.Assumption
    Togaf.Data.LogicalAssumption ..|> Togaf.Edges
    class Togaf.Data.LogicalConstraint {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.LogicalConstraint ..|> Togaf.Has.Constraint
    Togaf.Data.LogicalConstraint ..|> Togaf.Edges
    class Togaf.Data.LogicalPrinciple {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.LogicalPrinciple ..|> Togaf.Has.Principle
    Togaf.Data.LogicalPrinciple ..|> Togaf.Edges
    class Togaf.Data.LogicalVectorSpace {
        # owner  : Togaf.Data.Logical
        + Vector  : Hiperspace.Vector
    }
    Togaf.Data.LogicalVectorSpace *-- Hiperspace.Vector
    Togaf.Data.LogicalVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Data.EntityWorkPackage {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Data.EntityWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Data.EntityWorkPackage ..|> Togaf.Edge_
    class Togaf.Data.EntityGap {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.EntityGap ..|> Togaf.Has.Gap
    Togaf.Data.EntityGap ..|> Togaf.Edges
    class Togaf.Data.EntityLocation {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.EntityLocation ..|> Togaf.Has.Location
    Togaf.Data.EntityLocation ..|> Togaf.Edges
    class Togaf.Data.EntityRequirement {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.EntityRequirement ..|> Togaf.Has.Requirement
    Togaf.Data.EntityRequirement ..|> Togaf.Edges
    class Togaf.Data.EntityAssumption {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.EntityAssumption ..|> Togaf.Has.Assumption
    Togaf.Data.EntityAssumption ..|> Togaf.Edges
    class Togaf.Data.EntityConstraint {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.EntityConstraint ..|> Togaf.Has.Constraint
    Togaf.Data.EntityConstraint ..|> Togaf.Edges
    class Togaf.Data.EntityPrinciple {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Data.EntityPrinciple ..|> Togaf.Has.Principle
    Togaf.Data.EntityPrinciple ..|> Togaf.Edges
    class Togaf.Data.EntityVectorSpace {
        # owner  : Togaf.Data.Entity
        + Vector  : Hiperspace.Vector
    }
    Togaf.Data.EntityVectorSpace *-- Hiperspace.Vector
    Togaf.Data.EntityVectorSpace ..|> Hiperspace.VectorSpace
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
    Togaf.Application.System --> Togaf.Service
    Togaf.Application.System --> Togaf.Technology.Platform
    Togaf.Application.System o-- Togaf.Application.SystemVectorSpace
    Togaf.Application.System o-- Togaf.Application.SystemPrinciple
    Togaf.Application.System o-- Togaf.Application.SystemConstraint
    Togaf.Application.System o-- Togaf.Application.SystemAssumption
    Togaf.Application.System o-- Togaf.Application.SystemRequirement
    Togaf.Application.System o-- Togaf.Application.SystemLocation
    Togaf.Application.System o-- Togaf.Application.SystemGap
    Togaf.Application.System o-- Togaf.Application.SystemWorkPackage
    Togaf.Application.System ..|> Togaf.Edges
    Togaf.Application.System ..|> Togaf.Edges2
    class Togaf.Application.Component {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Implements  : Togaf.Application.System
        + Host  : Togaf.Technology.Host
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Application.ComponentVectorSpace
        + Principle () : Togaf.Application.ComponentPrinciple
        + Constraint () : Togaf.Application.ComponentConstraint
        + Assumption () : Togaf.Application.ComponentAssumption
        + Requirement () : Togaf.Application.ComponentRequirement
        + Location () : Togaf.Application.ComponentLocation
        + Gap () : Togaf.Application.ComponentGap
        + WorkPackage () : Togaf.Application.ComponentWorkPackage
        + ComponentUsage (Component = this) : Togaf.Data.Logical
        + DeployedBy (Deployes = this) : Togaf.Application.Deployed
        + SameName (Name = Name) : Togaf.Application.Component
    }
    Togaf.Application.Component --> Togaf.Application.System
    Togaf.Application.Component --> Togaf.Technology.Host
    Togaf.Application.Component o-- Togaf.Application.ComponentVectorSpace
    Togaf.Application.Component o-- Togaf.Application.ComponentPrinciple
    Togaf.Application.Component o-- Togaf.Application.ComponentConstraint
    Togaf.Application.Component o-- Togaf.Application.ComponentAssumption
    Togaf.Application.Component o-- Togaf.Application.ComponentRequirement
    Togaf.Application.Component o-- Togaf.Application.ComponentLocation
    Togaf.Application.Component o-- Togaf.Application.ComponentGap
    Togaf.Application.Component o-- Togaf.Application.ComponentWorkPackage
    Togaf.Application.Component ..|> Togaf.Edges
    Togaf.Application.Component ..|> Togaf.Edges2
    class Togaf.Application.Deployed {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Deployes  : Togaf.Application.Component
        + Host  : Togaf.Technology.Instance
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Application.DeployedVectorSpace
        + Principle () : Togaf.Application.DeployedPrinciple
        + Constraint () : Togaf.Application.DeployedConstraint
        + Assumption () : Togaf.Application.DeployedAssumption
        + Requirement () : Togaf.Application.DeployedRequirement
        + Location () : Togaf.Application.DeployedLocation
        + Gap () : Togaf.Application.DeployedGap
        + WorkPackage () : Togaf.Application.DeployedWorkPackage
        + Usage (Deployed = this) : Togaf.Data.Physical
        + SameName (Name = Name) : Togaf.Application.Deployed
    }
    Togaf.Application.Deployed --> Togaf.Application.Component
    Togaf.Application.Deployed --> Togaf.Technology.Instance
    Togaf.Application.Deployed o-- Togaf.Application.DeployedVectorSpace
    Togaf.Application.Deployed o-- Togaf.Application.DeployedPrinciple
    Togaf.Application.Deployed o-- Togaf.Application.DeployedConstraint
    Togaf.Application.Deployed o-- Togaf.Application.DeployedAssumption
    Togaf.Application.Deployed o-- Togaf.Application.DeployedRequirement
    Togaf.Application.Deployed o-- Togaf.Application.DeployedLocation
    Togaf.Application.Deployed o-- Togaf.Application.DeployedGap
    Togaf.Application.Deployed o-- Togaf.Application.DeployedWorkPackage
    Togaf.Application.Deployed ..|> Togaf.Edges
    Togaf.Application.Deployed ..|> Togaf.Edges2
    class Togaf.Application.DeployedWorkPackage {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Application.DeployedWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Application.DeployedWorkPackage ..|> Togaf.Edge_
    class Togaf.Application.DeployedGap {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.DeployedGap ..|> Togaf.Has.Gap
    Togaf.Application.DeployedGap ..|> Togaf.Edges
    class Togaf.Application.DeployedLocation {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.DeployedLocation ..|> Togaf.Has.Location
    Togaf.Application.DeployedLocation ..|> Togaf.Edges
    class Togaf.Application.DeployedRequirement {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.DeployedRequirement ..|> Togaf.Has.Requirement
    Togaf.Application.DeployedRequirement ..|> Togaf.Edges
    class Togaf.Application.DeployedAssumption {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.DeployedAssumption ..|> Togaf.Has.Assumption
    Togaf.Application.DeployedAssumption ..|> Togaf.Edges
    class Togaf.Application.DeployedConstraint {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.DeployedConstraint ..|> Togaf.Has.Constraint
    Togaf.Application.DeployedConstraint ..|> Togaf.Edges
    class Togaf.Application.DeployedPrinciple {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.DeployedPrinciple ..|> Togaf.Has.Principle
    Togaf.Application.DeployedPrinciple ..|> Togaf.Edges
    class Togaf.Application.DeployedVectorSpace {
        # owner  : Togaf.Application.Deployed
        + Vector  : Hiperspace.Vector
    }
    Togaf.Application.DeployedVectorSpace *-- Hiperspace.Vector
    Togaf.Application.DeployedVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Application.ComponentWorkPackage {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Application.ComponentWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Application.ComponentWorkPackage ..|> Togaf.Edge_
    class Togaf.Application.ComponentGap {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.ComponentGap ..|> Togaf.Has.Gap
    Togaf.Application.ComponentGap ..|> Togaf.Edges
    class Togaf.Application.ComponentLocation {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.ComponentLocation ..|> Togaf.Has.Location
    Togaf.Application.ComponentLocation ..|> Togaf.Edges
    class Togaf.Application.ComponentRequirement {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.ComponentRequirement ..|> Togaf.Has.Requirement
    Togaf.Application.ComponentRequirement ..|> Togaf.Edges
    class Togaf.Application.ComponentAssumption {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.ComponentAssumption ..|> Togaf.Has.Assumption
    Togaf.Application.ComponentAssumption ..|> Togaf.Edges
    class Togaf.Application.ComponentConstraint {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.ComponentConstraint ..|> Togaf.Has.Constraint
    Togaf.Application.ComponentConstraint ..|> Togaf.Edges
    class Togaf.Application.ComponentPrinciple {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.ComponentPrinciple ..|> Togaf.Has.Principle
    Togaf.Application.ComponentPrinciple ..|> Togaf.Edges
    class Togaf.Application.ComponentVectorSpace {
        # owner  : Togaf.Application.Component
        + Vector  : Hiperspace.Vector
    }
    Togaf.Application.ComponentVectorSpace *-- Hiperspace.Vector
    Togaf.Application.ComponentVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Application.SystemWorkPackage {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Application.SystemWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Application.SystemWorkPackage ..|> Togaf.Edge_
    class Togaf.Application.SystemGap {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.SystemGap ..|> Togaf.Has.Gap
    Togaf.Application.SystemGap ..|> Togaf.Edges
    class Togaf.Application.SystemLocation {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.SystemLocation ..|> Togaf.Has.Location
    Togaf.Application.SystemLocation ..|> Togaf.Edges
    class Togaf.Application.SystemRequirement {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.SystemRequirement ..|> Togaf.Has.Requirement
    Togaf.Application.SystemRequirement ..|> Togaf.Edges
    class Togaf.Application.SystemAssumption {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.SystemAssumption ..|> Togaf.Has.Assumption
    Togaf.Application.SystemAssumption ..|> Togaf.Edges
    class Togaf.Application.SystemConstraint {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.SystemConstraint ..|> Togaf.Has.Constraint
    Togaf.Application.SystemConstraint ..|> Togaf.Edges
    class Togaf.Application.SystemPrinciple {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Application.SystemPrinciple ..|> Togaf.Has.Principle
    Togaf.Application.SystemPrinciple ..|> Togaf.Edges
    class Togaf.Application.SystemVectorSpace {
        # owner  : Togaf.Application.System
        + Vector  : Hiperspace.Vector
    }
    Togaf.Application.SystemVectorSpace *-- Hiperspace.Vector
    Togaf.Application.SystemVectorSpace ..|> Hiperspace.VectorSpace
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
    Togaf.Technology.Platform --> Togaf.Service
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformVectorSpace
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformPrinciple
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformConstraint
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformAssumption
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformRequirement
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformLocation
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformGap
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformWorkPackage
    Togaf.Technology.Platform ..|> Togaf.Edges
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
    Togaf.Technology.Host --> Togaf.Technology.Platform
    Togaf.Technology.Host o-- Togaf.Technology.HostVectorSpace
    Togaf.Technology.Host o-- Togaf.Technology.HostPrinciple
    Togaf.Technology.Host o-- Togaf.Technology.HostConstraint
    Togaf.Technology.Host o-- Togaf.Technology.HostAssumption
    Togaf.Technology.Host o-- Togaf.Technology.HostRequirement
    Togaf.Technology.Host o-- Togaf.Technology.HostLocation
    Togaf.Technology.Host o-- Togaf.Technology.HostGap
    Togaf.Technology.Host o-- Togaf.Technology.HostWorkPackage
    Togaf.Technology.Host ..|> Togaf.Edges
    class Togaf.Technology.Instance {
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + Host  : Togaf.Technology.Host
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + VectorSpace () : Togaf.Technology.InstanceVectorSpace
        + Principle () : Togaf.Technology.InstancePrinciple
        + Constraint () : Togaf.Technology.InstanceConstraint
        + Assumption () : Togaf.Technology.InstanceAssumption
        + Requirement () : Togaf.Technology.InstanceRequirement
        + Location () : Togaf.Technology.InstanceLocation
        + Gap () : Togaf.Technology.InstanceGap
        + WorkPackage () : Togaf.Technology.InstanceWorkPackage
        + Hosts (Host = this) : Togaf.Application.Deployed
        + SameName (Name = Name) : Togaf.Technology.Instance
    }
    Togaf.Technology.Instance --> Togaf.Technology.Host
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceVectorSpace
    Togaf.Technology.Instance o-- Togaf.Technology.InstancePrinciple
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceConstraint
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceAssumption
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceRequirement
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceLocation
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceGap
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceWorkPackage
    Togaf.Technology.Instance ..|> Togaf.Edges
    class Togaf.Technology.InstanceWorkPackage {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Technology.InstanceWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Technology.InstanceWorkPackage ..|> Togaf.Edge_
    class Togaf.Technology.InstanceGap {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.InstanceGap ..|> Togaf.Has.Gap
    Togaf.Technology.InstanceGap ..|> Togaf.Edges
    class Togaf.Technology.InstanceLocation {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.InstanceLocation ..|> Togaf.Has.Location
    Togaf.Technology.InstanceLocation ..|> Togaf.Edges
    class Togaf.Technology.InstanceRequirement {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.InstanceRequirement ..|> Togaf.Has.Requirement
    Togaf.Technology.InstanceRequirement ..|> Togaf.Edges
    class Togaf.Technology.InstanceAssumption {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.InstanceAssumption ..|> Togaf.Has.Assumption
    Togaf.Technology.InstanceAssumption ..|> Togaf.Edges
    class Togaf.Technology.InstanceConstraint {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.InstanceConstraint ..|> Togaf.Has.Constraint
    Togaf.Technology.InstanceConstraint ..|> Togaf.Edges
    class Togaf.Technology.InstancePrinciple {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.InstancePrinciple ..|> Togaf.Has.Principle
    Togaf.Technology.InstancePrinciple ..|> Togaf.Edges
    class Togaf.Technology.InstanceVectorSpace {
        # owner  : Togaf.Technology.Instance
        + Vector  : Hiperspace.Vector
    }
    Togaf.Technology.InstanceVectorSpace *-- Hiperspace.Vector
    Togaf.Technology.InstanceVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Technology.HostWorkPackage {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Technology.HostWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Technology.HostWorkPackage ..|> Togaf.Edge_
    class Togaf.Technology.HostGap {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.HostGap ..|> Togaf.Has.Gap
    Togaf.Technology.HostGap ..|> Togaf.Edges
    class Togaf.Technology.HostLocation {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.HostLocation ..|> Togaf.Has.Location
    Togaf.Technology.HostLocation ..|> Togaf.Edges
    class Togaf.Technology.HostRequirement {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.HostRequirement ..|> Togaf.Has.Requirement
    Togaf.Technology.HostRequirement ..|> Togaf.Edges
    class Togaf.Technology.HostAssumption {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.HostAssumption ..|> Togaf.Has.Assumption
    Togaf.Technology.HostAssumption ..|> Togaf.Edges
    class Togaf.Technology.HostConstraint {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.HostConstraint ..|> Togaf.Has.Constraint
    Togaf.Technology.HostConstraint ..|> Togaf.Edges
    class Togaf.Technology.HostPrinciple {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.HostPrinciple ..|> Togaf.Has.Principle
    Togaf.Technology.HostPrinciple ..|> Togaf.Edges
    class Togaf.Technology.HostVectorSpace {
        # owner  : Togaf.Technology.Host
        + Vector  : Hiperspace.Vector
    }
    Togaf.Technology.HostVectorSpace *-- Hiperspace.Vector
    Togaf.Technology.HostVectorSpace ..|> Hiperspace.VectorSpace
    class Togaf.Technology.PlatformWorkPackage {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge(this)
        + Goals () = Goals(StrategicEdges)
    }
    Togaf.Technology.PlatformWorkPackage ..|> Togaf.Has.WorkPackage
    Togaf.Technology.PlatformWorkPackage ..|> Togaf.Edge_
    class Togaf.Technology.PlatformGap {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.PlatformGap ..|> Togaf.Has.Gap
    Togaf.Technology.PlatformGap ..|> Togaf.Edges
    class Togaf.Technology.PlatformLocation {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.PlatformLocation ..|> Togaf.Has.Location
    Togaf.Technology.PlatformLocation ..|> Togaf.Edges
    class Togaf.Technology.PlatformRequirement {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.PlatformRequirement ..|> Togaf.Has.Requirement
    Togaf.Technology.PlatformRequirement ..|> Togaf.Edges
    class Togaf.Technology.PlatformAssumption {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.PlatformAssumption ..|> Togaf.Has.Assumption
    Togaf.Technology.PlatformAssumption ..|> Togaf.Edges
    class Togaf.Technology.PlatformConstraint {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.PlatformConstraint ..|> Togaf.Has.Constraint
    Togaf.Technology.PlatformConstraint ..|> Togaf.Edges
    class Togaf.Technology.PlatformPrinciple {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    Togaf.Technology.PlatformPrinciple ..|> Togaf.Has.Principle
    Togaf.Technology.PlatformPrinciple ..|> Togaf.Edges
    class Togaf.Technology.PlatformVectorSpace {
        # owner  : Togaf.Technology.Platform
        + Vector  : Hiperspace.Vector
    }
    Togaf.Technology.PlatformVectorSpace *-- Hiperspace.Vector
    Togaf.Technology.PlatformVectorSpace ..|> Hiperspace.VectorSpace
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
    Togaf.Financial.Income_Fact --> Togaf.Technology.Host
    Togaf.Financial.Income_Fact --> Togaf.Business.Event
    Togaf.Financial.Income_Fact --> Togaf.Application.System
    Togaf.Financial.Income_Fact --> Togaf.Service
    Togaf.Financial.Income_Fact --> Togaf.Business.Process
    Togaf.Financial.Income_Fact --> Togaf.Business.Product
    Togaf.Financial.Income_Fact --> Togaf.Technology.Platform
    Togaf.Financial.Income_Fact --> Togaf.Business.Function
    Togaf.Financial.Income_Fact --> Togaf.Business.Capability
    Togaf.Financial.Income_Fact --> Togaf.Organization
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
    Togaf.Financial.Cost_Fact --> Togaf.Technology.Host
    Togaf.Financial.Cost_Fact --> Togaf.Business.Event
    Togaf.Financial.Cost_Fact --> Togaf.Application.System
    Togaf.Financial.Cost_Fact --> Togaf.Service
    Togaf.Financial.Cost_Fact --> Togaf.Business.Process
    Togaf.Financial.Cost_Fact --> Togaf.Business.Product
    Togaf.Financial.Cost_Fact --> Togaf.Technology.Platform
    Togaf.Financial.Cost_Fact --> Togaf.Business.Function
    Togaf.Financial.Cost_Fact --> Togaf.Business.Capability
    Togaf.Financial.Cost_Fact --> Togaf.Organization
```

---

## View Hiperspace.VectorSpace
 Aspect used to search for similar entities

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|+|Vector|Hiperspace.Vector||||

---

## Value Graph.Route
Route across a graph of edge/node to form an HiperEdge

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Name|String||||
|+|Rules|HashSet<Graph.Rule>||||

---

## Value Graph.Rule
A rule for a route that matched as a type of Edge to a HiperEdge, e.g. { Name = 'relation', Rules = [{FromType = 'Person', ToType = 'Person', EdgeType = 'Mother'}]}

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|FromType|String||||
|#|ToType|String||||
|#|EdgeType|String||||

---

## Message Togaf.PathMessage
Remote execution of path requests

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Node|Node||||
|#|Route|Graph.Route||||
|#|Length|Int32||||
|#|Targets|HashSet<String>||||
|+|Edges|HashSet<Graph.HiperEdge>||||

---

## View Togaf.Edge_
An additional edge helper for Togaf.Edges

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Togaf.Edges
Bidirectional Edge, implemented with two Togaf.Edges

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|FromTypeName|String||||
|#|ToTypeName|String||||
|+|Name|String||||

---

## View Togaf.Edges2


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|FromTypeName|String||||
|#|ToTypeName|String||||
|+|Name|String||||

---

## View Togaf.Edges3


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|FromTypeName|String||||
|#|ToTypeName|String||||
|+|Name|String||||

---

## View Togaf.Edges4


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|FromTypeName|String||||
|#|ToTypeName|String||||
|+|Name|String||||

---

## View Togaf.Edges5


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|FromTypeName|String||||
|#|ToTypeName|String||||
|+|Name|String||||

---

## Value Togaf.GoalRef


||Name|Type|*|@|=|
|-|-|-|-|-|
|+|Value|Togaf.Business.Goal||||

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

## SegmentImpl Togaf.ServiceWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.ServiceGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServicePrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.ServiceVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Service||||
|+|Vector|Hiperspace.Vector||||

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

## View Togaf.Has.Principle


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
|+|Deleted|Boolean||||
|+|ValidBase|Boolean||||

---

## View Togaf.Has.Constraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
|+|Deleted|Boolean||||
|+|ValidBase|Boolean||||

---

## View Togaf.Has.Assumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
|+|Deleted|Boolean||||
|+|ValidBase|Boolean||||

---

## View Togaf.Has.Requirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
|+|Deleted|Boolean||||
|+|ValidBase|Boolean||||

---

## View Togaf.Has.Location


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
|+|Deleted|Boolean||||
|+|ValidBase|Boolean||||

---

## View Togaf.Has.Gap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
|+|Deleted|Boolean||||
|+|ValidBase|Boolean||||

---

## View Togaf.Has.WorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
|+|Deleted|Boolean||||
|+|ValidBase|Boolean||||
|+|StrategicEdges|HashSet<Graph.HiperEdge>|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()||
|+|Goals|HashSet<Togaf.GoalRef>||||

---

## SegmentImpl Togaf.Has.Activity


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|A|Togaf.Business.Activity||||
|+|Comment|String||||

---

## EntityImpl Togaf.Business.Driver


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|MotivatedBy|Togaf.Organization||AlternateIndex()||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.DriverVectorSpace||||
|+|Principle|Togaf.Business.DriverPrinciple||||
|+|Constraint|Togaf.Business.DriverConstraint||||
|+|Assumption|Togaf.Business.DriverAssumption||||
|+|Requirement|Togaf.Business.DriverRequirement||||
|+|Location|Togaf.Business.DriverLocation||||
|+|Gap|Togaf.Business.DriverGap||||
|+|WorkPackage|Togaf.Business.DriverWorkPackage||||
||Creates|Togaf.Business.Goal|||By = this|
||SameName|Togaf.Business.Driver|||Name = Name|

---

## EntityImpl Togaf.Business.Actor


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|In|Togaf.Organization||AlternateIndex()||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ActorVectorSpace||||
|+|Principle|Togaf.Business.ActorPrinciple||||
|+|Constraint|Togaf.Business.ActorConstraint||||
|+|Assumption|Togaf.Business.ActorAssumption||||
|+|Requirement|Togaf.Business.ActorRequirement||||
|+|Location|Togaf.Business.ActorLocation||||
|+|Gap|Togaf.Business.ActorGap||||
|+|WorkPackage|Togaf.Business.ActorWorkPackage||||
|+|Performs|Togaf.Has.Activity||||
||Involved|Togaf.Business.ValueStream|||Involves = this|
||SameName|Togaf.Business.Actor|||Name = Name|

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

## EntityImpl Togaf.Business.Goal


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|By|Togaf.Business.Driver||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.GoalVectorSpace||||
|+|Principle|Togaf.Business.GoalPrinciple||||
|+|Constraint|Togaf.Business.GoalConstraint||||
|+|Assumption|Togaf.Business.GoalAssumption||||
|+|Requirement|Togaf.Business.GoalRequirement||||
|+|Location|Togaf.Business.GoalLocation||||
|+|Gap|Togaf.Business.GoalGap||||
|+|WorkPackage|Togaf.Business.GoalWorkPackage||||
||RealizedBy|Togaf.Business.Objective|||For = this|
||Follows|Togaf.Business.CourseOfAction|||Leads = this|
||SameName|Togaf.Business.Goal|||Name = Name|

---

## EntityImpl Togaf.Business.Objective


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|For|Togaf.Business.Goal||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ObjectiveVectorSpace||||
|+|Principle|Togaf.Business.ObjectivePrinciple||||
|+|Constraint|Togaf.Business.ObjectiveConstraint||||
|+|Assumption|Togaf.Business.ObjectiveAssumption||||
|+|Requirement|Togaf.Business.ObjectiveRequirement||||
|+|Location|Togaf.Business.ObjectiveLocation||||
|+|Gap|Togaf.Business.ObjectiveGap||||
|+|WorkPackage|Togaf.Business.ObjectiveWorkPackage||||
||Measured|Togaf.Business.Measure|||For = this|
||SameName|Togaf.Business.Objective|||Name = Name|

---

## EntityImpl Togaf.Business.Measure


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|For|Togaf.Business.Objective||||
|+|Unit|String||||
|+|Tracks|Togaf.Service||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.MeasureVectorSpace||||
|+|Principle|Togaf.Business.MeasurePrinciple||||
|+|Constraint|Togaf.Business.MeasureConstraint||||
|+|Assumption|Togaf.Business.MeasureAssumption||||
|+|Requirement|Togaf.Business.MeasureRequirement||||
|+|Location|Togaf.Business.MeasureLocation||||
|+|Gap|Togaf.Business.MeasureGap||||
|+|WorkPackage|Togaf.Business.MeasureWorkPackage||||
|+|Observation|Togaf.History.Measure||||
||SameName|Togaf.Business.Measure|||Name = Name|

---

## Enum Togaf.Business.ActivityType


||Name|Type|*|@|=|
|-|-|-|-|-|
||Task|Int32|||1|
||Decision|Int32|||2|
||Event|Int32|||3|

---

## EntityImpl Togaf.Business.Activity


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|By|Togaf.Business.Actor||||
|+|Type|Togaf.Business.ActivityType||||
|+|After|Togaf.Business.Activity||||
|+|Part|Togaf.Business.Process||||
|+|Event|Togaf.Business.Event||||
|+|Uses|Togaf.Service||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ActivityVectorSpace||||
|+|Principle|Togaf.Business.ActivityPrinciple||||
|+|Constraint|Togaf.Business.ActivityConstraint||||
|+|Assumption|Togaf.Business.ActivityAssumption||||
|+|Requirement|Togaf.Business.ActivityRequirement||||
|+|Location|Togaf.Business.ActivityLocation||||
|+|Gap|Togaf.Business.ActivityGap||||
|+|WorkPackage|Togaf.Business.ActivityWorkPackage||||
||Before|Togaf.Business.Activity|||After = this|
||Originates|Togaf.Data.Entity|||Originator = this|
||SameName|Togaf.Business.Activity|||Name = Name|

---

## Enum Togaf.Business.EventType


||Name|Type|*|@|=|
|-|-|-|-|-|
||Start|Int32|||1|
||End|Int32|||2|
||Intermediate|Int32|||3|

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

## EntityImpl Togaf.Business.Control


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|URL|String||||
|+|PartOf|Togaf.Business.Control||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ControlVectorSpace||||
|+|Principle|Togaf.Business.ControlPrinciple||||
|+|Constraint|Togaf.Business.ControlConstraint||||
|+|Assumption|Togaf.Business.ControlAssumption||||
|+|Requirement|Togaf.Business.ControlRequirement||||
|+|Location|Togaf.Business.ControlLocation||||
|+|Gap|Togaf.Business.ControlGap||||
|+|WorkPackage|Togaf.Business.ControlWorkPackage||||
||Includes|Togaf.Business.Control|||PartOf = this|
||Governs|Togaf.Business.Process|||Governed = this|
||SameName|Togaf.Business.Control|||Name = Name|

---

## EntityImpl Togaf.Business.ValueStream


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|URL|String||||
|+|Parent|Togaf.Business.ValueStream||||
|+|Enables|Togaf.Business.Capability||||
|+|Involves|Togaf.Business.Actor||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.ValueStreamVectorSpace||||
|+|Principle|Togaf.Business.ValueStreamPrinciple||||
|+|Constraint|Togaf.Business.ValueStreamConstraint||||
|+|Assumption|Togaf.Business.ValueStreamAssumption||||
|+|Requirement|Togaf.Business.ValueStreamRequirement||||
|+|Location|Togaf.Business.ValueStreamLocation||||
|+|Gap|Togaf.Business.ValueStreamGap||||
|+|WorkPackage|Togaf.Business.ValueStreamWorkPackage||||
||Children|Togaf.Business.ValueStream|||Parent = this|
||RealizedBy|Togaf.Business.Process|||Realizes = this|
||SameName|Togaf.Business.ValueStream|||Name = Name|

---

## EntityImpl Togaf.Business.CourseOfAction


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|URL|String||||
|+|Enables|Togaf.Business.Capability||||
|+|Leads|Togaf.Business.Goal||||
|+|Involves|Togaf.Business.Function||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Business.CourseOfActionVectorSpace||||
|+|Principle|Togaf.Business.CourseOfActionPrinciple||||
|+|Constraint|Togaf.Business.CourseOfActionConstraint||||
|+|Assumption|Togaf.Business.CourseOfActionAssumption||||
|+|Requirement|Togaf.Business.CourseOfActionRequirement||||
|+|Location|Togaf.Business.CourseOfActionLocation||||
|+|Gap|Togaf.Business.CourseOfActionGap||||
|+|WorkPackage|Togaf.Business.CourseOfActionWorkPackage||||
||SameName|Togaf.Business.CourseOfAction|||Name = Name|

---

## SegmentImpl Togaf.Business.CourseOfActionWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.CourseOfActionGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.CourseOfActionVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.ValueStreamWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.ValueStreamGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.ValueStreamVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.ControlWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.ControlGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.ControlVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.ProcessWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.ProcessGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.ProcessVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.EventWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.EventGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.EventVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.ActivityWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.ActivityGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.ActivityVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.MeasureWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.MeasureGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasurePrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.MeasureVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.ObjectiveWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.ObjectiveGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectivePrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.ObjectiveVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.GoalWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.GoalGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.GoalVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.ProductWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.ProductGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.ProductVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.CapabilityWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.CapabilityGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.CapabilityVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.FunctionWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.FunctionGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.FunctionVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.ActorWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.ActorGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.ActorVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Business.DriverWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Business.DriverGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Business.DriverVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.History.Measure


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|At|DateTime||||
|+|Value|Decimal||AlternateIndex(2216)||

---

## EntityImpl Togaf.Data.Entity


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Originator|Togaf.Business.Activity||||
|+|Provider|Togaf.Service||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Data.EntityVectorSpace||||
|+|Principle|Togaf.Data.EntityPrinciple||||
|+|Constraint|Togaf.Data.EntityConstraint||||
|+|Assumption|Togaf.Data.EntityAssumption||||
|+|Requirement|Togaf.Data.EntityRequirement||||
|+|Location|Togaf.Data.EntityLocation||||
|+|Gap|Togaf.Data.EntityGap||||
|+|WorkPackage|Togaf.Data.EntityWorkPackage||||
||Logical|Togaf.Data.Logical|||Encapsulate = this|
||DataUsage|Togaf.Data.Usage|||Entity = this|
||SameName|Togaf.Data.Entity|||Name = Name|

---

## EntityImpl Togaf.Data.Usage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|#|Entity|Togaf.Data.Entity||||
|#|System|Togaf.Application.System||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Comment|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||SameName|Togaf.Data.Usage|||Name = Name|

---

## EntityImpl Togaf.Data.Logical


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Encapsulate|Togaf.Data.Entity||||
|+|Component|Togaf.Application.Component||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Data.LogicalVectorSpace||||
|+|Principle|Togaf.Data.LogicalPrinciple||||
|+|Constraint|Togaf.Data.LogicalConstraint||||
|+|Assumption|Togaf.Data.LogicalAssumption||||
|+|Requirement|Togaf.Data.LogicalRequirement||||
|+|Location|Togaf.Data.LogicalLocation||||
|+|Gap|Togaf.Data.LogicalGap||||
|+|WorkPackage|Togaf.Data.LogicalWorkPackage||||
||Instantiate|Togaf.Data.Physical|||Instantiate = this|
||SameName|Togaf.Data.Logical|||Name = Name|

---

## EntityImpl Togaf.Data.Physical


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Instantiate|Togaf.Data.Logical||||
|+|Deployed|Togaf.Application.Deployed||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Data.PhysicalVectorSpace||||
|+|Principle|Togaf.Data.PhysicalPrinciple||||
|+|Constraint|Togaf.Data.PhysicalConstraint||||
|+|Assumption|Togaf.Data.PhysicalAssumption||||
|+|Requirement|Togaf.Data.PhysicalRequirement||||
|+|Location|Togaf.Data.PhysicalLocation||||
|+|Gap|Togaf.Data.PhysicalGap||||
|+|WorkPackage|Togaf.Data.PhysicalWorkPackage||||
||SameName|Togaf.Data.Physical|||Name = Name|

---

## SegmentImpl Togaf.Data.PhysicalWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Data.PhysicalGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Data.PhysicalVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Data.LogicalWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Data.LogicalGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Data.LogicalVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Data.EntityWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Data.EntityGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Data.EntityVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|+|Vector|Hiperspace.Vector||||

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

## EntityImpl Togaf.Application.Component


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Implements|Togaf.Application.System||||
|+|Host|Togaf.Technology.Host||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Application.ComponentVectorSpace||||
|+|Principle|Togaf.Application.ComponentPrinciple||||
|+|Constraint|Togaf.Application.ComponentConstraint||||
|+|Assumption|Togaf.Application.ComponentAssumption||||
|+|Requirement|Togaf.Application.ComponentRequirement||||
|+|Location|Togaf.Application.ComponentLocation||||
|+|Gap|Togaf.Application.ComponentGap||||
|+|WorkPackage|Togaf.Application.ComponentWorkPackage||||
||ComponentUsage|Togaf.Data.Logical|||Component = this|
||DeployedBy|Togaf.Application.Deployed|||Deployes = this|
||SameName|Togaf.Application.Component|||Name = Name|

---

## EntityImpl Togaf.Application.Deployed


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Deployes|Togaf.Application.Component||||
|+|Host|Togaf.Technology.Instance||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Application.DeployedVectorSpace||||
|+|Principle|Togaf.Application.DeployedPrinciple||||
|+|Constraint|Togaf.Application.DeployedConstraint||||
|+|Assumption|Togaf.Application.DeployedAssumption||||
|+|Requirement|Togaf.Application.DeployedRequirement||||
|+|Location|Togaf.Application.DeployedLocation||||
|+|Gap|Togaf.Application.DeployedGap||||
|+|WorkPackage|Togaf.Application.DeployedWorkPackage||||
||Usage|Togaf.Data.Physical|||Deployed = this|
||SameName|Togaf.Application.Deployed|||Name = Name|

---

## SegmentImpl Togaf.Application.DeployedWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Application.DeployedGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Application.DeployedVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Application.ComponentWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Application.ComponentGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Application.ComponentVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Application.SystemWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Application.SystemGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Application.SystemVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|+|Vector|Hiperspace.Vector||||

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

## EntityImpl Togaf.Technology.Instance


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Host|Togaf.Technology.Host||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
|+|VectorSpace|Togaf.Technology.InstanceVectorSpace||||
|+|Principle|Togaf.Technology.InstancePrinciple||||
|+|Constraint|Togaf.Technology.InstanceConstraint||||
|+|Assumption|Togaf.Technology.InstanceAssumption||||
|+|Requirement|Togaf.Technology.InstanceRequirement||||
|+|Location|Togaf.Technology.InstanceLocation||||
|+|Gap|Togaf.Technology.InstanceGap||||
|+|WorkPackage|Togaf.Technology.InstanceWorkPackage||||
||Hosts|Togaf.Application.Deployed|||Host = this|
||SameName|Togaf.Technology.Instance|||Name = Name|

---

## SegmentImpl Togaf.Technology.InstanceWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Technology.InstanceGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstancePrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Technology.InstanceVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Technology.HostWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Technology.HostGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Technology.HostVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|+|Vector|Hiperspace.Vector||||

---

## SegmentImpl Togaf.Technology.PlatformWorkPackage


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge(this)|
||Goals|Some(HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|

---

## SegmentImpl Togaf.Technology.PlatformGap


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformLocation


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformRequirement


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformAssumption


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformPrinciple


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## AspectImpl Togaf.Technology.PlatformVectorSpace


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|+|Vector|Hiperspace.Vector||||

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

