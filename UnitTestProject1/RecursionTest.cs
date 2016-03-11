using DavidMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class RecursionTest{
        [TestMethod]
        public void FactorialTest(){
            Assert.AreEqual(1, Recursion.Factorial(1));
            Assert.AreEqual(0, Recursion.Factorial(0));
            Assert.AreEqual(0, Recursion.Factorial(-1));
            Assert.AreEqual(6, Recursion.Factorial(3));
            Assert.AreEqual(24, Recursion.Factorial(4));
            Assert.AreEqual(120, Recursion.Factorial(5));
        }

        [TestMethod]
        public void FibonacciTest(){
            Assert.AreEqual(1, Recursion.Fibonacci(1));
            Assert.AreEqual(1, Recursion.Fibonacci(2));
            Assert.AreEqual(2, Recursion.Fibonacci(3));
            Assert.AreEqual(3, Recursion.Fibonacci(4));
            Assert.AreEqual(0, Recursion.Fibonacci(0));
            Assert.AreEqual(0, Recursion.Fibonacci(-1));
        }
    }
}
