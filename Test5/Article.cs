using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    public class Article : ContentService
    {
        public Appraise Appraise { get; set; }
        public IList<Comment> comments { get; set; }
        public IList<Keyword> keywords { get; set; }
        private string _title;
        public void setTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("标题不能为空");
                return;

            }

            else if (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("标题里不能有空格！");
                string Changetitle = title.Trim();
                _title = Changetitle;
            }
            else
            {
                _title = title;  
            }

        }
        public string getTitle()
        {
            return _title;


        }



        HelpMoney hpm = new HelpMoney();
        [HelpMoneyChanged(5)]
        public override void publish()
        {
            hpm.changes--;
            base.publish();
        }

    }
}
