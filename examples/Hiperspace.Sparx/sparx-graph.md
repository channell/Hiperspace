# sparx
```mermaid
classDiagram
    class Graph.Route {
        # Name  : String
        + Rules  : HashSet~Graph.Rule~
    }
    class Graph.Rule {
        # FromType  : String
        # ToType  : String
        # EdgeType  : String
    }
    class Graph.HiperEdge {
        # From  : Node
        # To  : Node
        # TypeName  : String
        + Name  : String
        + Edge  : Edge
        + Source  : Graph.HiperEdge
        + Width  = 1
        + Length  = 1
    }
    class Sparx.PathMessage {
        # Node  : Node
        # Route  : Graph.Route
        # Length  : Int32
        # Targets  : HashSet~String~
        + Edges  : HashSet~Graph.HiperEdge~
    }
    class Sparx.Load.Tracking {
        # owner  : Any
        + When  : DateTime
    }
    class Sparx.EA.Resource {
        # Name  : String
        + Organisation  : String
        + Phone1  : String
        + Phone2  : String
        + Mobile  : String
        + Fax  : String
        + Email  : String
        + Roles  : String
        + Notes  : String
    }
    Sparx.EA.Resource ..|> Node
    class Sparx.EA.RoleConstraint {
        # owner  : Sparx.EA.Connector
        # Constraint  : String
        # ConnectorEnd  : String
        # ConstraintType  : String
        + Notes  : String
        + Deleted  = false
    }
    class Sparx.EA.OperationTag {
        # owner  : Sparx.EA.Operation
        # Id  : Int32
        + Property  : String
        + VALUE  : String
        + NOTES  : String
        + GUID  : String
        + Deleted  = false
    }
    class Sparx.EA.OperationPreCondition {
        # owner  : Sparx.EA.Operation
        # PreCondition  : String
        + Type  : String
        + Notes  : String
        + Deleted  = false
    }
    class Sparx.EA.OperationPostCondition {
        # owner  : Sparx.EA.Operation
        # PostCondition  : String
        + Type  : String
        + Notes  : String
        + Deleted  = false
    }
    class Sparx.EA.OperationParam {
        # owner  : Sparx.EA.Operation
        # Name  : String
        + Type  : String
        + Default  : String
        + Notes  : String
        + Pos  : Int32
        + Const  : Int32
        + Style  : String
        + Kind  : String
        + Classifier  : String
        + GUID  : String
        + StyleEx  : String
        + Deleted  = false
    }
    class Sparx.EA.Operation {
        # owner  : Sparx.EA.Element
        # Id  : Int32
        + Name  : String
        + Scope  : String
        + Type  : String
        + ReturnArray  : String
        + Stereotype  : String
        + IsStatic  : String
        + Concurrency  : String
        + Notes  : String
        + Behaviour  : String
        + Abstract  : String
        + GenOption  : String
        + Synchronized  : String
        + Pos  : Int32
        + Const  : Int32
        + Style  : String
        + Pure  : Int32
        + Throws  : String
        + Classifier  : String
        + Code  : String
        + IsRoot  : Int32
        + IsLeaf  : Int32
        + IsQuery  : Int32
        + StateFlags  : String
        + GUID  : String
        + StyleEx  : String
        + Deleted  = false
        + Parameters () : Sparx.EA.OperationParam
        + PostConditions () : Sparx.EA.OperationPostCondition
        + PreConditions () : Sparx.EA.OperationPreCondition
        + Tags () : Sparx.EA.OperationTag
    }
    Sparx.EA.Operation ..|> Node
    Sparx.EA.Operation ..|> Edge
    class Sparx.EA.ObjectTest {
        # owner  : Sparx.EA.Element
        # Test  : String
        # TestClass  : Int32
        + TestType  : String
        + Notes  : String
        + InputData  : String
        + AcceptanceCriteria  : String
        + Status  : String
        + DateRun  : DateTime
        + Results  : String
        + RunBy  : String
        + CheckBy  : String
        + Deleted  = false
    }
    class Sparx.EA.ObjectScenario {
        # owner  : Sparx.EA.Element
        # Scenario  : String
        + ScenarioType  : String
        + EValue  : Double
        + Notes  : String
        + XMLContent  : String
        + GUID  : String
        + Deleted  = false
    }
    class Sparx.EA.ObjectRisk {
        # owner  : Sparx.EA.Element
        # Risk  : String
        + RiskType  : String
        + EValue  : Double
        + Notes  : String
        + Deleted  = false
    }
    class Sparx.EA.ObjectResource {
        # owner  : Sparx.EA.Element
        # Resource  : Sparx.EA.Resource
        # Role  : String
        + Time  : Double
        + Notes  : String
        + PercentComplete  : Int16
        + DateStart  : DateTime
        + DateEnd  : DateTime
        + History  : String
        + ExpectedHours  : Int32
        + ActualHours  : Int32
        + Deleted  = false
    }
    Sparx.EA.ObjectResource ..|> Edge
    class Sparx.EA.ObjectRequire {
        # owner  : Sparx.EA.Element
        # Id  : Int32
        + Requirement  : String
        + ReqType  : String
        + Status  : String
        + Notes  : String
        + Stability  : String
        + Difficulty  : String
        + Priority  : String
        + LastUpdate  : DateTime
        + Deleted  = false
    }
    Sparx.EA.ObjectRequire ..|> Node
    Sparx.EA.ObjectRequire ..|> Edge
    class Sparx.EA.ObjectProperty {
        # owner  : Sparx.EA.Element
        # Id  : Int32
        + Property  : String
        + Value  : String
        + Notes  : String
        + GUID  : String
        + Deleted  = false
    }
    class Sparx.EA.ObjectProblem {
        # owner  : Sparx.EA.Element
        # Problem  : String
        # ProblemType  : String
        + DateReported  : DateTime
        + Status  : String
        + ProblemNotes  : String
        + ReportedBy  : String
        + ResolvedBy  : String
        + DateResolved  : DateTime
        + Version  : String
        + ResolverNotes  : String
        + Priority  : String
        + Severity  : String
        + Deleted  = false
    }
    class Sparx.EA.ObjectMetric {
        # owner  : Sparx.EA.Element
        # Metric  : String
        + MetricType  : String
        + EValue  : Double
        + Notes  : String
        + Deleted  = false
    }
    class Sparx.EA.ObjectFile {
        # owner  : Sparx.EA.Element
        # FileName  : String
        + Type  : String
        + Note  : String
        + FileSize  : String
        + FileDate  : String
        + Deleted  = false
    }
    class Sparx.EA.DiagramObject {
        # Diagram  : Sparx.EA.Diagram
        # Element  : Sparx.EA.Element
        + RectTop  : Int32
        + RectLeft  : Int32
        + RectRight  : Int32
        + RectBottom  : Int32
        + Sequence  : Int32
        + ObjectStyle  : String
        + Id  : Int32
        + Deleted  = false
    }
    Sparx.EA.DiagramObject ..|> Edge
    class Sparx.EA.DiagramLink {
        # Diagram  : Sparx.EA.Diagram
        # Connector  : Sparx.EA.Connector
        + Geometry  : String
        + Style  : String
        + Hidden  : Int32
        + Path  : String
        + Id  : Int32
        + Deleted  = false
    }
    class Sparx.EA.Diagram {
        # Id  : Int32
        + PackageId  : Int32
        + ParentID  : Int32
        + DiagramTypeCode  : String
        + Name  : String
        + Version  : String
        + Author  : String
        + ShowDetails  : Int32
        + Notes  : String
        + Stereotype  : String
        + AttPub  : Int32
        + AttPri  : Int32
        + AttPro  : Int32
        + Orientation  : String
        + cx  : Int32
        + cy  : Int32
        + Scale  : Int32
        + CreatedDate  : DateTime
        + ModifiedDate  : DateTime
        + HTMLPath  : String
        + ShowForeign  : Int32
        + ShowBorder  : Int32
        + ShowPackageContents  : Int32
        + PDATA  : String
        + Locked  : Int32
        + GUID  : String
        + TPos  : Int32
        + Swimlanes  : String
        + StyleEx  : String
        + Package  : Sparx.EA.Package
        + Deleted  = false
        + DiagramLinks (Diagram = this) : Sparx.EA.DiagramLink
        + Parts (Diagram = this) : Sparx.EA.DiagramObject
    }
    Sparx.EA.Diagram ..|> Node
    class Sparx.EA.ConnectorTag {
        # owner  : Sparx.EA.Connector
        # PropertyId  : Int32
        + Property  : String
        + Value  : String
        + Notes  : String
        + GUID  : String
        + Deleted  = false
    }
    class Sparx.EA.ConnectorConstraint {
        # owner  : Sparx.EA.Connector
        # Constraint  : String
        + ConstraintType  : String
        + Notes  : String
        + Deleted  = false
    }
    class Sparx.EA.ObjectEffort {
        # Effort  : String
        + EffortType  : String
        + EValue  : Double
        + Notes  : String
    }
    class Sparx.EA.ObjectConstraint {
        # Constraint  : String
        # ConstraintType  : String
        + Weight  : Double
        + Notes  : String
        + Status  : String
    }
    class Sparx.EA.Connector {
        # Id  : Int32
        + GUID  : String
        + StartElement  : Sparx.EA.Element
        + EndElement  : Sparx.EA.Element
        + Name  : String
        + Direction  : String
        + Notes  : String
        + ConnectorType  : String
        + SubType  : String
        + SourceCard  : String
        + SourceAccess  : String
        + SourceElement  : String
        + DestCard  : String
        + DestAccess  : String
        + DestElement  : String
        + SourceRole  : String
        + SourceRoleType  : String
        + SourceRoleNote  : String
        + SourceContainment  : String
        + SourceIsAggregate  : Int32
        + SourceIsOrdered  : Int32
        + SourceQualifier  : String
        + DestRole  : String
        + DestRoleType  : String
        + DestRoleNote  : String
        + DestContainment  : String
        + DestIsAggregate  : Int32
        + DestIsOrdered  : Int32
        + DestQualifier  : String
        + TopStartLabel  : String
        + TopMidLabel  : String
        + TopEndLabel  : String
        + BottomStartLabel  : String
        + BottomMidLabel  : String
        + BottomEndLabel  : String
        + StartEdge  : Int32
        + EndEdge  : Int32
        + PtStartX  : Int32
        + PtStartY  : Int32
        + PtEndX  : Int32
        + PtEndY  : Int32
        + SeqNo  : Int32
        + HeadStyle  : Int32
        + LineStyle  : Int32
        + RouteStyle  : Int32
        + IsBold  : Int32
        + LineColor  : Int32
        + Stereotype  : String
        + VirtualInheritance  : String
        + LinkAccess  : String
        + PDATA1  : String
        + PDATA2  : String
        + PDATA3  : String
        + PDATA4  : String
        + PDATA5  : String
        + DiagramID  : Int32
        + SourceConstraint  : String
        + DestConstraint  : String
        + SourceIsNavigable  : Int32
        + DestIsNavigable  : Int32
        + IsRoot  : Int32
        + IsLeaf  : Int32
        + IsSpec  : Int32
        + SourceChangeable  : String
        + DestChangeable  : String
        + SourceTS  : String
        + DestTS  : String
        + StateFlags  : String
        + ActionFlags  : String
        + IsSignal  : Int32
        + IsStimulus  : Int32
        + DispatchAction  : String
        + Target2  : Int32
        + StyleEx  : String
        + SourceStereotype  : String
        + DestStereotype  : String
        + SourceStyle  : String
        + DestStyle  : String
        + EventFlags  : String
        + Deleted  = false
        + Constraints () : Sparx.EA.ConnectorConstraint
        + Tags () : Sparx.EA.ConnectorTag
        + Links (Connector = this) : Sparx.EA.DiagramLink
        + RoleConstraints () : Sparx.EA.RoleConstraint
    }
    Sparx.EA.Connector ..|> Edge
    class Sparx.EA.AttributeTag {
        # PropertyId  : Int32
        + GUID  : String
        + Property  : String
        + VALUE  : String
        + Notes  : String
    }
    class Sparx.EA.AttributeConstraint {
        # Constraint  : String
        + AttName  : String
        + Type  : String
        + Notes  : String
    }
    class Sparx.EA.Attribute {
        # Id  : Int32
        + Element  : Sparx.EA.Element
        + Constraint  : HashSet~Sparx.EA.AttributeConstraint~
        + Tags  : HashSet~Sparx.EA.AttributeTag~
        + Name  : String
        + Scope  : String
        + Stereotype  : String
        + Containment  : String
        + IsStatic  : Int32
        + IsCollection  : Int32
        + IsOrdered  : Int32
        + AllowDuplicates  : Int32
        + LowerBound  : String
        + UpperBound  : String
        + Container  : String
        + Notes  : String
        + Derived  : String
        + Pos  : Int32
        + GenOption  : String
        + Length  : Int32
        + Precision  : Int32
        + Scale  : Int32
        + Const  : Int32
        + Style  : String
        + Classifier  : String
        + Default  : String
        + Type  : String
        + GUID  : String
        + StyleEx  : String
        + Deleted  = false
    }
    Sparx.EA.Attribute ..|> Node
    Sparx.EA.Attribute ..|> Edge
    class Sparx.EA.Package {
        # Id  : Int32
        + Name  : String
        + Parent  : Sparx.EA.Package
        + CreatedDate  : DateTime
        + ModifiedDate  : DateTime
        + Notes  : String
        + GUID  : String
        + XMLPath  : String
        + IsControlled  : Int32
        + LastLoadDate  : DateTime
        + LastSaveDate  : DateTime
        + Version  : String
        + Protected  : Int32
        + PkgOwner  : String
        + UMLVersion  : String
        + UseDTD  : Int32
        + LogXML  : Int32
        + CodePath  : String
        + Namespace  : String
        + TPos  : Int32
        + PackageFlags  : String
        + BatchSave  : Int32
        + BatchLoad  : Int32
        + Deleted  = false
        + Diagrams (Package = this) : Sparx.EA.Diagram
        + Content (Package = this) : Sparx.EA.Element
        + Children (Parent = this) : Sparx.EA.Package
        + Loaded () : Sparx.EA.PackageLoaded
    }
    Sparx.EA.Package ..|> Node
    Sparx.EA.Package ..|> Edge
    class Sparx.EA.Element {
        # Id  : Int32
        + GUID  : String
        + Package  : Sparx.EA.Package
        + Parent  : Sparx.EA.Element
        + ObjectType  : String
        + Diagram  : Sparx.EA.Diagram
        + Name  : String
        + Alias  : String
        + Author  : String
        + Version  : String
        + Note  : String
        + Stereotype  : String
        + NType  : Int32
        + Complexity  : String
        + Effort  : Int32
        + Style  : String
        + Backcolor  : Int32
        + BorderStyle  : Int32
        + BorderWidth  : Int32
        + Fontcolor  : Int32
        + Bordercolor  : Int32
        + CreatedDate  : DateTime
        + ModifiedDate  : DateTime
        + Status  : String
        + Abstract  : String
        + Tagged  : Int32
        + PDATA1  : String
        + PDATA2  : String
        + PDATA3  : String
        + PDATA4  : String
        + PDATA5  : String
        + Concurrency  : String
        + Visibility  : String
        + Persistence  : String
        + Cardinality  : String
        + GenType  : String
        + GenFile  : String
        + Header1  : String
        + Header2  : String
        + Phase  : String
        + Scope  : String
        + GenOption  : String
        + GenLinks  : String
        + Classifier  : Int32
        + RunState  : String
        + Classifier_GUID  : String
        + TPos  : Int32
        + IsRoot  : Int32
        + IsLeaf  : Int32
        + IsSpec  : Int32
        + IsActive  : Int32
        + StateFlags  : String
        + PackageFlags  : String
        + Multiplicity  : String
        + StyleEx  : String
        + EventFlags  : String
        + ActionFlags  : String
        + Efforts  : HashSet~Sparx.EA.ObjectEffort~
        + Constraints  : HashSet~Sparx.EA.ObjectConstraint~
        + Deleted  = false
        + Valid  = ((((Name == null) || (ObjectType == null)) || (Package == null)) ? false : true)
        + StartConnectors (StartElement = this) : Sparx.EA.Connector
        + EndConnectors (EndElement = this) : Sparx.EA.Connector
        + Attributes (Element = this) : Sparx.EA.Attribute
        + Links (Element = this) : Sparx.EA.DiagramObject
        + Files () : Sparx.EA.ObjectFile
        + Metrics () : Sparx.EA.ObjectMetric
        + Problems () : Sparx.EA.ObjectProblem
        + Properties () : Sparx.EA.ObjectProperty
        + Requirements () : Sparx.EA.ObjectRequire
        + Resources () : Sparx.EA.ObjectResource
        + Risks () : Sparx.EA.ObjectRisk
        + Scenarios () : Sparx.EA.ObjectScenario
        + Tests () : Sparx.EA.ObjectTest
        + Operations () : Sparx.EA.Operation
        + Children (Parent = this) : Sparx.EA.Element
        + Loaded () : Sparx.EA.ElementLoaded
    }
    Sparx.EA.Element ..|> Node
    Sparx.EA.Element ..|> Edge
    Sparx.EA.Element ..|> Sparx.EA.Graph.ElementEdge
    class Sparx.EA.ElementLoaded {
        # owner  : Sparx.EA.Element
        + When  : DateTime
    }
    class Sparx.EA.PackageLoaded {
        # owner  : Sparx.EA.Package
        + When  : DateTime
    }
    class Sparx.EA.Graph.ElementEdge {
        # Element  : Sparx.EA.Element
        + Parent  : Sparx.EA.Element
    }
    Sparx.EA.Graph.ElementEdge ..|> Edge
    class Index.Element {
        # Name  : String
        + EName (Name = Name) : Sparx.EA.Element
    }
```

---

## Value Graph.Route
Route across a graph of edge/node to form an HiperEdge

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||||
|+|Rules|HashSet<Graph.Rule>||||

---

## Value Graph.Rule
A rule for a route that matched as a type of Edge to a HiperEdge, e.g. { Name = 'relation', Rules = [{FromType = 'Person', ToType = 'Person', EdgeType = 'Mother'}]}

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|FromType|String||||
|#|ToType|String||||
|#|EdgeType|String||||

---

## View Graph.HiperEdge
Path from one Node to another Node over a number of routes

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|From|Node||||
|#|To|Node||||
|#|TypeName|String||||
|+|Name|String||||
|+|Edge|Edge|The Edge that provides the end of this Path|||
|+|Source|Graph.HiperEdge|The shortest source Path that this path extends|||
||Width|Some(Int32)|The number of distict paths between the Nodes||1|
||Length|Some(Int32)|The shortest number of Edges in the Path||1|

---

## Message Sparx.PathMessage
Remote execution of path requests

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Node|Node||||
|#|Route|Graph.Route||||
|#|Length|Int32||||
|#|Targets|HashSet<String>||||
|+|Edges|HashSet<Graph.HiperEdge>||||

---

## View Sparx.Load.Tracking
when was the item loaded

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|+|When|DateTime||||

---

## EntityImpl Sparx.EA.Resource


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||Key(), StringLength(255)||
|+|Organisation|String||StringLength(255)||
|+|Phone1|String||StringLength(50)||
|+|Phone2|String||StringLength(50)||
|+|Mobile|String||StringLength(50)||
|+|Fax|String||StringLength(50)||
|+|Email|String||StringLength(255)||
|+|Roles|String||StringLength(255)||
|+|Notes|String||StringLength(255)||

---

## SegmentImpl Sparx.EA.RoleConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Connector||||
|#|Constraint|String||Column()||
|#|ConnectorEnd|String||Column()||
|#|ConstraintType|String||Column()||
|+|Notes|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.OperationTag
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Operation||||
|#|Id|Int32||||
|+|Property|String||StringLength(255)||
|+|VALUE|String||StringLength(255)||
|+|NOTES|String||Column()||
|+|GUID|String||StringLength(40), Column("ea_guid")||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.OperationPreCondition
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Operation||||
|#|PreCondition|String||Column(), StringLength(255)||
|+|Type|String||StringLength(50)||
|+|Notes|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.OperationPostCondition
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Operation||||
|#|PostCondition|String||Column(), StringLength(255)||
|+|Type|String||StringLength(255)||
|+|Notes|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.OperationParam
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Operation||||
|#|Name|String||Column(), StringLength(255)||
|+|Type|String||StringLength(255)||
|+|Default|String||StringLength(255)||
|+|Notes|String||Column()||
|+|Pos|Int32||||
|+|Const|Int32||||
|+|Style|String||StringLength(255)||
|+|Kind|String||StringLength(12)||
|+|Classifier|String||StringLength(50)||
|+|GUID|String||StringLength(50), Column("ea_guid")||
|+|StyleEx|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.Operation
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Id|Int32||||
|+|Name|String||StringLength(255)||
|+|Scope|String||StringLength(50)||
|+|Type|String||StringLength(255)||
|+|ReturnArray|String||StringLength(1)||
|+|Stereotype|String||StringLength(50)||
|+|IsStatic|String||StringLength(1)||
|+|Concurrency|String||StringLength(50)||
|+|Notes|String||Column()||
|+|Behaviour|String||Column()||
|+|Abstract|String||StringLength(1)||
|+|GenOption|String||Column()||
|+|Synchronized|String||StringLength(1)||
|+|Pos|Int32||||
|+|Const|Int32||||
|+|Style|String||StringLength(255)||
|+|Pure|Int32||||
|+|Throws|String||StringLength(255)||
|+|Classifier|String||StringLength(50)||
|+|Code|String||Column()||
|+|IsRoot|Int32||||
|+|IsLeaf|Int32||||
|+|IsQuery|Int32||||
|+|StateFlags|String||StringLength(255)||
|+|GUID|String||StringLength(50), Column("ea_guid")||
|+|StyleEx|String||Column()||
||Deleted|Some(Boolean)|||false|
|+|Parameters|Sparx.EA.OperationParam||||
|+|PostConditions|Sparx.EA.OperationPostCondition||||
|+|PreConditions|Sparx.EA.OperationPreCondition||||
|+|Tags|Sparx.EA.OperationTag||||

---

## SegmentImpl Sparx.EA.ObjectTest
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Test|String||||
|#|TestClass|Int32||||
|+|TestType|String||StringLength(50)||
|+|Notes|String||Column()||
|+|InputData|String||Column()||
|+|AcceptanceCriteria|String||Column()||
|+|Status|String||StringLength(32)||
|+|DateRun|DateTime||||
|+|Results|String||Column()||
|+|RunBy|String||StringLength(255)||
|+|CheckBy|String||StringLength(255)||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectScenario
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Scenario|String||||
|+|ScenarioType|String||StringLength(12)||
|+|EValue|Double||||
|+|Notes|String||Column()||
|+|XMLContent|String||Column()||
|+|GUID|String||StringLength(40), Column("ea_guid")||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectRisk
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Risk|String||||
|+|RiskType|String||StringLength(12)||
|+|EValue|Double||||
|+|Notes|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectResource
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Resource|Sparx.EA.Resource||||
|#|Role|String||||
|+|Time|Double||||
|+|Notes|String||Column()||
|+|PercentComplete|Int16||||
|+|DateStart|DateTime||||
|+|DateEnd|DateTime||||
|+|History|String||Column()||
|+|ExpectedHours|Int32||||
|+|ActualHours|Int32||||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectRequire
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Id|Int32||Key(), Column("ReqID")||
|+|Requirement|String||StringLength(255)||
|+|ReqType|String||StringLength(255)||
|+|Status|String||StringLength(50)||
|+|Notes|String||Column()||
|+|Stability|String||StringLength(50)||
|+|Difficulty|String||StringLength(50)||
|+|Priority|String||StringLength(50)||
|+|LastUpdate|DateTime||||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectProperty
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Id|Int32||Key(), Column("PropertyID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
|+|Property|String||StringLength(255)||
|+|Value|String||StringLength(255)||
|+|Notes|String||Column()||
|+|GUID|String||StringLength(40), Column("ea_guid")||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectProblem
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Problem|String||Column(), StringLength(255)||
|#|ProblemType|String||Column(), StringLength(255)||
|+|DateReported|DateTime||||
|+|Status|String||StringLength(50)||
|+|ProblemNotes|String||Column()||
|+|ReportedBy|String||StringLength(255)||
|+|ResolvedBy|String||StringLength(255)||
|+|DateResolved|DateTime||||
|+|Version|String||StringLength(50)||
|+|ResolverNotes|String||Column()||
|+|Priority|String||StringLength(50)||
|+|Severity|String||StringLength(50)||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectMetric
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|Metric|String||Column(), StringLength(255)||
|+|MetricType|String||StringLength(12)||
|+|EValue|Double||Column()||
|+|Notes|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ObjectFile
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|#|FileName|String||Column(), StringLength(255)||
|+|Type|String||StringLength(50)||
|+|Note|String||Column()||
|+|FileSize|String||StringLength(255)||
|+|FileDate|String||StringLength(255)||
||Deleted|Some(Boolean)|||false|

---

## EntityImpl Sparx.EA.DiagramObject


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Diagram|Sparx.EA.Diagram||||
|#|Element|Sparx.EA.Element||||
|+|RectTop|Int32||||
|+|RectLeft|Int32||||
|+|RectRight|Int32||||
|+|RectBottom|Int32||||
|+|Sequence|Int32||||
|+|ObjectStyle|String||StringLength(255)||
|+|Id|Int32||||
||Deleted|Some(Boolean)|||false|

---

## EntityImpl Sparx.EA.DiagramLink


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Diagram|Sparx.EA.Diagram||||
|#|Connector|Sparx.EA.Connector||||
|+|Geometry|String||||
|+|Style|String||StringLength(255)||
|+|Hidden|Int32||||
|+|Path|String||StringLength(255)||
|+|Id|Int32||Key(), Column("Instance_ID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
||Deleted|Some(Boolean)|||false|

---

## EntityImpl Sparx.EA.Diagram


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||Key(), Column("Diagram_ID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
|+|PackageId|Int32||Column("Package_ID")||
|+|ParentID|Int32||||
|+|DiagramTypeCode|String||StringLength(50), Column("Diagram_Type")||
|+|Name|String||StringLength(255)||
|+|Version|String||StringLength(50)||
|+|Author|String||StringLength(255)||
|+|ShowDetails|Int32||||
|+|Notes|String||Column()||
|+|Stereotype|String||StringLength(50)||
|+|AttPub|Int32||||
|+|AttPri|Int32||||
|+|AttPro|Int32||||
|+|Orientation|String||StringLength(1)||
|+|cx|Int32||||
|+|cy|Int32||||
|+|Scale|Int32||||
|+|CreatedDate|DateTime||||
|+|ModifiedDate|DateTime||||
|+|HTMLPath|String||StringLength(255)||
|+|ShowForeign|Int32||||
|+|ShowBorder|Int32||||
|+|ShowPackageContents|Int32||||
|+|PDATA|String||StringLength(255)||
|+|Locked|Int32||||
|+|GUID|String||StringLength(40), Column("ea_guid")||
|+|TPos|Int32||||
|+|Swimlanes|String||StringLength(255)||
|+|StyleEx|String||Column()||
|+|Package|Sparx.EA.Package||||
||Deleted|Some(Boolean)|||false|
||DiagramLinks|Sparx.EA.DiagramLink||NotMapped()|Diagram = this|
||Parts|Sparx.EA.DiagramObject||NotMapped()|Diagram = this|

---

## SegmentImpl Sparx.EA.ConnectorTag


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Connector||||
|#|PropertyId|Int32||Key(), Column("PropertyID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
|+|Property|String||StringLength(255)||
|+|Value|String||StringLength(255), Column("VALUE")||
|+|Notes|String||Column("NOTES")||
|+|GUID|String||StringLength(40), Column("ea_guid")||
||Deleted|Some(Boolean)|||false|

---

## SegmentImpl Sparx.EA.ConnectorConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Connector||||
|#|Constraint|String||||
|+|ConstraintType|String||StringLength(50)||
|+|Notes|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## Value Sparx.EA.ObjectEffort


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Effort|String||KeyAttribute(), Column(), StringLength(255)||
|+|EffortType|String||StringLength(12)||
|+|EValue|Double||||
|+|Notes|String||Column()||

---

## Value Sparx.EA.ObjectConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Constraint|String||StringLength(255)||
|#|ConstraintType|String||StringLength(30)||
|+|Weight|Double||||
|+|Notes|String||Column()||
|+|Status|String||StringLength(50)||

---

## EntityImpl Sparx.EA.Connector


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||Key(), Column("Connector_ID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
|+|GUID|String||StringLength(40), Column("ea_guid")||
|+|StartElement|Sparx.EA.Element||||
|+|EndElement|Sparx.EA.Element||||
|+|Name|String||StringLength(255)||
|+|Direction|String||StringLength(50)||
|+|Notes|String||Column()||
|+|ConnectorType|String||StringLength(50), Column("Connector_Type")||
|+|SubType|String||StringLength(50)||
|+|SourceCard|String||StringLength(50)||
|+|SourceAccess|String||StringLength(50)||
|+|SourceElement|String||StringLength(50)||
|+|DestCard|String||StringLength(50)||
|+|DestAccess|String||StringLength(50)||
|+|DestElement|String||StringLength(50)||
|+|SourceRole|String||StringLength(50)||
|+|SourceRoleType|String||StringLength(50)||
|+|SourceRoleNote|String||Column()||
|+|SourceContainment|String||StringLength(50)||
|+|SourceIsAggregate|Int32||||
|+|SourceIsOrdered|Int32||||
|+|SourceQualifier|String||StringLength(50)||
|+|DestRole|String||StringLength(255)||
|+|DestRoleType|String||StringLength(50)||
|+|DestRoleNote|String||Column()||
|+|DestContainment|String||StringLength(50)||
|+|DestIsAggregate|Int32||||
|+|DestIsOrdered|Int32||||
|+|DestQualifier|String||StringLength(50)||
|+|TopStartLabel|String||StringLength(50), Column("Top_Start_Label")||
|+|TopMidLabel|String||StringLength(50), Column("Top_Mid_Label")||
|+|TopEndLabel|String||StringLength(50), Column("Top_End_Label")||
|+|BottomStartLabel|String||StringLength(50), Column("Btm_Start_Label")||
|+|BottomMidLabel|String||StringLength(50), Column("Btm_Mid_Label")||
|+|BottomEndLabel|String||StringLength(50), Column("Btm_End_Label")||
|+|StartEdge|Int32||Column("Start_Edge")||
|+|EndEdge|Int32||Column("End_Edge")||
|+|PtStartX|Int32||||
|+|PtStartY|Int32||||
|+|PtEndX|Int32||||
|+|PtEndY|Int32||||
|+|SeqNo|Int32||||
|+|HeadStyle|Int32||||
|+|LineStyle|Int32||||
|+|RouteStyle|Int32||||
|+|IsBold|Int32||||
|+|LineColor|Int32||||
|+|Stereotype|String||StringLength(50)||
|+|VirtualInheritance|String||StringLength(1)||
|+|LinkAccess|String||StringLength(50)||
|+|PDATA1|String||StringLength(255)||
|+|PDATA2|String||Column()||
|+|PDATA3|String||StringLength(255)||
|+|PDATA4|String||StringLength(255)||
|+|PDATA5|String||Column()||
|+|DiagramID|Int32||||
|+|SourceConstraint|String||StringLength(255)||
|+|DestConstraint|String||StringLength(255)||
|+|SourceIsNavigable|Int32||||
|+|DestIsNavigable|Int32||||
|+|IsRoot|Int32||||
|+|IsLeaf|Int32||||
|+|IsSpec|Int32||||
|+|SourceChangeable|String||StringLength(12)||
|+|DestChangeable|String||StringLength(12)||
|+|SourceTS|String||StringLength(12)||
|+|DestTS|String||StringLength(12)||
|+|StateFlags|String||StringLength(255)||
|+|ActionFlags|String||StringLength(255)||
|+|IsSignal|Int32||||
|+|IsStimulus|Int32||||
|+|DispatchAction|String||StringLength(255)||
|+|Target2|Int32||||
|+|StyleEx|String||Column()||
|+|SourceStereotype|String||StringLength(255)||
|+|DestStereotype|String||StringLength(255)||
|+|SourceStyle|String||Column()||
|+|DestStyle|String||Column()||
|+|EventFlags|String||StringLength(255)||
||Deleted|Some(Boolean)|||false|
|+|Constraints|Sparx.EA.ConnectorConstraint||NotMapped()||
|+|Tags|Sparx.EA.ConnectorTag||NotMapped()||
||Links|Sparx.EA.DiagramLink||NotMapped()|Connector = this|
|+|RoleConstraints|Sparx.EA.RoleConstraint||NotMapped()||

---

## Value Sparx.EA.AttributeTag


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|PropertyId|Int32||KeyAttribute(), Column("PropertyID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
|+|GUID|String||StringLength(40), Column("ea_guid")||
|+|Property|String||StringLength(255)||
|+|VALUE|String||StringLength(255), Column("VALUE")||
|+|Notes|String||Column("NOTES")||

---

## Value Sparx.EA.AttributeConstraint


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Constraint|String||StringLength(255)||
|+|AttName|String||StringLength(255)||
|+|Type|String||StringLength(255)||
|+|Notes|String||Column()||

---

## EntityImpl Sparx.EA.Attribute


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||Key(), DatabaseGenerated(DatabaseGeneratedOption?.Identity), Column("ID")||
|+|Element|Sparx.EA.Element||||
|+|Constraint|HashSet<Sparx.EA.AttributeConstraint>||NotMapped(), JsonIgnore()||
|+|Tags|HashSet<Sparx.EA.AttributeTag>||NotMapped()||
|+|Name|String||StringLength(255)||
|+|Scope|String||StringLength(50)||
|+|Stereotype|String||StringLength(50)||
|+|Containment|String||StringLength(50)||
|+|IsStatic|Int32||||
|+|IsCollection|Int32||||
|+|IsOrdered|Int32||||
|+|AllowDuplicates|Int32||||
|+|LowerBound|String||StringLength(50)||
|+|UpperBound|String||StringLength(50)||
|+|Container|String||StringLength(50)||
|+|Notes|String||Column()||
|+|Derived|String||StringLength(1)||
|+|Pos|Int32||||
|+|GenOption|String||Column()||
|+|Length|Int32||||
|+|Precision|Int32||||
|+|Scale|Int32||||
|+|Const|Int32||||
|+|Style|String||StringLength(255)||
|+|Classifier|String||StringLength(50)||
|+|Default|String||Column()||
|+|Type|String||StringLength(255)||
|+|GUID|String||StringLength(50), Column("ea_guid")||
|+|StyleEx|String||Column()||
||Deleted|Some(Boolean)|||false|

---

## EntityImpl Sparx.EA.Package


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32||Key(), Column("Package_ID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
|+|Name|String||StringLength(255)||
|+|Parent|Sparx.EA.Package||||
|+|CreatedDate|DateTime||||
|+|ModifiedDate|DateTime||||
|+|Notes|String||Column()||
|+|GUID|String||StringLength(40), Column("ea_guid")||
|+|XMLPath|String||StringLength(255)||
|+|IsControlled|Int32||||
|+|LastLoadDate|DateTime||||
|+|LastSaveDate|DateTime||||
|+|Version|String||StringLength(50)||
|+|Protected|Int32||||
|+|PkgOwner|String||StringLength(255)||
|+|UMLVersion|String||StringLength(50)||
|+|UseDTD|Int32||||
|+|LogXML|Int32||||
|+|CodePath|String||StringLength(255)||
|+|Namespace|String||StringLength(50)||
|+|TPos|Int32||||
|+|PackageFlags|String||StringLength(255)||
|+|BatchSave|Int32||||
|+|BatchLoad|Int32||||
||Deleted|Some(Boolean)|||false|
||Diagrams|Sparx.EA.Diagram|||Package = this|
||Content|Sparx.EA.Element|||Package = this|
||Children|Sparx.EA.Package|||Parent = this|
|+|Loaded|Sparx.EA.PackageLoaded||NotMapped()||

---

## EntityImpl Sparx.EA.Element
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Id|Int32|Unique global key within a model|Key(), Column("Object_ID"), DatabaseGenerated(DatabaseGeneratedOption?.Identity)||
|+|GUID|String|GUID is used form XMI export/import to identify an elements independent of the database it is currently stored in|StringLength(40), Column("ea_guid")||
|+|Package|Sparx.EA.Package||||
|+|Parent|Sparx.EA.Element||||
|+|ObjectType|String|UML type of the element|StringLength(255), Column("Object_Type")||
|+|Diagram|Sparx.EA.Diagram|composite disgram that explains the element|||
|+|Name|String|Name of the element displayed without parameters|StringLength(255)||
|+|Alias|String|for tables, that can be the shortend name for implementation|StringLength(255)||
|+|Author|String||StringLength(255)||
|+|Version|String||StringLength(50)||
|+|Note|String|long textual description|Column()||
|+|Stereotype|String|table, struct, etc|StringLength(255)||
|+|NType|Int32||||
|+|Complexity|String||StringLength(50)||
|+|Effort|Int32||||
|+|Style|String||StringLength(255)||
|+|Backcolor|Int32||||
|+|BorderStyle|Int32||||
|+|BorderWidth|Int32||||
|+|Fontcolor|Int32||||
|+|Bordercolor|Int32||||
|+|CreatedDate|DateTime||||
|+|ModifiedDate|DateTime||||
|+|Status|String||StringLength(50)||
|+|Abstract|String||StringLength(1)||
|+|Tagged|Int32||||
|+|PDATA1|String||StringLength(255)||
|+|PDATA2|String||Column()||
|+|PDATA3|String||Column()||
|+|PDATA4|String||Column()||
|+|PDATA5|String||StringLength(255)||
|+|Concurrency|String||StringLength(50)||
|+|Visibility|String||StringLength(50)||
|+|Persistence|String||StringLength(50)||
|+|Cardinality|String||StringLength(50)||
|+|GenType|String||StringLength(50)||
|+|GenFile|String||StringLength(255)||
|+|Header1|String||Column()||
|+|Header2|String||Column()||
|+|Phase|String||StringLength(50)||
|+|Scope|String||StringLength(25)||
|+|GenOption|String||Column()||
|+|GenLinks|String||Column()||
|+|Classifier|Int32||||
|+|RunState|String||Column()||
|+|Classifier_GUID|String||StringLength(40)||
|+|TPos|Int32||||
|+|IsRoot|Int32||||
|+|IsLeaf|Int32||||
|+|IsSpec|Int32||||
|+|IsActive|Int32||||
|+|StateFlags|String||StringLength(255)||
|+|PackageFlags|String||StringLength(255)||
|+|Multiplicity|String||StringLength(50)||
|+|StyleEx|String||Column()||
|+|EventFlags|String||Column()||
|+|ActionFlags|String||StringLength(255)||
|+|Efforts|HashSet<Sparx.EA.ObjectEffort>|witin a sparx database this is seperate table, but here it is a set fo values for demonstration|NotMapped()||
|+|Constraints|HashSet<Sparx.EA.ObjectConstraint>|witin a sparx database this is seperate table, but here it is a set fo values for demonstration|NotMapped()||
||Deleted|Some(Boolean)|    Tombstone, to indicate the the latest update to this element was to delete it.    This field is initialised when bound to a subspace if it does not already have a value    ||false|
||Valid|Some(Boolean)|check constraints that name and object type have values and refers to a valid package|NotMapped()|((((Name == null) || (ObjectType == null)) || (Package == null)) ? false : true)|
||StartConnectors|Sparx.EA.Connector|    connections to 'Connector' objects where this Element is the StartElement.    Note: this will create an index (alternate key) in Connector set to navigate from Element    |NotMapped()|StartElement = this|
||EndConnectors|Sparx.EA.Connector||NotMapped()|EndElement = this|
||Attributes|Sparx.EA.Attribute||NotMapped()|Element = this|
||Links|Sparx.EA.DiagramObject||NotMapped()|Element = this|
|+|Files|Sparx.EA.ObjectFile||NotMapped()||
|+|Metrics|Sparx.EA.ObjectMetric|Metrics is a segment of Element that can be updated without chnaging the full element|NotMapped()||
|+|Problems|Sparx.EA.ObjectProblem||NotMapped()||
|+|Properties|Sparx.EA.ObjectProperty||NotMapped()||
|+|Requirements|Sparx.EA.ObjectRequire||NotMapped()||
|+|Resources|Sparx.EA.ObjectResource||NotMapped()||
|+|Risks|Sparx.EA.ObjectRisk||NotMapped()||
|+|Scenarios|Sparx.EA.ObjectScenario||NotMapped()||
|+|Tests|Sparx.EA.ObjectTest||NotMapped()||
|+|Operations|Sparx.EA.Operation||NotMapped()||
||Children|Sparx.EA.Element||NotMapped()|Parent = this|
|+|Loaded|Sparx.EA.ElementLoaded||NotMapped()||

---

## AspectImpl Sparx.EA.ElementLoaded
 All elements in a Sparx model are stored seperately

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Element||||
|+|When|DateTime||||

---

## AspectImpl Sparx.EA.PackageLoaded


||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|owner|Sparx.EA.Package||||
|+|When|DateTime||||

---

## View Sparx.EA.Graph.ElementEdge
 Additional Edge for Element structure

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Element|Sparx.EA.Element||||
|+|Parent|Sparx.EA.Element||||

---

## EntityImpl Index.Element
Index of <b>Element</b> by name - existence of this entity adds the index

||Name|Type|*|@|=|
|-|-|-|-|-|-|
|#|Name|String||||
||EName|Sparx.EA.Element|||Name = Name|

