using Graph;
using Hiperspace;

namespace Togaf
{
    internal class TogafFunctions
    {
        public static Graph.Route GoalPriority = new Graph.Route
        {
            Name = "Strategic-Goal",
            Rules = 
            [
                new Rule { FromType = "AF-CourseOfAction", ToType = "AF-Goal", EdgeType = "AF-CourseOfAction-Goal"},
                new Rule { FromType = "AF-Capability", ToType = "AF-CourseOfAction", EdgeType = "AF-Capability-Related"},
                new Rule { FromType = "AF-Function", ToType = "AF-CourseOfAction", EdgeType = "AF-Function-CourseOfAction"},
                new Rule { FromType = "AF-Capability", ToType = "AF-Capability", EdgeType = "AF-Capability-Part"}, // recursive
                new Rule { FromType = "AF-Function", ToType = "AF-Function", EdgeType = "AF-Function-Part"}, // recursive
                new Rule { FromType = "AF-Process", ToType = "AF-Function", EdgeType = "AF-Process-Function"},
                new Rule { FromType = "AF-Process", ToType = "AF-Capability", EdgeType = "AF-Process-Capability"},
                new Rule { FromType = "AF-Activity", ToType = "AF-Process", EdgeType = "AF-Activity-Process"},
                new Rule { FromType = "AF-Service", ToType = "AF-Activity", EdgeType = "AF-Activity-Service"},
                new Rule { FromType = "AF-System", ToType = "AF-Service", EdgeType = "AF-System-Service"},
                new Rule { FromType = "AF-Component", ToType = "AF-System", EdgeType = "AF-Component-System"},
                new Rule { FromType = "AF-Deployed", ToType = "AF-Component", EdgeType = "AF-Deployed-Component"},
                new Rule { FromType = "AF-Platform", ToType = "AF-Service", EdgeType = "*"},
                new Rule { FromType = "AF-Platform", ToType = "AF-Platform", EdgeType = "*"}, // recursive
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Function", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Capability", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Goal", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Activity", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Process", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-CourseOfAction", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Service", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-System", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Component", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Deployed", EdgeType = "AF-WorkPackage-For"},
                new Rule { FromType = "AF-WorkPackage", ToType = "AF-Platform", EdgeType = "AF-WorkPackage-For"},
            ]
        };

        public static HashSet<Graph.HiperEdge> StrategicEdge(Node? node)
        {
            return PathFunctions.Paths(node, GoalPriority, null, new HashSet<string> { "AF-Goal" });
        }
        public static HashSet<Togaf.GoalRef> Goals(HashSet<Graph.HiperEdge>? edges)
        {
            if (edges == null) return new HashSet<Togaf.GoalRef>();
            return 
                edges
                .Where(edge => edge.TypeName == "AF-Goal" && edge.To?.Object is Togaf.Business.Goal)
                .Select(edge => edge.To?.Object as Togaf.Business.Goal)
                .Select(goal => new Togaf.GoalRef { Value = goal })
                .ToHashSet();
        }
    }
}
