using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Student
    {
        private double[] scores = new double[10];
        public double this[int index]
        {
            get { return scores[index - 1]; }
            set { scores[index - 1] = value; }
        }


    
    }
}
