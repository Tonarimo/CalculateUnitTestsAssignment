using CalculateUnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass()]
    public class CalculationUnitTests
    {
        [TestMethod()]
        public void MultiplyPositiveDoublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = 10;
            double p2 = 5;
            double expectedNum = 50;

            cal.Multiply(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MultiplyAMaxDoubleWithAnotherDoubleGreaterThanOneThrowsArgumentOutOfRangeException()
        {
            Calculation cal = new Calculation();
            double p1 = double.MaxValue;
            double p2 = 3;
            //double expectedNum = 50;

            cal.Multiply(p1, p2);

            //Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void MultiplyOneNegativeAndOnePositiveDoubleToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -5;
            double p2 = 5;
            double expectedNum = -25;

            cal.Multiply(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void MultiplyTwoNegativeDoublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -5;
            double p2 = -15;
            double expectedNum = 75;

            cal.Multiply(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void DivideWithPositiveDoublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = 100;
            double p2 = 10;
            double expectedNum = 10;

            cal.Divide(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideByAZeroDoubleThrowsArgumentException()
        {
            Calculation cal = new Calculation();
            double p1 = 25;
            double p2 = 0;

            cal.Divide(p1, p2);

            //Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void DivideWithNegativeDloublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -18;
            double p2 = -2;
            double expectedNum = 9;

            cal.Divide(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void DivideWithAPositiveAndANegativeDoubleToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -300;
            double p2 = 25;
            double expectedNum = -12;

            cal.Divide(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void AddPositiveDoublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = 30;
            double p2 = 18;
            double expectedNum = 48;

            cal.Add(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void AddANegativeAndAPositiveDoubleToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -58;
            double p2 = 63;
            double expectedNum = 5;

            cal.Add(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void AddANegativeDoublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -42;
            double p2 = -12;
            double expectedNum = -54;

            cal.Add(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void SubtractPositiveDoublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = 20;
            double p2 = 15;
            double expectedNum = 5;

            cal.Subtract(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void SubtractANegativeAndAPositiveDoubleToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -12;
            double p2 = 8;
            double expectedNum = -20;

            cal.Subtract(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }

        [TestMethod()]
        public void SubtractNegativeDoublesToGetCalculatedResult()
        {
            Calculation cal = new Calculation();
            double p1 = -20;
            double p2 = -222;
            double expectedNum = 202;

            cal.Subtract(p1, p2);

            Assert.AreEqual(expectedNum, cal.calculatedResult);
        }
    }
}
