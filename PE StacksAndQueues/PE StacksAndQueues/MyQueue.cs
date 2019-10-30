using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_StacksAndQueues
{
    class MyQueue<T> : IQueue<T>
    {
        //FIELDS
        List<T> queue = new List<T>();


        //PROPERTIES
        public int Count
        {
            get { return queue.Count(); }
        }

        public bool IsEmpty
        {
            get
            {
                if(queue.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //CONSTRUCTORS

        //METHODS
        public T Peek()
        {
            if (queue.Count == 0)
            {
                return default(T);
            }
            else
            {
                return queue[0];
            }
        }

        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
            {
                return default(T);
            }
            else
            {
                T frontOfQueue = queue[0];
                queue.Remove(queue[0]);
                return frontOfQueue;
            }
        }

    }
}
