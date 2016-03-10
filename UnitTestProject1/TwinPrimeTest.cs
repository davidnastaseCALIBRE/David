using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class TwinPrimeTest{
        [TestMethod]
        public void TwinPrimeTestTrue(){
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(3));
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(5));
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(7));
            Assert.IsTrue(DavidMath.Prime.isTwinPrime(13));
        }

        [TestMethod]
        public void TwinPrimeTestIsNotTwin(){
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(2));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(23));
        }

        [TestMethod]
        public void TwinPrimeTestIsNotPrime(){
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(4));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(1));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(0));
            Assert.IsFalse(DavidMath.Prime.isTwinPrime(12));
        }
    }
}
