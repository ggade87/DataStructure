using System;
using System.Collections.Generic;
using System.Text;

namespace Codding
{
    public class BubbleSort
    {
        public static void BubbleSotrs(int[] arra)
        {
            int length = arra.Length-1;
            for(int i = length; i >=0; i--)
            {
                for (int j = 0; j < length; j++)
                {
                    if(arra[j] > arra[j+1])
                    {
                        int temp = arra[j+1];
                        arra[j+1] = arra[j];
                        arra[j] = temp;
                    }
                }
                length--;
            }
        }
    }
}
