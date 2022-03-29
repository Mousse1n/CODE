using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {

            Console.WriteLine("向数据库发送数据");
            //throw new NotImplementedException();
        }
    }
}
