using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HelpMoneyChanged:Attribute
    {
        public  int _amount { get; set; }
        public string Message { get; set; }
        public HelpMoneyChanged(int amount) 
        {
            _amount = amount;

        
        }
        
    
    
    }
}
