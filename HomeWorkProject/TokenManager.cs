using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class TokenManager
    {
        private Token _tokens;
        public void Add(Token token)
        {
            User user = new User();
            switch (token)
            {
                case Token.SuperAdmin:
                    user.TokenManager = user.TokenManager | Token.SuperAdmin;

                    break;
                case Token.Admin:
                    user.TokenManager = user.TokenManager | Token.Admin;
                    break;
                case Token.Blogger:
                    user.TokenManager = user.TokenManager | Token.Blogger;
                    break;
                case Token.Newbie:
                    user.TokenManager = user.TokenManager | Token.Newbie;
                    break;
                case Token.Registered:
                    user.TokenManager = user.TokenManager | Token.Registered;
                    break;
                default:
                    break;
            }
        }
        public void Remove(Token token)
        {

            User user = new User();
            switch (token)
            {
                case Token.SuperAdmin:
                    user.TokenManager = user.TokenManager ^ Token.SuperAdmin;
                    break;
                case Token.Admin:
                    user.TokenManager = user.TokenManager ^ Token.Admin;
                    break;
                case Token.Blogger:
                    user.TokenManager = user.TokenManager ^ Token.Blogger;
                    break;
                case Token.Newbie:
                    user.TokenManager = user.TokenManager ^ Token.Newbie;

                    break;
                case Token.Registered:
                    user.TokenManager = user.TokenManager ^ Token.Registered;
                    break;
                default:
                    break;
            }

        }
        public void Has(Token token)
        {
            User user = new User();
            switch (token)
            {
                case Token.SuperAdmin:
                    if ((user.TokenManager & Token.SuperAdmin) == Token.SuperAdmin)
                    {
                        Console.WriteLine("存在超级管理员权限");
                    }
                    break;
                case Token.Admin:
                    if ((user.TokenManager & Token.Admin) == Token.Admin)
                    {
                        Console.WriteLine("存在admin权限");
                    }
                    break;
                case Token.Blogger:
                    if ((user.TokenManager & Token.Blogger) == Token.Blogger)
                    {
                        Console.WriteLine("存在Blogger权限");
                    }
                    break;
                case Token.Newbie:
                    if ((user.TokenManager & Token.Newbie) == Token.Newbie)
                    {
                        Console.WriteLine("存在Newbie权限");
                    }
                    break;
                case Token.Registered:
                    if ((user.TokenManager & Token.Registered) == Token.Registered)
                    {
                        Console.WriteLine("存在Registered权限");
                    }

                    break;
                default:
                    break;
            }


        }
    }
}
