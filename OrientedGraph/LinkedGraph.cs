using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedGraph
{
    public class LinkedGraph<N, L> : IGraph<N, L>
    {
        public int Count => nodes.Count;

        public bool IsEmpty => nodes.Count == 0;

        public IEnumerable<IGraphNode<N>> Nodes => nodes;

        List<LinkedGraphNode<N, L>> nodes;

        public LinkedGraph()
        {
            nodes = new List<LinkedGraphNode<N, L>>();
        }

        public void AddNode(N nodeInfo)
        {
            LinkedGraphNode<N, L> node = new LinkedGraphNode<N, L>(nodeInfo);
            nodes.Add(node);
        }


        public void AddLink(IGraphNode<N> node1, IGraphNode<N> node2, L link)
        {
            if (!nodes.Contains(node1) || !nodes.Contains(node2))
            {
                return;
            }
            ((LinkedGraphNode<N, L>)node1).SetLink((LinkedGraphNode<N, L>)node2, link);
            
        }

        public void Clear()
        {
            nodes.Clear();
        }

        public bool Contains(IGraphNode<N> node)
        {
            return nodes.Contains(node);
        }

        public void RemoveNode(IGraphNode<N> node)
        {
            nodes.Remove((LinkedGraphNode<N,L>)node);
        }

        public void RemoveLink(IGraphNode<N> node1, IGraphNode<N> node2)
        {
            if (!nodes.Contains(node1) || !nodes.Contains(node2))
            {
                return;

            }

            ((LinkedGraphNode<N, L>)node1).DeleteLink((LinkedGraphNode<N,L>)node2);
        }

        public IEnumerator<N> GetEnumerator()
        {
            foreach (LinkedGraphNode<N,L> node in nodes)
            {
                yield return node.NodeInfo;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        
        public bool HasLink(IGraphNode<N> node1, IGraphNode<N> node2, out L? link)
        {
            link = default;
            if (!nodes.Contains(node1) || !nodes.Contains(node2))
            {
                return false;
            }

            return ((LinkedGraphNode<N,L>)node1).FindLink((LinkedGraphNode<N,L>)node2, out link) && !link.Equals(default(L));
        }

        
    }
}
