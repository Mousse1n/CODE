using System;
using System.Collections.Generic;
using System.Globalization;
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

            /// <summary>
            /// 函数GetDate()，能计算一个日期若干（日/周/月）后的日期
            /// </summary>
            /// <param name="DayHear">用户输入的string</param>
            /// <param name="UserNumber">用户给定的日子</param>
            /// <returns></returns>
            public string GetDate(string DayHear, int UserNumber)
            {
                string UserReadline = DayHear.Replace("年",".");

                string UserReadline2 = UserReadline.Replace("月", ".");
                string UserReadline3 = UserReadline2.Replace("日", ".");

                DateTime Dt = DateTime.Parse(UserReadline3);

                if (UserNumber < 7 && UserNumber > 0)
                {
                    DateTime OneWeakDateTime = Dt.AddDays(UserNumber);
                    return OneWeakDateTime.ToLongDateString();
                    //
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
            /// <summary>
            /// 获取一年中指定的一周的开始日期和结束日期。开始日期遵循ISO 8601即星期一。
            /// </summary>
            /// <param name="year">年（1到9999）</param>
            /// <param name="weeks">周(1到53)</param>
            /// <param name="weekrule">确定首周规则</param>
            /// <param name="first">当此方法返回时，则包含参数 year 和 weeks 指定的周的开始日期的 System.DateTime 值；如果失败，则为 System.DateTime.MinValue。如果参数 year 或 weeks 超出有效范围，则操作失败。该参数未经初始化即被传递。</param>
            /// <param name="Last">当此方法返回时，则包含参数 year 和 weeks 指定的周的结束日期的 System.DateTime 值；如果失败，则为 System.DateTime.MinValue。如果参数 year 或 weeks 超出有效范围，则操作失败。该参数未经初始化即被传递。</param>
            /// <returns>成功true，失败false</returns>
            public bool GetDaysOfWeeks(int year,int weeks, CalendarWeekRule weekrule, out DateTime first,out  DateTime Last)
            {
                //初始化out参数
                first = DateTime.MinValue;
                Last = DateTime.MinValue;
                //验证
                if (year<1||year>9999)
                {
                    Console.WriteLine("年份超限");
                    return false;
                }
                if (weeks<1||weeks>53)
                {
                    Console.WriteLine("周超限");
                    return false;
                }
                //当年首日为基准
                DateTime firstCurr = new DateTime(year,1,1);
                //下年首日用于计算
                DateTime firstNext = new DateTime(year+1,1,1);
                //将当年首日星期几转换为数字...星期日特别处理...ISO 8601 标准...
                int dayOfWeekFirst = (int)firstCurr.DayOfWeek;
                if (dayOfWeekFirst == 0)
                {
                    dayOfWeekFirst = 7;
                }
                //得到未经验证的周首日...
                first = firstCurr.AddDays((weeks-1)*7-dayOfWeekFirst+1);
                if (first.Year<year)
                {
                    switch (weekrule)
                    {
                        case CalendarWeekRule.FirstDay:
                            first = firstCurr;
                            break;
                        case CalendarWeekRule.FirstFullWeek:
                            first = first.AddDays(7);
                            break;
                        case CalendarWeekRule.FirstFourDayWeek:
                            if (firstCurr.Subtract(first).Days>3)
                            {
                                first = first.AddDays(7);
                            }
                            break;
                        default:
                            break;
                    }
                }
                Last = first.AddDays(7).AddSeconds(-1);
                if (Last.Year>year)
                {
                    switch (weekrule)
                    {
                        case CalendarWeekRule.FirstDay:
                            Last = firstNext.AddSeconds(-1);
                            break;
                        case CalendarWeekRule.FirstFullWeek:
                            break;
                        case CalendarWeekRule.FirstFourDayWeek:
                            if (firstNext.Subtract(first).Days < 4)
                            {
                                first = first.AddDays(-7);
                                Last = Last.AddDays(-7);
                            }
                            break;
                        default:
                            break;
                    }
                }
                return true;
            }
        }
       

        
        
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            DateTime time = new DateTime();
            DateTimeUser DU = new DateTimeUser();
            string Time = DU.GetDate("2022,11,12", 30);
            CalendarWeekRule wr = new CalendarWeekRule();
          bool IsTrue =  DU.GetDaysOfWeeks(2002,52,wr,out date,out time);
            Console.WriteLine(IsTrue);
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
