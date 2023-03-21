using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedGraph
{

    public class LinkedGraphNode<N,L> : IGraphNode<N>
    {        
        protected class Edge
        {
            public LinkedGraphNode<N,L> node;
            public L? linkType;
            public Edge? previousEdge;
            public Edge? nextEdge;

            public Edge(LinkedGraphNode<N, L> node, L? linkType)
            {
                this.node = node;
                this.linkType = linkType;
            }
        }
        
        public N NodeInfo { get; set; }
        Edge? firstEdge;

        public LinkedGraphNode(N nodeInformation)
        {
            NodeInfo = nodeInformation;            
        }

        public void SetLink(LinkedGraphNode<N,L> node, L linkType)
        {
            Edge tmp = new Edge(node, linkType);
            if (firstEdge == null)
            {
                firstEdge = tmp;
            }
            else
            {
                tmp.nextEdge = firstEdge;
                firstEdge.previousEdge = tmp;
                firstEdge = tmp;
            }
        }

        public void DeleteLink(LinkedGraphNode<N,L> node2)
        {
            if (node2 == null)
            {
                return;
            }
            if (firstEdge != null && node2 == firstEdge.node)
            {
                firstEdge = firstEdge.nextEdge;
                return;
            }

            Edge? cur = firstEdge;
            while (cur != null && cur.node != node2 )
            {
                cur = cur.nextEdge ;
            }

            if (cur == null)
            {
                return;
            }

            cur.previousEdge.nextEdge = cur.nextEdge;
            cur.nextEdge.previousEdge = cur.previousEdge;
        }

        public bool FindLink(LinkedGraphNode<N,L> node, out L? link)
        {
            Edge? cur = firstEdge;
            while (cur != null && cur.node != node) 
            {
                cur = cur.nextEdge;
            }

            if (cur == null)
            {
                link = default;
                return false;
            }

            link = cur.linkType;
            return true;
        }

        public override string? ToString()
        {
            return NodeInfo.ToString();
        }
    }
}
