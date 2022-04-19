using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStatic
{
//   自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
//出栈Pop()，弹出栈顶数据
//入栈Push()，可以一次性压入多个数据
//出/入栈检查，
//如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
//如果已弹出所有数据，提示“栈已空”

  public  class MimicStack
    {
        private int top = -1;//指向顶点元素
        private int maxSize;//数组最大存储空间
        private int[] datas;//存储数据数组
        private bool IsFull { get => top - 1 == maxSize - 1; }//是否装满
        public bool IsEmpty { get => top == maxSize - 1; }//是否为空
        /// <summary>
        /// 构造器
        /// </summary>
        /// <param name="maxSize">最大尺寸</param>
        public MimicStack(int maxSize) 
        {
            this.maxSize = maxSize;
            datas = new int[this.maxSize];
        }
        /// <summary>
        /// 判断是否满，并入栈；
        /// </summary>
        /// <param name="value">入栈元素</param>
        public void Push(int value) 
        {
           
            if (IsFull)
            {
                Console.WriteLine("栈已满");
                return;
                 
            }
            datas[++top] = value;
        }
        /// <summary>
        /// 弹出栈顶数据
        /// </summary>
        /// <returns></returns>
        public  int Pop() 
        {
            if (IsEmpty)
            {
                throw new Exception("栈空");
            }
            return datas[top--];
        }
       /// <summary>
       /// 查看但是不弹出
       /// </summary>
       /// <returns></returns>
        public int peek() 
        {
            if (IsEmpty)
            {
                throw new Exception("栈空");
            }
            
            return datas[top]; 
        
        }
        /// <summary>
        /// 打印
        /// </summary>
        public void Traverse()
        {
            if (IsEmpty)
            {
                Console.WriteLine("栈空");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine($"stack[{i}] = {datas[i]}");
            }
        }

    }
}
