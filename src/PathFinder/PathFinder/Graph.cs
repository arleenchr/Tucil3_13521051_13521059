using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Graph
    {
        public Vertex root { get; set; }
        public List<LinkedList<Edge>> adjacency { get; set; }
        
        /* ctor */
        public Graph(Vertex root) {
            this.root = root;
            adjacency = new List<LinkedList<Edge>>() { };
        }

        /*
        public void addEdge(Edge edge)
        {
            adjacency.Add(new LinkedList<Edge>());
            adjacency.Last().AddLast(edge);
        }*/
    }

    public class Edge
    {
        public Graph neighbor { get; set; }
        public double weight { get; set;}

        public Edge(Graph neighbor, double weight)
        {
            this.neighbor = neighbor;
            this.weight = weight;
        }
    }
}
