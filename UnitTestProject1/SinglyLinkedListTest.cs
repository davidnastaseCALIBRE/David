using System;
using DavidMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class SinglyLinkedListTest
    {
        [TestMethod]
        public void SLLContainsTest()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            Assert.IsFalse(test.Contains(1));

            test.Add(1);
            Assert.IsTrue(test.Contains(1));

            test.Add(3);
            Assert.IsTrue(test.Contains(3));

            test.Add(2);
            Assert.IsTrue(test.Contains(2));
            Assert.IsTrue(test.Contains(3));
        }

        [TestMethod]
        public void SLLAddTest()
        { //let's not reuse stuff from contains
            SinglyLinkedList test = new SinglyLinkedList();
            test.Add(1);
            test.Add(1);
            Assert.IsTrue(test.Contains(1));
            Assert.AreEqual(1, test.ReasonableList().Count);
        }

        [TestMethod]
        public void SLLRemoveTest()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            test.Remove(1); //hope no errors are thrown.

            test.Add(1);
            test.Add(2);
            test.Add(3);

            test.Remove(1);
            Assert.IsFalse(test.Contains(1));
            Assert.AreEqual(2, test.ReasonableList().Count);

            test.Remove(3);
            Assert.IsFalse(test.Contains(3));
            Assert.AreEqual(1, test.ReasonableList().Count);

            test.Remove(2);
            Assert.IsFalse(test.Contains(0));
            Assert.AreEqual(0, test.ReasonableList().Count);
        }

        [TestMethod]
        public void SLLToStringTest()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            Assert.AreEqual("", test.ToString());

            test.Add(1);
            Assert.AreEqual("1", test.ToString());

            test.Add(3);
            Assert.AreEqual("13", test.ToString());

            test.Add(2);
            Assert.AreEqual("123", test.ToString());
        }

        [TestMethod]
        public void SLLReasonableListTest()
        {
            SinglyLinkedList test = new SinglyLinkedList();
            Assert.AreEqual(0, test.ReasonableList().Count);

            test.Add(1);
            Assert.AreEqual(1, test.ReasonableList().Count);
            Assert.IsTrue(test.ReasonableList().Contains(1));
        }
    }
}
