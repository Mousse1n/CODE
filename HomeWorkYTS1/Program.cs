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
        /// <summary>
        /// 利用ref调用Swap()方法交换两个同学的床位号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;


        }
        //public
        //protected
        //private 
        public static double GetAverage(double[] exam)
        {
            double max = 0;

            for (int i = 0; i < exam.Length; i++)
            {
                //max += exam[i];
                max = max + exam[i];
            }
            double AVG = max / exam.Length;

            return AVG;

        }

        public static bool Login(string username, string pwd)
        {
            string user = "yangtongshu";
            string pwder = "111111";
            if (username == user && pwd == pwder)
            {
                return true;
                WriteLine("登录成功");
            }
            else
            {
                return false;
                WriteLine("用户名密码错误");
            }

        }
       /// <summary>
       /// Gussme
       /// </summary>
        public static void GuessMe()
        {
            Random Guessnumber = new Random();
            int GUs = Guessnumber.Next(0, 1000);
            
            int GuessNumberturn = 1;//猜测次数
            bool i = true;
            while (i)
            {
                WriteLine("请输入不超过1000的自然数：");
                int numberUSer = int.Parse(ReadLine());
                if (GuessNumberturn == 10)
                {
                    WriteLine($"猜了{GuessNumberturn}次，机会用完啦！");
                    break;
                }else if (numberUSer < GUs)
                {
                    WriteLine("猜小啦");
                    GuessNumberturn++;
                    continue;
                }
                else if (numberUSer > GUs)
                {
                    WriteLine("猜大啦");

                    GuessNumberturn++;
                    continue;
                }
                
                else if(numberUSer == GUs)
                {
                    WriteLine("猜对啦");
                    break;
                }
            }
            
            if (GuessNumberturn <= 5)
            {
                WriteLine($"答对了你真牛逼，用了{GuessNumberturn}次");
            }
            else if (GuessNumberturn <= 8)
            {

                WriteLine($"答对了不错嘛，用了{GuessNumberturn}次");
            }
            else if (GuessNumberturn == 10)
            {
                WriteLine($"(～￣(OO)￣)ブ没猜出来啊，用了{GuessNumberturn}次");

            }

        }
        static void Main(string[] args)
        {
           
            //double[] Exam = { 99.00, 88.00, 77.00, 11.00, 100.00, 22.00 };
            //double Avg = Math.Round(GetAverage(Exam), 2);
            //Console.WriteLine(Avg);
           // GuessMe();
                

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
            //int[] nums = new int[10];

            //Random random = new Random();

            ////随机数值

            //for (int i = 0; i < 10; i++)

            //{

            //    nums[i] = random.Next(0, 100);

            //}

            ////冒泡排序 从小到大

            //for (int i = 0; i < 9; i++)

            //{

            //    for (int j = i + 1; j < 10; j++)

            //    {

            //        if (nums[j] < nums[i])

            //        {

            //            int temp = nums[i];

            //            nums[i] = nums[j];

            //            nums[j] = temp;

            //        }

            //    }

            //}

            ////打印到屏幕

            //foreach (int num in nums)

            //{

            //    Console.Write($"{num},");

            //}

            //GetArray();
            //Swap(1, 2);
            ReadLine();


        }
        public static int BinarySeek(int[] numbers, int tarrget, int low, int high)
        {


            int mid = (low + high) / 2;
            if (low > high)
                return -1;
            else
            {
                if (numbers[mid] == tarrget)
                    return mid;
                else if (numbers[mid] > tarrget)
                    return BinarySeek(numbers, tarrget, low, mid - 1);
                else
                    return BinarySeek(numbers, tarrget, mid + 1, high);
            }




        }
        public static int[] GetArray()
        {
            Random random = new Random();
            Random random1 = new Random();
            Random random2 = new Random();
            int min = /*random1.Next(1,100)*/1;
            int gap = 5;
            int length = /*random2.Next(10,1000)*/10;

            int[] ArrayNumber = new int[length];

            for (int j = 0; j < length; j++)
            {
                ArrayNumber[j] = random.Next(min, 100);
            }//生成最小值可控的随机数
             //ArrayNumber[]看生成的ArrayNumber是不是最大差值为5如果是，输出如果不是，继续生成。
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                for (int k = 0; k < ArrayNumber.Length - i - 1; k++)
                {
                    if (ArrayNumber[k] > ArrayNumber[k + 1])
                    {
                        int temp = ArrayNumber[k];
                        ArrayNumber[k] = ArrayNumber[k + 1];
                        ArrayNumber[k + 1] = temp;

                    }
                }
            }
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                Console.Write($"{ArrayNumber[i]} ,");
            }




            return ArrayNumber;

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
