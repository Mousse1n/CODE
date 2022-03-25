using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Cat
    {

        public static string BeLong { get; set; } = "哺乳动物";
        private string name;
        static Cat()
        {
        
        }
        public Cat(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student gzc = new Student();
            gzc[1] = 98.5;
            gzc[2] = 89;
            Console.WriteLine(gzc[2]);
            Console.ReadLine();
            //var wx = new
            //{
            //    name = "liuliu",
            //    age = 23,

            //};
            //var liuliui = new
            //{ 
            //    name = "liliu",
            //    age = 27,

            //};
            //wx = liuliui;
            Cat follower =  new Cat("小花");
            Cat miao = new Cat("喵喵");

        }
    }
}
