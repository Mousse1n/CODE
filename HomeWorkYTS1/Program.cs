using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
namespace HomeWorkYTS1
{
    class Program
    {

        static void Main(string[] args)
        {

            //Random rand = new Random();//调用随机数
            //double radius = rand.Next(10);//固定随机数范围
            ////int radius = 9;
            //WriteLine(AlertArea(radius));//调用方法传数据计算面积
            //WriteLine(AlertGirth(radius));//调用方法传数据计算周长
            //ReadLine();//控制台不消失

            //double i = 23 * 12 + 7 * 12 - 8;
            //double j = i / 6;
            //string show = j.ToString("0.00");
            //WriteLine(show);

            //int i = 15;
            //Console.WriteLine(i++);
            //i -= 5;
            //Console.WriteLine(i);
            //Console.WriteLine(i >= 10);

            //Console.WriteLine("i值的最终结果为：" + i);

            //int j = 20;
            //Console.WriteLine($"{i}+{j}={i + j}");
            //ReadLine();
            //string[,,] yst = new string[2, 2, 2];
            //string[] axb = new string[2];
            //axb[0] = "sb";
            //axb[1] = "aa";
            //string[,] xuexi = new string[2, 2];
            //xuexi[0, 0] = "杨童舒";
            //xuexi[1, 0] = "葛志超";
            //xuexi[1, 1] = "范瑞吉";
            //xuexi[0, 1] = "张三";
            //for (int i = 0; i < xuexi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < xuexi.GetLength(1); j++)
            //    {
            //        Console.WriteLine("arr[" + i + "," + j + "] = " + xuexi[i, j]);
            //    }
            //}
            //double[] Exam = new double[4];
            //Exam[0] = 99;
            //Exam[1] = 100;
            //Exam[2] = 101;
            //Exam[3] = 80;
            //Console.WriteLine(FindMax(Exam));
            //Console.WriteLine(FindMin(Exam));
            // double ShowMax = FindMax(Exam);
            // double ShowMin = FindMin(Exam);
            //Console.WriteLine(ShowMax);
            //Console.WriteLine(ShowMin);
            int[] nums = new int[10];

            Random random = new Random();

            //随机数值

            for (int i = 0; i < 10; i++)

            {

                nums[i] = random.Next(0, 100);

            }

            //冒泡排序 从小到大

            for (int i = 0; i < 9; i++)

            {

                for (int j = i + 1; j < 10; j++)

                {

                    if (nums[j] < nums[i])

                    {

                        int temp = nums[i];

                        nums[i] = nums[j];

                        nums[j] = temp;

                    }

                }

            }

            //打印到屏幕

            foreach (int num in nums)

            {

                Console.Write($"{num},");

            }
            ReadLine();


        }
        public static double FindMax(double[] Exam)
        {
            double ExamMax = Exam[0];
            for (int i = 0; i < Exam.Length; i++)
            {
                if (ExamMax < Exam[i])
                {
                    ExamMax = Exam[i];
                }
            }
            return ExamMax;

        }
        public static double FindMin(double[] Exam) 
        {
            double ExamMin = Exam[0];
            for (int i = 0; i < Exam.Length; i++)
            {
                if (ExamMin > Exam[i])
                {
                    ExamMin = Exam[i];
                }
            }

            //for (int i = 0; i < Exam.Length; i++)
            //{

            //    //Console.WriteLine(Exam[i]);
            //    Exam[i];
                
            //}
            //for (int j = 1; j < Exam.Length; j++)
            //{
            //    Exam[j];
            //}
            
            
            return ExamMin;
        
        }
        public static double AlertArea(double radius)
        {
            double area = radius * radius * 3.14;//面积计算逻辑
            return area;

        }
        public static double AlertGirth(double radius)
        {
            double girth = 2 * 3.14 * radius;//周长计算逻辑
            return girth;
        }
    }
}
