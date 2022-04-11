using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Suggest :ContentService,IAgreeOrDisagree
    {
        Article Article = new Article();
        public override void publish()
        {
            base.publish();
        }

        public bool Agree()
        {
           
            throw new NotImplementedException();
        }

        public bool DisAgree()
        {
            throw new NotImplementedException();
        }
    }
}
