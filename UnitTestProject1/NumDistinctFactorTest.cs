using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class NumDistinctFactorTest{
        [TestMethod]
        public void factorsOf0and1(){
            Assert.AreEqual(0, DavidMath.Prime.NumDistinctFactors(0));
            Assert.AreEqual(0, DavidMath.Prime.NumDistinctFactors(0));
        }

        [TestMethod]
        public void factorsOfNegative(){
            Assert.AreEqual(0, DavidMath.Prime.NumDistinctFactors(-1));
            Assert.AreEqual(0, DavidMath.Prime.NumDistinctFactors(-17));
        }

        [TestMethod]
        public void factorsOfPrime(){
            Assert.AreEqual(1, DavidMath.Prime.NumDistinctFactors(2));
            Assert.AreEqual(1, DavidMath.Prime.NumDistinctFactors(3));
            Assert.AreEqual(1, DavidMath.Prime.NumDistinctFactors(17));
        }

        [TestMethod]
        public void factorsOfComposite(){
            Assert.AreEqual(1, DavidMath.Prime.NumDistinctFactors(4));
            Assert.AreEqual(2, DavidMath.Prime.NumDistinctFactors(6));
            Assert.AreEqual(3, DavidMath.Prime.NumDistinctFactors(30));
            Assert.AreEqual(1, DavidMath.Prime.NumDistinctFactors(64));
        }
    }
}
