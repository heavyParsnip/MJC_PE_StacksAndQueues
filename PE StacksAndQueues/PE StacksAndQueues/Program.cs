using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<String> testStack = new MyStack<String>();
            IQueue<double> testQueue = new MyQueue<double>();

            //Stack
            Console.WriteLine("Enter 5 spells to catalogue:");
            for (int i = 0;i < 5; i++)
            {
                string input = Console.ReadLine().Trim();
                testStack.Push(input);
            }
            Console.WriteLine();

            //Print results
            Console.WriteLine("\tSpells resolving in reverse order: ");
            while (testStack.Count > 0)
            {
                Console.WriteLine("\t- " + testStack.Pop());
            }
            Console.WriteLine();


            //Queue
            bool tryDouble;
            Console.WriteLine("Enter 5 prices to catalogue:");
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    string input = Console.ReadLine().Trim();
                    double doubleInput;
                    tryDouble = double.TryParse(input, out doubleInput);
                    if (tryDouble == false)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    else
                    {
                        testQueue.Enqueue(doubleInput);
                    }
                }
                while (tryDouble == false);
            }
            Console.WriteLine();

            //Print results
            double sum = 0;
            Console.WriteLine("Purchasing items:");
            while (testQueue.Count > 0)
            {
                double current = testQueue.Dequeue();
                Console.WriteLine("\t+ " + current + $" - {testQueue.Count} items left");
                sum += current;
            }
            Console.WriteLine($"Total = {sum:N2}");
            Console.ReadLine();
        }
    }
}