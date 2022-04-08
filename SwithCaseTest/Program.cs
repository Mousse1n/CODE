using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwithCaseTest
{
    public enum Grade
    {
        Excellent = 0,
        Passed,
        Failed = -1,
        Good = 2

    }
     public enum Role
    {
        TeamLeader=1,
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
            Console.WriteLine(Equals(new Student(),new Student()));
            Console.WriteLine(Equals(new Role(),new Role()));
            Console.WriteLine(1 | 0);
            Console.WriteLine(1 & 0);
            Console.WriteLine(2 & 3);
            Console.WriteLine(Grade.Passed | Grade.Failed);
            Console.WriteLine(2^3);//10,11,01,1
            Console.WriteLine(1^3);//01,11,10,2
            Console.WriteLine(5^3);//101,011,110,6

            Console.ReadLine();
            Grade grade = new Grade();
            switch (grade)//直接列出枚举值
            {
                case Grade.Good:
                    Console.WriteLine("学的不错");
                    break;
                case Grade.Excellent:
                    Console.WriteLine("学的好哦");
                    break;
                case Grade.Passed:
                    Console.WriteLine("查漏补缺");
                    break;
                case Grade.Failed:
                    Console.WriteLine("^(*￣(oo)￣)^");
                    break;
                default://问题要暴露出来
                    Console.WriteLine($"枚举值{grade}未被处理");
                    break;
            }
            //if (grade == Grade.Passed)
            //{

            //}
            //else if(grade == Grade.Excellent)
            //{

            //}
            //Student student = new Student();
            //student.Roles[0] = Role.TeamLeader;
            //student.Roles[1] = Role.Expert;
            //student.Roles[2] = Role.Beauty;
            Student lw = new Student();
            lw.Roles = (Role)lw.Roles | Role.Beauty;//加法
            lw.Roles = (Role)lw.Roles ^ Role.Beauty;//减法
            //Role r = Role
            Console.WriteLine(((Role)lw.Roles&Role.Beauty) == Role.Beauty);
        }
    }
}
