using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverride
{
    class OnlineStudent: Student 
    {

        public override void eat()
        {
            base.eat();/*多重的Override*/
        }

    }
}
