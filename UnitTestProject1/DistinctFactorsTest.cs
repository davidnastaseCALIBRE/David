﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class DistinctFactorTest{
        [TestMethod]
        public void is0or1(){
            List<int> test = DavidMath.Prime.distinctFactors(0);
            Assert.AreEqual(0, test.Count);
            test = DavidMath.Prime.distinctFactors(1);
            Assert.AreEqual(0, test.Count);
        }

        [TestMethod]
        public void isNegative(){
            List<int> test = DavidMath.Prime.distinctFactors(-1);
            Assert.AreEqual(0, test.Count);
        }

        [TestMethod]
        public void isAlreadyPrime(){
            List<int> test = DavidMath.Prime.distinctFactors(2);
            Assert.AreEqual(1, test.Count);
            Assert.AreEqual(2, test[0]);

            test = DavidMath.Prime.distinctFactors(7);
            Assert.AreEqual(1, test.Count);
            Assert.AreEqual(7, test[0]);

            test = DavidMath.Prime.distinctFactors(3);
            Assert.AreEqual(1, test.Count);
            Assert.AreEqual(3, test[0]);
        }

        [TestMethod]
        public void isNormalCase(){
            List<int> test = DavidMath.Prime.distinctFactors(4);
            Assert.AreEqual(1, test.Count);
            Assert.IsTrue(test.Contains(2));

            test = DavidMath.Prime.distinctFactors(8);
            Assert.AreEqual(1, test.Count);
            Assert.IsTrue(test.Contains(2));

            test = DavidMath.Prime.distinctFactors(14);
            Assert.AreEqual(2, test.Count);
            Assert.IsTrue(test.Contains(2));
            Assert.IsTrue(test.Contains(7));

            test = DavidMath.Prime.distinctFactors(25);
            Assert.AreEqual(1, test.Count);
            Assert.IsTrue(test.Contains(5));

            test = DavidMath.Prime.distinctFactors(64);
            Assert.AreEqual(1, test.Count);
            Assert.IsTrue(test.Contains(2));
        }
    }
}
