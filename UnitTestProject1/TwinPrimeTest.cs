using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class TwinPrimeTest{
        [TestMethod]
        public void TwinPrimeTestTrue(){
            Assert.IsTrue(DavidMath.Prime.IsTwinPrime(3));
            Assert.IsTrue(DavidMath.Prime.IsTwinPrime(5));
            Assert.IsTrue(DavidMath.Prime.IsTwinPrime(7));
            Assert.IsTrue(DavidMath.Prime.IsTwinPrime(13));
        }

        [TestMethod]
        public void TwinPrimeTestIsNotTwin(){
            Assert.IsFalse(DavidMath.Prime.IsTwinPrime(2));
            Assert.IsFalse(DavidMath.Prime.IsTwinPrime(23));
        }

        [TestMethod]
        public void TwinPrimeTestIsNotPrime(){
            Assert.IsFalse(DavidMath.Prime.IsTwinPrime(4));
            Assert.IsFalse(DavidMath.Prime.IsTwinPrime(1));
            Assert.IsFalse(DavidMath.Prime.IsTwinPrime(0));
            Assert.IsFalse(DavidMath.Prime.IsTwinPrime(12));
        }
    }
}
