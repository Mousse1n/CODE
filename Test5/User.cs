using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    //不能被继承
    sealed class User : Entity
    {
        //定义一个User类（以下所有类都按“一个类文件一个类”的原则组织），包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：
//        Register()：能输出当前用户的注册信息，比如：fg开始注册，密码：1234，邀请人：dk
//        Login()：能输出当前用户的登录信息，比如：fg开始登录，输入密码：1234
//求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）和作者
        private string Name;
        private string PassWord;
        private User InvitedBy;
        public User Register(string Name,string PassWord,string InvitedBy) 
        {
            User user = new User();
            user.Name = Name;
            user.PassWord = PassWord;
            user.InvitedBy.Name = InvitedBy;
           
            return user;
        }
        public User Login(string Name,string PassWord)
        {
            User user = new User();
            user.Name = Name;
            user.PassWord = PassWord;
            return user;
        
        }
    }
}
