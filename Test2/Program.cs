using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test2
{
    class Program
    {
        public static void grows( ref Student student)
        {
            //student = new Student();
            //student.age++;
        }
        // static Student grow(Student student)
        //{
        //    Student sql = new Student();
            
        //     sql.age = student.age++;
            
        //    return sql;
        //}
        static void Main(string[] args)
        {
            //Student GZC = new Student("葛志超");
            //Student sj = new Student(12);
            //Student MJ = new Student();
            //= new Student("aa",16);

            //int a = 18;
            //int b = a;
            //b = 20;
            //Console.WriteLine(b+a);
            //Console.ReadLine();
            //Student wx = new Student();
            //Student wx = new Student();
            //wx.age = 20;
            //Student Clone = wx;
            //Clone.age = 100;
            //Console.WriteLine(wx.age);
            //Student wx = new Student();
            //wx.age = 18;
            //grow(wx);
            //ReadLine();
            //Student aa = new Student();
            //aa.age = 19;
            //grow(aa);
            //WriteLine(aa.age);
            //grows(ref aa);
            //WriteLine(aa.age);
            //WriteLine();
            //Student csharp = new Student();
            //csharp.age = 19;
            //csharp = grow(csharp);
            //WriteLine(csharp.age);
            //ReadLine();
            Console.WriteLine("请输入字符串");
            string userin = Console.ReadLine();
            Console.WriteLine($"你输入的字符串是:{userin}");
        }
    }
}
