using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP2
{
    class Nodes
    {
        public string Name;
        public string[] Neighbors;
        public Nodes[] test {set;}

        public Nodes(string _Name, string[] _Neighbors)
        {
            this.Name = _Name;
            this.Neighbors = _Neighbors;
        }

        public static List<Nodes> nodeBuilder()
        {
            List<Nodes> nodeList = new List<Nodes>()
            {
                {new Nodes("A", new string[] {"B" , "I"})},
                {new Nodes("B", new string[] {"A", "C", "D"})},
                {new Nodes("C", new string[] {"D", "E"})},
                {new Nodes("D", new string[] {"B", "C", "G"})},
                {new Nodes("E", new string[] {"C", "F"})},
                {new Nodes("F", new string[] {"E", "I"})},
                {new Nodes("G", new string[] {"D", "H"})},
                {new Nodes("H", new string[] {"G", "M", "N"})},
                {new Nodes("I", new string[] {"A", "F", "K"})},
                {new Nodes("J", new string[] {"K", "L"})},
                {new Nodes("K", new string[] {"I", "J", "L"})},
                {new Nodes("L", new string[] {"J", "K", "N"})},
                {new Nodes("M", new string[] {"H", "N"})},
                {new Nodes("N", new string[] {"H", "L", "M", "P"})},
                {new Nodes("O", new string[] {"P", "Q", "S"})},
                {new Nodes("P", new string[] {"N", "O", "S"})},
                {new Nodes("Q", new string[] {"R", "S"})},
                {new Nodes("R", new string[] {"Q", "S"})},
                {new Nodes("S", new string[] {"O", "P", "Q", "R"})}
            };
            Nodes neighbor = null;
            return nodeList;

            //Nodes A = new Nodes("A", new string[] { "B", "I" });
            //Nodes B = new Nodes("B", new string[] { "B", "I" });
            //A.test = new Nodes[] { B, I };
            //return nodeList;
        }

        //public static string[][] Storage()
        //{
        //    string[][] neighbors = new string[19][];
        //    neighbors[0] = new string[3] { "A", "B", "I" };
        //    neighbors[1] = new string[4] { "B", "A", "C", "D" };
        //    neighbors[2] = new string[3] { "C", "D", "E" };
        //    neighbors[3] = new string[4] { "D", "B", "C", "G" };
        //    neighbors[4] = new string[3] { "E", "C", "F" };
        //    neighbors[5] = new string[3] { "F", "E", "I" };
        //    neighbors[6] = new string[3] { "G", "D", "H" };
        //    neighbors[7] = new string[4] { "H", "G", "M", "N" };
        //    neighbors[8] = new string[4] { "I", "A", "F", "K" };
        //    neighbors[9] = new string[3] { "J", "K", "L" };
        //    neighbors[10] = new string[4] { "K", "I", "J", "L" };
        //    neighbors[11] = new string[4] { "L", "J", "K", "N" };
        //    neighbors[12] = new string[3] { "M", "H", "N" };
        //    neighbors[13] = new string[5] { "N", "H", "L", "M", "P" };
        //    neighbors[14] = new string[4] { "O", "P", "Q", "S" };
        //    neighbors[15] = new string[4] { "P", "N", "O", "S" };
        //    neighbors[16] = new string[3] { "Q", "R", "S" };
        //    neighbors[17] = new string[3] { "R", "Q", "S" };
        //    neighbors[18] = new string[5] { "S", "O", "P", "Q", "R" };
        //    return neighbors;
        //}


        //public static void Search(string[][] neighbors, string source, string destination, string visited)
        //{
        //    string[] innerArray = new string[19];
        //    for (int i = 0; i < neighbors.Length; i++)
        //    {
        //        innerArray = neighbors[i];
        //        if (source == innerArray[0])
        //        {
        //            foreach (string next in innerArray.Skip(1))
        //            {
        //                if (visited.Contains(next) == false)
        //                {
        //                    visited = visited + source;
        //                    if (visited.Contains(destination) == true)
        //                    {
        //                        string validPath = "";
        //                        List<string>paths = new List<string>();
        //                        validPath = visited;
        //                        paths.Add(validPath);
        //                    }

        //                    Nodes.Search(neighbors, next, destination, visited);
                            

        //                }

        //            }
        //        }
        //    }
        //}
 
    }

}
