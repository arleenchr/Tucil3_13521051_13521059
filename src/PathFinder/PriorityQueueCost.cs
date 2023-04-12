using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    class PriorityQueueCost
    {
        // Priority Queue of VertexPathCost, ordered by cost (ascending)
        public List<VertexPathCost> queue { get; set; }

        /* ctor */
        public PriorityQueueCost()
        {
            queue = new List<VertexPathCost>() { };
        }
        public PriorityQueueCost(List<VertexPathCost> queue)
        {
            this.queue = queue;
        }

        /* methods */
        public VertexPathCost Peek()
        {
            // get the head of the queue (0th element)
            return queue[0];
        }
        public int Count()
        {
            // get the number of elements in queue
            return queue.Count;
        }

        public void Enqueue(VertexPathCost v)
        {
            // enqueue with priority (cost priority, ascending)
            if (queue.Count == 0)
            {
                queue.Add(v); // if queue is empty
            }
            else
            {
                // insert into queue according to its cost
                bool isFound = false;
                int idx = queue.Count - 1;
                while (idx > 0 && !isFound)
                {
                    if (v.cost < queue[idx].cost)
                    {
                        idx--;
                    }
                    else
                    {
                        isFound = true;
                    }
                }

                if (idx == 0)
                {
                    if (v.cost < queue[idx].cost)
                    {
                        queue.Insert(idx, v);
                    }
                    else
                    {
                        queue.Insert(idx + 1, v);
                    }
                }
                else if (idx == queue.Count - 1)
                {
                    queue.Add(v);
                }
                else
                {
                    queue.Insert(idx + 1, v);
                }
            }
        }
        public void Dequeue()
        {
            // remove 0th element of the queue
            queue.RemoveAt(0);
        }
    }
}
