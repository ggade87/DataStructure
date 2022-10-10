using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace DataStructure
{
    internal class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals([AllowNull] Student x, [AllowNull] Student y)
        {
            return x.Age == y.Age && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.GetHashCode();
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
    public class LinearSearch
    {
        public static void LinearSearchTechanics()
        {
            var studentList = new List<Student>() { 
                new Student(){ Age=21 ,Name="Ganesh" },
                new Student(){ Age=22 ,Name="Ramesh" },
                new Student(){ Age=32 ,Name="Amir" },
                new Student(){ Age=43 ,Name="Sohan" },
                new Student(){ Age=9 ,Name="Rima" },
            };
            var intList = new List<int>() { 3,4,2,5,7,2,8,6};

            bool contains = intList.Contains(3);
            bool containsObject = studentList.Contains(new Student() { Age = 9, Name = "Rima" });
            bool exists = studentList.Exists(x => x.Age == 21);
            int min = intList.Min();
            int max = intList.Max();

            int youngStudentAge = studentList.Min(x => x.Age);

            Student ganesh = studentList.Find(x => x.Name =="Ganesh");
            Student lastGanesh = studentList.FindLast(x => x.Name == "Ganesh");
            Student lastGanesh2 = studentList.Last(x => x.Name == "Ganesh");

            List<Student> students = studentList.FindAll(x => x.Age > 23);
            IEnumerable<Student> studentsWhereAge = studentList.Where(x => x.Age > 23);

            int index1 = studentList.FindIndex(x => x.Age == 21);
            int Lastindex1 = studentList.FindLastIndex(x => x.Age > 21);

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);

            bool isTrueForAll = studentList.TrueForAll(x => x.Age > 30);
            bool isTrueForAll2 = studentList.TrueForAll(x => x.Age > 7);

            bool all = studentList.All(x => x.Age == 44);
            bool all2 = studentList.All(x => x.Age >4);

            bool areThereAny = studentList.Any(x => x.Age == 21);
            int count = studentList.Count(x => x.Age == 21);

            Student firstGanesh = studentList.First(x => x.Name == "Ganesh");
            Student singleGanesh = studentList.Single(x => x.Name == "Ganesh");//Exception when more then one elements

        }

        private static bool Exists(int[] array, int number)
        {//LinearSearch
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }
            return false;
        }

        private static int IndexOf(int[] array, int number)
        {
            //LinearSearch
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return i;
            }
            return -1;
        }

    }
}
