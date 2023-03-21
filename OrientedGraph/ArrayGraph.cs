using System;
using System.Collections;
using System.Collections.Generic;
using OrientedGraph.GraphException;

namespace OrientedGraph
{
    public class ArrayGraph<N, L> : IGraph<N, L>
    {
        private ArrayGraphNode<N>?[] nodes;
        private L?[,] links;
        private HashSet<int> freeIndexes;

        public int Count => nodes.Length - freeIndexes.Count;
        public bool IsEmpty => nodes.Length == freeIndexes.Count;
        public IEnumerable<IGraphNode<N>> Nodes => nodes;

        

        public ArrayGraph(int count = 50)
        {
            nodes = new ArrayGraphNode<N>[count];
            links = new L?[count, count];
            freeIndexes = new HashSet<int>(count);
            for (int i = 0; i < count; i++)
            {
                freeIndexes.Add(i);
            }
        }

        private void ClearLinks(int nodeIndex)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                links[i, nodeIndex] = default;
                links[nodeIndex, i] = default;
            }
        }

        public void AddNode(N nodeInfo)
        {
            if (freeIndexes.Count == 0)
            {
                throw new GraphOverflowException();
            }

            int freeIndex = freeIndexes.Min();
            nodes[freeIndex] = new ArrayGraphNode<N>(nodeInfo);
            ClearLinks(freeIndex);
            freeIndexes.Remove(freeIndex);
            
        }

        public void AddLink(IGraphNode<N> node1, IGraphNode<N> node2, L link)
        {            
            int index1 = Array.IndexOf(nodes, node1);
            int index2 = Array.IndexOf(nodes, node2);
            if (index1<0 || index2<0)
            {
                return;
            }

            links[index1,index2] = link;
        }

        public void Clear()
        {
            nodes = new ArrayGraphNode<N>[Count];
            links = new L[Count, Count];
            freeIndexes = new HashSet<int>(Count);
            for (int i = 0; i < Count; i++)
            {
                freeIndexes.Add(i);
            }
        }

        public bool Contains(IGraphNode<N> node)
        {
            return nodes.Contains(node);
        }



        public void RemoveNode(IGraphNode<N> node)
        {
            int index = Array.IndexOf(nodes, node);
            if (index<0)
            {
                return;
            }
            
            nodes[index] = null;
            freeIndexes.Add(index);
        }



        public void RemoveLink(IGraphNode<N> node1, IGraphNode<N> node2)
        {
            int index1 = Array.IndexOf(nodes, node1);
            int index2 = Array.IndexOf(nodes, node2);
            if (index1 < 0 || index2 < 0)
            {
                return;
            }

            links[index1, index2] = default;
        }

        public IEnumerator<N> GetEnumerator()
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i]!= null)
                {
                    yield return nodes[i].NodeInfo;
                }
            }
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool HasLink(IGraphNode<N> node1, IGraphNode<N> node2, out L? link)
        {
            int index1 = Array.IndexOf(nodes, node1);
            int index2 = Array.IndexOf(nodes, node2);
            if (index1 < 0 || index2 < 0 || links[index1, index2] == null || links[index1, index2].Equals(default(bool)))
            {
                link = default;
                return false;
            }

            link = links[index1, index2];
            return !link.Equals(default(L));
        }

        
    }
}
