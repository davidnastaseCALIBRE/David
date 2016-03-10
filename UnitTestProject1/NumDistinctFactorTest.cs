using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class NumDistinctFactorTest{
        [TestMethod]
        public void factorsOf0and1(){
            Assert.AreEqual(0, DavidMath.Prime.numDistinctFactors(0));
            Assert.AreEqual(0, DavidMath.Prime.numDistinctFactors(0));
        }

        [TestMethod]
        public void factorsOfNegative(){
            Assert.AreEqual(0, DavidMath.Prime.numDistinctFactors(-1));
            Assert.AreEqual(0, DavidMath.Prime.numDistinctFactors(-17));
        }

        [TestMethod]
        public void factorsOfPrime(){
            Assert.AreEqual(1, DavidMath.Prime.numDistinctFactors(2));
            Assert.AreEqual(1, DavidMath.Prime.numDistinctFactors(3));
            Assert.AreEqual(1, DavidMath.Prime.numDistinctFactors(17));
        }

        [TestMethod]
        public void factorsOfComposite(){
            Assert.AreEqual(1, DavidMath.Prime.numDistinctFactors(4));
            Assert.AreEqual(2, DavidMath.Prime.numDistinctFactors(6));
            Assert.AreEqual(3, DavidMath.Prime.numDistinctFactors(30));
            Assert.AreEqual(1, DavidMath.Prime.numDistinctFactors(64));
        }
    }
}
