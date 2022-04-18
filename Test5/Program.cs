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
        
        public static bool ChangeCreateTime( Content content,DateTime ChangeCreateTime) 
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
        public static bool ChangePublishTime(Content content,DateTime ChangePublishTime)
        {
            typeof(Content)
                .GetProperty(nameof(content._publishTime), BindingFlags.Instance | BindingFlags.Public)
                .SetValue(content, ChangePublishTime);
            return true;
        
        }


        
        
        
        static void Main(string[] args)
        {
            //用反射获取Publish()上的特性实例，输出其中包含的信息
            Attribute attribute = HelpMoneyChanged.GetCustomAttribute(
                typeof(Article)
                .GetMethod("publish"),
                typeof(HelpMoneyChanged)
                );
            Console.WriteLine(((HelpMoneyChanged)attribute)._amount);
           // Console.WriteLine(((HelpMoneyChanged)attribute).Message);
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
            //bool i = ChangeCreateTime(DateTime.Now);
            //Console.WriteLine(i);
            Console.ReadLine();

        }
    }
}
