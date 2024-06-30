using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int input = 0;
        int expect = 1;

        // Act
        int actual = Factorial.CalculateFactorial(input);

        // Assert
        Assert.AreEqual(expect, actual);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        int input = 5;
        int expect = 120;
        int actual = Factorial.CalculateFactorial(input);
        Assert.AreEqual(expect, actual);
    }
}
