using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDemo.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod]
        public void Test_IsWithinRange_LowerThanMin_ReturnsFalse()
        {
            // Arrange
            double min = 1.0;
            double max = 10.0;
            double numToCheck = 0;

            // Act
            bool result = Validator.IsWithinRange(min, max, numToCheck);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_IsWithinRange_HigherThanMax_ReturnsFalse()
        {
            // Arrange
            double min = 1.0;
            double max = 10.0;
            double numToCheck = 11;

            // Act
            bool result = Validator.IsWithinRange(min, max, numToCheck);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_IsWithinRange_EqualToMin_ReturnsTrue()
        {
            // Arrange
            double min = 1.0;
            double max = 10.0;
            double numToCheck = min;

            // Act
            bool result = Validator.IsWithinRange(min, max, numToCheck);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_IsWithinRange_EqualToMax_ReturnsTrue()
        {
            // Arrange
            double min = 1.0;
            double max = 10.0;
            double numToCheck = max;

            // Act
            bool result = Validator.IsWithinRange(min, max, numToCheck);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_IsWithinRange_BetweenBoundaries_ReturnsTrue()
        {
            // Arrange
            double min = 1.0;
            double max = 10.0;
            double numToCheck = 5.0;

            // Act
            bool result = Validator.IsWithinRange(min, max, numToCheck);

            // Assert
            Assert.IsTrue(result);
        }
    }
}