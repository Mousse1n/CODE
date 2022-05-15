using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class EmailMessage : ISendMessage
    {
        public void Send()
        {

            Console.WriteLine("发送");
            //throw new NotImplementedException();
        }
    }
}
