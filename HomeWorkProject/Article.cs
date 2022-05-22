using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class Article : Content
    {


        public Appraise Appraise { get; set; }
        public IList<Comment> comments { get; set; }
        public IList<Keyword> KeyWords { get; set; }
        public Article(Article article)
        {
            if (article.Title == null)
            {
                Console.WriteLine("标题不能为null");
            }

        }
        public Article()
        {


        }
        /// <summary>
        /// 发布文章
        /// </summary>
        public override void Release()
        {

            Author.HelpMoney.HelpMoneyNumber = Author.HelpMoney.HelpMoneyNumber - 1;

            Console.WriteLine("发布文章");
            //base.Release();
        }
        /// <summary>
        /// 点赞帮帮点增加
        /// </summary>
        /// <returns>成功或者失败</returns>
        public override bool Agree()
        {
            Author.HelpPoint += 1;
            Appraiser.HelpPoint += 1;

            //base.Agree();
            return true;
        }
        /// <summary>
        /// 点踩帮帮点减少
        /// </summary>
        /// <returns>成功返回true,失败返回false</returns>
        public override bool DisAgree()
        {
            Author.HelpPoint -= 1;
            Appraiser.HelpPoint -= 1;
            return true;
        }

    }
}
