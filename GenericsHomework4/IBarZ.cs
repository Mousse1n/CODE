using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework4
{
    interface IBarZ<in T>
    {

        void Method(T param);


    }
}
