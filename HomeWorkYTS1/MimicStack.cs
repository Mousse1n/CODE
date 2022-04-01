using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkYTS1
{
   public class MimicStack
    {
        private int top = -1;
        private int maxSize;
        private int[] datas;
        private bool IsFull { get => top - 1 == maxSize - 1; }
        private bool IsEmpty { get => top == maxSize - 1; }

        public MimicStack(int maxSize)
        {
            this.maxSize = maxSize;
            //datas = new int[9]
            datas = new int[this.maxSize];

        }

        public int Pop(int[] arr)
        {

            if (IsEmpty)
            {
                throw new Exception("栈空");

            }
            return datas[top--];
        }

        public void Push(int[] arr)
        {
            if (IsFull)
            {
                Console.WriteLine("栈满了");
                return;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    datas[++top] = arr[i];
                }
            }



        }

    }
}
