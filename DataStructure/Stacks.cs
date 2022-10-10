using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    //LIFO Push pop Peek(return top item) by array to by list

    //Implement statck by array
    public class ArrayStack<T>
    {
        private int count { get; set; }
        private T[] items;
        public ArrayStack()
        {
            const int defaultCapacity = 4;
            items = new T[defaultCapacity];
        }
        public ArrayStack(int capacity)
        {
            items = new T[capacity];
        }
        public T Peek()
        {
            return items[count - 1];
        }
        public void Pop()
        {
            if (count == 0)
                throw new InvalidOperationException();

            items[--count] = default(T);
        }
        public void Push(T item)
        {
            if(items.Length == count)
            {
                //Increase array size in case array is full
                T[] lasterArray = new T[count * 2];
                Array.Copy(items, lasterArray, count);
                items = lasterArray;
            }
            items[count++]=item;

        }
        public void PrintStack()
        {
            int i = items.Length - 1;
            int index = 0;
            while(i != 0)
            {
                if(Convert.ToInt32(items[index]) > 0)
                    Console.WriteLine(items[index]);

                index++;
                i--;
            }
        }
    }

    //Implement statck by LinkedList
    public class LinkedListStack<T>
    {
        private readonly SinglyLinkedList<T> linkedList = new SinglyLinkedList<T>();
        public T Peek()
        {
            if (linkedList.Count == 0)
                throw new InvalidOperationException();

            return linkedList.Head.Value;
        }
        public void Pop()
        {
            if (linkedList.Count == 0)
                  throw new InvalidOperationException();

            linkedList.RemoveFirst();
        }
        public void Push(T item)
        {
            linkedList.AddFirst(item);
        }
        public void PrintStack()
        {
            linkedList.PrintLinkedList();
        }
    }
}
