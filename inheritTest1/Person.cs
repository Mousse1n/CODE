using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace inheritTest1
{
    class Person
    {
        public int Age { get; set; }
        public Person(string name) 
        {
            Name = name;
        
        }
        public Person(int age)
        {

            Age = age;

        }
        internal string Name { get; set; }
        
        internal void eat() 
        {

            WriteLine("吃饭去了");
        
        }
        public static string Belong { get; set; }
    }
}
