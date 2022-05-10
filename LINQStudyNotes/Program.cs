using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQStudyNotes
{
    //class ShortStudentInfo
    //{
    //    public string Name { get; set; }
    //    public double Score { get; set; }


    //}
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public class Teacher : Person
    {
        public IList<Major> Majors { get; set; }

    }
    public class Student : Person
    {

        public Teacher Teacher { get; set; }
        public double Score { get; set; }
        public IList<Major> Majors { get; set; }
        //public static  void Prompt<T>(T a,T b) where T:IComparable
        //{
        //    if (a.CompareTo(b)>0)
        //    {

        //    }



        //}
        public static void Prompt<T>(T a, T b, IMyCompare<T> compare)
        {
            if (compare.Conpare(a, b))
            {

            }



        }
    }

    public interface IMyCompare<T>
    {


        bool Conpare(T a, T b);

    }

    public class Major
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public double Difficulty { get; set; }
        public string TeacherName { get; set; }
    }
    //public static class Test1
    //{

    //   public static void ScoreAdd(this Major major, int a, int b)
    //    {

    //        Console.WriteLine($"{a}+{b} = {a + b}");

    //        //Console.WriteLine("aaa");

    //    }


    //}

    class Program
    {

        static void Main(string[] args)
        {
            //1.方便动态查询2.方便获取及时数据
            Major m1 = new Major();
            // m1.ScoreAdd(91,87);   

            Teacher fg = new Teacher { Age = 19, Id = 1, Name = "大飞哥" };
            Teacher fish = new Teacher { Age = 23, Id = 2, Name = "小鱼" };

            Teacher dfg = new Teacher { Name = "大飞哥", Age = 39 };
            IEnumerable<Teacher> teachers = new List<Teacher> { fg, fish, dfg };

            Major csharp = new Major { Name = "C#", /*Teacher = fg,*/ Age = 19, TeacherName = "大飞哥" };
            Major SQL = new Major { Name = "SQL", /*Teacher = fg,*/ Age = 19, TeacherName = "大飞哥" };
            Major Javascript = new Major { Name = "Javascript", Age = 39/*, Teacher = fg*/, TeacherName = "大飞哥" };
            Major UI = new Major { Name = "UI", Age = 23, TeacherName = "小鱼" };
            IEnumerable<Major> majors = new List<Major> { csharp, SQL, Javascript, UI };

            IList<Student> students = new List<Student>
            {

                new Student{Score =98,Name="屿",Majors = new List<Major>{csharp,SQL } },
                new Student{Score =86,Name="行人",Majors = new List<Major>{Javascript,csharp,SQL } },
                new Student{Score =78,Name="王平",Majors = new List<Major>{csharp } },
                new Student{Score =89,Name="王枫",Majors = new List<Major>{Javascript,csharp,SQL,UI } },
                new Student{Score =98,Name="蒋宜蒙",Majors = new List<Major>{Javascript,csharp } }

            };
            Student frist = students.FirstOrDefault();
            Console.WriteLine(frist.Name);
            Student single = students.Where(s => s.Score > 100).SingleOrDefault();
            Console.WriteLine(single.Name);
            //Console.WriteLine(frist == single);

            //var result = majors.Join
            //    (
            //    teachers,
            //    m => new { tname = m.TeacherName, m.Age },
            //    t => new { tname = t.Name, t.Age },
            //    (m, t) => new
            //    {
            //        tname = t.Name,
            //        mName = m.Name

            //    }
            //    );

            //所有学生的老师
            //var result = students.SelectMany
            //    (
            //    s => s.Majors,
            //    (s, m) => new
            //    {
            //        s,
            //        m.TeacherName,
            //        TeacherAge = m.Age,
            //        m.Name
            //    }
            //    );
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.s.Name}的{item.Name}的老师是{item.TeacherName},老师年龄是({item.TeacherAge})");
            //}



            //var Snames = students.Select(s => s.Name);

            //var Result = majors.GroupBy(m => new { m.TeacherName, m.Age });

            //var stat = Result.Select(r => new
            //{
            //    r.Key.TeacherName,
            //    r.Key.Age,
            //    Count = r.Count()
            //});
            //foreach (var item in stat)
            //{
            //    Console.WriteLine($"{item.TeacherName}{item.Age}岁，带了{item.Count}学生");
            //}
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Key.TeacherName}{item.Key.Age}岁，带了{item.Count()}学生");
            //}

            // IList<IGrouping<Teacher, Student>> lstStudents = Result.ToList();
            //var Result = students.OrderBy(s => s.Score)/*.Reverse()*/;//性能消耗

            //var result = from s in students
            //             where s.Score > 60
            //             select s;

            ////var result = students.Where(s => s.Score > 60);
            ////var result = students.Where(s => s.Score > 60);
            //if (true)
            //{
            //    result = result.Where(r => r.Name.StartsWith("王"));
            //}
            //students.Add
            //    (
            //    new Student
            //    {
            //        Score = 90,
            //        Name = "王尼玛",
            //        Majors = new List<Major>
            //        {
            //            Javascript,
            //            csharp,
            //            SQL,
            //            UI
            //        }
            //    }
            //    );

            //if (true)
            //{
            //    result = result.Where(r => r.Majors.Count() > 3);
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name}:{item.Score}:{item.Majors.Count()}");
            //}
            //IList<Student> listStudents = result.ToList();


            //if (true)//根据用户查找
            //{
            //    //王
            //    result = from r in listStudents/*.ToList()*///直接进行查询
            //             where r.Name.StartsWith("王")
            //             select r;

            //}
            //students.Add
            //    (

            //    new Student { Score = 90, Name = "王尼玛", Majors = new List<Major> { Javascript, csharp, SQL, UI } }

            //    );



            //if (true)
            //{
            //    result = from r in result
            //             where r.Majors.Count() > 3
            //             select r;
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name}:{item.Score}:{item.Majors.Count()}");
            //}
            //var result = from s in students
            //                 // let ms = s.Majors
            //                 //from m in ms
            //                 //select new { sname = s.Name, mname = m.Name };
            //             where s.Name == "小鱼"
            //             select s;

            /*result.Single()*/
            ;//如果result只有一个结果，

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.sname + ":" + item.mname);
            //}
            //var ms = from t in teachers
            //         join m in majors
            //         on t.Id equals m.Age into mt
            //         from result in mt.DefaultIfEmpty()
            //         select new
            //         {

            //             teacher = t.Name,
            //             major = result?.Name ?? "没有课程"

            //         };

            //foreach (var item in ms)
            //{
            //    Console.WriteLine($"{ item.teacher}:{item.major}");
            //}







            //var result = from m in majors
            //             from t in teachers
            //                 //join t in teachers
            //                 //on m.TeacherId equals t.Id
            //                 //where t.Name == "小鱼"
            //             select new
            //             {

            //                 t.Id,
            //                 TeacherName = t.Name,
            //                 MajorName = m.Name


            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Id}--{item.TeacherName}--{item.MajorName}");
            //}





            //IEnumerable<IGrouping<Teacher, Major>> result =
            //    from s in majors/*students*/
            //        // where s.Majors.Contains(Javascript)
            //        //where s.Majors.Count() >= 2
            //        // where s.Name.StartsWith("王") && s.Score > 80
            //        //orderby s.Score ascending
            //        //orderby s.Score descending
            //    group s by s.Teacher;
            //var stat = from m in majors
            //           group m by m.Teacher into/*命名*/ gm
            //           select new /*KeyValuePair<Teacher, int>*//*(gm.Key, gm.Count());*/
            //           {
            //               gm.Key,
            //               Count = gm.Count()


            //           };
            // var lstStat = stat.ToList();
            //var dicStat = stat.ToDictionary(s => s.Key.Name, s => s.Count);
            //foreach (var item in dicStat)
            //{
            //    // Console.WriteLine($"{item.Values}:{item.Count()}");
            //    Console.WriteLine($"{item.Key}:{item.Value}");

            //}
            //select s;
            //foreach (IGrouping<Teacher, Major> item in result)
            //{


            //    Console.WriteLine(item.Key.Name);//老师名字
            //    foreach (var mojer in item)
            //    {
            //        Console.WriteLine(mojer.Name);
            //    }

            //    Console.WriteLine(item.Count());
            //    Console.WriteLine(item.Sum(m => m.Difficulty));
            //    Console.WriteLine(item.Average(m => m.Difficulty));
            //    Console.WriteLine(item.Max(m => m.Difficulty));
            //    Console.WriteLine(item.Min(m => m.Difficulty));
            //    //Console.WriteLine(item.Sum(m => { return m.Difficulty; }));
            //    // Console.WriteLine($"{item.Name}:{item.Score}");
            //}
            //IEnumerable<Student> students = new List<Student>
            //{

            //  new Student { Age = 18 },
            //  new Student { Age = 19 },
            //  new Student{Age = 16 },
            //  new Student{Age = 26 }


            //};

            //var excellent = from s in students
            //                where s.Score > 90
            //                select s;

            //var teanager = from s in students
            //               where s.Age < 18
            //               select s;
            //foreach (var item in teanager)
            //{
            //    Console.WriteLine(item.Age);
            //}

        }
        static IEnumerable<T> filterByAge<T>(IEnumerable<T> students,
            Func<T, bool> predicate)
        {
            IList<T> result = new List<T>();
            foreach (var item in students)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }

            }


            return result;

        }
        static IEnumerable<T> DelfilterByAge<T>(IEnumerable<T> students,
            Func<T, bool> predicate)
        {
            //IList<T> result = new List<T>();
            foreach (var item in students)
            {
                if (predicate(item))
                {
                    //result.Add(item);
                    yield return item;

                }

            }


            //return result;

        }





    }
}
