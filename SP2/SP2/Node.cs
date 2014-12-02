using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP2
{
   public class Node
    {
        public string Name;
        public Neighbor[] neighbors { get;  set; }


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
            A.neighbors = new Neighbor[] {new Neighbor(B, 70), new Neighbor(I, 100)};
            B.neighbors = new Neighbor[] {new Neighbor(A, 70), new Neighbor(C, 10), new Neighbor(D, 25)};
            C.neighbors = new Neighbor[] {new Neighbor(B, 10), new Neighbor(D, 15), new Neighbor(E, 5)};
            D.neighbors = new Neighbor[] {new Neighbor(B, 25), new Neighbor(C, 15), new Neighbor(G, 45)};
            E.neighbors = new Neighbor[] {new Neighbor(C, 5), new Neighbor(F, 5)};
            F.neighbors = new Neighbor[] {new Neighbor(E, 5), new Neighbor(I, 35)};
            G.neighbors = new Neighbor[] {new Neighbor(D, 45), new Neighbor(H, 10)};
            H.neighbors = new Neighbor[] {new Neighbor(G, 10), new Neighbor(M, 45), new Neighbor(N, 160)};
            I.neighbors = new Neighbor[] {new Neighbor(A, 100),new Neighbor(F, 35), new Neighbor(K, 30)};
            J.neighbors = new Neighbor[] {new Neighbor(K, 20), new Neighbor(L, 7)};
            K.neighbors = new Neighbor[] {new Neighbor(I, 30), new Neighbor(J, 20), new Neighbor(L, 90)};
            L.neighbors = new Neighbor[] {new Neighbor(J, 7), new Neighbor(K, 90), new Neighbor(N, 60)};
            M.neighbors = new Neighbor[] {new Neighbor(H, 45), new Neighbor(N, 210)};
            N.neighbors = new Neighbor[] {new Neighbor(H, 160), new Neighbor(L, 60), new Neighbor(M, 210), new Neighbor(P, 12) };
            O.neighbors = new Neighbor[] {new Neighbor(P, 180), new Neighbor(Q, 65), new Neighbor(S, 300)};
            P.neighbors = new Neighbor[] {new Neighbor(N, 12), new Neighbor(O, 180), new Neighbor(S, 10)};
            Q.neighbors = new Neighbor[] {new Neighbor(O, 65), new Neighbor(R, 10), new Neighbor (S, 75)};
            R.neighbors = new Neighbor[] {new Neighbor(Q, 10), new Neighbor(S, 60)};
            S.neighbors = new Neighbor[] {new Neighbor(O, 300), new Neighbor(P, 10), new Neighbor(Q, 75), new Neighbor(R, 60)};
            List<Node> nodeList = new List<Node>()
            {
                A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S
            };
            return nodeList;
        }
 
    }

}
