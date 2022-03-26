using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Context
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
