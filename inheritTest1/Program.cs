using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace inheritTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            AgileStudent zha = new AgileStudent(98,"渣",20);
            WriteLine(zha.Age);
            //Student gzc = new Student(19,"嘿嘿");
            //gzc.Name = "葛志超";
            //gzc.eat();
            //Person fg = new Person("");
            //fg.Name = "叶飞";
            //Teacher feige = new Teacher();
            ////访问修饰符的一致性（简单理解为子类区域大于父类，会破坏本来设定的访问级别）
            //WriteLine(feige.Name);
            ////多重继承
            //AgileStudent gzcc = new AgileStudent(98,"ha",20);
            //gzcc.Name = "gezhichaochao";
            //gzcc.score = 99;
            //静态类不能被继承但是费静态类中的静态成员是能被继承的
            //Student.Belong("string");
            //UML统一建模语言
            //子类对象一定会调用父类构造函数
            //运行时会默认调用显示影视构造函数，如果是多个构造函数，在子类中决定 :base(参数)
        }
    }
}
