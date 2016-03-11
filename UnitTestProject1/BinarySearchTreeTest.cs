using System;
using DavidMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1{
    [TestClass]
    public class BinarySearchTreeTest{
        [TestMethod]
        public void BSTToStringTest(){
            BinarySearchTree tester = new BinarySearchTree();
            Assert.AreEqual("", tester.ToString());

            tester.Add(4);
            Assert.AreEqual("4", tester.ToString());

            tester.Add(2);
            Assert.AreEqual("24", tester.ToString());

            tester.Add(6);
            Assert.AreEqual("246", tester.ToString());
        }

        [TestMethod]
        public void BSTOrderedListTest(){
            BinarySearchTree tester = new BinarySearchTree();
            Assert.IsTrue(tester.OrderedList().Count == 0);

            tester.Add(4);
            Assert.AreEqual(1, tester.OrderedList().Count);
            Assert.IsTrue(tester.OrderedList().Contains(4));

            tester.Add(2);
            Assert.IsTrue(tester.OrderedList().Contains(2));
            Assert.AreEqual(0, tester.OrderedList().IndexOf(2));

            tester.Add(6);
            Assert.IsTrue(tester.OrderedList().Contains(6));
            Assert.AreEqual(2, tester.OrderedList().IndexOf(6));
        }

        [TestMethod]
        public void BSTContainsTest(){
            BinarySearchTree tester = new BinarySearchTree();
            Assert.IsFalse(tester.Contains(0));
            Assert.IsFalse(tester.Contains(1));

            tester.Add(5);
            Assert.IsTrue(tester.Contains(5));

            tester.Add(7); //Check right child
            Assert.IsTrue(tester.Contains(7));

            tester.Add(6); //Check right child left subchild
            Assert.IsTrue(tester.Contains(6));

            tester.Add(9);
            Assert.IsTrue(tester.Contains(9)); //check right recursive child

            tester.Add(3);
            Assert.IsTrue(tester.Contains(3)); //check left child

            tester.Add(4); //Check left child right subchild
            Assert.IsTrue(tester.Contains(4));

            tester.Add(1);
            Assert.IsTrue(tester.Contains(1)); //check left recursive child

            Assert.IsFalse(tester.Contains(18)); //checks that children report false correctly.
        }

        [TestMethod]
        public void BSTAddTest() { // note, add has been extensively tested by the other tests so far.
            BinarySearchTree tester = new BinarySearchTree();
            tester.Add(4);
            Assert.AreEqual("4", tester.ToString());
        }

        [TestMethod]
        public void BSTRemoveTest(){
            BinarySearchTree tester = new BinarySearchTree();
            tester.Remove(4); //let's remove from null. Let's hope for no exceptions
            Assert.IsFalse(tester.Contains(4));

            tester.Add(4);
            tester.Add(2);
            tester.Add(3);
            tester.Add(1);

            tester.Remove(2);
            Assert.IsFalse(tester.Contains(2)); //remove child node with two children.
            Assert.AreEqual(3, tester.OrderedList().Count);

            tester.Remove(3); //remove child with 1 child.
            Assert.IsFalse(tester.Contains(3)); //remove child node with one child.
            Assert.AreEqual(2, tester.OrderedList().Count);

            tester.Remove(4);
            Assert.IsFalse(tester.Contains(4)); // remove head node with one child.
            Assert.AreEqual(1, tester.OrderedList().Count);

            tester.Remove(1);
            Assert.IsFalse(tester.Contains(1)); // remove childless head node.
            Assert.AreEqual(0, tester.OrderedList().Count);

        }
    }
}
