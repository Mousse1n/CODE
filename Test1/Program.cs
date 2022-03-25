using System.Collections.Generic;
using static System.Console;
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            setGrade(98);
            
            int[] arrayNew = { 1, 5, 76, 34, 25, 64, 69, 7 };
            int result = find(arrayNew, 7);
            WriteLine(result);
            greet();
            swap(arrayNew,1,5);
            WriteLine("Hello world");  
            ///<summary> 作业一
            ///作业一 分别用for循环和while循环直接输出：1,2,3,4,5 和 1,3,5,7,9
            ///</summary>
            int NaturalNumber, OddNumber;
            for (int i = 1; i < 6; i++)
            {
                Write(i);
            }//for循环输出12345；
            int j = 1;
            while (j <= 5)
            {
                Write(j);
                j++;
            }//while循环
            OddNumber = 0;
            NaturalNumber = 0;
            for (int i = 0; i < 5; i++)
            {
                OddNumber = 2 * NaturalNumber + 1;
                Write(OddNumber);
                NaturalNumber += 1;
            }//for循环
            int k = 0;
            while (k < 5)
            {
                OddNumber = 2 * NaturalNumber + 1;
                Write(OddNumber);
                NaturalNumber += 1;
                k++;
            }//while循环
            ///<summary>
            ///作业二 分别利用while和for循环，计算出1000+999+998+997+……+100的值
            /// </summary>
            int SumFor = 0;
            int SumWhile = 0;
            int sumMax = 100;
            for (int i = 100; i < 1001; i++)
            {
                SumFor += i;
                SumFor = SumFor + i;
            }
            WriteLine(SumFor);//for循环求和
            while (sumMax < 1001)
            {
                SumWhile += sumMax;
                sumMax++;
            }
            WriteLine(SumWhile);
            ///<summary>
            ///作业三
            ///让电脑计算并输出：99+97+95+93+...+1的值
            /// </summary>
            int Sumture = 0;
            int Sumfor = 0;
            for (int m = 0; m < 100; m++)
            {
                Sumture = 2 * m + 1;
                Sumfor += Sumture;
            }
            WriteLine(Sumfor);
            ///<summary>
            ///作业四
            /// 声明一个数组ids，存放若干整数，利用：while for循环（i--）
            ///输出每个元素的值
            /// </summary>
            int[] ids = new int[] { 1, 3, 5, 7, 9 };
            int kid = 4;
            while (kid >= 0)
            {
                WriteLine(ids[kid]);
                kid--;
            }//while
            for (int l = ids.Length - 1; l >= 0; l--)
            {
                WriteLine(ids[l]);
            }
            ///<summary>
            ///作业六
            ///声明一个数组odds，利用循环把100以内的不能被3整除的数按从小到大的顺序存入其中
            /// </summary>
            int[] odds;
            List<int> oddsList = new List<int>();
            //int m = 0;
            for (int x = 0; x < 100; x++)
            {
                if (x % 3 == 0)
                {
                    WriteLine(x);
                    oddsList.Add(x);
                }

            }
            odds = oddsList.ToArray();
            WriteLine("存储成功");
            ///<summary>
            ///作业七：计算出odds数组中所有元素的和
            /// </summary>
            int SumMaxOdds = 0;
            for (int y = 0; y < odds.Length; y++)
            {
                SumMaxOdds += odds[y];
            }
            WriteLine(SumMaxOdds);
            ///<summary>
            ///8.找到数组中的最小值
            /// </summary>
            int minNumber = odds[0];
            for (int z = 0; z < odds.Length; z++)
            {
                if (odds[z] < minNumber)
                {
                    minNumber = odds[z];
                }

            }
            WriteLine(minNumber);
            ///<summary>
            ///完成课堂中的等腰三角形输出；再利用循环，输出这么一个梯形：
            /// </summary>
            int ForNumber = 3;
            for (int u = 3; u >= 0; u--)
            {

                int ForLineNumber = 6;
                ForLineNumber -= u;
                for (int v = 6 - u; v < 6; v++)
                {
                    Write(" ");
                }

                for (; ForLineNumber > 0; ForLineNumber--)
                {
                    Write(ForNumber);

                }
                WriteLine("\n");
                ForNumber++;
            }
            ///<summary>
            ///输出10000以内的所有“素数/质数”（只能被自己和1整除的数）
            /// </summary>
            /// 
            bool flag;
            for (int o = 1; o < 10001; o++)
            {
                flag = true;
                for (int t = 2; t < o; t++)
                {
                    if (o % t == 0)
                    {
                        flag = false;
                    }

                }
                if (flag)
                {
                    WriteLine(o);
                }
            }
            ReadLine();
        }
        static int find(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        static void greet()
        {
            WriteLine("good moring");

        }
        /// <summary>
        /// 将百分制成绩换为等级
        /// </summary>
        /// <param name="score">分数</param>
        /// <returns>等级</returns>
        static string setGrade(double score)
        {
            if (score < 0 || score > 100)
            {

                return "无效成绩";
            }

            if (100 > score || score >= 80)
            {
                return "优秀";
            }
            else if (0 < score || score >= 60)
            {
                return "及格";
            }

            return "测试";


        }
        /// <summary>
        /// 计算第一个和第二个数的和
        /// </summary>
        /// <param name="fristNumber">第一个数</param>
        /// <param name="sceoundNumber">第二个数</param>
        /// <returns>计算结果</returns>
        static double add(double fristNumber, double sceoundNumber)
        {
            double SumNumber = fristNumber + sceoundNumber;
            return SumNumber;
        }
        /// <summary>
        /// 传入最大数找到最大数中的素数并找出最大的素数
        /// </summary>
        /// <param name="max">最大数值</param>
        /// <returns></returns>
        static int findMaxPrime(int max)
        {
            int[] Prime;
            List<int> PrimeList = new List<int>();
            bool flag;
            for (int o = 1; o < max; o++)
            {


                flag = true;
                for (int t = 2; t < o; t++)
                {
                    if (o % t == 0)
                    {
                        flag = false;
                    }

                }
                if (flag)
                {
                    WriteLine(o);
                    PrimeList.Add(o);
                    WriteLine("添加成功");
                }
            }
            Prime = PrimeList.ToArray();
            int forPrimeNumber = PrimeList[0];
            for (int i = 0; i < Prime.Length; i++)
            {
                if (forPrimeNumber < Prime[i])
                {
                    forPrimeNumber = Prime[i];
                }
            }
            return forPrimeNumber;
        }
        /// <summary>
        /// 返回所有元素的和
        /// </summary>
        /// <param name="ArraySum">数组</param>
        /// <returns>元素的和</returns>
        static int getSum(int[] ArraySum)
        {
            int NewNumber = 0;
            for (int i = 0; i < ArraySum.Length; i++)
            {
                NewNumber += ArraySum[0];
            }
            return NewNumber;
        }
        /// <summary>
        /// 返回元素中所有元素的平均值
        /// </summary>
        /// <param name="ArraySum">数组</param>
        /// <returns>所有元素的平均值</returns>
        static int getAverage(int[] ArraySum)
        {
            int ArrayAverages = getSum(ArraySum) / ArraySum.Length;
            return ArrayAverages;
        }
        /// <summary>
        /// 返回元素中所有元素的最大值
        /// </summary>
        /// <param name="ArraySum">数组</param>
        /// <returns>最大值</returns>
        static int getMax(int[] ArraySum)
        {
            int ForNumberMax = ArraySum[0];
            for (int i = 0; i < ArraySum.Length; i++)
            {
                if (ForNumberMax < ArraySum[i])
                {
                    ForNumberMax = ArraySum[i];
                }
            }
            return ForNumberMax;

        }
        /// <summary>
        /// 返回数组中的最小元素
        /// </summary>
        /// <param name="ArraySum">数组</param>
        /// <returns>最小元素</returns>
        static int getMin(int[] ArraySum)
        {
            int ForNumberMin = ArraySum[0];
            for (int i = 0; i < ArraySum.Length; i++)
            {
                if (ForNumberMin < ArraySum[i])
                {
                    ArraySum[i] = ForNumberMin;
                }
            }
            return ForNumberMin;
        }
        /// <summary>
        /// 数组中最大一个元素和最小元素的差
        /// </summary>
        /// <param name="ArraySum">数组</param>
        /// <returns>最大一个元素和最小元素的差</returns>
        static int getRange(int[] ArraySum)
        {
            int Range = getMax(ArraySum) - getMin(ArraySum);
            return Range;
        }
        /// <summary>
        /// 设计一个函数sum，能求出任意等差数列之和
        /// </summary>
        /// <param name="start"></param>
        /// <param name="step"></param>
        /// <param name="SumNumber"></param>
        /// <returns></returns>
        static int sum(int start,int step,int SumNumber) 
        {
            int[] SumArray;
            List<int> SumList = new List<int>();
            for (int i = 0; i < SumNumber; i++)
            {
                start += step;
                WriteLine(start);
                SumList.Add(start);

            }
            SumArray = SumList.ToArray();
            int ArrayAll=0;
            for (int j = 0; j < SumArray.Length; j++)
            {
                ArrayAll += SumArray[j];
            }
            return ArrayAll;
        }
        /// <summary>
        /// 设计一个函数swap，能够交换数组中的任意两个元素
        /// </summary>
        /// <param name="ChangeArray">传入的数组</param>
        /// <param name="sitFirst">第一个数</param>
        /// <param name="sitSecound">第二个数</param>
        /// <returns>改变的状态</returns>
        static string swap(int[] ChangeArray, int sitFirst, int sitSecound)
        {
            for (int i = 0; i < ChangeArray.Length; i++)
            {
                WriteLine(ChangeArray[i]);
            }
            int changeSitFirst = 0;
            int changeSitSecound = 0;
            changeSitFirst = ChangeArray[sitFirst-1];
            changeSitSecound = ChangeArray[sitSecound-1];
            ChangeArray[sitFirst-1] = changeSitSecound;
            ChangeArray[sitSecound-1] = changeSitFirst;
            for (int j = 0; j < ChangeArray.Length; j++)
            {
                WriteLine(ChangeArray[j]);
            }
            return "交换成功";
        }


    } 
}
