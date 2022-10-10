using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class BinarySearch
    {
        public static bool BinarySearch1(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == number)
                    return true;
                else if (array[mid] < number)
                    low = mid + 1;
                else if (array[mid] > number)
                    high = mid;
            }
            return false;
        }
        public static bool ReciursiveBinarySearch1(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;
            if (low > high)
                return false;
            int mid = (low + high) / 2;
            if (array[mid] == number)
            {
                return true;
            }
            else if (array[mid] > number)
                ReciursiveBinarySearch1(array.Skip(low).Take(mid + 1).ToArray() , number);
            else if (array[mid] < number)
                ReciursiveBinarySearch1(array.Skip(mid + 1).Take(high).ToArray(), number);


            return false;
        }

        public static bool ReciursiveBinarySearch2(int[] array, int number)
        {
            return InternalReciursiveBinarySearch2(0,array.Length);

            bool InternalReciursiveBinarySearch2(int low, int high)
            {
                if (low >= high)
                    return false;

                int mid = (low + high) / 2;
                if (array[mid] == number)
                    return true;
                else if (array[mid] < number)
                    return InternalReciursiveBinarySearch2(mid+1,high);
                else if(array[mid] > number)
                    return InternalReciursiveBinarySearch2(low,mid);

                return false;
            }

        }
    }
}
