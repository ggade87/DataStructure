using System;
using System.Collections.Generic;
using System.Text;

namespace CoddingBST
{
    public class Node
    {
        public int element;
        public Node left;
        public Node right;
        public Node(int e, Node l, Node r)
        {
            element = e;
            left = l;
            right = r;
        }
    }

    class BinarySearchTree
    {
        Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public int height(Node temproot)
        {
            if (temproot != null)
            {
                int x = height(temproot.left);
                int y = height(temproot.right);
                if (x > y)
                    return x + 1;
                else
                    return y + 1;
            }
            return 0;
        }

        public int count(Node temproot)
        {
            if (temproot != null)
            {
                int x = count(temproot.left); // Goes on couting left to depth
                int y = count(temproot.right);//Comes up couting right 
                return x + y + 1;
            }
            return 0;
        }
        public bool delete(int e)
        {
            Node p = root;
            Node pp = null;
            while (p != null && p.element != e) //Find out the node which we are deleting 
            {
                pp = p;
                if (e < p.element)
                    p = p.left;
                else
                    p = p.right;
            }
            if (p == null)
                return false;
            if (p.left != null && p.right != null)
            {
                Node s = p.left;
                Node ps = p;
                while (s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                p.element = s.element;
                p = s;
                pp = ps;
            }
            Node c = null;
            if (p.left != null)
                c = p.left;
            else
                c = p.right;
            if (p == root)
                root = null;
            else
            {
                if (p == pp.left)
                    pp.left = c;
                else
                    pp.right = c;
            }
            return true;
        }

        public bool search(int key)
        {
            Node temproot = root;
            while (temproot != null)
            {
                if (key == temproot.element)
                    return true;
                else if (key < temproot.element)
                    temproot = temproot.left;
                else if (key > temproot.element)
                    temproot = temproot.right;
            }
            return false;
        }

        public bool search(Node temproot, int key)
        {
            if (temproot != null)
            {
                if (key == temproot.element)
                    return true;
                else if (key < temproot.element)
                    return search(temproot.left, key);
                else if (key > temproot.element)
                    return search(temproot.right, key);
            }
            return false;
        }
        public void insertIterative(Node temproot, int e)
        {
            Node temp = null;
            while (temproot != null)
            {
                temp = temproot;
                if (e == temproot.element)
                    return;
                else if (e < temproot.element)
                    temproot = temproot.left;
                else if (e > temproot.element)
                    temproot = temproot.right;
            }
            Node n = new Node(e, null, null);
            if (root != null)
            {
                if (e < temp.element)
                    temp.left = n;
                else
                    temp.right = n;
            }
            else
                root = n;
        }
        public Node insertRecirsive(Node temproot, int e)
        {
            if (temproot != null)
            {
                if (e < temproot.element)
                    temproot.left = insertRecirsive(temproot.left, e);
                else if (e > temproot.element)
                    temproot.right = insertRecirsive(temproot.right, e);
            }
            else
            {
                Node n = new Node(e, null, null);
                temproot = n;
            }
            return temproot;
        }
        public void inorder(Node temproot)
        {
            if (temproot != null)
            {
                inorder(temproot.left);
                Console.Write(temproot.element + " ");
                inorder(temproot.right);
            }
        }
        public void PostOrder(Node temproot)
        {
            if (temproot != null)
            {

                PostOrder(temproot.left);
                PostOrder(temproot.right);
                Console.Write(temproot.element + " ");

            }
        }
        public void preorder(Node temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.element + " ");
                preorder(temproot.left);
                preorder(temproot.right);
            }
        }

        public void levelorder(Node temproot)
        {
            QueuesLinked q = new QueuesLinked();
            Node t = root;
            Console.Write(t.element + " ");
            q.enqueue(t);
            while (!q.isEmpty())
            {
                t = (Node)q.dequeue();
                if (t.left != null)
                {
                    Console.Write(t.left.element + " ");
                    q.enqueue(t.left);
                }
                if (t.right != null)
                {
                    Console.Write(t.right.element + " ");
                    q.enqueue(t.right);
                }
            }
        }

    }

    #region


    /// <summary>
    /// Below code is just to implement queue using linked List
    /// </summary>
    public class QNode
    {
        public Object element;
        public QNode next;
        public QNode(Object e)
        {
            element = e;
            next = null;
        }
    }

    class QueuesLinked
    {
        QNode front;
        QNode rear;
        int size;

        public QueuesLinked()
        {
            front = null;
            rear = null;
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

        public void enqueue(Object e)
        {
            QNode newest = new QNode(e);
            if (isEmpty())
                front = newest;
            else
                rear.next = newest;
            rear = newest;
            size = size + 1;
        }

        public Object dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            Object e = front.element;
            front = front.next;
            size = size - 1;
            if (isEmpty())
                rear = null;
            return e;
        }

        public void display()
        {
            QNode p = front;
            while (p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
    #endregion
