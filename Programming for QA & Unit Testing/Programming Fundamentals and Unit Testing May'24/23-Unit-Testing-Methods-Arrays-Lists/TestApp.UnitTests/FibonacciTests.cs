using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int number = 0;

        // Act
        int actual = Fibonacci.CalculateFibonacci(number);

        // Assert
        Assert.AreEqual(number, actual);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int number = 3;
        int expected = 2;

        // Act
        int actual = Fibonacci.CalculateFibonacci(number);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}