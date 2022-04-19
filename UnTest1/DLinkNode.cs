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
            if (this.Next != null)
            {
                node.Next = this.Next;
                this.Next.Prervious = node;
            }

            node.Prervious = this;
            this.Next = node;
        }
        public void AddBefore(DLinkNode node)
        {
            this.Prervious = node;
            //1[3]2
            node.Prervious = this;
            node.Next = this.Next;
            this.Next.Prervious = node;
            this.Next = node;
            
            

        }
        public void Delete()
        {


        }
        public void Swap()
        {



        }
    }

}
