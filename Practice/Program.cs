using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{ 
    class Program
    {
        public static int GetCount(List<string> login2, List<string> newList, string last)
        {
            List<int> q = new List<int>();
            int ss =q.Max();
            newList = newList.Take(newList.Count / 2).ToList();
            newList = newList.Select(s => NewString(s)).ToList();
            var dd = newList.Intersect(newList).ToList();
            int res = dd.Count;
            if (!string.IsNullOrEmpty(last))
            {
                string rev = NewString(last);
                List<string> list44 = login2.Take(login2.Count - 1).ToList();
                if (list44.Contains(rev))
                {
                    res = res + 1;
                }
            }
            return res;
        }
        public static string NewString(string str)
        {
            string temp = new string(str.Select(r => (char)(r + 1)).ToArray());
            return temp.Replace('{', 'a');
        }
        public static int countFamilyLogins(List<string> logins)
        {
            int count = logins.Count;

            if (count % 2 == 0)
            {
                return GetCount(logins, logins, "");
            }
            else
            {
                List<string> list = logins.Take(count - 1).ToList();
                return GetCount(logins, list, logins[count - 1]);

            }
            return 0;
        }


        public static List<int> getLS(List<int> products)
        {
            List<int> result = new List<int>();
            var ls = products;
            for (int i = 0; i < ls.Count -1; i++)
            {
                if (ls[i] <= ls[i + 1])
                {
                    result.Add(ls[i]);
                }
                else
                {
                    result.Add(ls[i + 1] - 1);
                }
            }
            return result;
        }

        public static long findMaxProducts(List<int> products)
        {
            List<int> result = new List<int>();
            int r = 0;
            for (int i = 0; i < products.Count; i++)
            {
                r += 2;
                var pp = products.Take(r).ToList();
                result = getLS(pp);
            }

            return result.Max();
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                int temp = grades[i] + 1;
                if (temp >= 40)
                {
                    if (temp % 5 == 0)
                    {
                        result.Add(temp);
                        continue;
                    }
                }
                temp = grades[i] + 2 ;
                if (temp >= 40)
                {
                    if (temp % 5 == 0)
                    {
                        result.Add(temp);
                        continue;
                    }
                }
                result.Add(grades[i]);
            }
            return result;
        }
        public static int Difference(int a,int b)
        {
            return a > b ? a - b : b - a;
        }
        public static int formingMagicSquare(List<List<int>> list)
        {
            List<List<List<int>>> arry = new List<List<List<int>>>() {
                    new List<List<int>>(){ new List<int>() { 8, 1, 6 }, new List<int>() { 3, 5, 7 }, new List<int>() { 4, 9, 2  } },
                    new List<List<int>>(){ new List<int>() { 6, 1, 8 }, new List<int>() {  7, 5, 3}, new List<int>() { 2, 9, 4 } },
                    new List<List<int>>(){ new List<int>() { 4, 9, 2 }, new List<int>() { 3, 5, 7 }, new List<int>() { 8, 1, 6 } },
                    new List<List<int>>(){ new List<int>() { 2, 9, 4 }, new List<int>() { 7, 5, 3 }, new List<int>() { 6, 1, 8 } },
                    new List<List<int>>(){ new List<int>() { 8, 3, 4 }, new List<int>() { 1, 5, 9 }, new List<int>() { 6, 7, 2 } },
                    new List<List<int>>(){ new List<int>() { 4, 8, 3 }, new List<int>() { 9, 5, 1 }, new List<int>() { 2, 7, 6 } },
                    new List<List<int>>(){ new List<int>() { 6, 7, 2 }, new List<int>() { 1, 5, 9 }, new List<int>() { 8, 3, 4 } },
                    new List<List<int>>(){ new List<int>() { 2, 7, 6 }, new List<int>() { 9, 5, 1 }, new List<int>() { 4, 3, 8 } }
            };
            List<int> result = new List<int>();
            foreach (var ar in arry)
            {
                    int sum = 0;
                    for(int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (ar[i][j] != list[i][j])
                            {
                                sum+= Difference(ar[i][j],list[i][j]);
                            }
                    }
                    }
                result.Add(sum);
            }

            return result.Min();
        }
        public static int Diff(int a, int b)
        {
            return a>b? a-b:b-a;
    }

    public static int pickingNumbers(List<int> a)
    {
            List<int> list = new List<int>();
            a.Sort();
            int count = 0;
            for (int i = 0; i < a.Count; i++)
            {

                for (int j = i; j < a.Count; j++)
                {

                    if (Math.Abs((a[i] - a[j])) <= 1)
                        list.Add(a[j]);

                }
                if (list.Count > count)
                    count = list.Count;
                list.Clear();
            }
            return count;
        }

        public static int getElement(List<int> a, int temp)
        {
                int last = temp;
                a.Sort();
                for (int i = 0; i < a.Count; i++)
                {
                    if (temp % a[i] != 0)
                    {
                        temp += 1;
                        last = temp;
                        i = 0;
                        continue;
                    }
                }
            return last;
        }

        public static bool isFactor(List<int> b, int temp)
        {
            b.Sort();
            for (int i = 0; i < b.Count; i++)
            {
                if (temp >= b[b.Count - 1])
                {
                    return false;
                }
                if (b[i] % temp != 0 && temp > b[b.Count - 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static List<int> climbingLeaderboard1(List<int> ranked, List<int> player)
        {
            List<int> output = new List<int>();
            ranked = ranked.Intersect(ranked).ToList();
            int i = 0;
            int n = ranked.Count;
            foreach (var score in player)
            {
                while (i < n && ranked[n - i - 1] <= score)
                {
                    i += 1;
                }
                output.Add(n - i + 1);
            }
            return output;

        }

        public static int BinarySearch(List<int> ranked, int p, int low, int high)
        {
            int result = 0;
            if(high - low <  2)
            {
                if(p > ranked[low])
                {
                    return low + 1;
                } 
                else if (p > ranked[high])
                {
                    return high+1;
                }
            }
            int mid = (low + high) / 2;
            if (p == ranked[mid])
                return mid + 1;
            else if (p > ranked[mid])
                return BinarySearch(ranked, p, low, mid);
               
            else if (p < ranked[mid])
                return BinarySearch(ranked, p, mid + 1, high);
              
            return result;
        }
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> output = new List<int>();
            ranked = ranked.Intersect(ranked).ToList();
            int i = 0;
            int n = ranked.Count;
            foreach (var score in player)
            {
                while (i < n && ranked[n - i - 1] <= score)
                {
                    i += 1;
                }
                output.Add(n - i + 1);
            }
            return output;

        }

        public static string getString(string str)
        {
            StringBuilder sb = new StringBuilder();

            char[] array = str.ToCharArray();
            char prevCh = array[0];
            int count = 0;
            foreach(var c in array)
            {
                if( c == prevCh)
                {
                    count++;
                }else if(prevCh != '\0')
                {
                    sb.Append(count).Append(prevCh);
                    prevCh = c;
                    count = 1;
                }
                
            }
            sb.Append(count).Append(prevCh);
            return sb.ToString();
        }
        static int jumpingOnClouds(int[] c, int k)
        {

            int energy = 100;
            for (int i = 0; i < c.Length;)
            {
                int thunderheads = 0;
                if (c[i] == 1)
                {
                    thunderheads = 2;
                }
                energy = energy - 1 - thunderheads;
                i = i + k;
                if (i == c.Length - k) break;
                if (i > c.Length - 1 - k)
                {
                   
                    i = 0;
                    continue;
                }
            }
            return energy;
        }
        public static int findDigits(int n)
        {
            int count = 0;
            string[] A = n.ToString().Split("");
            int source = n;
            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                if (n % digit == 0)
                {
                    count++;
                }
            }


            return count;

        }
        private static long GetFactorial(int number)
        {
            long re = 1;
            for(int i=number;i >= 1; i--)
            {
                Console.WriteLine(i + " * " + re);
                re *= i;
                Console.WriteLine(re );
            }
            return re;
        }
        static void Main(string[] args)
        {
            long ssh = GetFactorial(25);
            int ss = findDigits(12);
            int dd = jumpingOnClouds(new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 },3); 
            Console.WriteLine("Hello World!");
        }
    }
}
