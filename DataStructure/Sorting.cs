using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 
    /// </summary>
    public static class Sorting
    {
        /// <summary>
        /// Time Complexity O(n^2)
        /// BubbleSort ,compair two element and swap them to push larger at last mean bubble out that
        /// element and remove from sorting repeat process untill all element bubble out and sortes 
        /// Bubble sort is ustable in case of dubplicate as int array can sort but object sorting collaps
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] array)
        {
            for (int j = array.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)//Each loop will bubble out one lement and that is maninta by j
                {
                    if (array[i] > array[i +1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// O(n^2) 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SelectioneSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)  
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static int[]  InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                int curUnsorted =array[i];
                int j = 0;
                for (j = i  ; j >0 && array[i + 1 ] > curUnsorted; j--)
                {
                    array[i] = array[i - 1] ;
                }
                array[i] = curUnsorted;
            }
            return array;
        }

        /// <summary>
        /// O(nlogn)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length / 3)
                gap = 3 * gap + 1;

            while(gap > 1)
            {
                for(int i = gap;i < array.Length; i++)
                {
                    for(int j = i; j> gap && array[j] < array[j -gap]; j -= gap)
                    {
                        int temp = array[j];
                        array[j] = array[j - gap];
                        array[j - gap] = temp;
                    }
                }
                gap /= 3;
            }
            return array;
        }

        public static int[] MergeSort(int[] array)
        {
            int[] aux = new int[array.Length];

            Sort(0, array.Length - 1);

            void Sort(int low, int heigh)
            {
                if (heigh <= low)
                    return;

                int mid = (heigh + low) / 2;
                Sort(low, mid);
                Sort(mid +1 , heigh);
                Merge(low,mid,heigh);
            }

            void Merge(int low, int mid, int heigh)
            {
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, heigh - low + 1);

                for(int k = low; k<= heigh; k++)
                {
                    if (i > mid) array[k] = aux[j++];
                    else if (j > heigh) array[k] = aux[i++];
                    else if (aux[j] < aux[i])
                        array[k] = aux[j++];
                    else
                        array[k] = aux[i++];
                }
            }
            return array;
        }

        public static int[] QuickSort(int[] array)
        {
            Sort(0,array.Length -1);

            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                int j = Partition(low,high);
                Sort(low, j -1);
                Sort(j + 1,high);
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high;
                int pivot = array[low];
                while (true)
                {
                    while(array[++i] < pivot)
                    {
                        if (i == low)
                            break;
                    }
                    while (pivot < array[--j])
                    {
                        if (j == low)
                            break;
                    }
                    if (i > j)
                        break;

                    int temp2 = array[i];
                    array[i] = array[j];
                    array[j] = temp2;
                }

                int temp = array[low];
                array[low] = array[j];
                array[j] = temp;
                return j;
            }
            return array;
        }
    }
}
