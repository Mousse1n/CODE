using System;
using System.Reflection;
using VBTest;

namespace GetFieldMore
{

    [AttributeUsage(AttributeTargets.Class)]
    public class OnlineAttribute : Attribute//只有继承Attribute才能是特性 
    {
        public int Version{get;set;}
    
    }
  
    [Flags]
    enum Grade 
    {
        Failed =0,
        Passed = 1,
        Good = 2,
        Nice = 4
    }
   
   [Online(Version = 3)]
    class Student
    {
        private int _weight;
        
        public Student(int weight) 
        {
            _weight = weight;
        
        
        }
        public Student() 
        {
        
        }
        [Obsolete("下个版本会删除，请使用welcome()", true)]
        public void Greet(string name ) 
        {
            Console.WriteLine($"你好啊{name}");
        
        }

    }



    class Program
    {



        static void Main(string[] args)
        {

            //Student student = new Student();
            // int weight  =(int) student.GetType()
            //    .GetField("_weight",BindingFlags.NonPublic|BindingFlags.Instance)
            //    .GetValue(student);
            //Console.WriteLine(weight);
            //typeof(Student).GetMethod("Greet").Invoke(student, new object[] { "shabi1" });
            //Attribute attribute  = OnlineAttribute.GetCustomAttribute(
            //    typeof(Student),//student
            //    typeof(OnlineAttribute)//OnlineAttribute特性




            //    );
            //Console.WriteLine(((OnlineAttribute)attribute).Version);
            Grade.Good.ToString();
           /// Console.WriteLine(Grade.Good is IFormattable);
            Console.WriteLine(Grade.Passed|Grade.Good);
            Student student = new Student();
           //student.Greet("shabi1");
        }
    }
}
