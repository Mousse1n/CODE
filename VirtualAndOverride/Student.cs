using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    class Student:Person
    {

        //public new  /*static*/ void  eat ()//静态方法也可以用new来使用 静态不存在多态问题
        //{

        //    Console.WriteLine("同学们到谁家吃饭了");

        //}
        public override /*sealed*/ void eat()
        {
            //base/*基类*/.eat();
            Console.WriteLine($"{Name}吃大锅饭");
        }
    }
}
