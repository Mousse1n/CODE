using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQStudyNotes
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Teacher : Person
    {
        public IList<Major> Majors { get; set; }

    }
    class Student : Person
    {

        public double Score { get; set; }
        public IList<Major> Majors { get; set; }
    }
    class Major
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public double Difficulty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher fg = new Teacher { Name = "大飞哥" };
            Teacher fish = new Teacher { Name = "小鱼" };
            Teacher waiting = new Teacher { Name = "诚聘", Age = 0 };
            IEnumerable<Teacher> teachers = new List<Teacher> { fg, fish, waiting };

            Major csharp = new Major { Name = "C#", Teacher = fg };
            Major SQL = new Major { Name = "SQL", Teacher = fg };
            Major Javascript = new Major { Name = "Javascript", Teacher = fg };
            Major UI = new Major { Name = "UI", Teacher = fish };
            IEnumerable<Major> majors = new List<Major> { csharp, SQL, Javascript, UI };

            IList<Student> students = new List<Student>
            {

                new Student{Score =98,Name="屿",Majors = new List<Major>{csharp,SQL } },
                new Student{Score =86,Name="行人",Majors = new List<Major>{Javascript,csharp,SQL } },
                new Student{Score =78,Name="王平",Majors = new List<Major>{csharp } },
                new Student{Score =89,Name="王枫",Majors = new List<Major>{Javascript,csharp,SQL,UI } },
                new Student{Score =98,Name="蒋宜蒙",Majors = new List<Major>{Javascript,csharp } }

            };
            IEnumerable<IGrouping<Teacher, Major>> result =
                from s in majors/*students*/
                    // where s.Majors.Contains(Javascript)
                    //where s.Majors.Count() >= 2
                    // where s.Name.StartsWith("王") && s.Score > 80
                    //orderby s.Score ascending
                    //orderby s.Score descending
                group s by s.Teacher;

            //select s;
            foreach (IGrouping<Teacher, Major> item in result)
            {


                Console.WriteLine(item.Key.Name);//老师名字
                foreach (var mojer in item)
                {
                    Console.WriteLine(mojer.Name);
                }
               
                Console.WriteLine(item.Count());
                Console.WriteLine(item.Sum(m => m.Difficulty));
                Console.WriteLine(item.Average(m => m.Difficulty));
                Console.WriteLine(item.Max(m=>m.Difficulty));
                Console.WriteLine(item.Min(m=>m.Difficulty));
                //Console.WriteLine(item.Sum(m => { return m.Difficulty; }));
                // Console.WriteLine($"{item.Name}:{item.Score}");
            }
            //IEnumerable<Student> students = new List<Student>
            //{

            //  new Student { Age = 18 },
            //  new Student { Age = 19 },
            //  new Student{Age = 16 },
            //  new Student{Age = 26 }


            //};

            //var excellent = from s in students
            //                where s.Score > 90
            //                select s;

            //var teanager = from s in students
            //               where s.Age < 18
            //               select s;
            //foreach (var item in teanager)
            //{
            //    Console.WriteLine(item.Age);
            //}

        }
        static IEnumerable<T> filterByAge<T>(IEnumerable<T> students,
            Func<T, bool> predicate)
        {
            IList<T> result = new List<T>();
            foreach (var item in students)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }

            }


            return result;

        }
        static IEnumerable<T> DelfilterByAge<T>(IEnumerable<T> students,
            Func<T, bool> predicate)
        {
            //IList<T> result = new List<T>();
            foreach (var item in students)
            {
                if (predicate(item))
                {
                    //result.Add(item);
                    yield return item;

                }

            }


            //return result;

        }





    }
}
