using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
   public static class HomeworkTest
    {
        /// <summary>
        /// 返回元素中所有元素的最大值
        /// </summary>
        /// <param name="ArraySum">数组</param>
        /// <returns>最大值</returns>
        public static int getMax(int[] ArraySum)
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


    }
}
