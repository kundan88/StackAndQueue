using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStackAndQueue
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    internal class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }
        public void AddNode(int data)
        {
            Node node = new Node(data);
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head = node;// make new node as head
            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
        public void AppendNode(int data)
        {
            Node node = new Node(data);
            if (head == null) // if empty
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;//add at end
                tail = node;//make new node as tail    
            }
        }
        public void AddNodeAtStart(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Node temp = head;
                head = head.next;
                Console.WriteLine("Removed from list " + temp.data);
            }
        }
        public void DeleteEndNode()
        {
            if (head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Node temp = this.head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
    }
}

