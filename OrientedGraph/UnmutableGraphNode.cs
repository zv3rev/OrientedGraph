using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientedGraph.GraphException;

namespace OrientedGraph
{
    internal class UnmutableGraphNode<N> : IGraphNode<N>
    {
        IGraphNode<N> node;
        public N NodeInfo { get => throw new NotImplementedException(); set => throw new UnmutableGraphChangeException(); }
    }
}
