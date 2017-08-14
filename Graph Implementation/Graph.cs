using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph_Implementation {

    public class Graph : IEnumerable {

        public List<Vertex> Vertices = new List<Vertex>();
        public List<Edge>   Edges    = new List<Edge>();

        /// <summary>
        /// Returns Enumerator of Vertex-List in a graph.
        /// </summary>
        public IEnumerator GetEnumerator() {
            return this.Vertices.GetEnumerator();
        }

        /// <summary>
        /// Returns a Vertex from Vertex-List
        /// </summary>
        public Vertex this[int index] {
            get { return this.Vertices[index]; }
        }

        /// <summary>
        /// Returns a Vertex count in a graph.
        /// </summary>
        public int V { get { return this.Vertices.Count; } }

        /// <summary>
        /// Streams all unvisited vertices in a graph.
        /// </summary>
        public IEnumerable<Vertex> nonVisited() {
            return (from v in this.OfType<Vertex>() where v.visited == false select v);
        }

        /// <summary>
        /// Streams all vertices whose 'permanent variable' is false.
        /// </summary>
        public IEnumerable<Vertex> nonPermanent() {
            return (from v in this.OfType<Vertex>() where v.permanent == false select v);
        }

        /// <summary>
        /// Returns vertex of who x and y coordinates match with entered.
        /// </summary>
        public Vertex Get(int x, int y) {
            return (from v in this.OfType<Vertex>() where v.x == x && v.y == y select v).FirstOrDefault();
        }

        /// <summary>
        /// Returns an Edge of two vertices.
        /// </summary>
        public Edge Get(Vertex V1, Vertex V2) {
            return (from e in this.Edges where (e[0] == V1 && e[1] == V2) || (e[0] == V2 && e[1] == V1) select e).FirstOrDefault();
        }

        /// <summary>
        /// Adds a new Vertex to a graph.
        /// </summary>
        public void Add(Vertex v) {

            if (this.V < mainForm.VERTEX_LIMIT)
                this.Vertices.Add(v);

            else
                System.Windows.Forms.MessageBox.Show("Vertex limit reached!", "Warning");
        }

        /// <summary>
        /// Removes vertex from graph then sorts all vertices by ID and recalculates Ids
        /// </summary>
        public void Remove(Vertex v) {

            this.Vertices.Remove(v);
            this.Vertices.Sort();

            for (int i = 0; i < V; i++)
                Vertices[i].id = i;

            this.Disconnect(v);
        }

        /// <summary>
        /// Connects two vertices (Creates an Edge (If already exists - increases cost by INITIAL_COST constant))
        /// </summary>
        public void Connect(Vertex V1, Vertex V2) {

            foreach (Edge e in this.Edges)
                if ((e[0] == V1 && e[1] == V2) || (e[0] == V2 && e[1] == V1)) {

                    e.cost += mainForm.INITIAL_COST;

                    return;
                }

            this.Edges.Add(new Edge(V1, V2));
        }

        /// <summary>
        /// Removes all connections from a Vertex.
        /// </summary>
        public void Disconnect(Vertex v) {

            Stack<Edge> garbage = new Stack<Edge>();

            foreach (Edge e in this.Edges)
                if (e[0] == v || e[1] == v) {

                    garbage.Push(e);
                }

            while (garbage.Count > 0)
                this.Edges.Remove(garbage.Pop());
        }

        /// <summary>
        /// Calculates the shortest distance between vertices using Dijkstra's algorithm.
        /// </summary>
        public static void Dijkstra(Graph _Graph, int start_id) {

            Vertex initial = _Graph[start_id];

            initial.min_cost  = 0;
            initial.permanent = true;
            initial.source_id = initial.id;

            for (int i = 0; i < _Graph.V; i++) {

                int min_cost = int.MaxValue, index = 0;
                foreach (Vertex v in _Graph.nonPermanent()) {

                    if (_Graph.Get(initial, v) != null)
                        if (initial + _Graph.Get(initial, v) < v.min_cost) {

                            v.min_cost  = initial + _Graph.Get(initial, v);
                            v.source_id = initial.id;
                        }

                    if (v.min_cost < min_cost) {

                        min_cost = v.min_cost;
                        index    = v.id;
                    }
                }

                _Graph[index].permanent = true;
                initial = _Graph[index];
            }
        }

        /// <summary>
        /// Calculates the shortest distances between all pairs of vertices using Floyd-Warshall algorithm.
        /// </summary>
        public static void Floyd_Warshall(Graph _Graph) {

            int[,] Adjacency = new int[_Graph.V, _Graph.V];

            foreach (Edge e in _Graph.Edges) {

                Adjacency[e[0].id, e[1].id] = e.cost;
                Adjacency[e[1].id, e[0].id] = e.cost;
            }

            for (int i = 0; i < _Graph.V; i++)
                for (int j = 0; j < _Graph.V; j++)
                    if (i != j && Adjacency[i, j] <= 0)
                        Adjacency[i, j] = 999;

            for (int k = 0; k < _Graph.V; k++)
                for (int i = 0; i < _Graph.V; i++)
                    for (int j = 0; j < _Graph.V; j++) {

                        if (Adjacency[i, k] + Adjacency[k, j] < Adjacency[i, j])
                            Adjacency[i, j] = Adjacency[i, k] + Adjacency[k, j];
                    }

            FloydCostTable costTable = new FloydCostTable(_Graph, Adjacency) {

                Size = new System.Drawing.Size(78 + _Graph.V * 30, 96 + _Graph.V * 30)
            };

            costTable.ShowDialog();
        }

        /// <summary>
        /// Traverses throught all vertices using Depth-First Search rule.
        /// </summary>
        public static string DFS(Graph _Graph, int start_key) {

            string plaintext = string.Empty;

            int[,] Adjacency = new int[_Graph.V, _Graph.V];

            foreach (Edge e in _Graph.Edges) {

                Adjacency[e[0].id, e[1].id] = e.cost;
                Adjacency[e[1].id, e[0].id] = e.cost;
            }

            Stack<int> dfs_stack = new Stack<int>();
            dfs_stack.Push(start_key);

            _Graph[start_key].visited = true;
            plaintext += (start_key + 1);

            while (dfs_stack.Count != 0) {
            A:
                for (int i = 0; i < _Graph.V; i++)
                    if (Adjacency[dfs_stack.Peek(), i] != 0 && dfs_stack.Peek() != i && _Graph[i].visited == false) {

                        dfs_stack.Push(i);
                        _Graph[i].visited = true;

                        plaintext += " -> " + (i + 1);

                        // BAD IDEA
                        goto A;
                    }

                plaintext += ")";
                dfs_stack.Pop();
            }

            foreach (Vertex v in _Graph.nonVisited())
                plaintext += "\nUnvisited Vertex -> " + (v.id + 1);

            return plaintext;
        }

        /// <summary>
        /// Traverses throught all vertices using Breadth-First Search rule.
        /// </summary>
        public static string BFS(Graph _Graph, int start_key) {

            string plaintext = string.Empty;

            int[,] Adjacency = new int[_Graph.V, _Graph.V];

            foreach (Edge e in _Graph.Edges) {

                Adjacency[e[0].id, e[1].id] = e.cost;
                Adjacency[e[1].id, e[0].id] = e.cost;
            }

            Queue<int> bfs_queue = new Queue<int>();

            bfs_queue.Enqueue(start_key);
            _Graph[start_key].visited = true;
            plaintext += (start_key + 1);
            
            while (bfs_queue.Count != 0) {

                for (int i = 0; i < _Graph.V; i++)
                    if (Adjacency[bfs_queue.Peek(), i] != 0 && bfs_queue.Peek() != i && _Graph[i].visited == false) {

                        bfs_queue.Enqueue(i);

                        _Graph[i].visited = true;
                        plaintext += " -> " + (i + 1);
                    }

                plaintext += ")";
                bfs_queue.Dequeue();
            }

            foreach (Vertex v in _Graph.nonVisited())
                plaintext += "\nUnvisited Vertex -> " + (v.id + 1);

            return plaintext;
        }
    }
}
