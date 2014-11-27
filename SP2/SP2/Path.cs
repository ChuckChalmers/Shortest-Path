using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP2
{
    class Path
    {
        public static void Pathing(string source, string destination, string visited)
        {
            visited = source + visited;
            List<Nodes> nodeList = new List<Nodes>();
            nodeList = Nodes.nodeBuilder();
            //int i = 0;

            //while (!visited.Contains(destination))
            //{
            //    neighbor = nodeList[i];
            //    i++;
            //}

        }

    }
}
