using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateNoteBook
{
    /// <summary>
    /// 定义返回值void，参数两个，int，string
    /// </summary>
    /// <returns></returns>
    public delegate void Opt(int a, int name);
    public delegate void OptString(string a, string b);
    public delegate void Opt<T1, T2>(T1 a, T2 b);
    public delegate Action<int, int> Opt2<T1, T2>(T1 a, T2 name);
    public class Generic<T> where T : Person
    {


    }
    public delegate TResult myFunc<in T1, in T2, out TResult>(T1 t1, T2 t2);

    public class Person
    {
        public int age { get; set; }


    }
    public class Student : Person
    {

    }
    class Program
    {
        //enum Operator
        //{
        //    Add,
        //    multpiple

        //}
        static Func<int> caculate()
        {
            int a = 100, b = 50;
            Console.WriteLine("this is a test");
            return () => a + b;


        }
        static void Opt(int x, int y)
        {
            int result = x % y /*+ sum*/;
            Console.WriteLine(result);
        }
        static void Closure(int a, int b, Action<int, int> opt)
        {
            Console.WriteLine("I'm AI caculator,let me try:");
            opt(a, b);
        }
        static void AICaculate(int a, int b, Action<int, int> opt)
        {

            Console.WriteLine("I am caculator,let me try:");

            opt(a, b);

            //switch (opt)
            //{
            //    case Operator.Add:
            //        Add(a, b);
            //        break;
            //    case Operator.multpiple:
            //        Multple(a, b);
            //        break;
            //    default:
            //        break;
            //}



            //Multple(a,b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"it is so easy,{a}+{b}={a + b}");



        }
        static Action<int, int> Multple(int a, int b)
        {

            Console.WriteLine($"I can ,{a}*{b} = {a * b}");
            return Add;
        }

        static void Main(string[] args)
        {

            IList<Student> students = new List<Student>
            {
            new Student{age = 60 },
            new Student{ age = 20},
            new Student{ age = 18}

            };
            //students.Any((student) => student.age > 20);
            //students.Any(s => s.age > 20);
            students.myAny(s => s.age>20);
        }

        static Student GetTeacher(Person student)
        {

            return new Student();

        }


    }
    public static class MyExtension
    {

       public  static bool myAny<T>(this IEnumerable<T> source, Func<T, bool> Preticate)
        {
            foreach (T item in source)
            {
                if (Preticate(item))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
