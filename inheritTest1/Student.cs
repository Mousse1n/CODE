using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritTest1
{
    class Student:Person
  {
    //    public Student() : base("") 
    //    {
        
    //    }
        internal int score { get; set; }
        public Student(int age,string name) :base(age)
        {
        
        
        }
        public Student(int age):base(age) 
        {
        
        }
    }  
}
