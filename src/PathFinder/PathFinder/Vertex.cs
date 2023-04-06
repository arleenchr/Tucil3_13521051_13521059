using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Vertex
    {
        /* attributes */
        public Point coordinate { get; set; }
        public String locName { get; set; }

        /* ctor */
        public Vertex(Point coordinate, String locName)
        {
            this.coordinate = coordinate;
            this.locName = locName;
        }
    }
}
