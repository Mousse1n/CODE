using System;
using System.Collections.Generic;

namespace GenericsHomework4
{

    interface IParent 
    {

        void DoSomething();
    
    }
    public class SubClass : IParent
    {
        public void DoSomething()
        {
            Console.WriteLine("SubMethod");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //IFoo不支持参数T的协变
            IFoo<SubClass> foo_sub = new ImplementFrist<SubClass>();
            //IFoo<IParent> foo_Parent = foo_sub;编译错误无法将类型“IFoo<SubClass>”隐式转换为“IFoo<IParent>”。存在一个显式转换(是否缺少强制转换?)”
            //IBar支持参数T的协变
            IBar<SubClass> bar_sub = new BarClass<SubClass>();
            IBar<IParent> bar_parent = bar_sub;



            //按照逆变逻辑，使用IFoo和IBaz。
            IFoo<IParent> foo_parent = null;
            //IFoo<SubClass> foo_sub = foo_parent;编译错误
            // foo_sub = foo_parent 会提示编译时错误“无法将类型“IFoo<IParent>”隐式转换为“IFoo<ISub>”。存在一个显式转换(是否缺少强制转换?)”
            //IBaz 对参数T逆变相容
            IBarZ<IParent> barz_parent = null;
            IBarZ<SubClass> barz_sub = barz_parent;
            //C#2.0报错
            List<SubClass> subarr = new List<SubClass>();
            IEnumerable<IParent> parentarr = subarr;













        }
    }
}
