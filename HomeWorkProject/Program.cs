using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HomeWorkProject
{
    public delegate int ProvideWater(Person person);

    class Program
    {
        /// <summary>
        /// 打水
        /// </summary>
        /// <param name="person">人实例</param>
        /// <returns>打水数</returns>
        public static int ProvideWaterMethod(Person person)
        {

            person.WaterNumber = 100;
            Console.WriteLine(person.WaterNumber);
            return person.WaterNumber;
        }
        /// <summary>
        /// 声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出
        /// </summary>
        /// <param name="provideWater">委托</param>

        public static void GetWater()
        {
            ProvideWater pw = ProvideWaterMethod;
            Console.WriteLine(pw(new Person()));

        }
        public static void Rundelegate()
        {
            //方法
            ProvideWater Pw = ProvideWaterMethod;
            Pw(new Person());
            //匿名方法
            ProvideWater Pwater = delegate (Person person)
            {
                person.WaterNumber = 1000;
                Console.WriteLine(person.WaterNumber);
                return person.WaterNumber;
            };
            Pwater(new Person());
            //lambda表达式
            ProvideWater provideWater = p =>
            {
                p.WaterNumber = 10000;
                Console.WriteLine(p.WaterNumber);
                return p.WaterNumber;

            };
            provideWater(new Person());



        }


        static void Main(string[] args)
        {
            //GetWater();
            // Rundelegate();
            //Console.WriteLine("Hello World!");
            //Problem problem = new Problem();
            //Type typeInfo = problem.GetType();
            //MethodInfo methodInfo  = typeInfo.GetMethod("publish");
            //Console.WriteLine(methodInfo.Attributes); 
            User fg = new User() { Name = "飞哥" };
            User xiaoyu = new User() { Name = "小鱼" };

            IList<Article> articles = new List<Article>();

            Article zbl = new Article() { Title = "资本论", Author = fg, PublishTime = new DateTime(2021, 12, 16) };
            Article zgts = new Article() { Title = "中国通史", Author = fg, PublishTime = new DateTime(2020, 12, 13) };
            Article swdnr = new Article() { Title = "上尉的女儿", Author = xiaoyu, PublishTime = new DateTime(2019, 4, 20) };
            Article CSharpTeacher = new Article() { Title = "C#老师", Author = fg, PublishTime = new DateTime(2019, 12, 13) };
            Article DaoNetTeacher = new Article() { Title = ".NET老师", Author = xiaoyu, PublishTime = new DateTime(2020, 12, 30) };

            articles.Add(zbl);
            articles.Add(zgts);
            articles.Add(swdnr);
            articles.Add(CSharpTeacher);
            articles.Add(DaoNetTeacher);

            Comment GoodComment = new Comment() { Title = "GOOD" };
            Comment NiceComment = new Comment() { Title = "nice" };
            Comment BadComment = new Comment() { Title = "不好" };

            Appraise zblAppraise = new Appraise() { Agree = 1 };
            Appraise zgtsAppraise = new Appraise() { Agree = 1 };
            Appraise swdnrAppraise = new Appraise() { Agree = 1 };
            Appraise GoodCommentAppraise = new Appraise() { Agree = 1 };
            Appraise NiceCommentAppraise = new Appraise() { Agree = 1 };
            Appraise BadCommentAppraise = new Appraise() { DisAgree = 1 };

            Keyword lishi = new Keyword() { Name = "历史" };
            Keyword wenxuezuoping = new Keyword() { Name = "文学作品" };
            Keyword Csharp = new Keyword() { Name = "C#" };
            Keyword daoNet = new Keyword() { Name = ".NET" };
            zbl.Appraise = zblAppraise;
            zgts.Appraise = zgtsAppraise;
            swdnr.Appraise = swdnrAppraise;
            GoodComment.Appraise = GoodCommentAppraise;
            NiceComment.Appraise = NiceCommentAppraise;
            BadComment.Appraise = BadCommentAppraise;

            zbl.comments = new List<Comment>();
            zbl.comments.Add(GoodComment);
            zbl.comments.Add(NiceComment);
            zbl.comments.Add(BadComment);
            zgts.comments = new List<Comment>();
            zgts.comments.Add(GoodComment);
            zgts.comments.Add(NiceComment);
            zgts.comments.Add(BadComment);
            swdnr.comments = new List<Comment>();
            swdnr.comments.Add(GoodComment);
            swdnr.comments.Add(NiceComment);
            swdnr.comments.Add(BadComment);

            GoodComment.Articles = new List<Article>();
            GoodComment.Articles.Add(zbl);
            GoodComment.Articles.Add(zgts);
            GoodComment.Articles.Add(swdnr);

            NiceComment.Articles = new List<Article>();
            NiceComment.Articles.Add(zbl);
            NiceComment.Articles.Add(zgts);
            NiceComment.Articles.Add(swdnr);

            BadComment.Articles = new List<Article>();
            BadComment.Articles.Add(zbl);
            BadComment.Articles.Add(zgts);
            BadComment.Articles.Add(swdnr);

            zbl.KeyWords = new List<Keyword>();
            zbl.KeyWords.Add(lishi);
            zbl.KeyWords.Add(wenxuezuoping);

            zgts.KeyWords = new List<Keyword>();
            zgts.KeyWords.Add(lishi);
            zgts.KeyWords.Add(wenxuezuoping);

            swdnr.KeyWords = new List<Keyword>();
            swdnr.KeyWords.Add(lishi);
            swdnr.KeyWords.Add(wenxuezuoping);

            CSharpTeacher.KeyWords = new List<Keyword>();
            CSharpTeacher.KeyWords.Add(Csharp);
            DaoNetTeacher.KeyWords = new List<Keyword>();
            DaoNetTeacher.KeyWords.Add(daoNet);

            Csharp.articles = new List<Article>();
            Csharp.articles.Add(CSharpTeacher);
            daoNet.articles = new List<Article>();
            daoNet.articles.Add(DaoNetTeacher);
            lishi.articles = new List<Article>();
            lishi.articles.Add(zbl);
            lishi.articles.Add(zgts);
            lishi.articles.Add(swdnr);


            wenxuezuoping.articles = new List<Article>();
            wenxuezuoping.articles.Add(zbl);
            wenxuezuoping.articles.Add(zgts);
            wenxuezuoping.articles.Add(swdnr);
            zbl.Author = fg;
            zgts.Author = fg;
            swdnr.Author = xiaoyu;
            CSharpTeacher.Author = fg;
            DaoNetTeacher.Author = xiaoyu;


            var excellent = from a in articles
                            where a.Author.Name == "飞哥"
                            select a;
            foreach (var item in excellent)
            {
                Console.WriteLine(item.Title);
            }

            var FishTimeQuery = from a in articles
                                where a.Author.Name == "小鱼" && a.PublishTime > new DateTime(2019, 4, 21)
                                select a;
            foreach (var item in FishTimeQuery)
            {
                Console.WriteLine(item.Title);
            }

            var OrderByReleaseTime = from a in articles
                                     orderby a.PublishTime ascending
                                     select a;
            foreach (var item in OrderByReleaseTime)
            {
                Console.WriteLine(item.Title);
            }

            var DescendingOrderOfReleaseRime = from a in articles
                                               orderby a.PublishTime descending
                                               select a;
            foreach (var item in DescendingOrderOfReleaseRime)
            {
                Console.WriteLine(item.Title);
            }
            ///统计每个用户各发布了多少篇文章
            ///
            var UserPosted = from a in articles
                             group a by a.Author.Name;

            foreach (var item in UserPosted)
            {
                Console.WriteLine($"{item.Key}发布了{item.Count()}篇文章");
            }
            ///找出包含关键字“C#”或“.NET”的文章
            ///

            var KeyWordsArticles = from a in articles
                                   where a.KeyWords.Contains(Csharp) || a.KeyWords.Contains(daoNet)
                                   select a;
            foreach (var item in KeyWordsArticles)
            {
                Console.WriteLine(item.Title);
            }
            ///找出评论数量最多的文章
            var TheMostComments = from a in articles
                                  orderby a.comments?.Count descending
                                  //where a.comments?.Count > 0
                                  select a;

            Console.WriteLine(TheMostComments.FirstOrDefault().Title);

            ///找出每个作者评论数最多的文章
            ///
            var TheMostCommentsOfAurther = from a in articles
                                           orderby a.comments?.Count descending
                                           group a by a.Author.Name
                                           into an
                                           select new
                                           {
                                               Author = an.Key,
                                               Articles = an.FirstOrDefault().Title

                                           };
            foreach (var item in TheMostCommentsOfAurther)
            {
                Console.WriteLine($"{item.Author}:{item.Articles}");
            }



        }
    }
}
