using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codding
{
    public class Code
    {
        public static void RetunTwoIndexOfAddition()
        {
            int[] array = new int[] {1,3,7,9,2 };
            int sum = 11;
            //find two number index  who add is 11

            for(int i=0; i< array.Length - 1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[i] + array[j] == sum)
                    {
                        Console.WriteLine($"{i} , {j}");
                        break;
                    }
                }
            }
        }

        public static void RetunTwoIndexOfAddition2()
        {
            int[] array = new int[] { 1, 3, 7, 9, 2 };
            int sum = 11;
            //find two number index  who add is 11

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int need = sum - array[i];
                    if(array[j] == need)
                    {
                        Console.WriteLine($"{i} , {j}");
                        break;
                    }
                }
            }
        }

        public static void RetunTwoIndexOfAddition3()
        {
            int[] array = new int[] { 3, 9, 7, 1, 2 };
            int sum = 11;
            //find two number index  who add is 11
            var map = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (map.Contains(array[i]))
                {
                    Console.WriteLine($"{map.IndexOf(array[i])} , { i}");
                    break;
                }
                else
                {
                    int need = sum - array[i];
                    map.Add(need);
                }
            }
        }

        public static void RetunTwoLineWithHighAre()
        {
            int[] array = new int[] { 1,7,2,8,1,6};
            int sum = 11;
            var dic = new Dictionary<List<int>,int>();
            //find two number index  who add is 11
            var map = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) continue;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == 0) continue;
                    if(array[i] < array[j])
                    {
                        int area = array[i] * (j - i);
                        List<int> vs = new List<int>();
                        vs.Add(i); vs.Add(j);
                        dic.Add(vs,area);
                    }else if (array[i]  >array[j])
                    {
                        int area = array[j] * (j - i);
                        List<int> vs = new List<int>();
                        vs.Add(i); vs.Add(j);
                        dic.Add(vs, area);
                    }

                }
            }
            map = dic.Where(x => x.Value == dic.Values.Max() ).FirstOrDefault().Key;
            Console.WriteLine($"{array[map[0]]} , {array[map[1]]}");
        }
    }
}
