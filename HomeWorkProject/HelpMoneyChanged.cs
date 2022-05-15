using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HelpMoneyChanged : Attribute
    {
        private int Amount { get; set; }
        public string Message { get; set; }
        public HelpMoneyChanged(int amount)
        {
            this.Amount = amount;

        }


    }
}
