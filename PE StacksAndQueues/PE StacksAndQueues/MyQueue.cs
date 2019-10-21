using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_StacksAndQueues
{
    class MyQueue : IQueue
    {
        //FIELDS
        List<String> queue = new List<String>();


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
        public String Peek()
        {
            if (queue.Count == 0)
            {
                return null;
            }
            else
            {
                return queue[0];
            }
        }

        public void Enqueue(String item)
        {
            queue.Add(item);
        }

        public String Dequeue()
        {
            if (queue.Count == 0)
            {
                return null;
            }
            else
            {
                String frontOfQueue = queue[0];
                queue.Remove(queue[0]);
                return frontOfQueue;
            }
        }

    }
}
