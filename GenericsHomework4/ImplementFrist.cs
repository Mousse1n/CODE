using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework4
{
    public class ImplementFrist<T> : IFoo<T>
    {
        public void Method1(T param)
        {
            Console.WriteLine(default(T));
        }

        public T Method2()
        {
            return default(T);
        }
    }
}
