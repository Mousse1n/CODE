using System;

namespace DelegateNoteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            static void AICaculate(int a, int b)
            {

                Console.WriteLine("I am caculator,let me try:");
                Add(a,b);
                Multpiple(a,b);
            }

            static void Add(int a,int b)
            {
                Console.WriteLine($"it is so easy,{a}+{b}={a+b}");

            

            }
            static void Multpiple(int a,int b) 
            {

                Console.WriteLine($"I can ,{a}*{b} = {a*b}");
            
            }

        }
    }
}
