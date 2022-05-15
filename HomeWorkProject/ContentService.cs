using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public class ContentService
    {
        public virtual bool Agree()
        {

            Console.WriteLine("帮帮点增加");
            return true;
        }
        public virtual bool DisAgree()
        {
            Console.WriteLine("帮帮点减少");
            return true;
        }
        public virtual void Release()
        {

            Console.WriteLine("发布");

        }
        public void SetPublishTime(Content content, DateTime dateTime)
        {
            Type typeInfo = content.GetType();
            PropertyInfo SetPublishTime = typeInfo.GetProperty("PublishTime");
            SetPublishTime.SetValue(content, dateTime);

        }
        public void SetCreateTime(Content content, DateTime dateTime)
        {
            Type typeInfo = content.GetType();
            PropertyInfo setCreateTime = typeInfo.GetProperty("CreateTime");
            setCreateTime.SetValue(content, dateTime);
        }
    }
}
