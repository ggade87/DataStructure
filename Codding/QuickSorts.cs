using System;
using System.Collections.Generic;
using System.Text;

namespace Codding
{
    public class QuickSorts
    {
        public static void QuickSort(int[] A, int low, int high)
        {

            if (low < high)
            {
                int pi = Partition(A, low, high);
                QuickSort(A, low, pi - 1);
                QuickSort(A, pi + 1, high);
            }
        }

        public static int Partition(int[] A, int low, int high)
        {
            int pivot = A[low];
            int i = low + 1;
            int j = high;
            do
            {
                while (i <= j && A[i] <= pivot)
                    i = i + 1;
                while (i <= j && A[j] > pivot)
                    j = j - 1;
                if (i <= j)
                    Swap(A, i, j);

            } while (i < j);
            Swap(A, low, j);
            return j;
        }

        public static void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
