using System;
using System.Collections.Generic;
using System.Text;

namespace Codding
{
    public class InsertionSort
    {
        /// <summary>
        /// [5,3,4,8,9,1]
        /// i=1 3 => 5 > 3 swap
        /// [3,5,4,8,9,1]
        /// i=2 4 => 5> 4 -> swapt 5 anr 4 [3,4,5,8,9,1] => 3< 4 quict
        /// i=3 8 => no swapt
        /// i=4 9 =>no spwap
        /// i =5 1 do swapt untill [1,3,4,5,8,9]
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        public static void InsertionSorts(int[] array,int n)
        {
            for(int i = 1; i < n; i++)
            {
                int position = i;
                int insertValue = array[position];

                while(position > 0 &&  array[position-1] > insertValue)
                {
                    array[position] = array[position - 1];
                    position = position - 1;
                }
                array[position] = insertValue;
            }   
        }

        public static void InsertionSortsDisplay(int[] array) { 
            foreach(int val in array)
            {
                Console.Write(val);
            }
        }
    }
}
