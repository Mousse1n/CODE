using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace AbstractTest
{
    public interface IPlay
    {
        //int all;不能有字段
        //接口里面可以有访问修饰符
        //private都行了吗哈哈哈哈啊哈哈哈
        //不能为private
        //以前是不能有访问修饰符
    
    }

    public interface Ilearn:IMove//接口可以继承接口
    {
        //public double Score { get; set; }
        void GoLesson();
    
    }
    public abstract  class Person
    {
        public Person() 
        {
        
        }
        public Person(string name)
        {
              
        }

        public int Age { get;set;}
        public string Name { get; set; }
        //public virtual void eat() 
        //{

        //    WriteLine("开饭了");

        //}
        /*public*/protected void Grow() 
        {
        
        
        
        }
        public abstract void eat();
    }
    public class Student : Person,Ilearn,IPlay//接口可以多继承
    {
        public double Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public Student()
        {


        }
        public Student(string name) : base(name)
        {


        }
       // public double Score { get; set; }

        public override void eat()
        {
            throw new NotImplementedException();
        }
        public void GoLesson()
        {
            WriteLine("上学校");
        }

        public void go()
        {
            throw new NotImplementedException();
        }//一个子类要实现一个接口，就需要继承一个抽象方法一样，必须“实现”接口的全部成员！包括接口继承的所有接口里面的成员，接口可以无限继承接口

        void Ilearn.GoLesson()
        {
            throw new NotImplementedException();
        }

        void IMove.go()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Student*/Ilearn lw = new Student();
            lw.GoLesson();//隐式调用
            lw.GoLesson();//显示调用，只能用接口变量去调用。
            //new Person();抽象类不能创建实例
            //Person p = null;
            //p = new Student();
            //p.eat();
        }
    }
}
