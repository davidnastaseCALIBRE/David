using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class PrimeTest{
        [TestMethod]
        public void PrimeTest0and1(){
            Assert.IsFalse(DavidMath.Prime.isPrime(0));
            Assert.IsFalse(DavidMath.Prime.isPrime(1));
        }

        [TestMethod]
        public void PrimeTestNegative(){
            Assert.IsFalse(DavidMath.Prime.isPrime(-1));
            Assert.IsFalse(DavidMath.Prime.isPrime(-5));
        }

        [TestMethod]
        public void PrimeTestIsPrime(){
            Assert.IsTrue(DavidMath.Prime.isPrime(2));
            Assert.IsTrue(DavidMath.Prime.isPrime(3));
            Assert.IsTrue(DavidMath.Prime.isPrime(5));
            Assert.IsTrue(DavidMath.Prime.isPrime(7));
            Assert.IsTrue(DavidMath.Prime.isPrime(17));
        }

        [TestMethod]
        public void PrimeTestIsNotPrime(){
            Assert.IsFalse(DavidMath.Prime.isPrime(6));
            Assert.IsFalse(DavidMath.Prime.isPrime(9));
            Assert.IsFalse(DavidMath.Prime.isPrime(15));
        }
    }
}
