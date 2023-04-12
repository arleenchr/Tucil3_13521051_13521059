using PathFinder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class UCS : Solver
    {
        public UCS(Graph g, Vertex s, Vertex e) : base(g, s, e) { }

        public void UCSSolver()
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
                    cost = graph.getWeight(start, graph.vertices[j]);
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
                        cost = currentVertex.cost + graph.getWeight(currentVertex.vertex, graph.vertices[j]);
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
                distance = currentVertex.cost;
            }
        }
    }
}