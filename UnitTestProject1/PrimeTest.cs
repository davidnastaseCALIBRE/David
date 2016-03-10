using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void PrimeTest0and1()
        {
            Assert.IsFalse(DavidMath.Prime.isPrime(0));
            Assert.IsFalse(DavidMath.Prime.isPrime(1));
        }

        [TestMethod]
        public void PrimeTestNegative()
        {
            Assert.IsFalse(DavidMath.Prime.isPrime(-1));
            Assert.IsFalse(DavidMath.Prime.isPrime(-5));
        }

        [TestMethod]
        public void PrimeTestIsPrime()
        {
            Assert.IsTrue(DavidMath.Prime.isPrime(2));
            Assert.IsTrue(DavidMath.Prime.isPrime(3));
            Assert.IsTrue(DavidMath.Prime.isPrime(5));
            Assert.IsTrue(DavidMath.Prime.isPrime(7));
            Assert.IsTrue(DavidMath.Prime.isPrime(17));
        }

        [TestMethod]
        public void PrimeTestIsNotPrime()
        {
            Assert.IsFalse(DavidMath.Prime.isPrime(6));
            Assert.IsFalse(DavidMath.Prime.isPrime(9));
            Assert.IsFalse(DavidMath.Prime.isPrime(15));
        }
    }

    [TestClass]
    public class TwinPrimeTest
    {
        [TestMethod]
        public void TwinPrimeTestTrue()
        {
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(3));
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(5));
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(7));
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(13));
        }

        [TestMethod]
        public void TwinPrimeTestIsNotTwin()
        {
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(2));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(23));
        }

        [TestMethod]
        public void TwinPrimeTestIsNotPrime()
        {
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(4));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(1));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(0));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(12));
        }
    }
    }
