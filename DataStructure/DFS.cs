using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class DFS
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
        public static List<int> DefthFirstSearch_InOrder(Node root,  List<int> list)
        {
            /*           9
                3               15

            1        4      12    20
          
           Output [1 , 3, 4, 9, 12, 15,  20]
           */
            List<int> list2 = TraverseInOrder(root, list);
            return list2;
        }

        private static List<int> TraverseInOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraverseInOrder(node.Left, list);
            }
            list.Add(node.Value);
            if (node.Right != null)
            {
                TraverseInOrder(node.Right, list);
            }
            return list;
        }

        public static List<int> DefthFirstSearch_PreOrder(Node root, List<int> list)
        {
            /*           9
                3               15

            1        4      12    20
          
           Output [9,3,1,4,15,12,20 ]
           */
            List<int> list2 = TraversePreOrder(root, list);
            return list2;
        }

        private static List<int> TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.Value);
            if (node.Left != null)
            {
                TraversePreOrder(node.Left, list);
            }
           
            if (node.Right != null)
            {
                TraversePreOrder(node.Right, list);
            }
            return list;
        }

        public static List<int> DefthFirstSearch_PostOrder(Node root, List<int> list)
        {
            /*           9
                3               15

            1        4      12    20
          
           Output [1,4,3, 12,20,15,9]
           */
            List<int> list2 = TraversePostOrder(root, list);
            return list2;
        }

        private static List<int> TraversePostOrder(Node node, List<int> list)
        {
            if (node.Left != null)
            {
                TraversePostOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                TraversePostOrder(node.Right, list);
            }
            list.Add(node.Value);
            return list;
        }

        public static List<int> DefthFirstSearchRecursive(Queue<Node> queue, List<int> list)
        {
            //Root - > left - > Right - and repeaset untill leaf nodes
             return list;
            //return DefthFirstSearchRecursive(queue, list);
        }
    }
}
