using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnTest1;

namespace TestProject1
{
    
   public class DLinkNodeTest
    {
       private DLinkNode node1, node2, node3, node4,node5;
       // [Test]
       [SetUp]
        public void Setup() 
        {
             node1 = new DLinkNode();
             node2 = new DLinkNode();
             node3 = new DLinkNode();
             node4 = new DLinkNode();
            //node1.AddAfter(node2);
            //node2.AddAfter(node3);
            //node3.AddAfter(node4);
            node1.Next = node2;
            node2.Prervious = node1;
            node2.Next = node3;
            node3.Prervious = node2;
            node3.Next = node4;
            node4.Prervious = node3;

        }



        
        
        [Test]
        public void AddTest()
        {
            //Setup();
            //1[2]
            Assert.IsNull(node1.Prervious);
            Assert.IsNull(node2.Next);
            Assert.AreEqual(node2, node1.Next);
            Assert.AreEqual(node1, node2.Prervious);

            //DLinkNode node3 = new DLinkNode();
            //1 2 [3]
            //node2.AddAfter(node3);
            ///node3.next => null
            ///node3.prev => node2
            ///node2.next => node3
            ///
            Assert.IsNull(node3.Next);
            Assert.AreEqual(node2,node3.Prervious);
            Assert.AreEqual(node3,node2.Next);
            ///1 2 [4] 3 
            ///
            //DLinkNode node4 = new DLinkNode();
            //node2.AddAfter(node4);
            Assert.AreEqual(node4,node2.Next);
            Assert.AreEqual(node2,node4.Prervious);
            Assert.AreEqual(node3,node4.Next);
            Assert.AreEqual(node4,node3.Prervious);
            Assert.IsNull(node3.Next);
        }
        [Test]
        public void BeforeTest()
        {
            ///[5]1,2,3,4
            node5 = new DLinkNode();
            node1.AddBefore(node5);
            Assert.IsNull(node1.Prervious);
            Assert.IsNull(node4.Next);
            ///1 [5] 2 3 4 
            node2.AddBefore(node5);
            Assert.AreEqual(node1, node5.Prervious);
            Assert.AreEqual(node2, node5);
            Assert.IsNull(node1.Prervious);
            Assert.AreEqual(node5, node1.Next);
            Assert.AreEqual(node5, node2.Prervious);
            Assert.IsNull(node2.Next);


        }
        [Test]
        public void DeleteTest()
        {
            ///1,2,3,4
            ///1 2,3,4
            ///
            node1.Delete();
            Assert.IsNull(node2.Prervious);
            ///2,3,4
            ///2,4
            ///
            node3.Delete();
            Assert.AreEqual(node2,node4.Prervious);
            Assert.AreEqual(node4,node2.Next);
            ///2,4
            ///2
            ///
            node4.Delete();
            Assert.IsNull(node2.Next);
            Assert.IsNull(node2.Prervious);







        }
        [Test]
        public void swapTest()
        {



        }
    }
}
