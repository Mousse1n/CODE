using NUnit.Framework;
using UnTest1;

namespace TestProject1
{
    public class StudentTests
    {
        

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Greet()
        {
            Assert.Pass();
        }
        [Test]
        public void Learn() 
        {
        
        
        }



        [Test]
        public void GetMax() 
        {
            int max = BaseLearn.GetMax(new int[] {2,7,11,-13444,234 });
            Assert.AreEqual(234, max);   
        
        
        }
    }
}