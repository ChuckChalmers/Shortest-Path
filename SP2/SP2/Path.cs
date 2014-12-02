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
        public static void Pathing(Node source, Node destination, string visited, List<Node> nodeList, int totalDist)
        {
            visited = visited + source.Name;
            
            foreach(Neighbor n in source.neighbors)
            {
                if (source == destination)
                {
                    Globals.validPaths.Add(visited + " " + totalDist.ToString());
                    return;
                }
                if (!visited.Contains(n.neighbor.Name) == true)
                {
                    totalDist = totalDist + n.distance;
                    Path.Pathing(n.neighbor, destination, visited, nodeList, totalDist);
                }
            }
        }

    }
}
