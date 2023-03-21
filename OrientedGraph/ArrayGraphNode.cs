using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedGraph
{
    public class ArrayGraphNode<N> : IGraphNode<N>
    {
        public N NodeInfo { get; set; }

        public ArrayGraphNode(N nodeInfo)
        {
            NodeInfo = nodeInfo;
        }

        public override string? ToString()
        {
            return NodeInfo.ToString();
        }
    }
}
