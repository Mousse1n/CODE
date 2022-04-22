using System;


namespace NewGenericsTest
{





    public class Person<T> /*where T : Major { }*/
        //泛型的类型参数 T这个值是自己取的（占位符，动态变化）
    //编译时完成，（具象化），类型安全，编译时检查，尽早的暴露问题,避免拆箱装箱，提高性能
    //泛型不是类
    {
     public T[] Hobbies { get; set; }
        //default 关键字
       private T innerT1Object  { get; set; }
        public Person()
        {
            innerT1Object = default(T);//判断是否是值类型，如果是值类型赋值0，如果是应用类型，赋值null；

        }
        public void Grow<Tage>()
        {


        }



    }
    public class Student{}
    public interface Ilearn<T>
    {

        void Teacher(T major);

    }
    public class Bed
    {


    }

    public class Generic<T/*,Tvalue*/> /*where T:*/ /*struct*/ /*class*//*new()*/ /*Person<T>以及其子类*/ /*Ilearn<T>及其实现*/
    {
    
    
    
    
    }


    public class Major { }
    public class SQL : Major { }
    //public class Teacher : Person<Major> { }//必须指明具体的类型参数 
    //public class Teacher : Person<T> { }
     class Teacher<T> : Person<T> where T : Major { }
    //Teacher<T>和Teacher有没有什么关系？
    //Teacher 是Teacher<T>的具象化
    class Program
    {
        //不知道A和B到底是哪个类型，a+b就没办法确定是拼接字符串还是计算加减法 ；
        //T GetT<T>(T a , T b)
        //{
        //    //T c;
        //    //if (a.GetType() == b.GetType())
        //    //{
        //    //     c = a + b;
        //    //    return c;
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("错误");
        //    //    return c;
        //    //}
        //    return a + b;
        //}
        
        
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
            //Console.WriteLine(typeof(Generic<Tkey,TValue>));
            //只有在指定了泛型的类型参数的时候，才确定了一个类型
           // Generic<int> scores;
            Generic<string> students = new Generic<string>();
            //使用了不同类型参数的泛型类，不是同一个类：
            Console.WriteLine(typeof(Generic<int>) ==new  Generic<int>().GetType());
            Console.WriteLine(typeof(Generic<Student>) == new Generic<Student>().GetType());
            Console.WriteLine(typeof(Generic<int>) == new Generic<Student>().GetType());
            //由泛型参数的和没有泛型参数的，也不是同一个类：
            Generic<int> scores = new Generic<int>();
           // scores = new Generic<string>();
            Console.WriteLine(typeof(Generic<int>) == new Generic<string>().GetType());


        }
    }
}
