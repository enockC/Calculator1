using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{

    public class SquarerootingTests
    {
        private readonly int a = 144;


        [TestMethod()]
        public void SquarerootTest()
        {
            Assert.AreEqual(12, Squarerooting.Squareroot(a));
        }
    }
}