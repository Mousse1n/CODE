using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class User
    {
        private static string Name;
        private static string Password;
        private static string InvutedBy;

        public string Name1 { get => Name; set => Name = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string InvutedBy1 { get => InvutedBy; set => InvutedBy = value; }
        public static string Register(string UserName,string UserPassword,string UserInvtedBy) 
        {
            UserName = Name;
            UserPassword = Password;
            UserInvtedBy = InvutedBy;
            return Name+"开始注册，密码："+UserPassword+",邀请人："+UserInvtedBy;
        }
        public static string Login(string UserName,string UserPassword)
        {
            UserName = Name;
            UserPassword = Password;
            return Name + "开始登录，输入密码：" + UserPassword;
        }
    }
}
