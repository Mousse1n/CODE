using System;
using System.Collections.Generic;

namespace ListTestApplication
{
    class Program
    {
       

        static void Main(string[] args)
        {
            List<int> score = new List<int> { 90, 110, 100 };
            score[1] = 120;
            score.Add(12);
            score.Add(100);
            score.BinarySearch(100);
            score.Insert(0, 70);
            //score.AddRange();
            score.Remove(100);
            //score.RemoveAll();
            score.RemoveAt(1);
            score.Contains(120);
            Console.WriteLine(score.IndexOf(120));
            Console.WriteLine(score.LastIndexOf(100));
            Console.WriteLine(score[2]);
            score.Clear();
            Console.WriteLine(score.Count);
            //Console.WriteLine("Hello World!");
            //Dictionary<string, double> scores = new Dictionary<string, double>()
            //{

            //    {"lgy",58},
            //    {"zl",98},
            //    {"gty",85 }

            //};
            //Console.WriteLine(scores["lgy"]);
            //scores.Add("",98);
            //scores.Remove("");
            //scores[""] = 68;

            ////LinkedList<>
            Student lw = new Student();
            Student zdh = new Student();
            Student lzb = new Student();
            //Queue<Student> students = new Queue<Student>();
            //students.Enqueue(lw);
            //students.Enqueue(zdh);
            //students.Enqueue(lzb);
            //Console.WriteLine(students.Peek() == lw);
            //Console.WriteLine(students.TryPeek(out Student result)&& result == lw);
            Dictionary<string, Student> students = new Dictionary<string, Student>
            {
                {"lw",new Student() },
                {"gzy",new Student() },
                {"zl",new Student() },
                {"lzb",new Student() }

            };
            foreach (var item in students)//item不能赋值
            {
                Console.WriteLine(item);
                //item.Value = "aaaa";
            }
            List<Student> studentList = new List<Student>()
            {

            new Student{Name ="aaa" },
            new Student{Name = "bbb" }

            };
            foreach (var item in studentList)
            {
                item.Name = "aaa";//将拿到的对象的属性进行更改是可以的
                //item = new Student(); 不能保证拿到下一个
            }




        }
    }

    public  class Student
    {
        public string Name { get;  set; }




    }
}
