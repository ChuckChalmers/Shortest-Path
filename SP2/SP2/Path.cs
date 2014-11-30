using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SP2;
namespace SP2
{
    class Path
    {
        public static void Pathing(Node source, Node destination, string visited, List<Node> nodeList)
        {
            visited = visited + source.Name;
            
            foreach(Node n in source.neighbors)
            {
                if (source == destination)
                {
                    Globals.validPaths.Add(visited);
                    return;
                }
                if (!visited.Contains(n.Name) == true)
                {
                    Path.Pathing(n, destination, visited, nodeList);
                }
            }
        }

    }
}
