using NUnit.Framework;
using Maximum_Problem_Using_Generics;

namespace MaximumNumberTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            MaximumNumber maximum = new MaximumNumber();
            int result = maximum.MaximumElement(1, 3, 2);
            Assert.AreEqual(3, result);
        }
    }
}