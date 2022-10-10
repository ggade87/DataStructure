using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class BST<T> where T : IComparable<T>
    {
        public BinarySearchTree<T> _root { get; set; }
        public BinarySearchTree<T> Get(T value)
        {
            return _root?.Get(value);
        }

        public T Min()
        {
            if (_root == null)
                throw new NotImplementedException();

            return _root.Min();
        }
        public T Max()
        {
            if (_root == null)
                throw new NotImplementedException();

            return _root.Max();
        }

        public void Insert(T value)
        {
            if (_root == null)
                _root = new BinarySearchTree<T>(value);
            else
                _root.Insert(value);
        }

        public IEnumerable<T> TraverserInOrder()
        {
            if (_root == null)
                return _root.TraverseInOrder();

            return null;
        }

        public void Remove(T value)
        {
          
             _root = Remove(_root,value);
        }
        public BinarySearchTree<T> Remove(BinarySearchTree<T> subTree,T value)
        {
            if (subTree == null)
                return null;

            var comparer = value.CompareTo(subTree.Value);
            if (comparer < 0)
            {
                subTree.Left = Remove(subTree.Left,value);
            }
            else if(comparer > 0)
            {
                subTree.Right = Remove(subTree.Right, value);
            }
            else
            {
                if(subTree.Left == null){
                    return subTree.Right;
                }

                if (subTree.Right == null)
                {
                    return subTree.Left;
                }

                subTree.Value = subTree.Right.Min();
                subTree.Right = Remove(subTree.Right, subTree.Value);
            }
            return subTree;
        }
    }
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public BinarySearchTree<T> Left { get; set; }
        public BinarySearchTree<T> Right { get; set; }
        public BinarySearchTree(T value)
        {
            Value = value;
        }

        public void Insert(T newValue)
        {
            var compare = newValue.CompareTo(Value);
            if (compare == 0)
                return;

            if(compare < 0)
            {
                if(Left != null)
                {
                    Left = new BinarySearchTree<T>(newValue);
                }
                else
                {
                    Left.Insert(newValue);
                }

            }
            else
            {
                if (Right != null)
                {
                    Right = new BinarySearchTree<T>(newValue);
                }
                else
                {
                    Right.Insert(newValue);
                }
            }
        }

        public BinarySearchTree<T> Get(T value)
        {
            var compare = value.CompareTo(Value);
            if (compare == 0)
                return this;

            if (compare < 0)
            {
                if(Left != null)
                {
                    return Left.Get(value);
                }
            }
            else
            {
                if (Right != null)
                {
                    return Right.Get(value);
                }
            }

            return null;
        }

        public IEnumerable<T> TraverseInOrder()
        {
            var list = new List<T>();
            InnerTraveser(list);
            return list;
        }

        private void InnerTraveser(List<T>  list)
        {
            if (Left != null)
                Left.InnerTraveser(list);
            list.Add(Value);
            if (Right != null)
                Right.InnerTraveser(list);
        }

        public T Min()
        {
            if (Left != null)
                return Left.Min();
            return Value;
        }

        public T Max()
        {
            if (Right != null)
                return Right.Max();
            return Value;
        }
    }
}