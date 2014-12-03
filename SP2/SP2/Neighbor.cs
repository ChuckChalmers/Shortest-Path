using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP2
{
   public class Neighbor
    {
       public Node neighbor { get; set; }
       public int distance { get; set; }

        public Neighbor(Node _neighbor, int _distance)
        {
            this.neighbor = _neighbor;
            this.distance = _distance;
        }
        public static Node ToNode(string name)
        {
            Node node = null;
            node = Globals.nodeList.FirstOrDefault(x => x.Name == name);
            return node;
        }
    }
}
