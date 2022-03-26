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
        //internal int score { get; set; }
        public Student()
        {
        
        
        }
        public Student(int age,string name) :base(age)
        {
        
        
        }
        public Student(int age):base(age) 
        {
        
        }
        public double score { get; set; }
        public void Exam() 
        {
            eat();
            this.eat();
            base.eat();
            if (Age>18)
            {

            };
        }
    }  
}
