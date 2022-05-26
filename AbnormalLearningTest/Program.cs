using System;

namespace AbnormalLearningTest
{
    class Student
    {
        public int age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("打开数据库");
            try
            {
                
                Console.WriteLine("执行操作。。。");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("关闭数据库");

            }



            //for (int i = 0; i < 5; i++)
            //{
            //    ScoreGrade? grade = null;
            //    try
            //    {
            //        int input = Convert.ToInt32(Console.ReadLine());
            //        grade = new Score(input).Transfer();

            //    }
            //    catch (ArgumentNullException)
            //    {
            //        Console.WriteLine("不在范围内");

            //    }

            //    catch (FormatException)
            //    {

            //        Console.WriteLine("输入的值无法转换成int类型");
            //    }
            //    catch (Exception e)
            //    {

            //        Console.WriteLine("发现一个错误：" + e.ToString());//日志log
            //        //不知道怎么处理抛出异常
            //        throw new Exception("输入的值无法装换成int类型", e);
            //    }
            //    finally
            //    {
            //        //清理工作

            //    }
            //    Console.WriteLine(grade);

            //}
        }


    }
}

