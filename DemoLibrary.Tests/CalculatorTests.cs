using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            // Arrange
            double expected = 5;
            double a = 3;
            double b = 2;

            // Act
            double actual = Calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}