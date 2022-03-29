using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
   //抽象类：因为里面有字段并且有些方法需要具体的方法实现。
    abstract class Content
    {

        protected string _kind ;
        private DateTime createTime;
        public  DateTime PublishTime 
        {

            get { return createTime; }
        
        }
        private string Title { get; set; }
        private User Auther { get; set; }
        public void Getcategory() 
        {
        
        
        
        }
        public  void Release()
        {
        
        
        }
    }
}
