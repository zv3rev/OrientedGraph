using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrientedGraph.GraphException;

namespace OrientedGraph
{
    public static class GraphUtils<N,L>
    {
        public delegate IGraph<N, L> GraphConstructorDelegate();

        private const int ArrayGraphLength = 100;
        public static readonly GraphConstructorDelegate ArrayGraphConstructorDelegate = () => new ArrayGraph<N,L>(ArrayGraphLength);
        public static readonly GraphConstructorDelegate LinkedGraphConstructorDelegate = () => new LinkedGraph<N, L>();

        public static bool Exists(IGraph<N, L> graph, Predicate<IGraphNode<N>> predicate)
        {
            bool result = false; 
            foreach (IGraphNode<N> node in graph.Nodes)
            {
                if (node != null)
                {
                    result |= predicate(node);
                }
            }
            return result;
        }

        public static void ForEach(IGraph<N,L> graph, Action<IGraphNode<N>> action)
        {
            foreach (IGraphNode<N> node in graph.Nodes)
            {
                if (node!= null)
                {
                    action(node);
                }

            }
        }

        public static IGraph<N,L> FindAll(IGraph<N,L> graph, Predicate<IGraphNode<N>> predicate, GraphConstructorDelegate constructor)
        {
            IGraph<N, L> result = constructor();
            foreach (IGraphNode<N> node in graph.Nodes)
            {
                if (node != null && predicate(node))
                {
                    result.AddNode(node.NodeInfo);
                }
            }

            return result;
        }

        public static bool CheckForAll(IGraph<N, L> graph, Predicate<IGraphNode<N>> predicate)
        {
            bool result = true;
            foreach (IGraphNode<N> node in graph.Nodes)
            {
                if (node != null)
                {
                    result &= predicate(node);
                    if (!result) 
                        break;
                }
                
            }
            return result;
        }

        public static bool BreadthFirstSearch(IGraph<N,L> graph, IGraphNode<N> start, Predicate<IGraphNode<N>> predicate)
        {
            List<IGraphNode<N>> nodeList = graph.Nodes.ToList();
            nodeList.RemoveAll((node) => node == null);
            if (!nodeList.Contains(start))
            {
                return false;
            }

            List<IGraphNode<N>> markedNodes = new List<IGraphNode<N>>();
            Queue<IGraphNode<N>> unseenNodes = new Queue<IGraphNode<N>>();
            unseenNodes.Enqueue(start);
            markedNodes.Add(start);

            bool isFound = false;
            while (unseenNodes.Count > 0)
            {
                IGraphNode<N> node = unseenNodes.Dequeue();
                isFound |= predicate(node);
                foreach (IGraphNode<N> item in nodeList)
                {
                    if (!markedNodes.Contains(item) && graph.HasLink(node,item, out L? l))
                    {
                        unseenNodes.Enqueue(item);
                        markedNodes.Add(item);
                    }
                }
                
            }

            return isFound;
        }

        public static bool DepthFirstSearch(IGraph<N, L> graph, IGraphNode<N> start, Predicate<IGraphNode<N>> predicate)
        {
            List<IGraphNode<N>> nodeList = graph.Nodes.ToList();
            nodeList.RemoveAll((node) => node == null);
            if (!nodeList.Contains(start))
            {
                return false;
            }

            List<IGraphNode<N>> markedNodes = new List<IGraphNode<N>>();
            Stack<IGraphNode<N>> unseenNodes = new Stack<IGraphNode<N>>();
            unseenNodes.Push(start);

            bool isFound = false;
            while (unseenNodes.Count > 0)
            {
                IGraphNode<N> node = unseenNodes.Pop();
                if (markedNodes.Contains(node))
                {
                    continue;
                }
                isFound |= predicate(node);
                markedNodes.Add(node);
                for (int i = nodeList.Count-1; i >= 0; i--)
                {
                    if (graph.HasLink(node, nodeList[i], out L? l))
                    {
                        unseenNodes.Push(nodeList[i]);                        
                    }
                }

            }

            return isFound;
        }

        public static int? Dijkstra(IGraph<N, L> graph, IGraphNode<N> start, IGraphNode<N> end)
        {
            if (typeof(L) != typeof(int))
            {
                throw new UnsupportedGraphTypeException();
            }

            List<IGraphNode<N>> nodeList = graph.Nodes.ToList();
            nodeList.RemoveAll((node) => node == null);
            int startIndex = nodeList.IndexOf(start);
            int endIndex = nodeList.IndexOf(end);

            int?[] distance = new int?[nodeList.Count];
            IGraphNode<N>?[] parent = new IGraphNode<N>[nodeList.Count];
            int?[,] matr = new int?[nodeList.Count, nodeList.Count];
            HashSet<int> unseenNodes = new HashSet<int>();

            for (int i = 0; i < nodeList.Count; i++)
            {
                for (int j = 0; j < nodeList.Count; j++)
                {
                    if (graph.HasLink(nodeList[i], nodeList[j], out L? link))
                    {
                        matr[i, j] = link as int?;
                    }
                    else
                    {
                        matr[i, j] = Int32.MaxValue; 
                    }
                }

                unseenNodes.Add(i);
                distance[i] = matr[startIndex, i];
                if (distance[i]<Int32.MaxValue)
                {
                    parent[i] = start;
                }
            }

            distance[startIndex] = 0;
            parent[startIndex] = null;
            unseenNodes.Remove(startIndex);
            while (unseenNodes.Count>0)
            {
                int? min = int.MaxValue;
                int minIndex = -1;
                foreach (int  i in unseenNodes)
                {
                    if (distance[i]<min)
                    {
                        min = distance[i];
                        minIndex = i;
                    }
                }

                if (minIndex > -1)
                {
                    unseenNodes.Remove(minIndex);
                }
                else break;

                foreach (int i in unseenNodes)
                {
                    if (matr[minIndex,i]<int.MaxValue)
                    {
                        distance[i] = Math.Min((int)distance[i], (int)(distance[minIndex] + matr[minIndex, i]));
                        if (distance[i] == distance[i] + matr[minIndex, i])
                        {
                            parent[i] = nodeList[minIndex];
                        }
                    }
                }
            }

            return distance[nodeList.IndexOf(end)] < Int32.MaxValue ? distance[nodeList.IndexOf(end)] : null ;
        }
    }
}
