using System;

namespace NewGenericsTest
{
    public class Person<T>//泛型的类型参数 T这个值是自己取的（占位符，动态变化）
    //编译时完成，（具象化），类型安全，编译时检查，尽早的暴露问题,避免拆箱装箱，提高性能
    //泛型不是类
    {
        public T[] Hobbies { get; set; }
        public Person()
        {
        
        
        }
        public void Grow<Tage>() 
        {
        
        
        }



    }
    public interface Ilearn<T>
    {

        void Teacher(T major);
    
    }
    public class Bed 
    {
    
    
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //object[] student = { 32,"48",true};
            //int age = (int)student[0];
            //age++;
           Person<int> GT = new Person<int>();
            GT.Hobbies = new int[10]; /*new string[10];*/
            Person < Bed > aaa = new Person<Bed>();
            Console.WriteLine(typeof(Console));
            //Console.WriteLine(typeof(Person<T>));
            Console.WriteLine(typeof(Person<int>));//具象化
            Console.WriteLine(typeof(Person<int>)== new Person<int>().GetType());

            Console.WriteLine(typeof(Person<int>) == new Person<string>().GetType());






        }
    }
}
