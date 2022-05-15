using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class Problem : Content
    {
        private string[] _ProblemKeyWords = { "代码", "学习", "注册问题" };
        public string Title;
        public string Body;
        public int Reward;
        public User Author { get; set; }
        /// <summary>
        /// 构造函数获取值保证一定赋值
        /// </summary>
        /// <param name="problem">problem对象传值</param>
        public Problem(Problem problem)
        {
            if (problem.Reward < 0 || problem.Body == null)
            {
                Console.WriteLine("不能为负数");
                Console.WriteLine("Body不能为空");
            }
            else
            {
                Reward = problem.Reward;
                Body = problem.Body;
            }




        }
        public Problem() { }
        public string this[int index]
        {
            get { return _ProblemKeyWords[index]; }
            set { _ProblemKeyWords[index] = value; }
        }
        [HelpMoneyChanged(5)]
        public void publish()
        {


        }
        public void Load(int id)
        {
            Console.WriteLine($"根据{id}查出数据库");


        }
        public void Delete(int id)
        {

            Console.WriteLine($"根据{id}删除");
        }
        public static void repoistory()
        {



        }
        public override void Release()
        {
            Author.HelpMoney.HelpMoneyNumber = Author.HelpMoney.HelpMoneyNumber - Reward;
            Console.WriteLine("saved into db");
            Console.WriteLine("发布求助");
            //base.Release();
        }
        /// <summary>
        /// 点赞帮帮点增加
        /// </summary>
        /// <returns>成功返回true</returns>
        public override bool Agree()
        {
            Author.HelpPoint += 1;
            Appraiser.HelpPoint += 1;
            return true;
        }
        /// <summary>
        /// 点踩帮帮币减少
        /// </summary>
        /// <returns>true成功</returns>
        public override bool DisAgree()
        {
            return true;

        }
    }
}
