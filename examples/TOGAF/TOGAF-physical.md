# TOGAF-physical
```mermaid
classDiagram
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
        + ComponentUsage (Component = ) : Togaf.Data.Logical
        + DeployedBy (Deployes = ) : Togaf.Application.Deployed
        + SameName (Name = Name) : Togaf.Application.Component
    }
    Togaf.Application.Component --> Togaf.Application.System
    Togaf.Application.Component --> Togaf.Technology.Host
    Togaf.Application.Component o-- Togaf.Application.ComponentPrinciple
    Togaf.Application.Component o-- Togaf.Application.ComponentConstraint
    Togaf.Application.Component o-- Togaf.Application.ComponentAssumption
    Togaf.Application.Component o-- Togaf.Application.ComponentRequirement
    Togaf.Application.Component o-- Togaf.Application.ComponentLocation
    Togaf.Application.Component o-- Togaf.Application.ComponentGap
    Togaf.Application.Component o-- Togaf.Application.ComponentWorkPackage
    class Togaf.Application.ComponentAssumption {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.ComponentConstraint {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.ComponentGap {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.ComponentLocation {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.ComponentPrinciple {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.ComponentRequirement {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.ComponentWorkPackage {
        # owner  : Togaf.Application.Component
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Usage (Deployed = ) : Togaf.Data.Physical
        + SameName (Name = Name) : Togaf.Application.Deployed
    }
    Togaf.Application.Deployed --> Togaf.Application.Component
    Togaf.Application.Deployed --> Togaf.Technology.Instance
    Togaf.Application.Deployed o-- Togaf.Application.DeployedPrinciple
    Togaf.Application.Deployed o-- Togaf.Application.DeployedConstraint
    Togaf.Application.Deployed o-- Togaf.Application.DeployedAssumption
    Togaf.Application.Deployed o-- Togaf.Application.DeployedRequirement
    Togaf.Application.Deployed o-- Togaf.Application.DeployedLocation
    Togaf.Application.Deployed o-- Togaf.Application.DeployedGap
    Togaf.Application.Deployed o-- Togaf.Application.DeployedWorkPackage
    class Togaf.Application.DeployedAssumption {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.DeployedConstraint {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.DeployedGap {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.DeployedLocation {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.DeployedPrinciple {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.DeployedRequirement {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.DeployedWorkPackage {
        # owner  : Togaf.Application.Deployed
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Application.System o-- Togaf.Application.SystemPrinciple
    Togaf.Application.System o-- Togaf.Application.SystemConstraint
    Togaf.Application.System o-- Togaf.Application.SystemAssumption
    Togaf.Application.System o-- Togaf.Application.SystemRequirement
    Togaf.Application.System o-- Togaf.Application.SystemLocation
    Togaf.Application.System o-- Togaf.Application.SystemGap
    Togaf.Application.System o-- Togaf.Application.SystemWorkPackage
    class Togaf.Application.SystemAssumption {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.SystemConstraint {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.SystemGap {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.SystemLocation {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.SystemPrinciple {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.SystemRequirement {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Application.SystemWorkPackage {
        # owner  : Togaf.Application.System
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
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
        + Before (After = ) : Togaf.Business.Activity
        + Originates (Originator = ) : Togaf.Data.Entity
        + SameName (Name = Name) : Togaf.Business.Activity
    }
    Togaf.Business.Activity --> Togaf.Business.Actor
    Togaf.Business.Activity --> Togaf.Business.Process
    Togaf.Business.Activity --> Togaf.Business.Event
    Togaf.Business.Activity --> Togaf.Service
    Togaf.Business.Activity o-- Togaf.Business.ActivityPrinciple
    Togaf.Business.Activity o-- Togaf.Business.ActivityConstraint
    Togaf.Business.Activity o-- Togaf.Business.ActivityAssumption
    Togaf.Business.Activity o-- Togaf.Business.ActivityRequirement
    Togaf.Business.Activity o-- Togaf.Business.ActivityLocation
    Togaf.Business.Activity o-- Togaf.Business.ActivityGap
    Togaf.Business.Activity o-- Togaf.Business.ActivityWorkPackage
    class Togaf.Business.ActivityAssumption {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActivityConstraint {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActivityGap {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActivityLocation {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActivityPrinciple {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActivityRequirement {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActivityWorkPackage {
        # owner  : Togaf.Business.Activity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Involved (Involves = ) : Togaf.Business.ValueStream
        + SameName (Name = Name) : Togaf.Business.Actor
    }
    Togaf.Business.Actor --> Togaf.Organization
    Togaf.Business.Actor o-- Togaf.Business.ActorPrinciple
    Togaf.Business.Actor o-- Togaf.Business.ActorConstraint
    Togaf.Business.Actor o-- Togaf.Business.ActorAssumption
    Togaf.Business.Actor o-- Togaf.Business.ActorRequirement
    Togaf.Business.Actor o-- Togaf.Business.ActorLocation
    Togaf.Business.Actor o-- Togaf.Business.ActorGap
    Togaf.Business.Actor o-- Togaf.Business.ActorWorkPackage
    Togaf.Business.Actor o-- Togaf.Has.Activity
    class Togaf.Business.ActorAssumption {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActorConstraint {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActorGap {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActorLocation {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActorPrinciple {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActorRequirement {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ActorWorkPackage {
        # owner  : Togaf.Business.Actor
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Business.Capability o-- Togaf.Business.CapabilityPrinciple
    Togaf.Business.Capability o-- Togaf.Business.CapabilityConstraint
    Togaf.Business.Capability o-- Togaf.Business.CapabilityAssumption
    Togaf.Business.Capability o-- Togaf.Business.CapabilityRequirement
    Togaf.Business.Capability o-- Togaf.Business.CapabilityLocation
    Togaf.Business.Capability o-- Togaf.Business.CapabilityGap
    Togaf.Business.Capability o-- Togaf.Business.CapabilityWorkPackage
    class Togaf.Business.CapabilityAssumption {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CapabilityConstraint {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CapabilityGap {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CapabilityLocation {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CapabilityPrinciple {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CapabilityRequirement {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CapabilityWorkPackage {
        # owner  : Togaf.Business.Capability
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Includes (PartOf = ) : Togaf.Business.Control
        + Governs (Governed = ) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.Control
    }
    Togaf.Business.Control o-- Togaf.Business.ControlPrinciple
    Togaf.Business.Control o-- Togaf.Business.ControlConstraint
    Togaf.Business.Control o-- Togaf.Business.ControlAssumption
    Togaf.Business.Control o-- Togaf.Business.ControlRequirement
    Togaf.Business.Control o-- Togaf.Business.ControlLocation
    Togaf.Business.Control o-- Togaf.Business.ControlGap
    Togaf.Business.Control o-- Togaf.Business.ControlWorkPackage
    class Togaf.Business.ControlAssumption {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ControlConstraint {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ControlGap {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ControlLocation {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ControlPrinciple {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ControlRequirement {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ControlWorkPackage {
        # owner  : Togaf.Business.Control
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionPrinciple
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionConstraint
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionAssumption
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionRequirement
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionLocation
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionGap
    Togaf.Business.CourseOfAction o-- Togaf.Business.CourseOfActionWorkPackage
    class Togaf.Business.CourseOfActionAssumption {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CourseOfActionConstraint {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CourseOfActionGap {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CourseOfActionLocation {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CourseOfActionPrinciple {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CourseOfActionRequirement {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.CourseOfActionWorkPackage {
        # owner  : Togaf.Business.CourseOfAction
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Creates (By = ) : Togaf.Business.Goal
        + SameName (Name = Name) : Togaf.Business.Driver
    }
    Togaf.Business.Driver --> Togaf.Organization
    Togaf.Business.Driver o-- Togaf.Business.DriverPrinciple
    Togaf.Business.Driver o-- Togaf.Business.DriverConstraint
    Togaf.Business.Driver o-- Togaf.Business.DriverAssumption
    Togaf.Business.Driver o-- Togaf.Business.DriverRequirement
    Togaf.Business.Driver o-- Togaf.Business.DriverLocation
    Togaf.Business.Driver o-- Togaf.Business.DriverGap
    Togaf.Business.Driver o-- Togaf.Business.DriverWorkPackage
    class Togaf.Business.DriverAssumption {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.DriverConstraint {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.DriverGap {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.DriverLocation {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.DriverPrinciple {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.DriverRequirement {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.DriverWorkPackage {
        # owner  : Togaf.Business.Driver
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Business.Event o-- Togaf.Business.EventPrinciple
    Togaf.Business.Event o-- Togaf.Business.EventConstraint
    Togaf.Business.Event o-- Togaf.Business.EventAssumption
    Togaf.Business.Event o-- Togaf.Business.EventRequirement
    Togaf.Business.Event o-- Togaf.Business.EventLocation
    Togaf.Business.Event o-- Togaf.Business.EventGap
    Togaf.Business.Event o-- Togaf.Business.EventWorkPackage
    class Togaf.Business.EventAssumption {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.EventConstraint {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.EventGap {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.EventLocation {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.EventPrinciple {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.EventRequirement {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.EventWorkPackage {
        # owner  : Togaf.Business.Event
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Business.Function o-- Togaf.Business.FunctionPrinciple
    Togaf.Business.Function o-- Togaf.Business.FunctionConstraint
    Togaf.Business.Function o-- Togaf.Business.FunctionAssumption
    Togaf.Business.Function o-- Togaf.Business.FunctionRequirement
    Togaf.Business.Function o-- Togaf.Business.FunctionLocation
    Togaf.Business.Function o-- Togaf.Business.FunctionGap
    Togaf.Business.Function o-- Togaf.Business.FunctionWorkPackage
    class Togaf.Business.FunctionAssumption {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.FunctionConstraint {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.FunctionGap {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.FunctionLocation {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.FunctionPrinciple {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.FunctionRequirement {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.FunctionWorkPackage {
        # owner  : Togaf.Business.Function
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + RealizedBy (For = ) : Togaf.Business.Objective
        + Follows (Leads = ) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Goal
    }
    Togaf.Business.Goal --> Togaf.Business.Driver
    Togaf.Business.Goal o-- Togaf.Business.GoalPrinciple
    Togaf.Business.Goal o-- Togaf.Business.GoalConstraint
    Togaf.Business.Goal o-- Togaf.Business.GoalAssumption
    Togaf.Business.Goal o-- Togaf.Business.GoalRequirement
    Togaf.Business.Goal o-- Togaf.Business.GoalLocation
    Togaf.Business.Goal o-- Togaf.Business.GoalGap
    Togaf.Business.Goal o-- Togaf.Business.GoalWorkPackage
    class Togaf.Business.GoalAssumption {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.GoalConstraint {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.GoalGap {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.GoalLocation {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.GoalPrinciple {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.GoalRequirement {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.GoalWorkPackage {
        # owner  : Togaf.Business.Goal
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Business.Measure o-- Togaf.Business.MeasurePrinciple
    Togaf.Business.Measure o-- Togaf.Business.MeasureConstraint
    Togaf.Business.Measure o-- Togaf.Business.MeasureAssumption
    Togaf.Business.Measure o-- Togaf.Business.MeasureRequirement
    Togaf.Business.Measure o-- Togaf.Business.MeasureLocation
    Togaf.Business.Measure o-- Togaf.Business.MeasureGap
    Togaf.Business.Measure o-- Togaf.Business.MeasureWorkPackage
    Togaf.Business.Measure o-- Togaf.History.Measure
    class Togaf.Business.MeasureAssumption {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.MeasureConstraint {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.MeasureGap {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.MeasureLocation {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.MeasurePrinciple {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.MeasureRequirement {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.MeasureWorkPackage {
        # owner  : Togaf.Business.Measure
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Measured (For = ) : Togaf.Business.Measure
        + SameName (Name = Name) : Togaf.Business.Objective
    }
    Togaf.Business.Objective --> Togaf.Business.Goal
    Togaf.Business.Objective o-- Togaf.Business.ObjectivePrinciple
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveConstraint
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveAssumption
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveRequirement
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveLocation
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveGap
    Togaf.Business.Objective o-- Togaf.Business.ObjectiveWorkPackage
    class Togaf.Business.ObjectiveAssumption {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ObjectiveConstraint {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ObjectiveGap {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ObjectiveLocation {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ObjectivePrinciple {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ObjectiveRequirement {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ObjectiveWorkPackage {
        # owner  : Togaf.Business.Objective
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
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
    Togaf.Business.Process --> Togaf.Business.Activity
    Togaf.Business.Process --> Togaf.Business.Capability
    Togaf.Business.Process --> Togaf.Business.Product
    Togaf.Business.Process --> Togaf.Business.Control
    Togaf.Business.Process --> Togaf.Business.ValueStream
    Togaf.Business.Process o-- Togaf.Business.ProcessPrinciple
    Togaf.Business.Process o-- Togaf.Business.ProcessConstraint
    Togaf.Business.Process o-- Togaf.Business.ProcessAssumption
    Togaf.Business.Process o-- Togaf.Business.ProcessRequirement
    Togaf.Business.Process o-- Togaf.Business.ProcessLocation
    Togaf.Business.Process o-- Togaf.Business.ProcessGap
    Togaf.Business.Process o-- Togaf.Business.ProcessWorkPackage
    class Togaf.Business.ProcessAssumption {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProcessConstraint {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProcessGap {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProcessLocation {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProcessPrinciple {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProcessRequirement {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProcessWorkPackage {
        # owner  : Togaf.Business.Process
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Business.Product o-- Togaf.Business.ProductPrinciple
    Togaf.Business.Product o-- Togaf.Business.ProductConstraint
    Togaf.Business.Product o-- Togaf.Business.ProductAssumption
    Togaf.Business.Product o-- Togaf.Business.ProductRequirement
    Togaf.Business.Product o-- Togaf.Business.ProductLocation
    Togaf.Business.Product o-- Togaf.Business.ProductGap
    Togaf.Business.Product o-- Togaf.Business.ProductWorkPackage
    class Togaf.Business.ProductAssumption {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProductConstraint {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProductGap {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProductLocation {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProductPrinciple {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProductRequirement {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ProductWorkPackage {
        # owner  : Togaf.Business.Product
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Children (Parent = ) : Togaf.Business.ValueStream
        + RealizedBy (Realizes = ) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.ValueStream
    }
    Togaf.Business.ValueStream --> Togaf.Business.Capability
    Togaf.Business.ValueStream --> Togaf.Business.Actor
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamPrinciple
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamConstraint
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamAssumption
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamRequirement
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamLocation
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamGap
    Togaf.Business.ValueStream o-- Togaf.Business.ValueStreamWorkPackage
    class Togaf.Business.ValueStreamAssumption {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ValueStreamConstraint {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ValueStreamGap {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ValueStreamLocation {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ValueStreamPrinciple {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ValueStreamRequirement {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Business.ValueStreamWorkPackage {
        # owner  : Togaf.Business.ValueStream
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
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
        + CubeDimensions () = cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + DrillDowns() () = drilldownEdges()
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
        + Logical (Encapsulate = ) : Togaf.Data.Logical
        + DataUsage (Entity = ) : Togaf.Data.Usage
        + SameName (Name = Name) : Togaf.Data.Entity
    }
    Togaf.Data.Entity --> Togaf.Business.Activity
    Togaf.Data.Entity --> Togaf.Service
    Togaf.Data.Entity o-- Togaf.Data.EntityPrinciple
    Togaf.Data.Entity o-- Togaf.Data.EntityConstraint
    Togaf.Data.Entity o-- Togaf.Data.EntityAssumption
    Togaf.Data.Entity o-- Togaf.Data.EntityRequirement
    Togaf.Data.Entity o-- Togaf.Data.EntityLocation
    Togaf.Data.Entity o-- Togaf.Data.EntityGap
    Togaf.Data.Entity o-- Togaf.Data.EntityWorkPackage
    class Togaf.Data.EntityAssumption {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.EntityConstraint {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.EntityGap {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.EntityLocation {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.EntityPrinciple {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.EntityRequirement {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.EntityWorkPackage {
        # owner  : Togaf.Data.Entity
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Instantiate (Instantiate = ) : Togaf.Data.Physical
        + SameName (Name = Name) : Togaf.Data.Logical
    }
    Togaf.Data.Logical --> Togaf.Data.Entity
    Togaf.Data.Logical --> Togaf.Application.Component
    Togaf.Data.Logical o-- Togaf.Data.LogicalPrinciple
    Togaf.Data.Logical o-- Togaf.Data.LogicalConstraint
    Togaf.Data.Logical o-- Togaf.Data.LogicalAssumption
    Togaf.Data.Logical o-- Togaf.Data.LogicalRequirement
    Togaf.Data.Logical o-- Togaf.Data.LogicalLocation
    Togaf.Data.Logical o-- Togaf.Data.LogicalGap
    Togaf.Data.Logical o-- Togaf.Data.LogicalWorkPackage
    class Togaf.Data.LogicalAssumption {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.LogicalConstraint {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.LogicalGap {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.LogicalLocation {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.LogicalPrinciple {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.LogicalRequirement {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.LogicalWorkPackage {
        # owner  : Togaf.Data.Logical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Data.Physical o-- Togaf.Data.PhysicalPrinciple
    Togaf.Data.Physical o-- Togaf.Data.PhysicalConstraint
    Togaf.Data.Physical o-- Togaf.Data.PhysicalAssumption
    Togaf.Data.Physical o-- Togaf.Data.PhysicalRequirement
    Togaf.Data.Physical o-- Togaf.Data.PhysicalLocation
    Togaf.Data.Physical o-- Togaf.Data.PhysicalGap
    Togaf.Data.Physical o-- Togaf.Data.PhysicalWorkPackage
    class Togaf.Data.PhysicalAssumption {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.PhysicalConstraint {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.PhysicalGap {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.PhysicalLocation {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.PhysicalPrinciple {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.PhysicalRequirement {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Data.PhysicalWorkPackage {
        # owner  : Togaf.Data.Physical
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + CubeDimensions () = cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + DrillDowns() () = drilldownEdges()
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
        + CubeDimensions () = cubedimensions(Host,Event,System,Service,Process,Product,Platform,Function,Capability,Organization)
        + DrillDowns() () = drilldownEdges()
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
    class Togaf.Has.Activity {
        # owner  : Togaf.Business.Actor
        # A  : Togaf.Business.Activity
        + Comment  : String
    }
    Togaf.Has.Activity --> Togaf.Business.Activity
    class Togaf.History.Measure {
        # owner  : Togaf.Business.Measure
        # At  : DateTime
        + Value  : Decimal
    }
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
    Togaf.Service o-- Togaf.ServicePrinciple
    Togaf.Service o-- Togaf.ServiceConstraint
    Togaf.Service o-- Togaf.ServiceAssumption
    Togaf.Service o-- Togaf.ServiceRequirement
    Togaf.Service o-- Togaf.ServiceLocation
    Togaf.Service o-- Togaf.ServiceGap
    Togaf.Service o-- Togaf.ServiceWorkPackage
    class Togaf.ServiceAssumption {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.ServiceConstraint {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.ServiceGap {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.ServiceLocation {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.ServicePrinciple {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.ServiceRequirement {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.ServiceWorkPackage {
        # owner  : Togaf.Service
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Technology.Host o-- Togaf.Technology.HostPrinciple
    Togaf.Technology.Host o-- Togaf.Technology.HostConstraint
    Togaf.Technology.Host o-- Togaf.Technology.HostAssumption
    Togaf.Technology.Host o-- Togaf.Technology.HostRequirement
    Togaf.Technology.Host o-- Togaf.Technology.HostLocation
    Togaf.Technology.Host o-- Togaf.Technology.HostGap
    Togaf.Technology.Host o-- Togaf.Technology.HostWorkPackage
    class Togaf.Technology.HostAssumption {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.HostConstraint {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.HostGap {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.HostLocation {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.HostPrinciple {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.HostRequirement {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.HostWorkPackage {
        # owner  : Togaf.Technology.Host
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
        + Hosts (Host = ) : Togaf.Application.Deployed
        + SameName (Name = Name) : Togaf.Technology.Instance
    }
    Togaf.Technology.Instance --> Togaf.Technology.Host
    Togaf.Technology.Instance o-- Togaf.Technology.InstancePrinciple
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceConstraint
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceAssumption
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceRequirement
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceLocation
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceGap
    Togaf.Technology.Instance o-- Togaf.Technology.InstanceWorkPackage
    class Togaf.Technology.InstanceAssumption {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.InstanceConstraint {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.InstanceGap {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.InstanceLocation {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.InstancePrinciple {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.InstanceRequirement {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.InstanceWorkPackage {
        # owner  : Togaf.Technology.Instance
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
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
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformPrinciple
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformConstraint
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformAssumption
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformRequirement
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformLocation
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformGap
    Togaf.Technology.Platform o-- Togaf.Technology.PlatformWorkPackage
    class Togaf.Technology.PlatformAssumption {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.PlatformConstraint {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.PlatformGap {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.PlatformLocation {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.PlatformPrinciple {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.PlatformRequirement {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
    }
    class Togaf.Technology.PlatformWorkPackage {
        # owner  : Togaf.Technology.Platform
        # Id  : Guid
        + Name  : String
        + Description  : String
        + Deleted  = false
        + ProjectKey  : String
        + ValidBase () = (((Id == null) || (Name == null)) ? false : true)
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## EntityImpl Togaf.Application.Component


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||ComponentUsage|Togaf.Data.Logical|||Component = |
||DeployedBy|Togaf.Application.Deployed|||Deployes = |
||SameName|Togaf.Application.Component|||Name = Name|

---

## SegmentImpl Togaf.Application.ComponentAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.ComponentWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Component||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Application.Deployed


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Usage|Togaf.Data.Physical|||Deployed = |
||SameName|Togaf.Application.Deployed|||Name = Name|

---

## SegmentImpl Togaf.Application.DeployedAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.DeployedWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.Deployed||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## SegmentImpl Togaf.Application.SystemAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Application.SystemWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Application.System||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.Activity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Before|Togaf.Business.Activity|||After = |
||Originates|Togaf.Data.Entity|||Originator = |
||SameName|Togaf.Business.Activity|||Name = Name|

---

## SegmentImpl Togaf.Business.ActivityAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActivityWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Activity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.Actor


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Involved|Togaf.Business.ValueStream|||Involves = |
||SameName|Togaf.Business.Actor|||Name = Name|

---

## SegmentImpl Togaf.Business.ActorAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ActorWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## SegmentImpl Togaf.Business.CapabilityAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CapabilityWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Capability||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.Control


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Includes|Togaf.Business.Control|||PartOf = |
||Governs|Togaf.Business.Process|||Governed = |
||SameName|Togaf.Business.Control|||Name = Name|

---

## SegmentImpl Togaf.Business.ControlAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ControlWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Control||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.CourseOfAction


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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

## SegmentImpl Togaf.Business.CourseOfActionAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.CourseOfActionWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.CourseOfAction||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.Driver


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Creates|Togaf.Business.Goal|||By = |
||SameName|Togaf.Business.Driver|||Name = Name|

---

## SegmentImpl Togaf.Business.DriverAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.DriverWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Driver||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## SegmentImpl Togaf.Business.EventAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.EventWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Event||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## SegmentImpl Togaf.Business.FunctionAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.FunctionWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Function||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.Goal


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||RealizedBy|Togaf.Business.Objective|||For = |
||Follows|Togaf.Business.CourseOfAction|||Leads = |
||SameName|Togaf.Business.Goal|||Name = Name|

---

## SegmentImpl Togaf.Business.GoalAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.GoalWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Goal||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.Measure


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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

## SegmentImpl Togaf.Business.MeasureAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasurePrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.MeasureWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.Objective


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Measured|Togaf.Business.Measure|||For = |
||SameName|Togaf.Business.Objective|||Name = Name|

---

## SegmentImpl Togaf.Business.ObjectiveAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectivePrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ObjectiveWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Objective||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## SegmentImpl Togaf.Business.ProcessAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProcessWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Process||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## SegmentImpl Togaf.Business.ProductAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ProductWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Product||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Business.ValueStream


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Children|Togaf.Business.ValueStream|||Parent = |
||RealizedBy|Togaf.Business.Process|||Realizes = |
||SameName|Togaf.Business.ValueStream|||Name = Name|

---

## SegmentImpl Togaf.Business.ValueStreamAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Business.ValueStreamWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.ValueStream||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## EntityImpl Togaf.Complexity_Fact


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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

## EntityImpl Togaf.Data.Entity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Logical|Togaf.Data.Logical|||Encapsulate = |
||DataUsage|Togaf.Data.Usage|||Entity = |
||SameName|Togaf.Data.Entity|||Name = Name|

---

## SegmentImpl Togaf.Data.EntityAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.EntityWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Entity||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Data.Logical


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Instantiate|Togaf.Data.Physical|||Instantiate = |
||SameName|Togaf.Data.Logical|||Name = Name|

---

## SegmentImpl Togaf.Data.LogicalAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.LogicalWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Logical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Data.Physical


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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

## SegmentImpl Togaf.Data.PhysicalAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Data.PhysicalWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Data.Physical||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Data.Usage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|#|Entity|Togaf.Data.Entity||||
|#|System|Togaf.Application.System||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|Comment|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||SameName|Togaf.Data.Usage|||Name = Name|

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

## EntityImpl Togaf.Financial.Cost_Fact


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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

## EntityImpl Togaf.Financial.Income_Fact


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
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

## SegmentImpl Togaf.Has.Activity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Actor||||
|#|A|Togaf.Business.Activity||||
|+|Comment|String||||

---

## SegmentImpl Togaf.History.Measure


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Business.Measure||||
|#|At|DateTime||||
|+|Value|Decimal||AlternateIndex(2216)||

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

## SegmentImpl Togaf.ServiceAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServicePrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.ServiceWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Service||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

## SegmentImpl Togaf.Technology.HostAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.HostWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Host||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## EntityImpl Togaf.Technology.Instance


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
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
||Hosts|Togaf.Application.Deployed|||Host = |
||SameName|Togaf.Technology.Instance|||Name = Name|

---

## SegmentImpl Togaf.Technology.InstanceAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstancePrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.InstanceWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Instance||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

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

---

## SegmentImpl Togaf.Technology.PlatformAssumption


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformConstraint


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformGap


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformLocation


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformPrinciple


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformRequirement


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## SegmentImpl Togaf.Technology.PlatformWorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Togaf.Technology.Platform||||
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
|+|ProjectKey|String||||
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|
||StrategicEdges|Some(global::System.Collections.Generic.HashSet<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(global::System.Collections.Generic.HashSet<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

