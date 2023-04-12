using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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
                string line = reader.ReadLine();
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

                // adjacency matrix
                vCount = 0;
                graph.adjacencyMatrix = new double[graph.vertexCount, graph.vertexCount];
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

                // edges
                // list of edges between vertex 1 and vertex 2 (with value 1 in adjacency matrix)
                // weight calculated by haversine formula between two vertex coordinates (longitude and latitude)
                // precondition: adjacency matrix is symmetrical
                for (int i = 0; i < graph.adjacencyMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < graph.adjacencyMatrix.GetLength(1); j++)
                    {
                        if (graph.adjacencyMatrix[i, j] != 0)
                        {
                            Vertex V1 = graph.vertices[i];
                            Vertex V2 = graph.vertices[j];
                            graph.edges.Add(new Edge(V1, V2, graph.adjacencyMatrix[i, j]));
                        }
                    }
                }
            }
            return graph;
        }
    }
}
