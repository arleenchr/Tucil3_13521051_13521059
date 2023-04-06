using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Point
    {
        public int x { get; set; } // row
        public int y { get; set; } // col

        /* constructor */
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
