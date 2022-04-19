using HomeworkStatic;
using NUnit.Framework;
using TestHomework;

namespace TestHomeworkNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void PrimeNumberTest()
        {
            PrimeNumber.FindPrimeNumber();
        
        
        
        }
        [Test]
        public void MimicStackTest()
        {
            MimicStack mimicStack;
            
        
        }
        [Test]
        public void MaxTest()
        {
            int[] array = { 1,2,3,4,5,6,7,8,99};
            int i =  Max.getMax(array);
            Assert.AreEqual(99,i);
        }
    }
}