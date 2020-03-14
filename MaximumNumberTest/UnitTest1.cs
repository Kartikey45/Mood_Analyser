using NUnit.Framework;
using Maximum_Problems_Using_Generic;

namespace MaximumNumberTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int result = MaximumNumber.GenericClass<int>.testMaximum(1, 3, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test2()
        {
            float result = MaximumNumber.GenericClass<float>.testMaximum(1.1f, 3.2f, 2.2f);
            Assert.AreEqual(3.2f, result);
        }

        [Test]
        public void Test3()
        {
            int result = MaximumNumber.GenericClass<int>.testMaximum("kartikey".Length, "anurag".Length, "abhijit".Length);
            Assert.AreEqual(8, result);

        }
    }
}