using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Test4
{
    class Property
    {
        private int _age;

        public int Age 
        { 
          get => _age;
          set => _age = value; 
        }

        //    internal void setAge(int age) 
        //    {

        //        if (age < 0 || age > 100)
        //        {
        //            Console.WriteLine("给age的赋值超过了");
        //            return;
        //        }
        //        _age = age;
        //    }
        //    internal int getAge(int age) 
        //    {

        //        return _age;

        //    }

    }
}
