using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedGraph.GraphException
{
    public class GraphException:Exception
    {
        public GraphException(): base(){}
        public GraphException(string message):base(message){}
    }
}
