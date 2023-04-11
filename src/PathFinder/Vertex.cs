using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Vertex
    {
        /* attributes */
        public String locName { get; set; }
        public Coordinate coordinate { get; set; }

        /* ctor */
        public Vertex(String locName, Coordinate coordinate)
        {
            this.locName = locName;
            this.coordinate = coordinate;
        }
    }

    public class VertexPathCost
    {
        /* attributes */
        public Vertex vertex { get; set; }
        public List<Vertex> path { get; set; }
        public double cost { get; set; }
        /* ctor */
        public VertexPathCost(Vertex vertex, List<Vertex> path, double cost)
        {
            this.vertex = vertex;
            this.path = path;
            this.cost = cost;
        }
        public VertexPathCost(Vertex vertex)
        {
            this.vertex = vertex;
            this.path = new List<Vertex>() { };
            this.cost = 0;
        }
    }
}
