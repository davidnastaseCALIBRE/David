using System;
using DavidMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ProgramRunTest()
        {
            string[] holder = new string[1];
            Program.Main(holder);
        }
    }
}
