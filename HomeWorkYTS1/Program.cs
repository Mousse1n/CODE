using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
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

            //double i = 23*12+7*12-8;
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

            string[,] xuexi = new string[2, 2];
            xuexi[0, 0] = "杨童舒";
            xuexi[1, 0] = "葛志超";
            xuexi[1, 1] = "范瑞吉";
            xuexi[0, 1] = "张三";
            WriteLine(xuexi.Length);
            ReadLine();


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
