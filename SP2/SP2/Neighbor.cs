using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP2
{
   public class Neighbor
    {
       public Node neighbor; 
       public int distance;

        public Neighbor(Node _neighbor, int _distance)
        {
            this.neighbor = _neighbor;
            this.distance = _distance;
        }
    }
}
