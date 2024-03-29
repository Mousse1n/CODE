﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProject
{
    public enum EnumKind
    {
        problem,
        article,
        suggest

    }
    public class Content : ContentService
    {

        public User Author { get; set; }
        public User Appraiser { get; set; }
        public string Title { get; set; }
        protected EnumKind kind;
        public DateTime PublishTime { get; set; }
        public DateTime CreateTime { get; set; }
        public override void Release()
        {
            //base.Release();
            Console.WriteLine("发布内容");
        }

    }
}
