using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxNumberWithGenric;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumberWithGenric
{
    [TestClass]
    public class FindMaxTests
    {
        [TestMethod]
        public void Passing_Integer_Array_Should_Return_Maximum_Value()
        {
            /*string firstValue = "Carrot", secondValue = "Banana", thirdValue = "Apple";
            string expected = "Carrot";
            FindMax find = new FindMax();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);*/
            int[] intArray = { 10, 20, 30 };
            int expected = 30;
            FindMax<int> first = new FindMax<int>(intArray);
            int actual = first.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        //TC1.2
        [TestMethod]
        public void Passing_float_Array_Should_Return_Maximum_Valuee()
        {
            /*string firstValue = "Banana", secondValue = "Carrot", thirdValue = "Apple";
            string expected = "Carrot";
            FindMax find = new FindMax();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);*/
            float[] floatArray = { 10.5f, 20.5f, 30.5f };
            float expected = 30.5f;
            FindMax<float> secod = new FindMax<float>(floatArray);
            float actual = secod.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        //TC1.3
        [TestMethod]
        public void Passing_string_Array_Should_Return_Maximum_Value()
        {
/*            string firstValue = "Apple", secondValue = "Banana", thirdValue = "Carrot";
            string expected = "Carrot";
            FindMax find = new FindMax();
            string actual = find.MaximumStringNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);*/
             string[] strArray = { "10", "20", "30" };
            string expected = "30";
            FindMax<string> third = new FindMax<string>(strArray);
            string actual = third.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
    }
}