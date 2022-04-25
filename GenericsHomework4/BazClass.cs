using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework4
{
    public class BazClass<T> : IBarZ<T>
    {
        public void Method(T param)
        {
            Console.WriteLine(param.ToString());
        }
    }
}
