using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    class Teacher :Person
    {

        public override void eat()
        {
             Console.WriteLine($"{Name}吃小灶");
            //base.eat();
        }

    }
}
