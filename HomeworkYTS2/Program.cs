using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HomeworkYTS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Number = new int[3,4];
            WriteLine("一个二维数组，元素值等于下标之和");
            for (int i = 0; i < 3; i++)
            {
                WriteLine("\n");
                
                for (int j = 0; j < 4; j++)
                {
                     
                    Number[i, j] = i+j;   
                    Write(Number[i,j]+"  ");
                }
            }
            //int number = 100;
            //number > 0;
            //100 > number > 0;
            //1000 > number > 100;
            //10000 > number && number % 3 == 0;
            //string sname = "shabi";
            //Console.WriteLine($"{sname},学业不成，誓不出栈！");
            ReadLine();
        }
    }
}
