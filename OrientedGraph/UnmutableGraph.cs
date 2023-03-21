using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientedGraph.GraphException;

namespace OrientedGraph
{
    public class UnmutableGraph<N, L> : IGraph<N, L> 
    {
        private IGraph<N, L> graph;
        public int Count => graph.Count;

        public bool IsEmpty => graph.IsEmpty;

        public IEnumerable<IGraphNode<N>> Nodes => graph.Nodes;

        public UnmutableGraph(IGraph<N, L> source)
        {
            if (source is LinkedGraph<N,L>)
            {
                graph = new LinkedGraph<N, L>();
            }
            else if (source is ArrayGraph<N, L>)
            {
                graph = new ArrayGraph<N, L>(source.Count);
            }

            List<IGraphNode<N>> nodeList = source.Nodes.ToList();
            nodeList.RemoveAll((node) => node == null);
            for (int i = 0; i < nodeList.Count; i++)
            {
                graph.AddNode(nodeList[i].NodeInfo);
            }

            List<IGraphNode<N>> nodeListNew = graph.Nodes.ToList();
            nodeListNew.RemoveAll((node) => node == null);
            for (int i = 0; i < nodeList.Count; i++)
            {
                for (int j = 0; j < nodeList.Count; j++)
                {
                    if (source.HasLink(nodeList[i], nodeList[j], out L link))
                    {
                        graph.AddLink(nodeListNew[i], nodeListNew[j], link);
                    }
                }
            }
        }

        public void AddLink(IGraphNode<N> node1, IGraphNode<N> node2, L link)
        {
            throw new UnmutableGraphChangeException();
        }

        public void AddNode(N nodeInfo)
        {
            throw new UnmutableGraphChangeException();
        }

        public void Clear()
        {
            throw new UnmutableGraphChangeException();
        }

        public bool Contains(IGraphNode<N> node)
        {
            return graph.Contains(node);
        }

        public IEnumerator<N> GetEnumerator()
        {
            return graph.GetEnumerator();
        }

        public bool HasLink(IGraphNode<N> node1, IGraphNode<N> node2, out L? link)
        {
            return graph.HasLink(node1, node2, out link);
        }

        public void RemoveLink(IGraphNode<N> node1, IGraphNode<N> node2)
        {
            throw new UnmutableGraphChangeException();
        }

        public void RemoveNode(IGraphNode<N> node)
        {
            throw new UnmutableGraphChangeException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return graph.GetEnumerator();
        }
    }
}
