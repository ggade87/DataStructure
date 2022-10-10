using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    //Breadth First Search.
    public class BFS
    {
        public static Node CreatBST()
        {
            LinkedLists linkedLists = new LinkedLists();
            linkedLists.Insert(9);
            linkedLists.Insert(3);
            linkedLists.Insert(15);
            linkedLists.Insert(1);
            linkedLists.Insert(4);
            linkedLists.Insert(12);
            linkedLists.Insert(20);
            return linkedLists.Root;
        }
        public static List<int> BeardthFirstSearch(Node root)
        {
            //Root - > left - > Right - and repeaset untill leaf nodes
          
            List<int> list = new List<int>();
            Node tempNode = root;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(tempNode);
            while (queue.Count > 0)
            {
                tempNode = queue.Dequeue();
                list.Add(tempNode.Value);
                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                }
                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                }
            }

            return list;
        }

        public static List<int> BeardthFirstSearchRecursive(Queue<Node> queue, List<int> list)
        {
            //Root - > left - > Right - and repeaset untill leaf nodes
                if (queue.Count == 0)
                {
                    return list;
                }
                var tempNode = queue.Dequeue();
                list.Add(tempNode.Value);
                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                }
                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                }
            return BeardthFirstSearchRecursive(queue,list);
        }
    }

    public class LinkedLists
    {
        public int Count { get; set; }
        public Node Root { get; set; }

        public void Insert(int val)
        {
            Insert(Root,new Node(val));
        }
        public void Insert(Node node,Node newNode)
        {
            if (Root  == null) //First node insertion  
                Root = newNode;
            else
            {
                if (Convert.ToInt32(newNode.Value) < Convert.ToInt32(node.Value))
                {
                    if (node.Left == null)
                    {
                        node.Left = newNode;
                        return;
                    }
                    else
                    {
                        Insert(node.Left, newNode);
                    }
                        
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = newNode;
                        return;
                    }
                    else
                    {
                        Insert(node.Right, newNode);
                    }
                }
            }
        }
    }
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
