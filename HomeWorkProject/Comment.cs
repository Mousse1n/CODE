using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class Comment : Content
    {
        public IList<Article> Articles { get; set; }
        public Appraise Appraise { get; set; }



    }
}
