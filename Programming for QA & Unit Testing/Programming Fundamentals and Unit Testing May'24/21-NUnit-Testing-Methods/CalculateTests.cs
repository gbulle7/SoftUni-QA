using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Subtraction(9, 3);

        // Assert
        Assert.That(6, Is.EqualTo(actual), "Subtraction did not work properly.");
    }

    [TestCase(5, 5, 10)]
    [TestCase(0, 5, 5)]
    [TestCase(5, 0, 5)]
    [TestCase(0, 0, 0)]
    [TestCase(-10, 5, -5)]
    [TestCase(-10, 0, -10)]
    public void Test_Addition(int a, int b, int expected)
    {
        // Arrange
        Calculate calculator = new Calculate();

        // Act
        int actual = calculator.Addition(a, b);

        // Assert
        Assert.That(expected, Is.EqualTo(actual), "Addition did not work properly.");
    }
}
