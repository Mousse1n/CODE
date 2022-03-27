using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace VirtualAndOverride
{
    class Program
    {
        static void Main(string[] args)
        {

            //Teacher fg = new Teacher();
            ServerLunch(new Teacher {Name = "飞哥" });
            ServerLunch(new Student {Name ="aa" });
            //ServerLunch("老师",fg);
            //Person gzc = new Student();
            //Person gzc = new Student();
            //gzc.eat();
            //gzc = new Teacher();
            //gzc.eat();
            ReadLine();
        }
        static void ServerLunch(Person person) 
        {
             
            WriteLine("开饭了");
            person.eat();
            //if (role == "老师")
            //{
            //    teacher.eat();
            //}
            //else if (role == "学生")
            //{
            //    new Student().eat();
            //}

        }
    }
}
