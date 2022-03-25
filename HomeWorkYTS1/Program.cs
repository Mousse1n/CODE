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
            
            Random rand = new Random();//调用随机数
            double radius = rand.Next(10);//固定随机数范围
            //int radius = 9;
            WriteLine(AlertArea(radius));//调用方法传数据计算面积
            WriteLine(AlertGirth(radius));//调用方法传数据计算周长
            ReadLine();//控制台不消失

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
