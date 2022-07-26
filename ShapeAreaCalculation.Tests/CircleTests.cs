using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ShapeAreaCalculation.Tests
{
    public class CircleTests
    {
        [Test]
        public void Test_CircleCantExist_InputNegativParameter_ReturnsNegativeOne()
        {
            // Arrange
            var testList = new List<double>(){-1};
            var circle = new Circle(testList);

            //Act
            var testResult = circle.CalculateArea();

            //Assert
            Assert.False(circle.CanExist);
            Assert.True(testResult == -1);
        }

        [Test]
        public void Test_CircleCantExist_InputNoParameters_ReturnsNegativeOne()
        {
            // Arrange
            var testList = new List<double>();
            var circle = new Circle(testList);

            //Act
            var testResult = circle.CalculateArea();

            //Assert
            Assert.False(circle.CanExist);
            Assert.True(testResult == -1);
        }

        [Test]
        public void Test_CircleCantExist_InputNull_ReturnsNegativeOne()
        {
            // Arrange
            var circle = new Circle(null);

            //Act
            var testResult = circle.CalculateArea();

            //Assert
            Assert.False(circle.CanExist);
            Assert.True(testResult == -1);
        }

        [Test]
        public void Test_CircleCantExist_InputZero_ReturnsNegativeOne()
        {
            // Arrange
            var testList = new List<double>(){0};
            var circle = new Circle(testList);

            //Act
            var testResult = circle.CalculateArea();

            //Assert
            Assert.False(circle.CanExist);
            Assert.True(testResult == -1);
        }

        [Test]
        public void Test_CircleCantExist_InputValidParameter_ReturnsExpectedResult()
        {
            // Arrange
            var testList = new List<double>() { 2 };
            var circle = new Circle(testList);
            double expectedResult = 12.56637;

            //Act
            var testResult = Math.Round( circle.CalculateArea(),5);

            //Assert
            Assert.True(circle.CanExist);
            Assert.AreEqual(expectedResult,testResult);
        }
    }
}