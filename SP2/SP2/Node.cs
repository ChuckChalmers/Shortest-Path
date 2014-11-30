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
        public Node[] neighbors { get;  set; }


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
            return nodeList;
        }
 
    }

}
