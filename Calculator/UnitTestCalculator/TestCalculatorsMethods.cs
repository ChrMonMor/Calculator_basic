using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class TestCalculatorsMethods
    {
        [TestMethod]
        public void TestMethodAdds()
        {

            //-- Arrange
            double a = 5;
            double b = 5;
            double expected = 10;

            //-- Act
            var actaul = Program.Adds(a, b);

            //-- Assert
            Assert.AreEqual(expected, actaul);
        }
        [TestMethod]
        public void TestMethodSubtracks()
        {

            //-- Arrange
            double a = 5;
            double b = 5;
            double expected = 0;

            //-- Act
            var actaul = Program.Subtracks(a, b);

            //-- Assert
            Assert.AreEqual(expected, actaul);
        }
        [TestMethod]
        public void TestMethodDivides()
        {

            //-- Arrange
            double a = 5;
            double b = 5;
            double expected = 1;

            //-- Act
            var actaul = Program.Divides(a, b);

            //-- Assert
            Assert.AreEqual(expected, actaul);
        }
        [TestMethod]
        public void TestMethodMultiples()
        {

            //-- Arrange
            double a = 5;
            double b = 5;
            double expected = 25;

            //-- Act
            var actaul = Program.Multiples(a, b);

            //-- Assert
            Assert.AreEqual(expected, actaul);
        }
        [TestMethod]
        public void TestMethodCheckForEndIsTrue()
        {
            //-- Arrange
            string a = "ewqe";

            //-- Act
            var actaul = Program.CheckForEnd(a);

            //-- Assert
            Assert.IsTrue(actaul);
        }
        [TestMethod]
        public void TestMethodCheckForEndIsFalse()
        {
            //-- Arrange
            string a = "y";

            //-- Act
            var actaul = Program.CheckForEnd(a);

            //-- Assert
            Assert.IsFalse(actaul);
        }
        [TestMethod]
        public void TestMethodToThePowerOf()
        {

            //-- Arrange
            double a = 5;
            double b = 2;
            double expected = 25;

            //-- Act
            var actaul = Program.ToThePowerOf(a, b);

            //-- Assert
            Assert.AreEqual(expected, actaul);
        }
        [TestMethod]
        public void TestMethodModulus()
        {

            //-- Arrange
            double a = 5;
            double b = 2;
            double expected = 1;

            //-- Act
            var actaul = Program.Modulus(a, b);

            //-- Assert
            Assert.AreEqual(expected, actaul);
        }
    }
}
