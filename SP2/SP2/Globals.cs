using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP2
{
    public static class Globals
    {
        public static List<string> validPaths = new List<string>();
        public static List<Node> nodeList = Node.nodeBuilder();
        public static int shortestpath = new int();
        public static string path = null;
    }
}
