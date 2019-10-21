using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_StacksAndQueues
{
    class MyStack : IStack
    {
        //FIELDS
        List<String> stack = new List<String>();


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
        public String Peek()
        {
            if(stack.Count == 0)
            {
                return null;
            }
            else
            {
                return stack[stack.Count - 1];
            }
        }

        public void Push(String item)
        {
            stack.Add(item);
        }

        public String Pop()
        {
            if (stack.Count == 0)
            {
                return null;
            }
            else
            {
                String topOfStack = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return topOfStack;
            }
        }
    }
}
