using PathFinder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class UCS
    {
        public void UCSSolver(Graph graph, Vertex start, Vertex destination, ref List<Vertex> path, ref double distance)
        {
            /* initialize */
            path = new List<Vertex>() { };
            distance = 0;
            PriorityQueueCost prioqueue = new PriorityQueueCost();
            VertexPathCost currentVertex = new VertexPathCost(start, new List<Vertex>() { }, distance);
            Boolean isArrived = (currentVertex.vertex == destination);
            Boolean[] isVisited = new Boolean[graph.vertexCount];
            double cost;

            // Add vertices adjacent with start vertex to prioqueue
            for (int j = 0; j < graph.vertexCount; j++)
            {
                if (graph.adaJalan(start, graph.vertices[j]))
                {
                    cost = graph.getWeight(start, graph.vertices[j]);
                    prioqueue.Enqueue(new VertexPathCost(graph.vertices[j], new List<Vertex>() { start }, cost));

                    //Console.WriteLine("     Enqueue");
                    //Console.WriteLine(String.Format("     {0}, path = {1}, {2}", graph.vertices[j].locName, start.locName, cost));

                }
            }

            isVisited[graph.findIndex(start)] = true;



            while (!isArrived && prioqueue.Count() > 0)
            {
                // Dequeue
                currentVertex = prioqueue.Peek();
                prioqueue.Dequeue();
                isVisited[graph.findIndex(currentVertex.vertex)] = true;

                /*
                Console.Write(String.Format("Current = {0}, path = ", currentVertex.vertex.locName));
                for (int i = 0; i < currentVertex.path.Count; i++)
                {
                    Console.Write(String.Format("{0}, ",currentVertex.path[i].locName));
                }
                Console.WriteLine(currentVertex.cost);
                */

                // check if has reached the destination
                if (currentVertex.vertex == destination)
                {
                    isArrived = true;
                    currentVertex.path.Add(currentVertex.vertex);
                    break;
                }

                // enqueue
                for (int j = 0; j < graph.vertexCount; j++)
                {
                    if (!isVisited[j] && graph.adaJalan(currentVertex.vertex, graph.vertices[j]))
                    {

                        //Console.WriteLine("     Enqueue");
                        //Console.WriteLine(String.Format("     cost = {0} + {1}", currentVertex.cost, graph.getWeight(currentVertex.vertex, graph.vertices[j])));


                        List<Vertex> currentPath = new List<Vertex>(currentVertex.path);
                        if (currentPath.Last() != currentVertex.vertex)
                        {
                            currentPath.Add(currentVertex.vertex);
                        }
                        cost = currentVertex.cost + graph.getWeight(currentVertex.vertex, graph.vertices[j]);
                        prioqueue.Enqueue(new VertexPathCost(graph.vertices[j], currentPath, cost));

                        /*
                        Console.Write(String.Format("     {0}, path = ", graph.vertices[j].locName));
                        for (int i=0; i<currentPath.Count; i++)
                        {
                            Console.Write(String.Format("{0}, ", currentPath[i].locName));
                        }
                        Console.WriteLine(cost);
                        */
                    }
                }
            }

            path = currentVertex.path;
            distance = currentVertex.cost;
        }
    }
}
