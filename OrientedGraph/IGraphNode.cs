using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedGraph
{
    public interface IGraphNode<N>
    {
        public N NodeInfo { get; set; }
    }
}
