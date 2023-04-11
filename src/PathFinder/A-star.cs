using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Collections.Generic;

namespace PathFinder
{
    public class Astar : Solver
    {
        /* ctor */
        public Astar(Graph g, Vertex s, Vertex e) : base(g,s,e) { }

        /* method */
        public double straightDist(Vertex v1, Vertex v2)
        {
            double v1lat = v1.coordinate.latitude * (Math.PI / 180);
            double v2lat = v2.coordinate.latitude * (Math.PI / 180);
            double difflon = (v1.coordinate.longitude - v2.coordinate.longitude) * (Math.PI / 180);

            double a = Math.Pow(Math.Sin((v1lat - v2lat) / 2), 2) + Math.Cos(v1lat) * Math.Cos(v2lat) * Math.Pow(Math.Sin(difflon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = 6378137 * c;
            return d;
        }

        public List<(Vertex, double)> getNeighDist(Vertex v)
        {
            List<(Vertex, double)> withDist = new List<(Vertex, double)>();
            List<Vertex> neigh = graph.getNeighbour(v);

            for (int i = 0; i < neigh.Count; i++)
            {
                withDist.Add((neigh[i], straightDist(neigh[i], end) + distance));
            }

            return withDist;
        }

        public Vertex chooseNeigh(List<(Vertex, double)> neigh)
        {
            (Vertex, double) min = neigh[0]; ;
            for (int i = 1; i < neigh.Count; i++)
            {
                if (!contain(neigh[i].Item1))
                {
                    if (neigh[i].Item2 < min.Item2)
                    {
                        min = neigh[i];
                    }
                }
            }
            return min.Item1;
        }

        public bool contain(Vertex v)
        {
            bool found = false;
            int i = 0;
            while (i < solution.Count && !found)
            {
                if (solution[i] == v)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return found;
        }

        public bool containEnd()
        {
            return contain(end);
        }

        public void printSolution()
        {
            for (int i = 0; i < solution.Count; i++)
            {
                Console.Write(solution[i].locName);
                Console.Write(" ");
            }
            Console.WriteLine("");
        }

        public void search()
        {
            solution.Add(start);
            Vertex curr = start;

            while (!containEnd())
            {
                // generate tetangga
                List<(Vertex, double)> neighbour = getNeighDist(curr);

                // pilih tetangga
                Vertex chosen = chooseNeigh(neighbour);

                // add solution
                solution.Add(chosen);
                printSolution();

                curr = chosen;
            }
        }


        // public static void Main(){
        //     Console.WriteLine("START");
        //     FileReader reader = new FileReader();
        //     Graph graph = reader.readFile("\\c #\\tes path finder\\Sample.txt");
        //     Astar a = new Astar(graph, graph.vertices[0], graph.vertices[2]);
        //     Console.WriteLine(a.start.locName);
        //     Console.WriteLine(a.end.locName);

        //     List<(Vertex, double)> neighbour = a.getNeighDist(a.start);
        //     Console.WriteLine("ITB Neighbour: ");
        //     for(int i = 0; i < neighbour.Count; i++){
        //         Console.Write(neighbour[i].Item1.locName);
        //         Console.WriteLine(neighbour[i].Item2.ToString());
        //     }

        //     a.search();
        // }
    }
}