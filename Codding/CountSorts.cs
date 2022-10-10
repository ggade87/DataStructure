
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding
{
    public class CountSorts
    {
        public static int[] CountSort(int[] array, int n)
        {
            int size = array.Max();
            int[] Counts = new int[size + 1];

            for (int i = 0; i < n; i++)
            {
                Counts[array[i]] = Counts[array[i]] + 1;
            }

            int m = 0, j = 0;

            while(m < size + 1)
            {
                if(Counts[m] > 0)
                {
                    array[j++] = m;
                    Counts[m] = Counts[m] - 1;
                }
                else
                {
                    m = m + 1;
                }
            }

            return array;
        }
    }
}
