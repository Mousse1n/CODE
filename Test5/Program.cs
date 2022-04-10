using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            Suggest sg = new Suggest();
            //不能调用Id
            //加载
            //aaaa
            Article article = new Article();
            article.publish();
            int a = article.id;
            Suggest suggest = new Suggest();
            suggest.publish();
            int b = suggest.id;
        }
    }
}
