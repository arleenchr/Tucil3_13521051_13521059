using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Edge
    {
        /* attributes */
        public Vertex V1 { get; set; }
        public Vertex V2 { get; set; }
        public double weight { get; set; } // distance between V1 and V2 in meters

        /* ctor */
        public Edge(Vertex V1, Vertex V2, double weight)
        {
            this.V1 = V1;
            this.V2 = V2;
            this.weight = weight;
        }
    }
}