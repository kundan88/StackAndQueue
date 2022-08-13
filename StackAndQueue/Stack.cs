using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Stack
    {
        LinkedList linkedList = new LinkedList();
        public void Push(Node node)
        {
            linkedList.AddNode(node);
        }

        public void DisplayStack()
        {
            linkedList.Display();
        }
        public void Pop(Node node)
        {
            Console.WriteLine("\nStack: ");
            linkedList.Empty();
        }
    }
}

