using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Program
    {
        /// <summary>
        /// 用反射修改CreateTime
        /// </summary>
        /// <param name="content">Content对象</param>
        /// <param name="ChangeCreateTime">修改的时间</param>
        /// <returns>成功返回true</returns>

        public static bool ChangeCreateTime(Content content, DateTime ChangeCreateTime)
        {
            typeof(Content)
                .GetProperty(nameof(content._createTime), BindingFlags.Public | BindingFlags.Instance)
                .SetValue(content, ChangeCreateTime);

            return true;
        }
        /// <summary>
        /// 用反射修改PublishTime
        /// </summary>
        /// <param name="content">content对象</param>
        /// <param name="ChangePublishTime">修改的时间</param>
        /// <returns>成功返回true</returns>
        public static bool ChangePublishTime(Content content, DateTime ChangePublishTime)
        {
            typeof(Content)
                .GetProperty(nameof(content._publishTime), BindingFlags.Instance | BindingFlags.Public)
                .SetValue(content, ChangePublishTime);
            return true;

        }





        static void Main(string[] args)
        {
            // //用反射获取Publish()上的特性实例，输出其中包含的信息
            // Attribute attribute = HelpMoneyChanged.GetCustomAttribute(
            //     typeof(Article)
            //     .GetMethod("publish"),
            //     typeof(HelpMoneyChanged)
            //     );
            // Console.WriteLine(((HelpMoneyChanged)attribute)._amount);
            //// Console.WriteLine(((HelpMoneyChanged)attribute).Message);
            // Suggest sg = new Suggest();
            // //不能调用Id
            // //加载
            // //aaaa
            // Article article = new Article();
            // article.publish();
            // int a = article.id;
            // Suggest suggest = new Suggest();
            // suggest.publish();
            // int b = suggest.id;
            // //bool i = ChangeCreateTime(DateTime.Now);
            // //Console.WriteLine(i);
            // Console.ReadLine();
            ///一个文章有多个评论,
            ///一个评论必须有一个它所评论的文章，
            ///每个文章和评论都有一个评价
            ///一篇文章可以有多个关键字，
            ///一个关键字可以对应多篇文章

            Article gzc = new Article { name = "杨童舒" };
            Article yts = new Article { name = "dashbi" };

            Comment GoodComment = new Comment { content = "真棒" };
            Comment BadComment = new Comment { content = "差劲" };

            Keyword StudentLife = new Keyword { KeyWordName = "学生生活" };
            Keyword WorkLife = new Keyword { KeyWordName = "工作生活" };


            gzc.comments = new List<Comment>();
            gzc.comments.Add(GoodComment);
            gzc.comments.Add(BadComment);
            GoodComment.Article = gzc;
            BadComment.Article = gzc;

            gzc.Appraise = new Appraise { Agree = 1 };
            GoodComment.Appraise = new Appraise { Agree = 1 };
            BadComment.Appraise = new Appraise { DisAgree = 1 };
            gzc.keywords = new List<Keyword>();
            gzc.keywords.Add(StudentLife);
            gzc.keywords.Add(WorkLife);
            yts.keywords.Add(StudentLife);
            yts.keywords.Add(WorkLife);

            StudentLife.Articles = new List<Article>();
            WorkLife.Articles = new List<Article>();
            StudentLife.Articles.Add(gzc);
            StudentLife.Articles.Add(yts);
            WorkLife.Articles.Add(gzc);
            WorkLife.Articles.Add(yts);
        }

    }
}
