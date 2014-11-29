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
            //Node[] neighbors = new Node[source.neighbors.Length];
            visited = visited + source.Name;
            
            foreach(Node n in source.neighbors)
            {
                if (!visited.Contains(n.Name) == true)
                {
                    if(source == destination)
                    {
                        if (Globals.validPaths.Contains(visited) == false)
                        {
                            Globals.validPaths.Add(visited);
                        }
                        return;
                    }
                    Path.Pathing(n, destination, visited, nodeList);
                }
            }
        }

    }
}
