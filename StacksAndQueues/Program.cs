using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to STACK!");
            //Stack
            Stack list = new Stack();
            list.push(56);
            list.push(30);
            list.push(70);
            list.Display();
            Console.WriteLine();
            list.Peek();
            list.Pop();
            list.Pop();
            list.Pop();
            list.Pop();
            list.Display();

            Console.WriteLine("===============================");
            Console.WriteLine("Welcome to QUEUE!");
            //Queue
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeu();
            queue.Display();

            Console.ReadLine();
        }
    }
}
