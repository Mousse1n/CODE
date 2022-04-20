using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnTest1
{
    public class DLinkNode
    {
        public DLinkNode Prervious { get; set; }
        public DLinkNode Next { get; set; }
        public void AddAfter(DLinkNode node)
        {
            //1 [2]
            this.Next = node;
            node.Prervious = this;
            //1 [3] 2
            node.Next = this.Next;
            node.Prervious = this;

            this.Next = node;
            this.Next.Prervious = node;
            //if (this.Next != null)//1
            //{

            //    node.Next = this.Next;
            //    this.Next/*node2*/.Prervious = node;
            //    //this.Next.Prervious = node;
            //}

            //node.Prervious = this;
            //this.Next = node;
            //1.[2]
            //this.Next = node;
            //node.Prervious = this;
            ////1[3]2/分支 1 2 [3]
            //node.Prervious = this;
            //node.Next = this.Next;
            //this.Next/*node2*/.Prervious = node;
            //this.Next = node;




            //    if (this.Next != null)
            //    {
            //        node.Next = this.Next;
            //        this.Next.Prervious = node;
            //    }

            //    node.Prervious = this;
            //    this.Next = node;
        }
        public void AddBefore(DLinkNode node)
        {
            if (this.Prervious == null)
            {
                node.Next = this;
                this.Prervious = node;
            }
            else
            {
                node.Next = this.Next;
                node.Prervious = this;
                this.Next.Prervious = node;
                this.Next = node;

            }




            //this.Prervious = node;
            ////1[3]2
            //node.Prervious = this;
            //node.Next = this.Next;
            //this.Next.Prervious = node;
            //this.Next = node;



        }
        public void Delete()
        {
            ///1,2,3,4
            ///2,3,4
           

            ///2,3,4
            ///2,4
            //this.Prervious.Next = this.Next;
            ///2,4
            ///2
            ///
            //this.Next.Prervious = this.Prervious;
            if (this.Prervious != null && this.Next != null)
            {
                this.Next.Prervious = null;
                this.Prervious.Next = null;
                this.Prervious.Next = this.Next;
                this.Next.Prervious = this.Prervious;


            }
            else if (this.Next == null)
            {
                this.Prervious.Next = null;
                
               
            }
            else if (this.Prervious == null)
            {
                
                this.Next.Prervious = null;
                
            }

            this.Next = null;
            this.Prervious = null;
        }
        public void Swap()
        {



        }
    }

}
