using System;
namespace StackAndQueue
{
    internal class Queue
    {
        LinkedList linkedList;
        public Queue()
        {
            linkedList = new LinkedList();
        }
        public void Enqueue(int data)
        {
            linkedList.AppendNode(data);
        }
        public void DisplayQueue()
        {
            Console.WriteLine("In queue -");
            linkedList.Display();
        }
        public void Dequeue()
        {
            linkedList.DeleteNodeAtFirst();
        }
    }
}

