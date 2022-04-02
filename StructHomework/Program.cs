using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructHomework
{
    class Program
    {
        public struct Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }
        public class DateTimeUser
        {

            public string GetDate(string DayHear, int UserNumber)
            {

                DateTime Dt = DateTime.Parse(DayHear);

                if (UserNumber < 7 && UserNumber > 0)
                {
                    DateTime OneWeakDateTime = Dt.AddDays(UserNumber);
                    return OneWeakDateTime.ToLongDateString();

                }
                if (30 > UserNumber && UserNumber > 7)
                {

                    DateTime OneWeakDateTime = Dt.AddDays(UserNumber);
                    return OneWeakDateTime.ToLongDateString();
                }
                if (UserNumber >= 30)
                {
                    DateTime OneWeakDate = Dt.AddMonths(UserNumber / 30);
                    return OneWeakDate.ToLongDateString();
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            DateTimeUser DU = new DateTimeUser();
            

            string Time = DU.GetDate(, 30);
            Console.WriteLine(Time);
            //Student student = new Student();
            //if (student is ValueType)
            //{
            //    Console.WriteLine("值类型");
            //}
            //else
            //{
            //    Console.WriteLine("引用类型");
            //}

            Console.ReadLine();
        }
    }
}
