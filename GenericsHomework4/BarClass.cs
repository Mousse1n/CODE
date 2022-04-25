using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework4
{
    public class BarClass<T> : IBar<T>
    {
        public T Method()
        {
            return default(T);
        }
    }
}
