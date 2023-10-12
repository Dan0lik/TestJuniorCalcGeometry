using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestJuniorLib;
using System;

namespace MyJuniorLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_3_4_5_returned_6()
        {
            //arrange
            double arg1 = 3;
            double arg2 = 4;
            double arg3 = 5;

            double result = 6;

            //act
            ShapeCalculator ShCl = new ShapeCalculator();
            double actuall = ShCl.ChekingRightTriangle(arg1,arg2,arg3);

            //assert
            Assert.AreEqual(result, actuall);
        }
    }
}
