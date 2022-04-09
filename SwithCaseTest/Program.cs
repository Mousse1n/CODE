using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithCaseTest
{
    //public struct 
    public enum Grade
    {
        Excellent = 0,
        Passed,
        Failed = -1,
        Good = 2

    }

    public struct Bed
    {

        public double Price { get; set; }

    }

    public enum Role
    {
        TeamLeader = 1,
        Expert = 2,
        Beauty = 4,
        Player = 8
    }
    public class Person
    {



    }
    public class Student
    {
        //public Role[] Roles { get; set; } = new Role[10];
        public Role Roles { get; set; }


    }
    class Program
    {

        static void Main(string[] args)
        {

            DayOfWeek.Friday.GetType();//所有类都继承自Object类(默认继承子object类)
                                       //Console.WriteLine(Equals(new Student(),new Student()));
                                       //Console.WriteLine(Equals(new Role(),new Role()));
                                       //Console.WriteLine(1 | 0);
                                       //Console.WriteLine(1 & 0);
                                       //Console.WriteLine(2 & 3);
                                       //Console.WriteLine(Grade.Passed | Grade.Failed);
                                       //Console.WriteLine(2^3);//10,11,01,1
                                       //Console.WriteLine(1^3);//01,11,10,2
                                       //Console.WriteLine(5^3);//101,011,110,6
            Console.WriteLine(Equals(new Grade(), new Grade()));
            Console.WriteLine(new Grade() == new Grade());
            //Console.WriteLine(new Bed() == new Bed());
            Console.WriteLine(Equals(new Student(), new Student()));
            Console.WriteLine(Equals(new Student(), new Person()));
            Console.WriteLine(Equals(new Student(), new Bed()));
            Console.WriteLine(ReferenceEquals(new Student(), new Student()));
            Console.WriteLine();
            Console.WriteLine(new Student() == new Student());
            Bed b1 = new Bed();
            Bed b2 = b1;
            Console.WriteLine(ReferenceEquals(b2, b1));
            string s1 = "shabi";
            string s2 = "shabi";
            Console.WriteLine(s1 == s2);
            Console.WriteLine(Equals(s1, s2));
            //散列算法获取固定长度数据
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(new Student().GetHashCode());
            Console.WriteLine(new Person().GetHashCode());
            Person gzc = new Person();
            Console.WriteLine(gzc.GetType().Name);//运行时能拿到信息
            Console.WriteLine(gzc.GetType().FullName);
            Console.WriteLine(gzc.GetType().IsClass);
            Console.WriteLine(typeof(Person).Name);//编译时就能拿到信息
            Console.ReadLine();
            //  Grade grade = new Grade();
            //switch (grade)//直接列出枚举值
            //{
            //    case Grade.Good:
            //        Console.WriteLine("学的不错");
            //        break;
            //    case Grade.Excellent:
            //        Console.WriteLine("学的好哦");
            //        break;
            //    case Grade.Passed:
            //        Console.WriteLine("查漏补缺");
            //        break;
            //    case Grade.Failed:
            //        Console.WriteLine("^(*￣(oo)￣)^");
            //        break;
            //    default://问题要暴露出来
            //        Console.WriteLine($"枚举值{grade}未被处理");
            //        break;
            //}
            ////if (grade == Grade.Passed)
            ////{

            ////}
            ////else if(grade == Grade.Excellent)
            ////{

            ////}
            ////Student student = new Student();
            ////student.Roles[0] = Role.TeamLeader;
            ////student.Roles[1] = Role.Expert;
            ////student.Roles[2] = Role.Beauty;
            //Student lw = new Student();
            //lw.Roles = (Role)lw.Roles | Role.Beauty;//加法
            //lw.Roles = (Role)lw.Roles ^ Role.Beauty;//减法
            ////Role r = Role
            // Console.WriteLine(((Role)lw.Roles&Role.Beauty) == Role.Beauty);
        }
    }
}
