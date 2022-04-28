using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ForeachTest
{
    public class Student
    {
        public string Name { get; /*internal*/ set; }
    }
   public  class Perple
    {

        public void Learn()
        {

            Console.WriteLine("learning");

        }

    }

    public static class Extens
    {

        public static void Learn(this Perple perple)
        {

            Console.WriteLine("learning");

        }


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
            new Perple().Learn();//拓展方法
            
            
            //ICollection<int> col = null;
            //LinkedList<>
            //Queue<int>
            Exam(GetSingleDigtNumbers());
            IEnumerable<int> Numbers = GetSingleDigtNumbers();
            //系统生成一个Enumerable实例
            // Numbers.Average()

            //Enumerable.Average();


            //Exam(new List<Student>());

            //Exam(new Queue<Student>());
            IList<Student> students = new List<Student>
            {
            new Student(){Name ="lw" },
            new Student(){Name = "gz" }


            };


        }
    }
}
