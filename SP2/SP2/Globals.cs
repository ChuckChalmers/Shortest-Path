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
        public static List<Node> nodeList = new List<Node>();
        public static int shortestpath = new int();
        public static string path = null;
        public static void Initialize()
        {
            validPaths.Clear();
            shortestpath = 0;
            path = null;
            nodeList = Node.nodeBuilder();
        }
    }
}
