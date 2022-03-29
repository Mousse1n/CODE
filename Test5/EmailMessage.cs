using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class EmailMessage : ISendMessage
    {
        public void Send()
        {

            Console.WriteLine("发送邮件");
            //throw new NotImplementedException();
        }
    }
}
