# readme
```mermaid
classDiagram
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
    class Plan.PathMessage {
        # Node  : Node
        # Route  : Graph.Route
        # Length  : Int32
        # Targets  : HashSet~String~
        + Edges  : HashSet~Graph.HiperEdge~
    }
    Plan.PathMessage *-- Graph.Route
    Plan.PathMessage *-- String
    Plan.PathMessage *-- Graph.HiperEdge
    class Plan.Duration {
        + Start  : DateTime
        + End  : DateTime
        + Valid  = ((Start ~= End) ? true : false)
        + Time () = hours(End,Start)
    }
    class Plan.Project {
        # Id  : Guid
        + Deleted  = false
        + Name  : String
        + Description  : String
        + WBS  : String
        + Duration  : Plan.Duration
        + Valid  = (((Name == null) || (Duration == null)) ? false : true)
        + Timesheet_Cube (CubeSlice = "52", Project = this, ContextLabel = contextlabel(this)) : Booking.Timesheet_Cube
        + Task_Cube (CubeSlice = "52", Project = this, ContextLabel = contextlabel(this)) : Plan.Tasks.Task_Cube
        + Tasks (Project = this) : Plan.Tasks.Task
        + PlanCost () = (0.0m + sum(Tasks.PlanCost))
        + ActualCost () = (0.0m + sum(Tasks.ActualCost))
        + ImpliedCost () = (0.0m + sum(Tasks.ImpliedCost))
    }
    Plan.Project *-- Plan.Duration
    Plan.Project ..|> BI.Item
    class Plan.Resource {
        # Name  : String
        + Deleted  = false
        + Notes  : String
        + Duration  : Plan.Duration
        + UseCost  : Decimal
        + TimeCost  : Decimal
        + Timesheet_Cube (CubeSlice = "54", Resource = this, ContextLabel = contextlabel(this)) : Booking.Timesheet_Cube
        + Booked (Resource = this) : Booking.Timesheet
    }
    Plan.Resource *-- Plan.Duration
    class Plan.Tasks.SubTask {
        # Parent  : Plan.Tasks.Task
        # Task  : Plan.Tasks.Task
    }
    Plan.Tasks.SubTask --> Plan.Tasks.Task
    Plan.Tasks.SubTask --> Plan.Tasks.Task
    class Plan.Tasks.Task {
        # Project  : Plan.Project
        # Id  : Int32
        + Deleted  = false
        + Parent  : Plan.Tasks.Task
        + Name  : String
        + WBS  : String
        + Schedule  : Plan.Tasks.ScheduleType
        + Duration  : Plan.Duration
        + Cost  : Decimal
        + Valid  = ((((Project == null) || (Duration == null)) || (Name == null)) ? false : true)
        + Timesheet_Cube (CubeSlice = "70", Task = this, ContextLabel = contextlabel(this)) : Booking.Timesheet_Cube
        + Actual () : Plan.Tasks.Actual
        + After () : Plan.Tasks.TaskAfter
        + Before () : Plan.Tasks.TaskBefore
        + SubTasks (Parent = this) : Plan.Tasks.Task
        + Resources () : Plan.Tasks.TaskResource
        + BIWBS () = ((Parent == null) ? ((Project?.WBS + ".") + WBS) : ((Parent?.BIWBS + ".") + WBS))
        + SunkCost () = (0.0m + sum(After.LinkCost))
        + PctComplete () = (Actual?.Duration?.Time / Duration?.Time)
        + Effort () = (count(Resources.Weight) * Duration?.Time)
        + ImpResCost () = (0.0m + sum(Resources.ImpliedCost))
        + PlanCost () = ((((Cost + sum(SubTasks.PlanCost)) + sum(Resources.UseCost)) + 0.0m) + (sum(Resources.TimeCost) * Duration?.Time))
        + ActualCost () = (((Cost + sum(SubTasks.ActualCost)) + sum(Resources.UseCost)) + Actual?.Cost)
        + ImpliedCost () = (((Cost + sum(SubTasks.ImpliedCost)) + sum(Resources.UseCost)) + zeronull(ImpResCost))
        + Task_Dimension () = 
        + Project_Dimension () = Project
        + Task_Cube (CubeSlice = "70", Task = this, ContextLabel = contextlabel(this)) : Plan.Tasks.Task_Cube
    }
    Plan.Tasks.Task --> Plan.Project
    Plan.Tasks.Task --> Plan.Tasks.ScheduleType
    Plan.Tasks.Task *-- Plan.Duration
    Plan.Tasks.Task o-- Plan.Tasks.Actual
    Plan.Tasks.Task o-- Plan.Tasks.TaskAfter
    Plan.Tasks.Task o-- Plan.Tasks.TaskBefore
    Plan.Tasks.Task o-- Plan.Tasks.TaskResource
    Plan.Tasks.Task ..|> Plan.Tasks.SubTask
    Plan.Tasks.Task ..|> BI.Item
    class Plan.Tasks.Actual {
        # owner  : Plan.Tasks.Task
        + Duration  : Plan.Duration
        + Close  : DateTime
        + Approval  : HashSet~String~
        + Cost  : Decimal
    }
    Plan.Tasks.Actual *-- Plan.Duration
    Plan.Tasks.Actual *-- String
    class Plan.Tasks.TaskLink {
        # owner  : Any
        # Task  : Plan.Tasks.Task
        + Lag  : TimeSpan
        + LinkCost  : Decimal
    }
    Plan.Tasks.TaskLink --> Plan.Tasks.Task
    class Plan.Tasks.ScheduleType {
        Manual = 1
        Auto = 2
    }
    class Plan.Tasks.TaskResource {
        # owner  : Plan.Tasks.Task
        # Resource  : Plan.Resource
        + Weight  = 1.0m
        + Deleted  = false
        + Valid  = ((Resource == null) ? false : true)
        + Timesheets (Resource = Resource, Task = owner) : Booking.Timesheet
        + ImpliedCost () = (0.0m + sum(Timesheets.Cost))
        + TimeCost () = Resource?.TimeCost
        + UseCost () = Resource?.UseCost
    }
    Plan.Tasks.TaskResource --> Plan.Resource
    Plan.Tasks.TaskResource ..> Booking.Timesheet
    class Plan.Tasks.TaskBefore {
        # owner  : Plan.Tasks.Task
        # Task  : Plan.Tasks.Task
        + Lag  : TimeSpan
        + LinkCost () = (0.0m + Task?.SunkCost)
    }
    Plan.Tasks.TaskBefore --> Plan.Tasks.Task
    Plan.Tasks.TaskBefore ..|> Plan.Tasks.TaskLink
    class Plan.Tasks.TaskAfter {
        # owner  : Plan.Tasks.Task
        # Task  : Plan.Tasks.Task
        + Lag  : TimeSpan
        + LinkCost () = (0.0m + Task?.SunkCost)
    }
    Plan.Tasks.TaskAfter --> Plan.Tasks.Task
    Plan.Tasks.TaskAfter ..|> Plan.Tasks.TaskLink
    class Plan.Tasks.Task_Fact {
        # ContextLabel  : String
        # Task  : Plan.Tasks.Task
        # Project  : Plan.Project
        + SunkCost  : Decimal
        + Effort  : Decimal
        + PlanCost  : Decimal
        + ActualCost  : Decimal
        + ImpliedCost  : Decimal
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Task,Project)
    }
    Plan.Tasks.Task_Fact --> Plan.Tasks.Task
    Plan.Tasks.Task_Fact --> Plan.Project
    class BI.Item {
        # WBS  : String
        # TypeName  : String
        + Name  : String
        + ActualCost  : Decimal
        + PlanCost  : Decimal
        + ImpliedCost  : Decimal
        + Plan  : Plan.Duration
        + Actual  : Plan.Duration
        + PlanStart () = Plan?.Start
        + PlanEnd () = Plan?.End
        + PlanTime () = Plan?.Time
        + ActualStart () = Actual?.Start
        + ActualEnd () = Actual?.End
        + ActualTime () = Actual?.Time
    }
    BI.Item *-- Plan.Duration
    BI.Item *-- Plan.Duration
    class Booking.Timesheet {
        # Resource  : Plan.Resource
        # Task  : Plan.Tasks.Task
        # Date  : DateTime
        + Deleted  = false
        + Time  : Decimal
        + Estimate  : Decimal
        + Comment  : String
        + Valid  = ((((((Resource == null) || (Task == null)) || (Date ~= Task?.Duration?.Start)) || (Date ~= Task?.Duration?.End)) || (Date ~= Task?.Actual?.Close)) ? false : true)
        + Cost () = (Resource?.TimeCost * Time)
        + Task_Dimension () = Task
        + Project_Dimension () = Task?.Project
        + Resource_Dimension () = Resource
    }
    Booking.Timesheet --> Plan.Resource
    Booking.Timesheet --> Plan.Tasks.Task
    class Booking.Timesheet_Fact {
        # ContextLabel  : String
        # Task  : Plan.Tasks.Task
        # Project  : Plan.Project
        # Resource  : Plan.Resource
        + Deleted  = false
        + Facts  : Int64
        + CubeName () = cubename(Task,Project,Resource)
    }
    Booking.Timesheet_Fact --> Plan.Tasks.Task
    Booking.Timesheet_Fact --> Plan.Project
    Booking.Timesheet_Fact --> Plan.Resource
```

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

## Message Plan.PathMessage
Remote execution of path requests

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Node|Node||||
|#|Route|Graph.Route||||
|#|Length|Int32||||
|#|Targets|HashSet<String>||||
|+|Edges|HashSet<Graph.HiperEdge>||||

---

## Value Plan.Duration


||Name|Type|*|@|=|
|-|-|-|-|-|
|+|Start|DateTime||||
|+|End|DateTime||||
||Valid|Some(Boolean)|||((Start <= End) ? true : false)|
||Time|Some(Decimal)|||hours(End,Start)|

---

## EntityImpl Plan.Project
What is a project, exactly? We talk a lot about specific facets of project management, but it’s sometimes valuable to start at the root and dig into the basics.To fully understand high-level project management concepts, it’s important to know the simple answers. When you can call on this knowledge, more complicated concepts are easier to master. Whether you’re the project manager or a stakeholder, give your next project definition with these project management tips in mind.<b>Project Definition</b>A project is a set of tasks that must be completed within a defined timeline to accomplish a specific set of goals. These tasks are completed by a group of people known as the project team, which is led by a project manager, who oversees the planning, scheduling, tracking and successful completion of projects.Besides the project team, projects require resources such as labor, materials and equipment. Organizations and individualsmanage projects with a wide range of objectives. These can take many forms, from constructing a building to planning an event and even completing a certain duty. Retailers, for example, may pursue projects that improve the way they track order fulfillment. Construction teams complete projects any time they plan and build something—and so on!Project management software gives you the tools to manage all the parts of a project so it is delivered on time and within budget. ProjectManager is award-winning project management software with features to plan, manage and track your project in real time. Organize tasks on our robust Gantt, link all four types of task dependencies to avoid costly delays and save your project plan by setting a baseline. This allows you to track your actual progress against your planned progress to help you stay on track. Get started with ProjectManager today for free.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Id|Guid||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Name|String||||
|+|Description|String||||
|+|WBS|String||||
|+|Duration|Plan.Duration||||
||Valid|Some(Boolean)|||(((Name == null) \|\| (Duration == null)) ? false : true)|
||Timesheet_Cube|Booking.Timesheet_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "52", Project = this, ContextLabel = contextlabel(this)|
||Task_Cube|Plan.Tasks.Task_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "52", Project = this, ContextLabel = contextlabel(this)|
||Tasks|Plan.Tasks.Task|||Project = this|
||PlanCost|Some(Decimal)|||(0.0m + sum(Tasks.PlanCost))|
||ActualCost|Some(Decimal)|||(0.0m + sum(Tasks.ActualCost))|
||ImpliedCost|Some(Decimal)|||(0.0m + sum(Tasks.ImpliedCost))|

---

## EntityImpl Plan.Resource
Resource planning is the process of determining how a business will allocate resources in a project, such as assigning tasks to individuals based on their skills and availability. It helps balance demand and capacity across projects, allowing you to keep tight timelines and manage stakeholder expectations.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Name|String||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Notes|String|Description of the resource|||
|+|Duration|Plan.Duration|Dates the resource is available|||
|+|UseCost|Decimal|Cost each time the resource is used|||
|+|TimeCost|Decimal|Cost per hour of resource usage|||
||Timesheet_Cube|Booking.Timesheet_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "54", Resource = this, ContextLabel = contextlabel(this)|
||Booked|Booking.Timesheet|||Resource = this|

---

## View Plan.Tasks.SubTask
SubTask enables the entity Task to export more than one Edge

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Parent|Plan.Tasks.Task||||
|#|Task|Plan.Tasks.Task||||

---

## EntityImpl Plan.Tasks.Task
While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Project|Plan.Project||||
|#|Id|Int32||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Parent|Plan.Tasks.Task||||
|+|Name|String||||
|+|WBS|String||||
|+|Schedule|Plan.Tasks.ScheduleType||||
|+|Duration|Plan.Duration||||
|+|Cost|Decimal||||
||Valid|Some(Boolean)|||((((Project == null) \|\| (Duration == null)) \|\| (Name == null)) ? false : true)|
||Timesheet_Cube|Booking.Timesheet_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "70", Task = this, ContextLabel = contextlabel(this)|
|+|Actual|Plan.Tasks.Actual||||
|+|After|Plan.Tasks.TaskAfter||||
|+|Before|Plan.Tasks.TaskBefore||||
||SubTasks|Plan.Tasks.Task|||Parent = this|
|+|Resources|Plan.Tasks.TaskResource||||
||BIWBS|Some(String)|||((Parent == null) ? ((Project?.WBS + ".") + WBS) : ((Parent?.BIWBS + ".") + WBS))|
||SunkCost|Some(Decimal)|Cost of prior tasks that can not be recovered|CubeMeasure(Aggregate?.Sum)|(0.0m + sum(After.LinkCost))|
||PctComplete|Some(Decimal)|||(Actual?.Duration?.Time / Duration?.Time)|
||Effort|Some(Decimal)||CubeMeasure(Aggregate?.Sum)|(count(Resources.Weight) * Duration?.Time)|
||ImpResCost|Some(Decimal)|||(0.0m + sum(Resources.ImpliedCost))|
||PlanCost|Some(Decimal)||CubeMeasure(Aggregate?.Sum)|((((Cost + sum(SubTasks.PlanCost)) + sum(Resources.UseCost)) + 0.0m) + (sum(Resources.TimeCost) * Duration?.Time))|
||ActualCost|Some(Decimal)||CubeMeasure(Aggregate?.Sum)|(((Cost + sum(SubTasks.ActualCost)) + sum(Resources.UseCost)) + Actual?.Cost)|
||ImpliedCost|Some(Decimal)||CubeMeasure(Aggregate?.Sum)|(((Cost + sum(SubTasks.ImpliedCost)) + sum(Resources.UseCost)) + zeronull(ImpResCost))|
||Task_Dimension|Some(Plan.Tasks.Task)||||
||Project_Dimension|Some(Plan.Project)|||Project|
||Task_Cube|Plan.Tasks.Task_Cube|Reference to the dimension|CubeFactReference()|CubeSlice = "70", Task = this, ContextLabel = contextlabel(this)|

---

## AspectImpl Plan.Tasks.Actual
While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Plan.Tasks.Task||||
|+|Duration|Plan.Duration||||
|+|Close|DateTime||||
|+|Approval|HashSet<String>|set of the controllers th  at have approved this update|||
|+|Cost|Decimal||||

---

## View Plan.Tasks.TaskLink


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Any|owner of the segment/aspect as an object|||
|#|Task|Plan.Tasks.Task||||
|+|Lag|TimeSpan||||
|+|LinkCost|Decimal||||

---

## Enum Plan.Tasks.ScheduleType


||Name|Type|*|@|=|
|-|-|-|-|-|
||Manual|Int32|||1|
||Auto|Int32|||2|

---

## SegmentImpl Plan.Tasks.TaskResource
While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Plan.Tasks.Task||||
|#|Resource|Plan.Resource||||
||Weight|Some(Decimal)|||1.0m|
||Deleted|Some(Boolean)|||false|
||Valid|Some(Boolean)|||((Resource == null) ? false : true)|
||Timesheets|Booking.Timesheet|||Resource = Resource, Task = owner|
||ImpliedCost|Some(Decimal)|Implied Cost||(0.0m + sum(Timesheets.Cost))|
||TimeCost|Some(Decimal)|Time cost is an aggregate because the Resource reference is not infered to be a single||Resource?.TimeCost|
||UseCost|Some(Decimal)|Use cost is an aggregate because the Resource reference is not infered to be a single||Resource?.UseCost|

---

## SegmentImpl Plan.Tasks.TaskBefore
While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Plan.Tasks.Task||||
|#|Task|Plan.Tasks.Task||||
|+|Lag|TimeSpan||||
||LinkCost|Some(Decimal)|||(0.0m + Task?.SunkCost)|

---

## SegmentImpl Plan.Tasks.TaskAfter
While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|owner|Plan.Tasks.Task||||
|#|Task|Plan.Tasks.Task||||
|+|Lag|TimeSpan||||
||LinkCost|Some(Decimal)|||(0.0m + Task?.SunkCost)|

---

## EntityImpl Plan.Tasks.Task_Fact
While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ContextLabel|String||||
|#|Task|Plan.Tasks.Task|While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.|CubeDimensionReference()||
|#|Project|Plan.Project|What is a project, exactly? We talk a lot about specific facets of project management, but it’s sometimes valuable to start at the root and dig into the basics.To fully understand high-level project management concepts, it’s important to know the simple answers. When you can call on this knowledge, more complicated concepts are easier to master. Whether you’re the project manager or a stakeholder, give your next project definition with these project management tips in mind.<b>Project Definition</b>A project is a set of tasks that must be completed within a defined timeline to accomplish a specific set of goals. These tasks are completed by a group of people known as the project team, which is led by a project manager, who oversees the planning, scheduling, tracking and successful completion of projects.Besides the project team, projects require resources such as labor, materials and equipment. Organizations and individualsmanage projects with a wide range of objectives. These can take many forms, from constructing a building to planning an event and even completing a certain duty. Retailers, for example, may pursue projects that improve the way they track order fulfillment. Construction teams complete projects any time they plan and build something—and so on!Project management software gives you the tools to manage all the parts of a project so it is delivered on time and within budget. ProjectManager is award-winning project management software with features to plan, manage and track your project in real time. Organize tasks on our robust Gantt, link all four types of task dependencies to avoid costly delays and save your project plan by setting a baseline. This allows you to track your actual progress against your planned progress to help you stay on track. Get started with ProjectManager today for free.|CubeDimensionReference()||
|+|SunkCost|Decimal|Cost of prior tasks that can not be recovered|CubeMeasure(Aggregate?.Sum)||
|+|Effort|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|PlanCost|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|ActualCost|Decimal||CubeMeasure(Aggregate?.Sum)||
|+|ImpliedCost|Decimal||CubeMeasure(Aggregate?.Sum)||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Task,Project)|

---

## View BI.Item


||Name|Type|*|@|=|
|-|-|-|-|-|
|#|WBS|String||||
|#|TypeName|String||||
|+|Name|String||||
|+|ActualCost|Decimal||||
|+|PlanCost|Decimal||||
|+|ImpliedCost|Decimal||||
|+|Plan|Plan.Duration||||
|+|Actual|Plan.Duration||||
||PlanStart|Some(DateTime)|||Plan?.Start|
||PlanEnd|Some(DateTime)|||Plan?.End|
||PlanTime|Some(Decimal)|||Plan?.Time|
||ActualStart|Some(DateTime)|||Actual?.Start|
||ActualEnd|Some(DateTime)|||Actual?.End|
||ActualTime|Some(Decimal)|||Actual?.Time|

---

## EntityImpl Booking.Timesheet
Time booking by resources against 

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|Resource|Plan.Resource||||
|#|Task|Plan.Tasks.Task||||
|#|Date|DateTime||||
||Deleted|Some(Boolean)|Flag for read horizon filter to hide when true||false|
|+|Time|Decimal||||
|+|Estimate|Decimal|Estimated time to comple  te this task|||
|+|Comment|String||||
||Valid|Some(Boolean)|||((((((Resource == null) \|\| (Task == null)) \|\| (Date <= Task?.Duration?.Start)) \|\| (Date >= Task?.Duration?.End)) \|\| (Date <= Task?.Actual?.Close)) ? false : true)|
||Cost|Some(Decimal)|||(Resource?.TimeCost * Time)|
||Task_Dimension|Some(Plan.Tasks.Task)|||Task|
||Project_Dimension|Some(Plan.Project)|||Task?.Project|
||Resource_Dimension|Some(Plan.Resource)|||Resource|

---

## EntityImpl Booking.Timesheet_Fact
Time booking by resources against 

||Name|Type|*|@|=|
|-|-|-|-|-|
|#|ContextLabel|String||||
|#|Task|Plan.Tasks.Task|While the word “task” might bring about feelings of despair related to chores or undesirable actions, this is usually related more so to the way you have to manage your time than the task itthis.In this article, we’ll do a deep dive into tasks, show you the best ways to break down larger projects into them, while covering efficient approaches to manage and distribute tasks.|CubeDimensionReference()||
|#|Project|Plan.Project|What is a project, exactly? We talk a lot about specific facets of project management, but it’s sometimes valuable to start at the root and dig into the basics.To fully understand high-level project management concepts, it’s important to know the simple answers. When you can call on this knowledge, more complicated concepts are easier to master. Whether you’re the project manager or a stakeholder, give your next project definition with these project management tips in mind.<b>Project Definition</b>A project is a set of tasks that must be completed within a defined timeline to accomplish a specific set of goals. These tasks are completed by a group of people known as the project team, which is led by a project manager, who oversees the planning, scheduling, tracking and successful completion of projects.Besides the project team, projects require resources such as labor, materials and equipment. Organizations and individualsmanage projects with a wide range of objectives. These can take many forms, from constructing a building to planning an event and even completing a certain duty. Retailers, for example, may pursue projects that improve the way they track order fulfillment. Construction teams complete projects any time they plan and build something—and so on!Project management software gives you the tools to manage all the parts of a project so it is delivered on time and within budget. ProjectManager is award-winning project management software with features to plan, manage and track your project in real time. Organize tasks on our robust Gantt, link all four types of task dependencies to avoid costly delays and save your project plan by setting a baseline. This allows you to track your actual progress against your planned progress to help you stay on track. Get started with ProjectManager today for free.|CubeDimensionReference()||
|#|Resource|Plan.Resource|Resource planning is the process of determining how a business will allocate resources in a project, such as assigning tasks to individuals based on their skills and availability. It helps balance demand and capacity across projects, allowing you to keep tight timelines and manage stakeholder expectations.|CubeDimensionReference()||
||Deleted|Some(Boolean)|The cube fact has been deleted||false|
|+|Facts|Int64|Indicate that the Cube Slice is a Fact|||
||CubeName|Some(String)|||cubename(Task,Project,Resource)|

