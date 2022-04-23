using System;
using System.Collections.Generic;

namespace ListTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> score = new List<int> {90,110,100 };
            score[1] = 120;
            score.Add(12);
            score.Add(100);
            score.BinarySearch(100);
            score.Insert(0,70);
            //score.AddRange();
            score.Remove(100);
            //score.RemoveAll();
            score.RemoveAt(1);
            score.Contains(120);
            Console.WriteLine(score.IndexOf(120));
            Console.WriteLine(score.LastIndexOf(100));
            Console.WriteLine(score[2]);
            score.Clear();
            Console.WriteLine(score.Count);
            //Console.WriteLine("Hello World!");
        }
    }
}
