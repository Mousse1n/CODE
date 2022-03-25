using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。
namespace Test5
{
   
    class FactoryContext
    {
        private static FactoryContext _factoryContext = null;
        static FactoryContext() 
        {

            _factoryContext = new FactoryContext();
        
        }
        public static FactoryContext CreateInstance() 
        {

            return _factoryContext;
        
        }
    }
}
