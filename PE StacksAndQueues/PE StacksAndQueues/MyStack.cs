using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_StacksAndQueues
{
    class MyStack<T> : IStack<T>
    {
        //FIELDS
        List<T> stack = new List<T>();


        //PROPERTIES
        public int Count
        {
            get { return stack.Count(); }
        }

        public bool IsEmpty
        {
            get
            {
                if(stack.Count == 0)
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
            if(stack.Count == 0)
            {
                return default(T);
            }
            else
            {
                return stack[stack.Count - 1];
            }
        }

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            if (stack.Count == 0)
            {
                return default(T);
            }
            else
            {
                T topOfStack = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return topOfStack;
            }
        }
    }
}
