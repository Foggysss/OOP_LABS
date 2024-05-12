using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestClass()]
    public class RationalNumbTests
    {
        [TestMethod()]
        public void TestOne()
        {
            RationalNumb first = new RationalNumb(2, 3);
            Assert.IsTrue(first.ToString() == "2/3");
        }
        [TestMethod()]
        public void TestTwo()
        {
            RationalNumb first = new RationalNumb(2, 5);
            RationalNumb second = new RationalNumb(7, 3);
            Assert.IsTrue((first * second) == new RationalNumb(14, 15));
        }
        [TestMethod()]
        public void TestThree()
        {
            RationalNumb first = new RationalNumb(5, 3);
            RationalNumb second = new RationalNumb(6, 9);
            Assert.IsTrue(first > second);
        }
    }
}