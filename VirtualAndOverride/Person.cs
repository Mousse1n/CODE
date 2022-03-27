using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    class Person
    {
        public String Name;
    public /*static*/ virtual/*虚拟的*/ void eat() 
        {

            Console.WriteLine("同学们开饭了");


        }
    
    }
}
