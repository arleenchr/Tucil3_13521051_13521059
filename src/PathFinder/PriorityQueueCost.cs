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
            return queue[0];
        }
        public int Count()
        {
            return queue.Count;
        }

        public void Enqueue(VertexPathCost v)
        {
            if (queue.Count == 0)
            {
                queue.Add(v);
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
            queue.RemoveAt(0);
        }
    }
}
