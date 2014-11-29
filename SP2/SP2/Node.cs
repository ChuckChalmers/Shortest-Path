using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP2
{
    class Node
    {
        public string Name;
        public Node[] neighbors{get; set;}

        public Node(string _Name)
        {
            this.Name = _Name;
        }

        public static List<Node> nodeBuilder()
        {
            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");
            Node G = new Node("G");
            Node H = new Node("H");
            Node I = new Node("I");
            Node J = new Node("J");
            Node K = new Node("K");
            Node L = new Node("L");
            Node M = new Node("M");
            Node N = new Node("N");
            Node O = new Node("O");
            Node P = new Node("P");
            Node Q = new Node("Q");
            Node R = new Node("R");
            Node S = new Node("S");
            A.neighbors = new Node[] { B, I };
            B.neighbors = new Node[] { A, C, D };
            C.neighbors = new Node[] { D, E };
            D.neighbors = new Node[] { B, C, G };
            E.neighbors = new Node[] { C, F };
            F.neighbors = new Node[] { E, I };
            G.neighbors = new Node[] { D, H };
            H.neighbors = new Node[] { G, M, N };
            I.neighbors = new Node[] { A, F, K };
            J.neighbors = new Node[] { K, L };
            K.neighbors = new Node[] { I, J, L };
            L.neighbors = new Node[] { J, K, N };
            M.neighbors = new Node[] { H, N };
            N.neighbors = new Node[] { H, L, M, P };
            O.neighbors = new Node[] { P, Q, S };
            P.neighbors = new Node[] { N, O, S };
            Q.neighbors = new Node[] { R, S };
            R.neighbors = new Node[] { Q, S };
            S.neighbors = new Node[] { O, P, Q, R };
            List<Node> nodeList = new List<Node>()
            {
                A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S
            };

            //List<Node> nodeList = new List<Node>()
            //{
            //    {new Node("A", new string[] {"B" , "I"})},
            //    {new Node("B", new string[] {"A", "C", "D"})},
            //    {new Node("C", new string[] {"D", "E"})},
            //    {new Node("D", new string[] {"B", "C", "G"})},
            //    {new Node("E", new string[] {"C", "F"})},
            //    {new Node("F", new string[] {"E", "I"})},
            //    {new Node("G", new string[] {"D", "H"})},
            //    {new Node("H", new string[] {"G", "M", "N"})},
            //    {new Node("I", new string[] {"A", "F", "K"})},
            //    {new Node("J", new string[] {"K", "L"})},
            //    {new Node("K", new string[] {"I", "J", "L"})},
            //    {new Node("L", new string[] {"J", "K", "N"})},
            //    {new Node("M", new string[] {"H", "N"})},
            //    {new Node("N", new string[] {"H", "L", "M", "P"})},
            //    {new Node("O", new string[] {"P", "Q", "S"})},
            //    {new Node("P", new string[] {"N", "O", "S"})},
            //    {new Node("Q", new string[] {"R", "S"})},
            //    {new Node("R", new string[] {"Q", "S"})},
            //    {new Node("S", new string[] {"O", "P", "Q", "R"})}
            //};
            return nodeList;
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

        //                    Node.Search(neighbors, next, destination, visited);
                            

        //                }

        //            }
        //        }
        //    }
        //}
 
    }

}
