using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestHomework
{
   public static  class PrimeNumber
    {

        ///<summary>
        ///输出10000以内的所有“素数/质数”（只能被自己和1整除的数）
        /// </summary>
        /// 
        public static void FindPrimeNumber() 
        {
            
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

    }
        
    
    }

