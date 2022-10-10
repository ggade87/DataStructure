using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class DoublyLinkedNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedNode<T> Next { get; set; }
        public DoublyLinkedNode<T> Prev { get; set; }
        public DoublyLinkedNode(T value)
        {
            Value = value;
        }
    }
    public class DoublyLinkedList<T>
    {
        //Point back and forth // We can make it cerculer last poit ot first 
        public DoublyLinkedNode<T> Head { get; internal set; }
        public DoublyLinkedNode<T> Tail { get; internal set; }
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }

        private void AddFirst(DoublyLinkedNode<T> node)
        {
            //save current head
            DoublyLinkedNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
            else
            {
                temp.Prev = Head;
            }
            Count++;

        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));
        }

        private void AddLast(DoublyLinkedNode<T> node)
        {
            //save current head
            if (Count == 0)
                Head = node;
            else
                Tail.Next = node;
                node.Prev = Tail;
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;
            Count--;
            if (Count == 0)
            {
                Tail = null;
            }
            else
            {
                Head.Prev = null;
            }
        }
        public void RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;

            }
            Count--;
        }
        public void PrintLinkedList()
        {
            DoublyLinkedNode<T> temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
        }
    }
    public class SinglyLinkedList<T>
    {
        //Head point root element tail post last element.
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get;  set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            //save current head
            Node<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
        }
        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            //save current head
            if (Count == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;
            if (Count == 1)
            {
                Tail = null;
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
            Count--;
        }

        public void PrintLinkedList()
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
   public class LinkedList
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
        }
        public static Node CreateLinkedList()
        {
            Node first = new Node() { Value = 1 };
            Node secound = new Node() { Value = 2 };
            first.Next = secound;
            Node third = new Node() { Value = 3 };
            secound.Next = third;
            Node fourth = new Node() { Value = 4 };
            third.Next = fourth;
            return first;
        }

        public static void PrintLinkedList(Node node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
    
    public class List
    {
        public class Customer
        {
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
        }
        public static void ApiMembers()
        {
            List<int> list = new List<int>() { 4,5,6};
            list.Sort();
            list.Reverse();

            IReadOnlyCollection<int> readOnlyList = list.AsReadOnly(); //Get readu only version will not change orogonal array

            int[] array = list.ToArray();//Convert list to artay;
            //Sorting pobject list
            var listCustomer = new List<Customer>()
            {
                new Customer(){BirthDate= new DateTime(1998,08,12),Name="Ganesh" },
                new Customer(){BirthDate= new DateTime(1999,08,11),Name="Mahesh" },
                new Customer(){BirthDate= new DateTime(200,03,11),Name="Yam" },
            };
            listCustomer.Sort((left,right) => {
                if (left.BirthDate > right.BirthDate)
                    return 1;
                else if (left.BirthDate < right.BirthDate)
                    return -1;
                else
                    return 0;
            });
        }
       public static void run()
        {
            List<int> list = new List<int>();
            LogCountAndCapacity(list);
            for (int i=0;i< 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }
            for (int i = 10; i > 0; i--)
            {
                list.RemoveAt(i-1);
                LogCountAndCapacity(list);
            }

        }
        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count: {list.Count} && Capacity: {list.Capacity}");//List capacity double start with 4 , 8 , 16 and so on on Removal capacity will not reduced.

        }
    }
}
