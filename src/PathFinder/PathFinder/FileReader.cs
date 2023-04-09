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
            Graph graph = new Graph();

            string pathfilename = "..\\..\\" + filename;

            using (StreamReader reader = new StreamReader(pathfilename))
            {
                string? line = reader.ReadLine();
                if (line == null) throw new InvalidDataException("File tidak valid!");

                // vertex count
                int vertexCount;
                var Result = int.TryParse(line, out vertexCount);
                if (!Result) throw new InvalidDataException("File tidak valid!");
                graph.vertexCount = vertexCount;

                // vertices
                int vCount = 0;
                line = reader.ReadLine();
                while (vCount < graph.vertexCount && line != null)
                {
                    string[] vertex = line.Split(' ');
                    if (vertex.Length != 3) throw new InvalidDataException("File tidak valid!");
                    string locName = vertex[0];
                    double coordinateX = Convert.ToDouble(vertex[1], CultureInfo.InvariantCulture);
                    double coordinateY = Convert.ToDouble(vertex[2], CultureInfo.InvariantCulture);
                    graph.vertices.Add(new Vertex(locName, new Coordinate(coordinateX, coordinateY)));

                    line = reader.ReadLine();
                    vCount++;
                }
                /*for (int v = 0; v < graph.vertices.Count; v++)
                {
                    Console.WriteLine(String.Format("loc = {0}, position = {1},{2}", graph.vertices[v].locName, graph.vertices[v].coordinate.latitude, graph.vertices[v].coordinate.longitude));
                }*/

                // adjacency matrix
                vCount = 0;
                graph.adjacencyMatrix = new int[graph.vertexCount, graph.vertexCount];
                while (vCount < graph.vertexCount && line != null)
                {
                    string[] matrixRow = line.Split(' ');
                    if (matrixRow.Length != graph.vertexCount) throw new InvalidDataException("File tidak valid");

                    for (int col = 0; col < graph.vertexCount; col++)
                    {
                        graph.adjacencyMatrix[vCount, col] = int.Parse(matrixRow[col]);
                    }

                    line = reader.ReadLine();
                    vCount++;
                }

                /*for (int row = 0; row < graph.adjacencyMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < graph.adjacencyMatrix.GetLength(1); col++)
                    {
                        Console.Write(graph.adjacencyMatrix[row, col]);
                        if (col < graph.adjacencyMatrix.GetLength(1) - 1)
                        {
                            Console.Write(", ");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }*/

                // edges
                // list of edges between vertex 1 and vertex 2 (with value 1 in adjacency matrix)
                // weight calculated by haversine formula between two vertex coordinates (longitude and latitude)
                // precondition: adjacency matrix is symmetrical
                for (int i = 1; i < graph.adjacencyMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (graph.adjacencyMatrix[i, j] != 0)
                        {
                            Vertex V1 = graph.vertices[i];
                            Vertex V2 = graph.vertices[j];
                            graph.edges.Add(new Edge(V1, V2));
                        }
                    }
                }

                /*for (int count = 0; count<graph.edges.Count; count++)
                {
                    Console.WriteLine(String.Format("V1 = {0}, V2 = {1}, weight = {2}", graph.edges[count].V1.locName, graph.edges[count].V2.locName, graph.edges[count].weight));
                }*/
            }
            return graph;
        }
    }
}
