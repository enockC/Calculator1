using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        
        private readonly int a = 20;
        private readonly int b = 10;
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(200, Multiplication.Multiply(a, b));
        }
    }
}