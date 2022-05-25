using System;
using System.Threading;

namespace Multithreading
{

    public class Person
    {

        public int Age { get; set; }
        private string _name;


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = Thread.CurrentThread;

            //Console.WriteLine(Thread.GetDomain().FriendlyName);

            //Console.WriteLine(thread.ManagedThreadId);//托管线程ID
            //Console.WriteLine(thread.Priority);//优先级
            //Console.WriteLine(thread.ThreadState);//线程状态
            //Console.WriteLine(thread.IsThreadPoolThread);//是否线程池线程
            ///*Thread.Sleep(2000);*/                                             //thread.Abort();
            //Thread thread1 = new Thread(Process);
            ////thread.Suspend();
            //Console.WriteLine(thread1.ManagedThreadId);//托管线程ID
            //Console.WriteLine(thread1.Priority);//优先级
            //Console.WriteLine(thread1.ThreadState);//线程状态
            //Console.WriteLine(thread1.IsThreadPoolThread);//是否线程池线程
            //Thread.Sleep(2000);\
            for (int i = 0; i < 20; i++)
            {
                //Console.WriteLine($"{i}:threadId-{Thread.CurrentThread.ManagedThreadId}");
                new Thread(() => { Console.WriteLine($"{i}:threadId-{Thread.CurrentThread.ManagedThreadId}"); }).Start();
            }
        }
        public static void Process()
        {

            Console.WriteLine($".........");

        }
    }
}
