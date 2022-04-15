using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Test4
{
    class Student
    {
        private int _weight;
        public Student(int weight)
        {

            _weight = weight;

        }




        internal const string BELONG = " ";

        public Student()
        {

        }

        public Student(string name)
        {
            this.name = name;
            WriteLine($"你好啊{name}");

        }
        public Student(string name, int age) : this(name)
        {

            this.age = age;

        }
        public Student(string name, int age, int score) : this(name, age)
        {
            this.score = score;
        }
        //public Student(int age)
        //{
        //    this.age = age;
        //    WriteLine($"你的年龄是{age}");
        //}
        private string name;
        private int age;
        private int score;
    }
}
