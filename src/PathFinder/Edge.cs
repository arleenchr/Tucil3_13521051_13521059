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

        public Edge(Vertex V1, Vertex V2)
        {
            this.V1 = V1;
            this.V2 = V2;
            weight = calculateWeight();
        }

        /* methods */
        public double calculateWeight()
        {
            // calculate weight (distance) between V1 and V2 using Haversine formula
            double lat1 = V1.coordinate.latitude;
            double lon1 = V1.coordinate.longitude;
            double lat2 = V2.coordinate.latitude;
            double lon2 = V2.coordinate.longitude;

            double deltaLat = (Math.PI / 180) * (lat2 - lat1);
            double deltaLon = (Math.PI / 180) * (lon2 - lon1);

            // convert latitude of V1 and V2 to radian
            double radLat1 = (Math.PI / 180) * (lat1);
            double radLat2 = (Math.PI / 180) * (lat2);

            // Haversine formula
            double a = Math.Pow(Math.Sin(deltaLat / 2), 2) + Math.Pow(Math.Sin(deltaLon / 2), 2) * Math.Cos(radLat1) * Math.Cos(radLat2);
            double r = 6378137; // Earth radius (6371 kilometer = 6378137 meter)
            return 2 * r * Math.Asin(Math.Sqrt(a));
        }
    }
}