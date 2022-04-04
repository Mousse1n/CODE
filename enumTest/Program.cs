using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //初始化的时候，初始值为0,枚举会去找0对应的参数
            Grade grade = Grade.Excellent;
            Console.WriteLine((int)grade);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Grade got = (Grade)10;//不报错
            //Console.WriteLine();
            Console.WriteLine((short)Grade.Passed);
            Console.ReadLine();
        
        }
    }
}
