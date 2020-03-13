using NUnit.Framework;
using Maximum_Problems_Using_Generic;

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

        [Test]
        public void Test2()
        {
            MaximumNumber maximum = new MaximumNumber();
            float result = maximum.MaximumElement(1.2f, 3.2f, 2.2f);
            Assert.AreEqual(3.2f, result);
        }

        [Test]
        public void Test3()
        {
            MaximumNumber maximum = new MaximumNumber();
            int result = maximum.maximumElement1("kartikey", "anurag", "abhijeet");
            Assert.AreEqual(8, result);
        }
    }
}