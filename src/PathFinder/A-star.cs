using PathFinder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Astar : Solver
    {
        public Astar(Graph g, Vertex s, Vertex e) : base(g, s, e) { }

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

        public void AstarSolver()
        {
            /* initialize */
            solution = new List<VertexPathCost>() { };
            distance = 0;
            PriorityQueueCost prioqueue = new PriorityQueueCost();
            VertexPathCost currentVertex = new VertexPathCost(start, new List<VertexPathCost>() { }, distance);
            Boolean isArrived = (currentVertex.vertex == end);
            Boolean[] isVisited = new Boolean[graph.vertexCount];
            double cost;
            history = new List<(VertexPathCost, List<VertexPathCost>)>() { };
            List<VertexPathCost> historyQueue = new List<VertexPathCost>() { };

            // Add vertices adjacent with start vertex to prioqueue
            for (int j = 0; j < graph.vertexCount; j++)
            {
                if (graph.adaJalan(start, graph.vertices[j]))
                {
                    cost = graph.getWeight(start, graph.vertices[j]) + straightDist(graph.vertices[j], end);
                    prioqueue.Enqueue(new VertexPathCost(graph.vertices[j], new List<VertexPathCost>() { currentVertex }, cost));
                    historyQueue.Add(new VertexPathCost(graph.vertices[j], new List<VertexPathCost>() { currentVertex }, cost));
                }
            }
            history.Add((currentVertex, historyQueue)); // add to history
            isVisited[graph.findIndex(start)] = true; // marked as visited

            // Search while hasn't arrived at the destination and prioqueue is not empty
            while (!isArrived && prioqueue.Count() > 0)
            {
                // Dequeue
                currentVertex = prioqueue.Peek();
                prioqueue.Dequeue();
                isVisited[graph.findIndex(currentVertex.vertex)] = true;

                // check if has reached the destination
                if (currentVertex.vertex == end)
                {
                    isArrived = true;
                    currentVertex.path.Add(currentVertex);
                    history.Add((currentVertex, new List<VertexPathCost>() { }));
                    break;
                }

                // enqueue
                historyQueue = new List<VertexPathCost>() { };
                for (int j = 0; j < graph.vertexCount; j++)
                {
                    if (!isVisited[j] && graph.adaJalan(currentVertex.vertex, graph.vertices[j]))
                    {
                        List<VertexPathCost> currentPath = new List<VertexPathCost>(currentVertex.path);
                        if (currentPath.Last() != currentVertex)
                        {
                            currentPath.Add(currentVertex);
                        }
                        cost = currentVertex.cost + graph.getWeight(currentVertex.vertex, graph.vertices[j]) + straightDist(graph.vertices[j], end);
                        prioqueue.Enqueue(new VertexPathCost(graph.vertices[j], currentPath, cost));
                        historyQueue.Add(new VertexPathCost(graph.vertices[j], currentPath, cost));
                    }
                }
                history.Add((currentVertex, historyQueue)); // add to history
            }

            if (prioqueue.Count() == 0 && !isArrived)
            {
                // path tidak ditemukan
                distance = 0;
                solution = new List<VertexPathCost>() { };
            }
            else
            {
                // result
                if (currentVertex.vertex == start)
                {
                    currentVertex.path.Add(currentVertex);
                }
                solution = currentVertex.path;
                distance = 0;
                Vertex v1;
                Vertex v2;
                for (int i = 0; i < solution.Count - 1; i++)
                {
                    v1 = solution[i].vertex;
                    v2 = solution[i + 1].vertex;
                    distance += graph.getWeight(v1, v2);
                }
            }
        }
    }
}
