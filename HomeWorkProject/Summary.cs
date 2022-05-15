using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class Summary : Content
    {
        /// <summary>
        /// 点赞帮帮点增加
        /// </summary>
        /// <returns>成功true失败false</returns>
        public override bool Agree()
        {

            Author.HelpPoint += 1;
            Appraiser.HelpPoint += 1;
            return true;

        }
        /// <summary>
        ///点踩帮帮点减少
        /// </summary>
        /// <returns>成功返回true,失败返回false</returns>
        public override bool DisAgree()
        {
            Author.HelpPoint -= 1;
            Appraiser.HelpPoint -= 1;
            return true;
            //base.DisAgree();
        }


        public override void Release()
        {
            //base.Release();
        }


    }
}
