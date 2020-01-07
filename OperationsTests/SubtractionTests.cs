using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 10;
        private readonly int b = 5;

        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(5, Subtraction.Subtract(a, b));
        }
    }
}