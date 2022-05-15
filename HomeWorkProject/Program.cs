using System;
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
            Article zbl = new Article() { Title = "资本论" };
            Article zgts = new Article() { Title = "中国通史" };
            Article swdnr = new Article() { Title = "上尉的女儿" };

            Comment GoodComment = new Comment() { Title = "GOOD" };
            Comment NiceComment = new Comment() { Title = "nice" };
            Comment BadComment = new Comment() { Title = "不好" };

            Appraise zblAppraise = new Appraise() { Agree = 1 };
            Appraise zgtsAppraise = new Appraise() { Agree = 1 };
            Appraise swdnrAppraise = new Appraise() { Agree = 1 };
            Appraise GoodCommentAppraise = new Appraise() { Agree = 1 };
            Appraise NiceCommentAppraise = new Appraise() { Agree = 1 };
            Appraise BadCommentAppraise = new Appraise() { DisAgree = 1 };
        }
    }
}
