using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{

    public  class  ContentService
    {
        public int id { get; set; }
        public virtual void   publish()
        {

            Console.WriteLine("已经推送且扣除相应帮帮币");

        }

    }
}
