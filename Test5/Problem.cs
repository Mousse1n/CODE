using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Problem:ContentService
    {

        private string Title;
        private string Body;
        private int Reward;
        private User Author;
        HelpMoney hpm = new HelpMoney();
        public override void publish()
        {
            hpm.changes -= Reward;
            base.publish();
        }
        public void Load(int id)
        {
        

        
        }
        public void Delete(int id) 
        {
            

         
        }
        public void Repoistory() 
        {
        
        
        
        }

    }
}
