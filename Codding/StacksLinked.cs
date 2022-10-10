using System;
using System.Collections.Generic;
using System.Text;

namespace CoddingSL
{
    public class Node
    {
        public int element;
        public Node next;

        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class StacksLinked
    {
        Node top;
        int size;

        public StacksLinked()
        {
            top = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void push(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }
            size = size + 1;
        }

        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int e = top.element;
            top = top.next;
            size = size - 1;
            return e;
        }

        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return top.element;
        }

        public void display()
        {
            Node p = top;
            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
