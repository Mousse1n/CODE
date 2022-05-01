using System;

namespace DelegateNoteBook
{
    /// <summary>
    /// 定义返回值void，参数两个，int，string
    /// </summary>
    /// <returns></returns>
    public delegate void Opt(int a, int name);
    public delegate void OptString(string a, string b);
    public delegate void Opt<T1, T2>(T1 a, T2 b);
    public delegate Action<int, int> Opt2<T1, T2>(T1 a, T2 name);
    class Program
    {
        //enum Operator
        //{
        //    Add,
        //    multpiple

        //}
        static Func<int> caculate()
        {
            int a = 100, b = 50;
            Console.WriteLine("this is a test");
            return () => a + b;


        }
        static void Opt(int x, int y)
        {
            int result = x % y /*+ sum*/;
            Console.WriteLine(result);
        }
        static void Closure(int a, int b, Action<int, int> opt)
        {
            Console.WriteLine("I'm AI caculator,let me try:");
            opt(a, b);
        }
        static void AICaculate(int a, int b, Action<int, int> opt)
        {

            Console.WriteLine("I am caculator,let me try:");

            opt(a, b);

            //switch (opt)
            //{
            //    case Operator.Add:
            //        Add(a, b);
            //        break;
            //    case Operator.multpiple:
            //        Multple(a, b);
            //        break;
            //    default:
            //        break;
            //}



            //Multple(a,b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"it is so easy,{a}+{b}={a + b}");



        }
        static Action<int, int> Multple(int a, int b)
        {

            Console.WriteLine($"I can ,{a}*{b} = {a * b}");
            return Add;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Opt opt = Add;
            //opt(75, 63);
            //Action<int, int> opt = Add;
            //Action<int, int> mulitple = opt;
            //Action<int, int> action = Multple(23,32);
            //action(12,21);
            //Func<int, int,Action<int,int>> action1 = Multple;
            //Opt2<int, int> opt2 = Multple;
            //AICaculate(8, 3, delegate (int a, int b)
            // {

            //     Console.WriteLine($"{a}%{b} ={a % b}");

            // });

            //Action<int, int> opt = Add;
            //Action<int, int> opt = delegate (int a, int b)
            //{

            //    Console.WriteLine($"it is so easy,{a}+{b}={a + b}");

            //};
            //Action<int, int> opt = (a, b) =>
            //{

            //    Console.WriteLine($"it is so easy,{a}+{b}={a + b}");


            //};

            //int sum = 100;
            //Closure(18, 5, (x, y) =>
            // {

            //     int result = x % y + sum;
            //     Console.WriteLine(result);



            // });

            //Closure(18, 5, (x, y) =>
            //{
            //    int result = x % y + sum;
            //    Console.WriteLine(result);
            //});

            //result++


            //Action<int> square = (a) =>
            //{

            //    Console.WriteLine($"{a}*{a} ={a * a}");

            //};
            //Func<int, int> square1 = (a) =>
            //    {
            //        return a * a;
            //        //Console.WriteLine($"{a}*{a} ={a * a}");

            //    };

            //Action<int> square = (a) => Console.WriteLine($"{a}*{a} ={a * a}");

            //Func<int, int> square1 = (a) => a * a;

            //Action greet = () => Console.WriteLine("hello");
            //Func<int, int> square1 = a => a * a;
           Func<int> func =  caculate();
            func();
        }
    }
}
