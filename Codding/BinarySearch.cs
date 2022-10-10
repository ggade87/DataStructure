using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding
{
    public class BinarySearchs
    {
        public static bool BinarySearch(int[] array,int value)
        {
            int i = 0;
            int j =array.Length - 1;
            while( i <= j)
            {
                int mid = (i + j) / 2;
                if(array[mid] == value)
                {
                    return true;
                }else if (array[mid] > value)
                {
                    j = mid;
                }
                else if (array[mid] < value)
                {
                    i = mid + 1;
                }
            }
            return false;
        }

        public static bool BinarySearchRecussive(int[] array, int value)
        {
            int i = 0;
            int j = array.Length - 1;
            int mid = (i + j) / 2;
            if(array.Length == 0) return false;
            if (array[mid] == value)
            {
                return true;
            }
            else if (array[mid] > value)
            {
                j = mid;
                BinarySearchRecussive(array.Take(j).ToArray(),value);
            }
            else if (array[mid] < value)
            {
                i = mid + 1;
                BinarySearchRecussive(array.Skip(i).ToArray(), value);
            }
            return false;
        }
    }
}
