using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class Suggest : Content
    {




        public override void Release()
        {
            Console.WriteLine("发布建议");
            Console.WriteLine("saved into db");
            //base.Release();
        }

    }
}
