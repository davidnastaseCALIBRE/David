using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class PrimeTest{
        [TestMethod]
        public void PrimeTest0and1(){
            Assert.IsFalse(DavidMath.Prime.IsPrime(0));
            Assert.IsFalse(DavidMath.Prime.IsPrime(1));
        }

        [TestMethod]
        public void PrimeTestNegative(){
            Assert.IsFalse(DavidMath.Prime.IsPrime(-1));
            Assert.IsFalse(DavidMath.Prime.IsPrime(-5));
        }

        [TestMethod]
        public void PrimeTestIsPrime(){
            Assert.IsTrue(DavidMath.Prime.IsPrime(2));
            Assert.IsTrue(DavidMath.Prime.IsPrime(3));
            Assert.IsTrue(DavidMath.Prime.IsPrime(5));
            Assert.IsTrue(DavidMath.Prime.IsPrime(7));
            Assert.IsTrue(DavidMath.Prime.IsPrime(17));
        }

        [TestMethod]
        public void PrimeTestIsNotPrime(){
            Assert.IsFalse(DavidMath.Prime.IsPrime(6));
            Assert.IsFalse(DavidMath.Prime.IsPrime(9));
            Assert.IsFalse(DavidMath.Prime.IsPrime(15));
        }
    }
}
