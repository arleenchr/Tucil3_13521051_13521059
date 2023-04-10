using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Coordinate
    {
        /* attributes */
        public double latitude { get; set; } // row
        public double longitude { get; set; } // col

        /* ctor */
        public Coordinate(double _latitude, double _longitude)
        {
            latitude = _latitude;
            longitude = _longitude;
        }
    }
}
