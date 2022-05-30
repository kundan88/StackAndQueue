using System;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.DisplayStack();
            stack.Peek();
            stack.IsEmpty();
            stack.DisplayStack();

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.DisplayQueue();
        }
    }
}

