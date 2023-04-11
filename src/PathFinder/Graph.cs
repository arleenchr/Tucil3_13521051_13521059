using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Graph
    {
        /* attributes */
        public int vertexCount { get; set; }
        public List<Vertex> vertices { get; set; }
        public List<Edge> edges { get; set; }
        public int[,] adjacencyMatrix { get; set; }

        /* ctor */
        public Graph()
        {
            vertexCount = 0;
            vertices = new List<Vertex>();
            edges = new List<Edge>();
            adjacencyMatrix = null;
        }
        public Graph(int vertexCount, List<Vertex> vertices, List<Edge> edges, int[,] adjacencyMatrix)
        {
            this.vertexCount = vertexCount;
            this.vertices = vertices;
            this.edges = edges;
            this.adjacencyMatrix = adjacencyMatrix;
        }

        public int findIndex(Vertex v)
        {
            bool found = false;
            int i = 0;
            while (i < vertexCount && !found)
            {
                if (vertices[i] == v)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            if (found)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        /* method */
        public Boolean adaJalan(Vertex v1, Vertex v2)
        {
            // cari index v1 dan v2
            int i = findIndex(v1);
            int j = findIndex(v2);

            if (adjacencyMatrix != null && adjacencyMatrix[i, j] > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getWeight(Vertex v1, Vertex v2)
        {
            bool found = false;
            int i = 0;
            while (i < edges.Count && !found)
            {
                if (edges[i].V1 == v1 && edges[i].V2 == v2)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            if (found)
            {
                return edges[i].weight;
            }
            else
            {
                return -1;
            }
        }

        public List<Vertex> getNeighbour(Vertex v)
        {
            int i = findIndex(v);
            List<Vertex> arr = new List<Vertex>();
            for (int j = 0; j < vertexCount; j++)
            {
                if (adjacencyMatrix[i, j] == 1)
                {
                    arr.Add(vertices[j]);
                }
            }
            return arr;
        }

        public Vertex getVertex(String name)
        {
            bool found = false;
            int i = 0;
            while(i < vertices.Count && !found)
            {
                if (vertices[i].locName == name)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return vertices[i];
        }
    }
}
