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
        public static void Pathing(Node source, Node destination, string visited)
        {
            visited = visited + source.Name;
            
            foreach(Neighbor n in source.neighbors)
            {
                if (source == destination)
                {
                    int distance = 0;
                    distance = travelDist(visited);
                    if(Globals.shortestpath == 0)
                    {
                        Globals.shortestpath = distance;
                        Globals.path = visited;
                    }
                    if(Globals.shortestpath > distance)
                    {
                        Globals.shortestpath = distance;
                        Globals.path = visited;
                    }
                    Globals.validPaths.Add(visited + " " + distance.ToString());
                    return;
                }
                if (!visited.Contains(n.neighbor.Name) == true)
                {
                    Path.Pathing(n.neighbor, destination, visited);
                }
            }
        }

        private static int travelDist(string visited)
        {
            int dist = 0;
            foreach(char d in visited)
            {
                if(d.ToString() == visited.Substring(visited.Length -1))
                {
                    break;
                }
                Node start = null;
                Node next = null;
                int count = 0;
                string test1 = "";
                count = visited.IndexOf(d) + 1;
                start = Neighbor.ToNode(d.ToString());
                next = Neighbor.ToNode(visited.Substring(count, 1));
                test1 = start.neighbors[0].neighbor.Name;
                foreach(Neighbor n in start.neighbors)
                {
                    if(n.neighbor == next)
                    {
                        dist = n.distance + dist;
                    }
                }

                
            }
            return dist;
        }

    }
}
