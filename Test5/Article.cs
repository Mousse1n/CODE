using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Article :ContentService
    {
        HelpMoney hpm = new HelpMoney();

        public override void publish()
        {
            hpm.changes--;
            base.publish();
        }

    }
}
