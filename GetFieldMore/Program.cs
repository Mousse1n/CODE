using System;
using System.Reflection;
using VBTest;

namespace GetFieldMore
{
    //public class
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
        public void Greet(string name ) 
        {
            Console.WriteLine($"你好啊{name}");
        
        }

    }



    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            
            Student student = new Student();
             int weight  =(int) student.GetType()
                .GetField("_weight",BindingFlags.NonPublic|BindingFlags.Instance)
                .GetValue(student);
            Console.WriteLine(weight);
            typeof(Student).GetMethod("Greet").Invoke(student, new object[] { "shabi1" });
        }
    }
}
