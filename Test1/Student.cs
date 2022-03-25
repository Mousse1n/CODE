using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Student
    {

        static string at = "元栈";
        private   string _name;
       public  static  Student[] students = new Student[20];
        public Student(string name)
        {
            _name = name;
        }
        internal  void learn() 
        {

            Console.WriteLine($"{_name}在{at}学习……");
            
        }
       public static  int enroll(Student student) 
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                }
                else
                {
                    continue;
                }
                return i;
            }
            return -1;
        }
    }
}
