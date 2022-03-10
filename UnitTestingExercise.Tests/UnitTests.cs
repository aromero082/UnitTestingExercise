using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        private IEnumerable<char> expected;

        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5,5,5,15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5,10,-5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Substract(minuend, subtrhend);


            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5,4,20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20,5,4)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void GetTesla()
        {
            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var  actual = tester.GetTesla();

            //Assert
            Assert.Equal(expected, actual);
           

        }

        [Fact]
        public void GetHello()
        {
            //Arrange
            var tester2 = new UnitTestMethods();


            //Act
            var actual = tester2.GetHello();

            //Assert
            Assert.Equal("Hello", expected);
            
        }
    }
}
