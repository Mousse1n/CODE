using System;

namespace EventTest
{
    public class Button
    {
        public string Text { get; set; }
        public event EventHandler OnClick;//事件 封装了委托
        //public EventHandler OnClick { get; set; }
        public void Clicck()
        {
            //OnClick(this, null);
            //Console.WriteLine("aaa");
            //Action();
            //if (OnClick!=null)
            //{
            //    OnClick(this, null);
            //}
            
            OnClick?.Invoke/*调用*/(this, null);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Button btnSubmit = new Button();//工具自动生成



            //btnSubmit.OnClick = (sender, args) =>
            //{
            //    Console.WriteLine("aaa");
            //    Console.WriteLine("bbb");
            //};
            
            btnSubmit.OnClick += (sender, args) =>
            {
                Console.WriteLine("ccc");
                Console.WriteLine("ddd");

            };

            btnSubmit.OnClick += Test;
            btnSubmit.OnClick += ShowResult;//+= 订阅事件
            btnSubmit.OnClick -= Test;//退订
            btnSubmit.OnClick += BtnSubmit_OnClick;
            btnSubmit.Clicck();
            //};//有委托之前 数据 有了之后就可以传递行为
            // btnSubmit.Clicck();//用户做动作 操作系统调用

            //  Console.WriteLine("Hello World!");



            //new Button().Clicck(() =>
            //{
            //    Console.WriteLine("aaa");
            //    Console.WriteLine("bbb");

            //});//有委托之前 数据 有了之后就可以传递行为
            //Console.WriteLine("Hello World!");
        }

        private static void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private static void Test(object sender, EventArgs args)
        {

            Console.WriteLine("aaa");

        }
        private static void ShowResult(object sender, EventArgs args)
        {

            Console.WriteLine("bbb");

        }
    }
}
