using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph_Implementation {

    public class Edge {

        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }

        public int cost { get; set; }

        public Edge(Vertex Vertex1, Vertex Vertex2) {

            this.Vertex1 = Vertex1;
            this.Vertex2 = Vertex2;

            this.cost = mainForm.INITIAL_COST;
        }

        public Vertex this[int index] {

            get {

                switch (index) {

                    case 0: return Vertex1;
                    case 1: return Vertex2;
                }

                throw new IndexOutOfRangeException();
            }
        }
    }
}
