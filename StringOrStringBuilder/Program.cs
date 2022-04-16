using System;
using System.Text;

namespace StringOrStringBuilder
{

    class Student{}
    class Teacher { }
    
    class Program
    {

        static void say(ref string words)
        {

            words = words + "oh,yeah!";


        }
        static void addAge(ref int age)
        {

            age = age + 1;

        }
        /// <summary>
        /// 实现GetCount(string container, string target)方法，可以统计出container中有多少个target
        /// </summary>
        /// <param name="container">用户输入字符串</param>
        /// <param name="target">寻找目标字符串</param>
        /// <returns>查找到的个数</returns>
        public static  int getCount(string container, string target)
        {
            int number = 0;
            string[] Change = container.Split(" ");
            for (int i = 0; i < Change.Length; i++)
            {
                if (Change[i].Contains(target))
                {
                    number++;
                }
                else
                {
                     Console.WriteLine($"第{i}位没有{target}");
                }
            }

            return number;
        }


        public static string mimicJoin(string Joinsign,string stringone,string stringtwo,string stringthree) 
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(stringone).Append(Joinsign).Append(stringtwo).Append(Joinsign).Append(stringthree);
            string slagon = sb.ToString();
            return slagon;
        
        }
        
        static void Main(string[] args)
        {
            //string slagon = "@大神小班，拎包入住@";
            ////删除
            //Console.WriteLine(slagon.Remove(1));//@
            //Console.WriteLine(slagon.Remove(1, 1));//@aa@
            //string slagon1 = slagon.Remove(1, 1);//操作后的字符串需要新对象接收
            ////插入
            //Console.WriteLine(slagon.Insert(2, "@"));//@a@aa@
            ////替换
            //Console.WriteLine(slagon.Replace('大', '小'));//@aaa@
            ////截取
            //Console.WriteLine(slagon.Substring(1, 3));//aaa
            ////字符串本身不会改变，但是slagon里字符串没有改变，因为字符互传改变是已经输出了
            //Console.WriteLine(slagon); //@aaa@
            //string fg = " 大 飞 哥 ";
            //Console.WriteLine("@" + fg.Trim() + "@");
            //Console.WriteLine("@" + fg.TrimStart() + "@");
            //Console.WriteLine("@" + fg.TrimEnd() + "@");
            //Console.WriteLine("@" + fg + "@");
            //int age = 20;
            //addAge(ref age);
            //Console.WriteLine(age);
            //string yezi = "yefei";
            //say(ref yezi);
            //Console.WriteLine(yezi);
              
            Console.WriteLine(mimicJoin("+", "1", "2", "3"));
            string a = "源栈";
            string b = "源栈";
            Console.WriteLine(a == b);//是因为有个字符串池技术，先去看字符串池中有没有这个字符串，有就直接将地址给变量，如果没有就新建对象给到字符串池中
            string a1 = null;
            string b1 = "";
            string c = "           ";
            Console.WriteLine(string.IsNullOrEmpty(a1));
            Console.WriteLine(string.IsNullOrWhiteSpace(a1));
            Console.WriteLine(string.IsNullOrEmpty(b1));
            Console.WriteLine(string.IsNullOrWhiteSpace(b1));
            Console.WriteLine(string.IsNullOrEmpty(c));
            Console.WriteLine(string.IsNullOrWhiteSpace(c));
            string aa = "元栈欢迎你！";
            Console.WriteLine(aa.IndexOf("!"));
            Console.WriteLine(aa.LastIndexOf("!"));
            string e = "原栈";
            string d = "欢迎";
            string f = "您";
            //链接起来
            Console.WriteLine(string.Concat(e,d,f));
            //用“ ”链接起来
            Console.WriteLine(string.Join(" ",e,d,f));
            Console.WriteLine(
                string
                .Join("*", new Teacher(), new Student(), 32, true)
                .Split("*", StringSplitOptions.RemoveEmptyEntries)
                
                );
            Console.WriteLine(32);
            StringBuilder sb = new StringBuilder();
            sb.Append("源栈");
            sb.Append(",");
            sb.Append("欢迎您!");
            string slin = sb.ToString();//释放多余内存空间 


        }
    }
}
