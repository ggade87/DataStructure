using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding
{
    public class RadixSorts
    {
        public static int[] radixSort(int[] A, int n)
        {
            int maxElement = A.Max();
            int digits = maxElement.ToString().Length;
            List<List<int>> temp = new List<List<int>>() {
                new List<int>(){ },new List<int>(){ },new List<int>(){ },new List<int>(){ },new List<int>(){ },
                new List<int>(){ },new List<int>(){ },new List<int>(){ },new List<int>(){ },new List<int>(){ },

        };
            for(int i=0;i< digits; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int element = (A[j] / (int)Math.Pow(10, i)) % 10;
                    List<int>  temp1 = temp[element];
                    temp1.Add(A[j]);
                    temp1.Sort();
                    temp[element] = temp1;
                }
                int k = 0;
                for(int x = 0; x < 10; x++)
                {
                    List<int> ls= temp[x];
                    temp[x] = new List<int>();
                    foreach (int e in ls)
                    {
                        A[k] = e;
                        k++;
                    }
                }
            }
            return A;
        }
    }
}
