using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Point
    {
        public double x { get; set; } // row
        public double y { get; set; } // col

        /* constructor */
        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
    }
}
