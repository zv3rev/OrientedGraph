using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedGraph
{
    public interface IGraph<N,L> : IEnumerable<N>
    {
        public int Count { get; }
        public bool IsEmpty { get; }
        public IEnumerable<IGraphNode<N>> Nodes { get; }
        public void AddNode(N nodeInfo);
        public void AddLink(IGraphNode<N> node1, IGraphNode<N> node2, L link);
        public void Clear();
        public bool Contains(IGraphNode<N> node);
        public void RemoveNode(IGraphNode<N> node);
        public void RemoveLink(IGraphNode<N> node1, IGraphNode<N> node2);
        public bool HasLink(IGraphNode<N> node1, IGraphNode<N> node2, out L? link);
    }
}
