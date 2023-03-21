using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedGraph
{
    public class ArrayGraphEnumerator<N,L> : IEnumerator<N> 
    {
        private ArrayGraphNode<N>?[] nodes;
        private int position = -1;

        public ArrayGraphEnumerator(ArrayGraph<N, L> graph) => nodes = (ArrayGraphNode<N>?[])graph.Nodes;


        public N Current 
        {
            get
            {
                if (position<0 || position>=nodes.Length)
                {
                    throw new ArgumentException();
                }

                return nodes[position].NodeInfo;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            position = position == -1 ? position++ : position;
            while (position<nodes.Length && nodes[position]==null)
            {
                position++;
            }

            return position < nodes.Length && nodes[position] != null;
        }

        public void Reset() => position = -1;
    }
}
