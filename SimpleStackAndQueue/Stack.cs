using System;
namespace SimpleStackAndQueue
{
    internal class Stack
    {
        LinkedList linkedList;
        public Stack()
        {
            linkedList = new LinkedList();
        }
        public void Push(int data)
        {
            linkedList.AddNode(data);
        }
        public void DisplayStack()
        {
            Console.WriteLine("Stack elements are");
            linkedList.Display();
        }
        public void Peek()
        {
            var top = linkedList.head;
            Console.WriteLine("Top element is " + top.data);
        }
        public void Pop()
        {
            if (linkedList.head == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Poped " + linkedList.head.data);
                linkedList.head = linkedList.head.next;
            }
        }
        public void IsEmpty()
        {
            while (linkedList.head != null)
            {
                Peek();
                Pop();
            }
        }
    }
}

