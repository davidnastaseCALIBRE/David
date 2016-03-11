using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class CollatzTest{
        /***
        *I'm aware that the list tests are pretty lazy. They're basically identical to
        *the tests of length. I couldn't think of a not-super-inconvenient way to have
        *the tests not just check every step of a list individually and I'd rather not
        *do that.
        */
        [TestMethod]
        public void CollatzListTest(){
            Assert.AreEqual(1, DavidMath.Collatz.CollatzList(1).Count);
            Assert.AreEqual(2, DavidMath.Collatz.CollatzList(2).Count);
            Assert.AreEqual(8, DavidMath.Collatz.CollatzList(3).Count);
            Assert.AreEqual(3, DavidMath.Collatz.CollatzList(4).Count);
        }

        [TestMethod]
        public void CollatzList0Test(){
            Assert.AreEqual(0,DavidMath.Collatz.CollatzList(0).Count);
        }

        [TestMethod]
        public void CollatzListNegativeTest(){
            Assert.AreEqual(0, DavidMath.Collatz.CollatzList(-1).Count);
        }

        [TestMethod]
        public void CollatzLengthTest(){
            Assert.AreEqual(1, DavidMath.Collatz.CollatzLength(1));
            Assert.AreEqual(2, DavidMath.Collatz.CollatzLength(2));
            Assert.AreEqual(8, DavidMath.Collatz.CollatzLength(3));
            Assert.AreEqual(3, DavidMath.Collatz.CollatzLength(4));
        }

        [TestMethod]
        public void CollatzLength0Test(){
            Assert.AreEqual(0, DavidMath.Collatz.CollatzLength(0));
        }

        [TestMethod]
        public void CollatzLengthNegativeTest(){
            Assert.AreEqual(0, DavidMath.Collatz.CollatzLength(-1));
        }
    }
}
