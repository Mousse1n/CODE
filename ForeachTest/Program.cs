using ForeachTest;
using MyNamespace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ForeachTest
{
    public class Person 
    {

        public string Name { get; /*internal*/ set; }

    }
    
    public class Major
    {
        public IList<Teacher> Teachers { get; set; }
        public string Name { get; /*internal*/ set; }
    }


    public class Teacher:Person
    {
        public ICollection<Student> Student { get; set; }
        public IList<Major> Majors { get; set; }

    }
    public class Student:Person
    {
        public Teacher Teacher { get; set; }
        public Perple Perple { get; set; }

        
    }
    public class Perple
    {
        public string name { get; set; }
        //public void Learn()
        //{

        //    Console.WriteLine("learning");

        //}

    }



    class Program
    {
        static IEnumerable<int> GetSingleDigtNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 2)
                {
                    yield break;
                }
                yield return i;
            }




            //yield return 0;
            //yield return 1;
            //yield return 2;
            //yield return 3;
            //yield return 4;
            //yield return 5;
            //return new int[10];
        }
        static void Exam(IEnumerable<int> students)
        {

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

        }

        static void Main(string[] args)
        {
            Student student = new Student { Name = "aa" };
            Teacher ba = new Teacher { Name = "bb"};


            student.Teacher = ba;
            //teacher.Student = new List<Student>();
            //teacher.Student.Add(student);
            ba.Student = new List<Student> { student };
            Major csharp = new Major {Name ="csharp" };
            Major sql = new Major {Name = "Sql" };
            Major javascript = new Major {Name = "javascript" };

            Teacher ab = new Teacher { Name = "ab" };

            ba.Majors = new List<Major>{csharp,sql,javascript };
            ab.Majors = new List<Major> {sql,javascript };

            csharp.Teachers = new List<Teacher> { ba };
            sql.Teachers = new List<Teacher> { ba, ab };
            javascript.Teachers = new List<Teacher> { ba, ab };


            //Perple perple = new Perple();

            //perple.Learn("Name");
            //Console.WriteLine(perple.name);
            ////拓展方法,优先级低于类的静态实例方法
            ////ArrayList array = new ArrayList();
            ////array.Add();
            ////ICollection<int> col = null;
            ////LinkedList<>
            ////Queue<int>
            //Exam(GetSingleDigtNumbers());
            //IEnumerable<int> Numbers = GetSingleDigtNumbers();
            ////系统生成一个Enumerable实例
            //// Numbers.Average()

            ////Enumerable.Average();


            ////Exam(new List<Student>());

            ////Exam(new Queue<Student>());
            //IList<Student> students = new List<Student>
            //{
            //new Student(){Name ="lw" },
            //new Student(){Name = "gz" }


            //};


        }
    }
}
namespace MyNamespace
{

    public static class Extens
    {

        public static void Learn(this Perple perple, string name)
        {

            perple.name = name;
            Console.WriteLine("learning");

        }


    }


}
