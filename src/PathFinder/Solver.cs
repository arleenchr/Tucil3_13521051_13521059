using PathFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Solver
    {
        /* attributes */
        public Graph graph { get; set; }
        public Vertex start { get; set; }
        public Vertex end { get; set; }
        public double distance { get; set; }
        public List<Vertex> solution { get; set; }
        public List<(VertexPathCost, List<VertexPathCost>)> history { get; set; }

        /* ctor */
        public Solver(Graph g, Vertex s, Vertex e)
        {
            graph = g;
            start = s;
            end = e;
            distance = 0;
            solution = new List<Vertex>();
            history = new List<(VertexPathCost, List<VertexPathCost>)>() { };
        }
    }
}
