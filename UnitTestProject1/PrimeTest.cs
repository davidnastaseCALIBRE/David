using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DavidMath;

namespace UnitTestProject1{
    [TestClass]
    public class PrimeTest{
        [TestMethod]
        public void PrimeTest0and1(){
            Assert.IsFalse( Prime.IsPrime(0));
            Assert.IsFalse( Prime.IsPrime(1));
        }

        [TestMethod]
        public void PrimeTestNegative(){
            Assert.IsFalse( Prime.IsPrime(-1));
            Assert.IsFalse( Prime.IsPrime(-5));
        }

        [TestMethod]
        public void PrimeTestIsPrime(){
            Assert.IsTrue( Prime.IsPrime(2));
            Assert.IsTrue( Prime.IsPrime(3));
            Assert.IsTrue( Prime.IsPrime(5));
            Assert.IsTrue( Prime.IsPrime(7));
            Assert.IsTrue( Prime.IsPrime(17));
        }

        [TestMethod]
        public void PrimeTestIsNotPrime(){
            Assert.IsFalse( Prime.IsPrime(6));
            Assert.IsFalse( Prime.IsPrime(9));
            Assert.IsFalse( Prime.IsPrime(15));
        }
    }
    [TestClass]
    public class FactorTest
    {
        [TestMethod]
        public void PrimeFactors0or1()
        {
            List<int> test = Prime.PrimeFactors(0);
            Assert.AreEqual(0, test.Count);
            test = Prime.PrimeFactors(1);
            Assert.AreEqual(0, test.Count);
        }

        [TestMethod]
        public void PrimeFactorsNegative()
        {
            List<int> test = Prime.PrimeFactors(-1);
            Assert.AreEqual(0, test.Count);
        }

        [TestMethod]
        public void PrimeFactorsAlreadyPrime()
        {
            List<int> test = Prime.PrimeFactors(2);
            Assert.AreEqual(1, test.Count);
            Assert.AreEqual(2, test[0]);

            test = Prime.PrimeFactors(7);
            Assert.AreEqual(1, test.Count);
            Assert.AreEqual(7, test[0]);

            test = Prime.PrimeFactors(3);
            Assert.AreEqual(1, test.Count);
            Assert.AreEqual(3, test[0]);
        }

        [TestMethod]
        public void PrimeFactorsNormalCase()
        {
            List<int> test = Prime.PrimeFactors(4);
            Assert.AreEqual(2, test.Count);
            Assert.IsTrue(test.FindAll(s => s == 2).Count == test.Count);

            test = Prime.PrimeFactors(8);
            Assert.AreEqual(3, test.Count);
            Assert.IsTrue(test.FindAll(s => s == 2).Count == test.Count);

            test = Prime.PrimeFactors(14);
            Assert.AreEqual(2, test.Count);
            Assert.IsTrue(test.Contains(2));
            Assert.IsTrue(test.Contains(7));

            test = Prime.PrimeFactors(25);
            Assert.AreEqual(2, test.Count);
            Assert.IsTrue(test.FindAll(s => s == 5).Count == test.Count);

            test = Prime.PrimeFactors(64);
            Assert.AreEqual(6, test.Count);
            Assert.IsTrue(test.FindAll(s => s == 2).Count == test.Count);
        }
    }
}
