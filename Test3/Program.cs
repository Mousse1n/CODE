using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test3
{
    class Program
    {
        static int pass(ref int PassNum,ref int PassNum2)
        {
            int MaxNumber = PassNum + PassNum2;
            return MaxNumber;
        }
        static void Main(string[] args)
        {
            int Maxnumber1 = 6;
            int Maxnumber2 = 7;
            int ShowMax = pass(ref Maxnumber1, ref Maxnumber2);
            WriteLine(ShowMax);
            ReadLine();
        }
    }
}
