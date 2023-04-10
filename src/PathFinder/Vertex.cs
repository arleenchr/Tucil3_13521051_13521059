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
        public String locName { get; set; }
        public Coordinate coordinate { get; set; }

        /* ctor */
        public Vertex(String locName, Coordinate coordinate)
        {
            this.locName = locName;
            this.coordinate = coordinate;
        }
    }
}
