using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace ShapeAreaCalculation.Tests
{
    internal class TriangleTests
    {
        private static readonly object[] _TestCasesInputNegativeNumber = GenerateTestCasesInputNegativeNumber();

        private static object[] GenerateTestCasesInputNegativeNumber()
        {
            var testCases = new List<object>();
            testCases.Add(new List<double>() { -1, 1, 1 });
            testCases.Add(new List<double>() { 1, -1, 1 });
            testCases.Add(new List<double>() { 1, 1, -1 });
            testCases.Add(new List<double>() { 1, -1, -1 });
            testCases.Add(new List<double>() { -1, -1, -1 });

            return testCases.ToArray();
        }

        [Test]
        [TestCaseSource(nameof(_TestCasesInputNegativeNumber))]
        public void Test_TriangleCantExist_InputNegativParameter_ReturnsNegativeOne(List<double> tasteCase)
        {
            // Arrange
            var triangle = new Triangle(tasteCase);

            //Act
            var testResult = triangle.CalculateArea();

            //Assert
            Assert.False(triangle.canExist);
            Assert.True(testResult == -1);
        }

        private static readonly object[] _TestCasesInputZero = GenerateTestCasesInputZero();

        private static object[] GenerateTestCasesInputZero()
        {
            var testCases = new List<object>();
            testCases.Add(new List<double>() { 1, 1, 0 });
            testCases.Add(new List<double>() { 1, 0, 1 });
            testCases.Add(new List<double>() { 1, 1, 0 });
            testCases.Add(new List<double>() { 1, 0, 0 });
            testCases.Add(new List<double>() { 0, 0, 0 });

            return testCases.ToArray();
        }

        [Test]
        [TestCaseSource(nameof(_TestCasesInputZero))]

        public void Test_TriangleCantExist_InputZero_ReturnsNegativeOne(List<double> tasteCase)
        {
            // Arrange
            var triangle = new Triangle(tasteCase);

            //Act
            var testResult = triangle.CalculateArea();

            //Assert
            Assert.False(triangle.canExist);
            Assert.True(testResult == -1);
        }

        [Test]
        public void Test_TriangleCantExist_InputNoParameters_ReturnsNegativeOne()
        {
            // Arrange
            var testList = new List<double>();
            var triangle = new Triangle(testList);

            //Act
            var testResult = triangle.CalculateArea();

            //Assert
            Assert.False(triangle.canExist);
            Assert.True(testResult == -1);
        }

        [Test]
        public void Test_TriangleCantExist_InputNull_ReturnsNegativeOne()
        {
            // Arrange
            var triangle = new Triangle(null);

            //Act
            var testResult = triangle.CalculateArea();

            //Assert
            Assert.False(triangle.canExist);
            Assert.True(testResult == -1);
        }

        [Test]
        public void Test_InputRightTriangleValidParameter_ReturnsExpectedResult()
        {
            // Arrange
            var testList = new List<double>(){3,4,5};
            var triangle = new Triangle(testList);
            double expectedResult = 6;

            //Act
            var testResult = triangle.CalculateArea();

            //Assert
            Assert.True(triangle.canExist);
            Assert.AreEqual(expectedResult, testResult);
        }

        [Test]
        public void Test_InputTriangleValidParameter_ReturnsExpectedResult()
        {
            // Arrange
            var testList = new List<double>() { 1, 1, 1 };
            var triangle = new Triangle(testList);
            double expectedResult = 0.4330127018922193;

            //Act
            var testResult = triangle.CalculateArea();

            //Assert
            Assert.True(triangle.canExist);
            Assert.AreEqual(expectedResult, testResult);
        }

        [Test]
        public void Test_InputRightTriangle_ExpectedIsRightIsTrue()
        {
            // Arrange
            var testList = new List<double>() { 3, 4, 5 };
            var triangle = new Triangle(testList);
            
            //Assert
            Assert.True(triangle.IsRight);
        }

        [Test]
        public void Test_InputNoTRightTriangle_ExpectedIsRightIsFalse()
        {
            // Arrange
            var testList = new List<double>() { 1, 1, 1 };
            var triangle = new Triangle(testList);

            //Assert
            Assert.False(triangle.IsRight);
        }

        [Test]
        public void Test_InputNonexistedTriangleParameters_ReturnsNegativeOne()
        {
            // Arrange
            var testList = new List<double>() { 1, 4, 1 };
            var triangle = new Triangle(testList);
            
            //Act
            var testResult = triangle.CalculateArea();

            //Assert
            Assert.False(triangle.canExist);
            Assert.True(testResult == -1);
        }
    }
}
