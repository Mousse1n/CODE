using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Test4
{
    [Flags]
    enum Grade
    {

        Excellent,
        Passed,
        Failed

    }




    class Program
    {

        static void Main(string[] args)
        {
            //const Teacher gzc = new Teacher();

            //Student student = new Student();
            //Student TestString = new Student("张三");
            //Student TestInt = new Student(19);
            //Student TT = new Student("aa",16);
            //Teacher Me = new Teacher();
            //Student.BELONG;
            // WriteLine(Me.age);
            //Property student = new Property();
            // student.Age = 25;
            // WriteLine(student.Age);
            Student zjq = new Student(63);
            Type typeInfo = zjq.GetType();
            Type typeInfo2 = typeof(Student);
            FieldInfo onWeight = typeInfo.GetField("_weght", BindingFlags.NonPublic | BindingFlags.Instance);
            object student = onWeight.GetValue(zjq);
            ReadLine();
        }
    }


}
