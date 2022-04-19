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
       private DLinkNode node1, node2, node3, node4;
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
            ///[3]1 2
            
            node1.AddBefore(node3);
            Assert.IsNull(node3.Prervious);
            ///1 [3] 2 
            node2.AddBefore(node3);
            Assert.AreEqual(node1,node3.Prervious);
            Assert.AreEqual(node2,node3.Next);
            Assert.IsNull(node1.Prervious);
            Assert.AreEqual(node3,node1.Next);
            Assert.AreEqual(node3, node2.Prervious);
            Assert.IsNull(node2.Next);


        }
        [Test]
        public void DeleteTest()
        {
        
        
        
        }
        [Test]
        public void swapTest()
        {



        }
    }
}
