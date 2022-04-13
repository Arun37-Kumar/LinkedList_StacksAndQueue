using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Stack
    {
        public Node top;
        public Stack()
        {
            this.top = null;
        }

        public void push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed in stack.", value);
        }

        //To display the elements in the stack
        public void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        //To check for the element
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            Console.WriteLine("{0} is at the top of the stack.", this.top.data);
        }

        //Pop opertions in stacks
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            Console.WriteLine("Value popped is {0}",this.top.data);
            this.top = this.top.next;
        }

        //Check for empty Stack
        public void isEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }

    }
}
