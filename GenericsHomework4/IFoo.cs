using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework4
{
    interface IFoo<T>
    {
        void Method1(T param);
        T Method2();
    }
}
