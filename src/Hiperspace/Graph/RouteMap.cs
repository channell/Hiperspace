// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2025 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
using Hiperspace;
using Microsoft.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Graph
{
    public class RouteMap : Dictionary<string, Dictionary<string, string>>
    {
        public RouteMap(Route? route) : this(route.HasValue ? route.Value : new Route()) { }

        public RouteMap(Route route) : base()
        {
            if (route.Rules != null)
            {
                foreach (var rule in route.Rules)
                {
                    Dictionary<string, string>? from = null;
                    if (rule.FromType != null && !TryGetValue(rule.FromType, out from))
                    {
                        from = new Dictionary<string, string>();
                        Add(rule.FromType, from);
                    }
                    if (from != null && rule.EdgeType != null && !from.TryGetValue(rule.EdgeType, out var to))
                    {
                        if (rule.ToType != null)
                            from.Add(rule.EdgeType, rule.ToType);
                        else
                            throw new ArgumentException($"Missing ToType ({rule.FromType}, {rule.EdgeType})");
                    }
                    else
                        throw new ArgumentException($"Duplicate ({rule.FromType}, {rule.EdgeType}, {rule.ToType})");
                }
            }
            Name = route.Name;
        }
        public bool Match(Edge edge)
        {
            if (edge.From?.TypeName != null)
            {
                if (TryGetValue(edge.From.TypeName, out var from) || TryGetValue("*", out from))
                {
                    if (from != null && edge.TypeName != null && (from.TryGetValue(edge.TypeName, out var to) || from.TryGetValue("*", out to)))
                    {
                        if (to != null && edge.To?.TypeName != null && (edge.To.TypeName == to || to == "*"))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public readonly string? Name;
    }
}