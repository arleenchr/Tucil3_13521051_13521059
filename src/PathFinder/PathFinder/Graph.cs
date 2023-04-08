﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Graph
    {
        public int vertexCount { get; set; }
        public List<Vertex> vertices { get; set; }
        public List<Edge> edges { get; set; }
        public double[,] adjacencyMatrix { get; set; }

        /* ctor */
        public Graph()
        {
            vertexCount = 0;
            vertices = new List<Vertex>();
            edges = new List<Edge>();
            adjacencyMatrix = null;
        }
        public Graph(int vertexCount, List<Vertex> vertices, List<Edge> edges, double[,] adjacencyMatrix)
        {
        this.vertexCount = vertexCount;
        this.vertices = vertices;
        this.edges = edges;
        this.adjacencyMatrix = adjacencyMatrix;
        }
    }
}
