using Hiperspace.Graph.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiperspace.Graph
{
    /// <summary>
    /// GraphSpace aggregates a number of domain spaces to support graph queries over 
    /// a number of underlying spaces, as if they were a single space.
    /// </summary>
    public class GraphSpace : SubSpace
    {
        private SubSpace[] _subSpaces;
        public GraphSpace(HiperSpace space, SubSpace[] subSpaces, Horizon[]? horizon, DateTime? AsAt = null, DateTime? DeltaFrom = null)
            : base(space, horizon, AsAt, DeltaFrom)
        {
            if (subSpaces == null || subSpaces.Length < 1)
                throw new ArgumentException($"{nameof(GraphSpace)} should have at least one spaces");
            _subSpaces = subSpaces;

            var nodes = new SetSpace<Node>[subSpaces.Length];
            var edges = new SetSpace<Edge>[subSpaces.Length];
            var vectorNodes = new SetSpace<VectorNode>[subSpaces.Length];

            for (int c = 0;  c < subSpaces.Length; c++)
            {
                nodes[c] = subSpaces[c].Nodes;
                edges[c] = subSpaces[c].Edges;
                vectorNodes[c] = subSpaces[c].VectorNodes;

            }
            Nodes = new NodeSetSpace(this, nodes);
            Edges = new EdgeSetSpace(this, edges);
            VectorNodes = new VectorNodeSetSpace(this, vectorNodes);
        }

        public override object? Get(string sid)
        {
            for (int c = 0; c < _subSpaces.Length; c++)
            {
                var result = _subSpaces[c].Get(sid);
                if (result != null)
                    return result;
            }
            return null;
        }
    }
}
