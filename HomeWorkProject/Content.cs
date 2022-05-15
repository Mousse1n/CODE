using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class Content : ContentService
    {

        public User Author { get; set; }
        public User Appraiser { get; set; }
        public string Title { get; set; }
        protected string[] kind = { "problem", "article", "suggest" };
        private DateTime PublishTime { get; }
        private DateTime CreateTime { get; }
        public override void Release()
        {
            //base.Release();
            Console.WriteLine("发布内容");
        }

    }
}
