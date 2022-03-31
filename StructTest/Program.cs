using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTest
{
    public struct /*class*/ Bed
    {
        //public Bed() 结构不包括显式的无参构造函数，值类型要求其所有成员必须有值，引用类型可以指向null值，因为值类型存储是要在地址中拓展。引用类型是存的地址。
        //{
        //不写代码由.net运行时自己控制，怕乱
        //}
        //结构是值类型
        public double Price { get; set; }
        public int _number;
        public bool HasBooked { get; set; }
        public Bed(int number) //有值保证以后调用时不会出现null，不然就和引用类型是一样的，逻辑错误。
        {
            _number = number;
            Price = 98.6;
            HasBooked = true;
        }

    }



    class Program
    {




        //private string _i;
        //public string SetI(string i) 
        //{

        //    if (i=="admin")
        //    {
        //        i = "系统管理员";
        //        return "修改陈宫";
        //    }
        //    _i = i;
        //    return null;
        //} 



        static void Main(string[] args)
        {
            Console.WriteLine(new Student {age = 18 }>new Student{age=17 });
            double gep = new Student { Score = 98.5 } - new Student {Score = 98.0 };
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH小时mm分 "));





            //string now = "2010/2/22";

            //if (DateTime.TryParse(now, out DateTime result))
            //{
            //    result = result.AddYears(10);//传出的是对象，需要变量接受
            //    Console.WriteLine(result.Year);
            //}
            //else
            //{
            //    Console.WriteLine("wrong format");
            //}

            ////DateTime.Parse();
            //DateTime time;
            //Console.WriteLine(new DateTime(2020,10,29,3,12,20));
            //Console.WriteLine(DateTime.MaxValue );
            // Console.WriteLine(DateTime.Now);
            ///*int*/Int32 age = new Int32();//int 是int32的简写
            /*long aa = new Int64()*/
            ;
            //if (age is Int32)
            //{

            //}
            //Bed bed = new Bed();
            // long number = 6789;
            // number.CompareTo(age);
            // Console.WriteLine(age);
            ////struct结构
            // int.Parse("");
            // Bed dream /*= new Bed()*/;
            // //dream.HasBooked = false;
            // dream._number = 32;//只有字段可以，方法属性是不行的
        }
    }
    internal class Person
    {
        public int age { get; set; }
        public Person()
        {
            
        }

    }
    internal class Student : Person
    {
        public double Score { get;  set; }

        public static Double operator -(Student a,Student b)
        {
            
            return a.Score - b.Score;

        }
        public static bool operator >(Student a,Student b)
        {
            return a.age > b.age;



        }
        public static bool operator <(Student a, Student b)
        {
            return a.age < b.age;

        }
        public Student()
        {




        }
    }
}
