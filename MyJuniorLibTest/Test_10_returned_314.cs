using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestJuniorLib;

namespace MyJuniorLibTest
{
    [TestClass]
    public class Test_10_returned
    {
        [TestMethod]
        public void Test_10_returned_314()
        {
            //arrange
            double x = 10;

            double result = 314;

            //act
            ShapeCalculator ShCl = new ShapeCalculator();
            double actuall = ShCl.CalculateCircleArea(x);

            //assert
            Assert.AreEqual(result,actuall);

        }
    }
}
