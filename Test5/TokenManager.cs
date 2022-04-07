using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    public class TokenManager
    {
        private Token _token { get; set; }

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="tok">权限枚举对象</param>
        /// <returns>成功返回true,失败返回false</returns>
        public bool Add(Token tok)
        {
            User user = new User();
            switch (tok)
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
                    Console.WriteLine("错误");
                    return false;

            }
            return true;

        }
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="tok">枚举对象</param>
        /// <returns>成功返回true,失败返回false</returns>
        public bool Remove(Token tok)
        {
            User user = new User();
            switch (tok)
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
                    Console.WriteLine("错误");
                    return false;
                    
            }
            return true;

        }
        /// <summary>
        /// 查看是否有对应的权限
        /// </summary>
        /// <param name="tok">权限对象</param>
        /// <returns>成功返回true,失败返回false</returns>
        public bool Has(Token tok)
        {
            User user = new User();
            switch (tok)
            {
                case Token.SuperAdmin:
                    if ((user.TokenManager & Token.SuperAdmin) == Token.SuperAdmin)
                    {
                        Console.WriteLine("user中存在SuperAdmin权限");
                    }
                    break;
                case Token.Admin:
                    if ((user.TokenManager & Token.Admin) == Token.Admin)
                    {
                        Console.WriteLine("user中存在Admin权限");
                    }
                    break;
                case Token.Blogger:
                    if ((user.TokenManager&Token.Blogger)==Token.Blogger)
                    {
                        Console.WriteLine("user中存在Blagger权限");
                    }
                    break;
                case Token.Newbie:
                    if ((user.TokenManager&Token.Newbie) == Token.Newbie)
                    {
                        Console.WriteLine("user中存在Newbie权限");
                    }
                    break;
                case Token.Registered:
                    if ((user.TokenManager&Token.Registered)== Token.Registered)
                    {
                        Console.WriteLine("user中存在Registered权限");
                    }
                    break;
                default:
                   
                    return false;
                    
            }
            return true;

        }
    }
}
