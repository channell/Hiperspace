# TOGAF
```mermaid
classDiagram
    class Hiperspace.Edge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
    }
    class Graph.HiperEdge {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # TypeName  : String
        + Name  : String
        + Edge  : Hiperspace.Edge
        + Source  : Graph.HiperEdge
        + Width  = 1
        + Length  = 1
    }
    class Hiperspace.Node {
        # SKey  : String
        + TypeName  : String
        + Name  : String
        + Froms (From = ) : Hiperspace.Edge
        + Tos (To = ) : Hiperspace.Edge
    }
    class Togaf.Application.Component {
        + Implements  : Togaf.Application.System
        + Host  : Togaf.Technology.Host
        + ComponentUsage (Component = ) : Togaf.Data.Logical
        + DeployedBy (Deployes = ) : Togaf.Application.Deployed
        + SameName (Name = Name) : Togaf.Application.Component
    }
    Togaf.Application.Component --|> Togaf.General.Base
    Togaf.Application.Component --> Togaf.Application.System
    Togaf.Application.Component --> Togaf.Technology.Host
    Togaf.Application.Component ..|> Hiperspace.Node
    Togaf.Application.Component ..|> Togaf.Edges
    class Togaf.Application.Deployed {
        + Deployes  : Togaf.Application.Component
        + Host  : Togaf.Technology.Instance
        + Usage (Deployed = ) : Togaf.Data.Physical
        + SameName (Name = Name) : Togaf.Application.Deployed
    }
    Togaf.Application.Deployed --|> Togaf.General.Base
    Togaf.Application.Deployed --> Togaf.Application.Component
    Togaf.Application.Deployed --> Togaf.Technology.Instance
    Togaf.Application.Deployed ..|> Hiperspace.Node
    Togaf.Application.Deployed ..|> Togaf.Edges
    class Togaf.Application.System {
        + Realizes  : Togaf.Service
        + Platform  : Togaf.Technology.Platform
        + SystemUsage (System = ) : Togaf.Data.Usage
        + ImplementedBy (Implements = ) : Togaf.Application.Component
        + SameName (Name = Name) : Togaf.Application.System
    }
    Togaf.Application.System --|> Togaf.General.Base
    Togaf.Application.System --> Togaf.Service
    Togaf.Application.System --> Togaf.Technology.Platform
    Togaf.Application.System ..|> Hiperspace.Node
    Togaf.Application.System ..|> Togaf.Edges
    class Togaf.Business.Activity {
        + By  : Togaf.Business.Actor
        + Type  : Togaf.Business.ActivityType
        + After  : Togaf.Business.Activity
        + Part  : Togaf.Business.Process
        + Event  : Togaf.Business.Event
        + Uses  : Togaf.Service
        + Before (After = ) : Togaf.Business.Activity
        + Originates (Originator = ) : Togaf.Data.Entity
        + SameName (Name = Name) : Togaf.Business.Activity
    }
    Togaf.Business.Activity --|> Togaf.General.Base
    Togaf.Business.Activity --> Togaf.Business.Actor
    Togaf.Business.Activity --> Togaf.Business.ActivityType
    Togaf.Business.Activity --> Togaf.Business.Process
    Togaf.Business.Activity --> Togaf.Business.Event
    Togaf.Business.Activity --> Togaf.Service
    Togaf.Business.Activity ..|> Hiperspace.Node
    Togaf.Business.Activity ..|> Togaf.Edges
    class Togaf.Business.ActivityType {
        Task = 1
        Decision = 2
        Event = 3
    }
    class Togaf.Business.Actor {
        + In  : Togaf.Organization
        + Performs () : Togaf.Has.Activity
        + Involved (Involves = ) : Togaf.Business.ValueStream
        + SameName (Name = Name) : Togaf.Business.Actor
    }
    Togaf.Business.Actor --|> Togaf.General.Base
    Togaf.Business.Actor --> Togaf.Organization
    Togaf.Business.Actor o-- Togaf.Has.Activity
    Togaf.Business.Actor ..|> Hiperspace.Node
    Togaf.Business.Actor ..|> Togaf.Edges
    class Togaf.Business.Capability {
        + By  : Togaf.Organization
        + Parent  : Togaf.Business.Capability
        + Children (Parent = ) : Togaf.Business.Capability
        + Operated (Operates = ) : Togaf.Business.Process
        + Delivered (Delivers = ) : Togaf.Business.Function
        + EnabledBy (Enables = ) : Togaf.Business.ValueStream
        + Related (Enables = ) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Capability
    }
    Togaf.Business.Capability --|> Togaf.General.Base
    Togaf.Business.Capability --> Togaf.Organization
    Togaf.Business.Capability ..|> Hiperspace.Node
    Togaf.Business.Capability ..|> Togaf.Edges
    class Togaf.Business.Control {
        + URL  : String
        + PartOf  : Togaf.Business.Control
        + Includes (PartOf = ) : Togaf.Business.Control
        + Governs (Governed = ) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.Control
    }
    Togaf.Business.Control --|> Togaf.General.Base
    Togaf.Business.Control ..|> Hiperspace.Node
    Togaf.Business.Control ..|> Togaf.Edges
    class Togaf.Business.CourseOfAction {
        + URL  : String
        + Enables  : Togaf.Business.Capability
        + Leads  : Togaf.Business.Goal
        + Involves  : Togaf.Business.Function
        + SameName (Name = Name) : Togaf.Business.CourseOfAction
    }
    Togaf.Business.CourseOfAction --|> Togaf.General.Base
    Togaf.Business.CourseOfAction --> Togaf.Business.Capability
    Togaf.Business.CourseOfAction --> Togaf.Business.Goal
    Togaf.Business.CourseOfAction --> Togaf.Business.Function
    Togaf.Business.CourseOfAction ..|> Hiperspace.Node
    Togaf.Business.CourseOfAction ..|> Togaf.Edges
    class Togaf.Business.Driver {
        + MotivatedBy  : Togaf.Organization
        + Creates (By = ) : Togaf.Business.Goal
        + SameName (Name = Name) : Togaf.Business.Driver
    }
    Togaf.Business.Driver --|> Togaf.General.Base
    Togaf.Business.Driver --> Togaf.Organization
    Togaf.Business.Driver ..|> Hiperspace.Node
    Togaf.Business.Driver ..|> Togaf.Edges
    class Togaf.Business.Event {
        + Type  : Togaf.Business.EventType
        + Trigger  : Togaf.Service
        + Activities (Event = ) : Togaf.Business.Activity
        + SameName (Name = Name) : Togaf.Business.Event
    }
    Togaf.Business.Event --|> Togaf.General.Base
    Togaf.Business.Event --> Togaf.Business.EventType
    Togaf.Business.Event --> Togaf.Service
    Togaf.Business.Event ..|> Hiperspace.Node
    Togaf.Business.Event ..|> Togaf.Edges
    class Togaf.Business.EventType {
        Start = 1
        End = 2
        Intermediate = 3
    }
    class Togaf.Business.Function {
        + For  : Togaf.Organization
        + Parent  : Togaf.Business.Function
        + Delivers  : Togaf.Business.Capability
        + Children (Parent = ) : Togaf.Business.Function
        + Orchestrates (Decomposes = ) : Togaf.Business.Process
        + Involves (Involves = ) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Function
    }
    Togaf.Business.Function --|> Togaf.General.Base
    Togaf.Business.Function --> Togaf.Organization
    Togaf.Business.Function --> Togaf.Business.Capability
    Togaf.Business.Function ..|> Hiperspace.Node
    Togaf.Business.Function ..|> Togaf.Edges
    class Togaf.Business.Goal {
        + By  : Togaf.Business.Driver
        + RealizedBy (For = ) : Togaf.Business.Objective
        + Follows (Leads = ) : Togaf.Business.CourseOfAction
        + SameName (Name = Name) : Togaf.Business.Goal
    }
    Togaf.Business.Goal --|> Togaf.General.Base
    Togaf.Business.Goal --> Togaf.Business.Driver
    Togaf.Business.Goal ..|> Hiperspace.Node
    Togaf.Business.Goal ..|> Togaf.Edges
    class Togaf.Business.Measure {
        + For  : Togaf.Business.Objective
        + Unit  : String
        + Tracks  : Togaf.Service
        + Observation () : Togaf.History.Measure
        + SameName (Name = Name) : Togaf.Business.Measure
    }
    Togaf.Business.Measure --|> Togaf.General.Base
    Togaf.Business.Measure --> Togaf.Business.Objective
    Togaf.Business.Measure --> Togaf.Service
    Togaf.Business.Measure o-- Togaf.History.Measure
    Togaf.Business.Measure ..|> Hiperspace.Node
    Togaf.Business.Measure ..|> Togaf.Edges
    class Togaf.Business.Objective {
        + For  : Togaf.Business.Goal
        + Measured (For = ) : Togaf.Business.Measure
        + SameName (Name = Name) : Togaf.Business.Objective
    }
    Togaf.Business.Objective --|> Togaf.General.Base
    Togaf.Business.Objective --> Togaf.Business.Goal
    Togaf.Business.Objective ..|> Hiperspace.Node
    Togaf.Business.Objective ..|> Togaf.Edges
    class Togaf.Business.Process {
        + Decomposes  : Togaf.Business.Function
        + Starts  : Togaf.Business.Activity
        + Operates  : Togaf.Business.Capability
        + Provides  : Togaf.Business.Product
        + Governed  : Togaf.Business.Control
        + Realizes  : Togaf.Business.ValueStream
        + Steps (Part = ) : Togaf.Business.Activity
        + SameName (Name = Name) : Togaf.Business.Process
    }
    Togaf.Business.Process --|> Togaf.General.Base
    Togaf.Business.Process --> Togaf.Business.Function
    Togaf.Business.Process --> Togaf.Business.Activity
    Togaf.Business.Process --> Togaf.Business.Capability
    Togaf.Business.Process --> Togaf.Business.Product
    Togaf.Business.Process --> Togaf.Business.Control
    Togaf.Business.Process --> Togaf.Business.ValueStream
    Togaf.Business.Process ..|> Hiperspace.Node
    Togaf.Business.Process ..|> Togaf.Edges
    class Togaf.Business.Product {
        + By  : Togaf.Organization
        + Parent  : Togaf.Business.Product
        + Children (Parent = ) : Togaf.Business.Product
        + ProvidedBy (Provides = ) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.Product
    }
    Togaf.Business.Product --|> Togaf.General.Base
    Togaf.Business.Product --> Togaf.Organization
    Togaf.Business.Product ..|> Hiperspace.Node
    Togaf.Business.Product ..|> Togaf.Edges
    class Togaf.Business.ValueStream {
        + URL  : String
        + Parent  : Togaf.Business.ValueStream
        + Enables  : Togaf.Business.Capability
        + Involves  : Togaf.Business.Actor
        + Children (Parent = ) : Togaf.Business.ValueStream
        + RealizedBy (Realizes = ) : Togaf.Business.Process
        + SameName (Name = Name) : Togaf.Business.ValueStream
    }
    Togaf.Business.ValueStream --|> Togaf.General.Base
    Togaf.Business.ValueStream --> Togaf.Business.Capability
    Togaf.Business.ValueStream --> Togaf.Business.Actor
    Togaf.Business.ValueStream ..|> Hiperspace.Node
    Togaf.Business.ValueStream ..|> Togaf.Edges
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
        + E  : Decimal
        + N  : Decimal
        + P  : Decimal
        + M () = ((E - N) + (2 * P))
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
    Togaf.Complexity ..|> Hiperspace.Node
    class Togaf.Data.Entity {
        + Originator  : Togaf.Business.Activity
        + Provider  : Togaf.Service
        + Logical (Encapsulate = ) : Togaf.Data.Logical
        + DataUsage (Entity = ) : Togaf.Data.Usage
        + SameName (Name = Name) : Togaf.Data.Entity
    }
    Togaf.Data.Entity --|> Togaf.General.Base
    Togaf.Data.Entity --> Togaf.Business.Activity
    Togaf.Data.Entity --> Togaf.Service
    Togaf.Data.Entity ..|> Hiperspace.Node
    Togaf.Data.Entity ..|> Togaf.Edges
    class Togaf.Data.Logical {
        + Encapsulate  : Togaf.Data.Entity
        + Component  : Togaf.Application.Component
        + Instantiate (Instantiate = ) : Togaf.Data.Physical
        + SameName (Name = Name) : Togaf.Data.Logical
    }
    Togaf.Data.Logical --|> Togaf.General.Base
    Togaf.Data.Logical --> Togaf.Data.Entity
    Togaf.Data.Logical --> Togaf.Application.Component
    Togaf.Data.Logical ..|> Hiperspace.Node
    Togaf.Data.Logical ..|> Togaf.Edges
    class Togaf.Data.Physical {
        + Instantiate  : Togaf.Data.Logical
        + Deployed  : Togaf.Application.Deployed
        + SameName (Name = Name) : Togaf.Data.Physical
    }
    Togaf.Data.Physical --|> Togaf.General.Base
    Togaf.Data.Physical --> Togaf.Data.Logical
    Togaf.Data.Physical --> Togaf.Application.Deployed
    Togaf.Data.Physical ..|> Hiperspace.Node
    Togaf.Data.Physical ..|> Togaf.Edges
    class Togaf.Data.Usage {
        # Entity  : Togaf.Data.Entity
        # System  : Togaf.Application.System
        + Comment  : String
        + SameName (Name = Name) : Togaf.Data.Usage
    }
    Togaf.Data.Usage --|> Togaf.Base
    Togaf.Data.Usage --> Togaf.Data.Entity
    Togaf.Data.Usage --> Togaf.Application.System
    Togaf.Data.Usage ..|> Hiperspace.Node
    Togaf.Data.Usage ..|> Togaf.Edges
    class Togaf.Edges {
        # From  : Hiperspace.Node
        # To  : Hiperspace.Node
        # FromTypeName  : String
        # ToTypeName  : String
        + Name  : String
    }
    Togaf.Edges ..|> Hiperspace.Edge
    class Togaf.GoalRef {
        + Value  : Togaf.Business.Goal
    }
    Togaf.GoalRef --> Togaf.Business.Goal
    class Togaf.Has.Activity {
        + Comment  : String
    }
    Togaf.Has.Activity --|> ManyActivity
    Togaf.Has.Activity ..|> Togaf.Edges
    class Togaf.Has.WorkPackage {
        + ProjectKey  : String
        + StrategicEdges () = StrategicEdge()
        + Goals () = Goals(StrategicEdges)
        + Project () = externalnode(ProjectKey)
    }
    Togaf.Has.WorkPackage --|> Togaf.Base
    Togaf.Has.WorkPackage ..|> Hiperspace.Node
    Togaf.Has.WorkPackage ..|> Hiperspace.Edge
    Togaf.Has.WorkPackage ..|> Togaf.Edges
    Togaf.Has.WorkPackage ..|> Graph.HiperEdge
    class Togaf.History.Measure {
        # At  : DateTime
        + Value  : Decimal
    }
    Togaf.History.Measure ..|> Hiperspace.Node
    Togaf.History.Measure ..|> Hiperspace.Edge
    class Togaf.Organization {
        + Parent  : Togaf.Organization
        + Children (Parent = ) : Togaf.Organization
        + Motivates (MotivatedBy = ) : Togaf.Business.Driver
        + Contains (In = ) : Togaf.Business.Actor
        + Functions (For = ) : Togaf.Business.Function
        + Uses (By = ) : Togaf.Business.Capability
        + Produces (By = ) : Togaf.Business.Product
        + Governs (OwnedBy = ) : Togaf.Service
        + SameName (Name = Name) : Togaf.Organization
    }
    Togaf.Organization --|> Togaf.Base
    Togaf.Organization ..|> Hiperspace.Node
    Togaf.Organization ..|> Togaf.Edges
    class Togaf.Service {
        + OwnedBy  : Togaf.Organization
        + Measures (Tracks = ) : Togaf.Business.Measure
        + Triggers (Trigger = ) : Togaf.Business.Event
        + UsedBy (Uses = ) : Togaf.Business.Activity
        + Provides (Provider = ) : Togaf.Data.Entity
        + ProvidedBy (Realizes = ) : Togaf.Application.System
        + SameName (Name = Name) : Togaf.Service
    }
    Togaf.Service --|> Togaf.General.Base
    Togaf.Service --> Togaf.Organization
    Togaf.Service ..|> Hiperspace.Node
    Togaf.Service ..|> Togaf.Edges
    class Togaf.Technology.Host {
        + Platform  : Togaf.Technology.Platform
        + Hosts (Host = ) : Togaf.Application.Component
        + Instances (Host = ) : Togaf.Technology.Instance
    }
    Togaf.Technology.Host --|> Togaf.General.Base
    Togaf.Technology.Host --> Togaf.Technology.Platform
    Togaf.Technology.Host ..|> Hiperspace.Node
    Togaf.Technology.Host ..|> Togaf.Edges
    class Togaf.Technology.Instance {
        + Host  : Togaf.Technology.Host
        + Hosts (Host = ) : Togaf.Application.Deployed
        + SameName (Name = Name) : Togaf.Technology.Instance
    }
    Togaf.Technology.Instance --|> Togaf.General.Base
    Togaf.Technology.Instance --> Togaf.Technology.Host
    Togaf.Technology.Instance ..|> Hiperspace.Node
    Togaf.Technology.Instance ..|> Togaf.Edges
    class Togaf.Technology.Platform {
        + Serves  : Togaf.Service
        + Hosts (Platform = ) : Togaf.Application.System
        + Defines (Platform = ) : Togaf.Technology.Host
        + SameName (Name = Name) : Togaf.Technology.Platform
    }
    Togaf.Technology.Platform --|> Togaf.General.Base
    Togaf.Technology.Platform --> Togaf.Service
    Togaf.Technology.Platform ..|> Hiperspace.Node
    Togaf.Technology.Platform ..|> Togaf.Edges
```
> The tables below contain descriptions of the members of each Element. 
> The first column indicates the type of the member:
> A ‘#’ indicates that the field is a key to the element, and a ‘+’ indicates that the field is a value.
> The ‘*’ column contains a description for the element member.  
> The ‘@’ column contains any properties for the member.
> The ‘=’ column contains calculated values; or in the case of an enum, the serialized value.

---

## View Hiperspace.Edge
edge between nodes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||

---

## View Graph.HiperEdge
Path from one Node to another Node over a number of routes

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|TypeName|String||||
|+|Name|String||||
|+|Edge|Hiperspace.Edge|The Edge that provides the end of this Path|||
|+|Source|Graph.HiperEdge|The shortest source Path that this path extends|||
||Width|Some(Int32)|The number of distict paths between the Nodes||1|
||Length|Some(Int32)|The shortest number of Edges in the Path||1|

---

## View Hiperspace.Node
node in a graph view of data

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|SKey|String||||
|+|TypeName|String||||
|+|Name|String||||
||Froms|Hiperspace.Edge|||From = |
||Tos|Hiperspace.Edge|||To = |

---

## Entity Togaf.Application.Component


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Implements|Togaf.Application.System||||
|+|Host|Togaf.Technology.Host||||
||ComponentUsage|Togaf.Data.Logical|||Component = |
||DeployedBy|Togaf.Application.Deployed|||Deployes = |
||SameName|Togaf.Application.Component|||Name = Name|

---

## Entity Togaf.Application.Deployed


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Deployes|Togaf.Application.Component||||
|+|Host|Togaf.Technology.Instance||||
||Usage|Togaf.Data.Physical|||Deployed = |
||SameName|Togaf.Application.Deployed|||Name = Name|

---

## Entity Togaf.Application.System


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Realizes|Togaf.Service||||
|+|Platform|Togaf.Technology.Platform||||
||SystemUsage|Togaf.Data.Usage|||System = |
||ImplementedBy|Togaf.Application.Component|||Implements = |
||SameName|Togaf.Application.System|||Name = Name|

---

## Type Togaf.Base


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Guid||||
|+|Name|String||AlternateIndex("""Togaf.Data.Usage""", 1757), AlternateIndex("""Togaf.Organization""", 19), AlternateIndex("""Togaf.Service""", 1328)||
|+|Description|String||||
||Deleted|Some(Boolean)|||false|
||ValidBase|Some(Boolean)|||(((Id == null) \|\| (Name == null)) ? false : true)|

---

## Entity Togaf.Business.Activity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|By|Togaf.Business.Actor||||
|+|Type|Togaf.Business.ActivityType||||
|+|After|Togaf.Business.Activity||||
|+|Part|Togaf.Business.Process||||
|+|Event|Togaf.Business.Event||||
|+|Uses|Togaf.Service||||
||Before|Togaf.Business.Activity|||After = |
||Originates|Togaf.Data.Entity|||Originator = |
||SameName|Togaf.Business.Activity|||Name = Name|

---

## Enum Togaf.Business.ActivityType


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Task|Int32|||1|
||Decision|Int32|||2|
||Event|Int32|||3|

---

## Entity Togaf.Business.Actor


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|In|Togaf.Organization||AlternateIndex()||
|+|Performs|Togaf.Has.Activity||||
||Involved|Togaf.Business.ValueStream|||Involves = |
||SameName|Togaf.Business.Actor|||Name = Name|

---

## Entity Togaf.Business.Capability


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|By|Togaf.Organization||||
|+|Parent|Togaf.Business.Capability||||
||Children|Togaf.Business.Capability|||Parent = |
||Operated|Togaf.Business.Process|||Operates = |
||Delivered|Togaf.Business.Function|||Delivers = |
||EnabledBy|Togaf.Business.ValueStream|||Enables = |
||Related|Togaf.Business.CourseOfAction|||Enables = |
||SameName|Togaf.Business.Capability|||Name = Name|

---

## Entity Togaf.Business.Control


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URL|String||||
|+|PartOf|Togaf.Business.Control||||
||Includes|Togaf.Business.Control|||PartOf = |
||Governs|Togaf.Business.Process|||Governed = |
||SameName|Togaf.Business.Control|||Name = Name|

---

## Entity Togaf.Business.CourseOfAction


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URL|String||||
|+|Enables|Togaf.Business.Capability||||
|+|Leads|Togaf.Business.Goal||||
|+|Involves|Togaf.Business.Function||||
||SameName|Togaf.Business.CourseOfAction|||Name = Name|

---

## Entity Togaf.Business.Driver


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|MotivatedBy|Togaf.Organization||AlternateIndex()||
||Creates|Togaf.Business.Goal|||By = |
||SameName|Togaf.Business.Driver|||Name = Name|

---

## Entity Togaf.Business.Event


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Type|Togaf.Business.EventType||||
|+|Trigger|Togaf.Service||||
||Activities|Togaf.Business.Activity|||Event = |
||SameName|Togaf.Business.Event|||Name = Name|

---

## Enum Togaf.Business.EventType


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
||Start|Int32|||1|
||End|Int32|||2|
||Intermediate|Int32|||3|

---

## Entity Togaf.Business.Function


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|For|Togaf.Organization||AlternateIndex()||
|+|Parent|Togaf.Business.Function||||
|+|Delivers|Togaf.Business.Capability||||
||Children|Togaf.Business.Function|||Parent = |
||Orchestrates|Togaf.Business.Process|||Decomposes = |
||Involves|Togaf.Business.CourseOfAction|||Involves = |
||SameName|Togaf.Business.Function|||Name = Name|

---

## Entity Togaf.Business.Goal


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|By|Togaf.Business.Driver||||
||RealizedBy|Togaf.Business.Objective|||For = |
||Follows|Togaf.Business.CourseOfAction|||Leads = |
||SameName|Togaf.Business.Goal|||Name = Name|

---

## Entity Togaf.Business.Measure


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|For|Togaf.Business.Objective||||
|+|Unit|String||||
|+|Tracks|Togaf.Service||||
|+|Observation|Togaf.History.Measure||||
||SameName|Togaf.Business.Measure|||Name = Name|

---

## Entity Togaf.Business.Objective


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|For|Togaf.Business.Goal||||
||Measured|Togaf.Business.Measure|||For = |
||SameName|Togaf.Business.Objective|||Name = Name|

---

## Entity Togaf.Business.Process


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Decomposes|Togaf.Business.Function||||
|+|Starts|Togaf.Business.Activity||||
|+|Operates|Togaf.Business.Capability||||
|+|Provides|Togaf.Business.Product||||
|+|Governed|Togaf.Business.Control||||
|+|Realizes|Togaf.Business.ValueStream||||
||Steps|Togaf.Business.Activity|||Part = |
||SameName|Togaf.Business.Process|||Name = Name|

---

## Entity Togaf.Business.Product


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|By|Togaf.Organization||||
|+|Parent|Togaf.Business.Product||||
||Children|Togaf.Business.Product|||Parent = |
||ProvidedBy|Togaf.Business.Process|||Provides = |
||SameName|Togaf.Business.Product|||Name = Name|

---

## Entity Togaf.Business.ValueStream


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|URL|String||||
|+|Parent|Togaf.Business.ValueStream||||
|+|Enables|Togaf.Business.Capability||||
|+|Involves|Togaf.Business.Actor||||
||Children|Togaf.Business.ValueStream|||Parent = |
||RealizedBy|Togaf.Business.Process|||Realizes = |
||SameName|Togaf.Business.ValueStream|||Name = Name|

---

## Entity Togaf.Complexity


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
|+|E|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|N|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|P|Decimal||CubeMeasure(Aggregate?.Sum)||
||M|Some(Decimal)||CubeExtent()|((E - N) + (2 * P))|

---

## Entity Togaf.Data.Entity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Originator|Togaf.Business.Activity||||
|+|Provider|Togaf.Service||||
||Logical|Togaf.Data.Logical|||Encapsulate = |
||DataUsage|Togaf.Data.Usage|||Entity = |
||SameName|Togaf.Data.Entity|||Name = Name|

---

## Entity Togaf.Data.Logical


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Encapsulate|Togaf.Data.Entity||||
|+|Component|Togaf.Application.Component||||
||Instantiate|Togaf.Data.Physical|||Instantiate = |
||SameName|Togaf.Data.Logical|||Name = Name|

---

## Entity Togaf.Data.Physical


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Instantiate|Togaf.Data.Logical||||
|+|Deployed|Togaf.Application.Deployed||||
||SameName|Togaf.Data.Physical|||Name = Name|

---

## Entity Togaf.Data.Usage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Entity|Togaf.Data.Entity||||
|#|System|Togaf.Application.System||||
|+|Comment|String||||
||SameName|Togaf.Data.Usage|||Name = Name|

---

## View Togaf.Edges
Bidirectional Edge, implemented with two Togaf.Edges

| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Hiperspace.Node||||
|#|To|Hiperspace.Node||||
|#|FromTypeName|String||||
|#|ToTypeName|String||||
|+|Name|String||||

---

## Type Togaf.Financial.Allocation


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
|+|RevX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|CapX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|OpeX|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|Hours|Int64||CubeMeasure(Aggregate?.Sum)||

---

## Type Togaf.General.Base


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Principle|Togaf.Has.Principle||||
|+|Constraint|Togaf.Has.Constraint||||
|+|Assumption|Togaf.Has.Assumption||||
|+|Requirement|Togaf.Has.Requirement||||
|+|Location|Togaf.Has.Location||||
|+|Gap|Togaf.Has.Gap||||
|+|WorkPackage|Togaf.Has.WorkPackage||||

---

## Value Togaf.GoalRef


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Value|Togaf.Business.Goal||||

---

## Segment Togaf.Has.Activity


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Comment|String||||

---

## Segment Togaf.Has.WorkPackage


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|ProjectKey|String||||
||StrategicEdges|Some(Set<Graph.HiperEdge>)|All Togaf.Edges that can be projected as Transitative Togaf.Edges to a Business Goal|Once()|StrategicEdge()|
||Goals|Some(Set<Togaf.GoalRef>)|||Goals(StrategicEdges)|
||Project|Some(Hiperspace.Node)|||externalnode(ProjectKey)|

---

## Segment Togaf.History.Measure


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|At|DateTime||||
|+|Value|Decimal||AlternateIndex(2216)||

---

## Entity Togaf.Organization


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Parent|Togaf.Organization||AlternateIndex()||
||Children|Togaf.Organization|||Parent = |
||Motivates|Togaf.Business.Driver|||MotivatedBy = |
||Contains|Togaf.Business.Actor|||In = |
||Functions|Togaf.Business.Function|||For = |
||Uses|Togaf.Business.Capability|||By = |
||Produces|Togaf.Business.Product|||By = |
||Governs|Togaf.Service|||OwnedBy = |
||SameName|Togaf.Organization|||Name = Name|

---

## Entity Togaf.Service


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|OwnedBy|Togaf.Organization||||
||Measures|Togaf.Business.Measure|||Tracks = |
||Triggers|Togaf.Business.Event|||Trigger = |
||UsedBy|Togaf.Business.Activity|||Uses = |
||Provides|Togaf.Data.Entity|||Provider = |
||ProvidedBy|Togaf.Application.System|||Realizes = |
||SameName|Togaf.Service|||Name = Name|

---

## Entity Togaf.Technology.Host


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Platform|Togaf.Technology.Platform||||
||Hosts|Togaf.Application.Component|||Host = |
||Instances|Togaf.Technology.Instance|||Host = |

---

## Entity Togaf.Technology.Instance


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Host|Togaf.Technology.Host||||
||Hosts|Togaf.Application.Deployed|||Host = |
||SameName|Togaf.Technology.Instance|||Name = Name|

---

## Entity Togaf.Technology.Platform


| |Name|Type|*|@|=|
|-|-|-|-|-|-|
|+|Serves|Togaf.Service||||
||Hosts|Togaf.Application.System|||Platform = |
||Defines|Togaf.Technology.Host|||Platform = |
||SameName|Togaf.Technology.Platform|||Name = Name|

