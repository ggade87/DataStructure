using System;
using System.Collections.Generic;
using System.Linq;
using static DataStructure.LinkedList;

namespace DataStructure
{
    class Program
    {

        static void Main(string[] args)
        {
            Node root = BFS.CreatBST();
            List<int> list = DFS.DefthFirstSearch_InOrder(root, new List<int>());
            List<int> list2 = DFS.DefthFirstSearch_PreOrder(root, new List<int>());
            List<int> list3 = DFS.DefthFirstSearch_PostOrder(root, new List<int>());
            //List<int> lists = BFS.BeardthFirstSearch(root);

            //Queue<Node> queue = new Queue<Node>();
            //queue.Enqueue(root);
            //List<int> listsRecursive = BFS.BeardthFirstSearchRecursive(queue, new List<int>());
            //int[] a = new int[] { 2, 3, 5, 1, 4 };
            //string sss = "1 2 3 4 5 6 7";
            //string[] words = sss.Split(" ");
            //int i = 0;
            //foreach(string s  in words)
            //{

            //}



            //var bstTree = new BST<int>();
            //bstTree.Insert(32);
            //bstTree.Insert(22);
            //bstTree.Insert(42);

            //bstTree.Insert(62);
            //bstTree.Insert(72);
            //bstTree.Insert(82);

            //int[] arry = new int[] { 2,3,4,5,6,7,1,9};
            //bool res = BinarySearch.BinarySearch1(arry,2);
            //bool res2 = BinarySearch.BinarySearch1(arry, 23);

            //bool res3 = BinarySearch.ReciursiveBinarySearch1(arry, 2);
            //bool res4 = BinarySearch.ReciursiveBinarySearch1(arry, 23);

            //bool res5 = BinarySearch.ReciursiveBinarySearch2(arry, 2);
            //bool res6 = BinarySearch.ReciursiveBinarySearch2(arry, 23);


            //LinearSearch.LinearSearchTechanics();
            //Queue.LinkedListQueueOperations();
            //Queue.CircularQueueOperations();
            //Queue.ArrayQueueOperations();
            //Stack.LinkedListStackOperations();
            //Stack.ArrayStackOperations();
            //DoublyLinkedList.DoublyLinkedListOperations();
            //SinglyLinkedList.SinglyLinkedListOperations();
            //Node ll = LinkedList.CreateLinkedList();
            //LinkedList.PrintLinkedList(ll);
            //Lists.run();
            //DataStructure.SortingTypes();
            Console.WriteLine("Hello World!");
        }

    }
    public static class Queue
    {
        public static void ArrayQueueOperations()
        {
            Console.WriteLine("Statck is FIFO");
            ArrayQueue<int> arrayQueue = new ArrayQueue<int>();
            arrayQueue.Enqueue(1);
            Console.WriteLine("Enqueue 1");
            arrayQueue.PrintQueue();
            Console.WriteLine("Enqueue 2");
            arrayQueue.Enqueue(2);
            arrayQueue.PrintQueue();
            Console.WriteLine("Enqueue 3");
            arrayQueue.Enqueue(3);
            arrayQueue.PrintQueue();
            Console.WriteLine("Dnqueue");
            arrayQueue.Dequeue();
            arrayQueue.PrintQueue();
            Console.WriteLine("Peek" + arrayQueue.Peek());
            arrayQueue.Peek();
            arrayQueue.PrintQueue();
        }

        public static void CircularQueueOperations()
        {
            Console.WriteLine("Statck is FIFO");
            CircularQueue<int> circularQueue = new CircularQueue<int>();
            circularQueue.Enqueue(1);
            Console.WriteLine("Enqueue 1");
            circularQueue.PrintQueue();
            Console.WriteLine("Enqueue 2");
            circularQueue.Enqueue(2);
            circularQueue.PrintQueue();
            Console.WriteLine("Enqueue 3");
            circularQueue.Enqueue(3);
            circularQueue.PrintQueue();
            Console.WriteLine("Dequeue");
            circularQueue.Dequeue();
            circularQueue.PrintQueue();
            Console.WriteLine("Peek" + circularQueue.Peek());
            circularQueue.Peek();
            circularQueue.PrintQueue();
        }

        public static void LinkedListQueueOperations()
        {
            Console.WriteLine("Statck is FIFO");
            LinkedListQueue<int> linkedListQueue = new LinkedListQueue<int>();
            linkedListQueue.Enqueue(1);
            Console.WriteLine("Enqueue 1");
            linkedListQueue.PrintQueue();
            Console.WriteLine("Enqueue 2");
            linkedListQueue.Enqueue(2);
            linkedListQueue.PrintQueue();
            Console.WriteLine("Enqueue 3");
            linkedListQueue.Enqueue(3);
            linkedListQueue.PrintQueue();
            Console.WriteLine("Dequeue");
            linkedListQueue.Dequeue();
            linkedListQueue.PrintQueue();
            Console.WriteLine("Peek" + linkedListQueue.Peek());
            linkedListQueue.Peek();
            linkedListQueue.PrintQueue();
        }
    }
    public static class Stack
    {
        public static void ArrayStackOperations()
        {
            Console.WriteLine("Statck is LIFO");
            ArrayStack<int> arrayStack = new ArrayStack<int>();
            arrayStack.Push(1);
            Console.WriteLine("Push 1");
            arrayStack.PrintStack();
            Console.WriteLine("Push 2");
            arrayStack.Push(2);
            arrayStack.PrintStack();
            Console.WriteLine("Push 3");
            arrayStack.Push(3);
            arrayStack.PrintStack();
            Console.WriteLine("Pop");
            arrayStack.Pop();
            arrayStack.PrintStack();
            Console.WriteLine("Peek" + arrayStack.Peek());
            arrayStack.Peek();
            arrayStack.PrintStack();
        }

        public static void LinkedListStackOperations()
        {
            Console.WriteLine("Statck is LIFO");
            LinkedListStack<int> linkedListStack = new LinkedListStack<int>();
            linkedListStack.Push(1);
            Console.WriteLine("Push 1");
            linkedListStack.PrintStack();
            Console.WriteLine("Push 2");
            linkedListStack.Push(2);
            linkedListStack.PrintStack();
            Console.WriteLine("Push 3");
            linkedListStack.Push(3);
            linkedListStack.PrintStack();
            Console.WriteLine("Pop");
            linkedListStack.Pop();
            linkedListStack.PrintStack();
            Console.WriteLine("Peek" + linkedListStack.Peek());
            linkedListStack.Peek();
            linkedListStack.PrintStack();
        }
    }
    public static class DoublyLinkedList
    {
        public static void DoublyLinkedListOperations()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.AddFirst(1);
            Console.WriteLine("AddFirst 1");
            doublyLinkedList.PrintLinkedList();
            doublyLinkedList.AddFirst(2);
            Console.WriteLine("AddFirst 2");
            doublyLinkedList.PrintLinkedList();
            doublyLinkedList.AddLast(7);
            Console.WriteLine("AddLast 7");
            doublyLinkedList.PrintLinkedList();
            doublyLinkedList.AddLast(9);
            Console.WriteLine("AddLast 9");
            doublyLinkedList.PrintLinkedList();
            doublyLinkedList.RemoveFirst();
            Console.WriteLine("RemoveFirst");
            doublyLinkedList.PrintLinkedList();
            doublyLinkedList.RemoveLast();
            Console.WriteLine("RemoveLast");
            doublyLinkedList.PrintLinkedList();
        }
    }
    public static class SinglyLinkedList
    {
        public static void SinglyLinkedListOperations()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.AddFirst(1);
            Console.WriteLine("AddFirst 1");
            singlyLinkedList.PrintLinkedList();
            singlyLinkedList.AddFirst(2);
            Console.WriteLine("AddFirst 2");
            singlyLinkedList.PrintLinkedList();
            singlyLinkedList.AddLast(7);
            Console.WriteLine("AddLast 7");
            singlyLinkedList.PrintLinkedList();
            singlyLinkedList.AddLast(9);
            Console.WriteLine("AddLast 9");
            singlyLinkedList.PrintLinkedList();
            singlyLinkedList.RemoveFirst();
            Console.WriteLine("RemoveFirst");
            singlyLinkedList.PrintLinkedList();
            singlyLinkedList.RemoveLast();
            Console.WriteLine("RemoveLast");
            singlyLinkedList.PrintLinkedList();
        }
    }
    public static class DataStructure
    {
        public static void SortingTypes()
        {
            int[] array = new int[] { 2, 6, 3, 8, 4, 7, 9 };
            Sorting.BubbleSort(array);
            Sorting.SelectioneSort(array);
            Sorting.InsertionSort(array);
            Sorting.ShellSort(array);
            Sorting.MergeSort(array);
            Sorting.QuickSort(array);
        }
    }
}
