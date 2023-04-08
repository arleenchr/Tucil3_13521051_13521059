using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class FileReader
    {
        public Graph readFile(String filename)
        {
            Graph result = new Graph();

            //string directoryPath = "..\\..\\testcase";
            filename = "..\\..\\" + "Sample.txt";

            using (StreamReader reader = new StreamReader(filename))
            {
                string? line = reader.ReadLine();
                if (line == null) throw new InvalidDataException("File tidak valid!");

                //result.adjacencyMatrix = new double[line.Length / 2 + 1, line.Length / 2 + 1];
                //int count = 0;

                //Console.WriteLine(line[0]);

                /* adjacency matrix */
                string[] values = line.Split(' ');
                result.adjacencyMatrix = new double[values.Length, values.Length];
                result.vertexCount = result.adjacencyMatrix.GetLength(0);

                int i = 0;
                while (i < result.adjacencyMatrix.GetLength(0) && line != null)
                {
                    int j = 0;
                    while (j < values.Length)
                    {
                        result.adjacencyMatrix[i, j] = Convert.ToDouble(values[j], CultureInfo.InvariantCulture);
                        j++;
                    }
                    line = reader.ReadLine();
                    values = line.Split(' ');
                    i++;
                }

                /*
                for (int row = 0; row < result.adjacencyMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < result.adjacencyMatrix.GetLength(1); col++)
                    {
                        Console.Write(result.adjacencyMatrix[row, col]);
                        if (col < result.adjacencyMatrix.GetLength(1) - 1)
                        {
                            Console.Write(", ");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
                */

                /* vertices */
                result.vertices = new List<Vertex>() { };
                int countV = 0;
                while (countV < result.vertexCount && line != null)
                {
                    string[] vertexInfo = line.Split(',');
                    string locName = vertexInfo[0];
                    double x = Convert.ToDouble(vertexInfo[1], CultureInfo.InvariantCulture);
                    double y = Convert.ToDouble(vertexInfo[2], CultureInfo.InvariantCulture);
                    result.vertices.Add(new Vertex(new Point(x, y), locName));

                    line = reader.ReadLine();
                    countV++;
                }

                /*
                for (int v=0; v<result.vertices.Count; v++)
                {
                    Console.WriteLine(String.Format("loc = {0}, position = {1},{2}", result.vertices[v].locName, result.vertices[v].coordinate.x, result.vertices[v].coordinate.y));
                }
                */

                /* edge */
                result.edges = new List<Edge>() { };
                for (int row = 0; row < result.adjacencyMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < result.adjacencyMatrix.GetLength(1); col++)
                    {
                        if (result.adjacencyMatrix[row, col] > 0)
                        {
                            result.edges.Add(new Edge(result.vertices[row], result.vertices[col], result.adjacencyMatrix[row, col]));
                        }
                    }
                }

                /*
                for (int e=0; e<result.edges.Count; e++)
                {
                    Console.WriteLine(String.Format("v1 = {0}, v2 = {1}, weight = {2}", result.edges[e].V1.locName, result.edges[e].V2.locName, result.edges[e].weight));
                }
                */
            }

            //if (!Validate(grid)) throw new InvalidDataException("File tidak valid!");

            return result;
        }
    }
}
