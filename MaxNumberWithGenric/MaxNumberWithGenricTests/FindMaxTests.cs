using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxNumberWithGenric;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumberWithGenric.Tests
{
    [TestClass]
    public class FindMaxTests
    {
        [TestMethod]
        public void Maximum_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Carrot", secondValue = "Banana", thirdValue = "Apple";
            string expected = "Carrot";
            FindMax find = new FindMax();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Banana", secondValue = "Carrot", thirdValue = "Apple";
            string expected = "Carrot";
            FindMax find = new FindMax();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            string firstValue = "Apple", secondValue = "Banana", thirdValue = "Carrot";
            string expected = "Carrot";
            FindMax find = new FindMax();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }
}