using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{

    public sealed class User : Entity<User>, ISendMessage, IChat
    {

        public string Name { get; set; }
        public string Password { get; }
        public User invitedBy { get; set; }
        public HelpMoney HelpMoney { get; set; }
        public int HelpPoint { get; set; }
        public Token TokenManager { get; set; }
        /// <summary>
        /// 构造函数赋值
        /// </summary>
        /// <param name="Password">密码</param>
        /// <param name="Name">用户名</param>
        public User(string Password, string Name)
        {
            if (Name == "admin")
            {
                this.Name = "系统管理员";
            }
            this.Name = Name;
            this.Password = Password;
            if (Name.Contains("admin") || Name.Contains("17bang") || Name.Contains("管理员"))
            {
                Console.WriteLine("不能有敏感词");
            }

        }
        public User() { }



        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        public void Register(User user)
        {
            Console.WriteLine($"{user.Name}开始注册，密码：{user.Password},邀请人：{user.invitedBy.Name}");

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user"></param>
        public void Login(User user)
        {

            Console.WriteLine($"{user.Name}开始登录，输入密码：{user.Password}");

        }

        void ISendMessage.Send()
        {
            Console.WriteLine("发送信息");

        }

        void IChat.Send()
        {

            Console.WriteLine("发送聊天信息");
        }
    }
}
