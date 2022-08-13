using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedList
    {
        public Node head;
       
        public void AddNode(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                //if node then add new node as head
                node.next = head;
                head = node;
            }
        }
        public void Empty()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Value Poped is {0}", head.data);
            head = head.next;
        }
        public void Append(int data)
        {
            //create new node
            Node node = new Node(data);
            //check if list is empty then node becomes as head
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                //if not then put head in temp variable
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Added node to the Queue :" + data);
        }
        public void Display()
        {
            //temp variable will be head
            Node temp = head;
            //check if list is empty or not
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + "");
                //check until temp is null
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                //for traversing the node
                temp = temp.next;
            }
        }
    }
}

