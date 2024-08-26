using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long num = 11;
        long expected = 11;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long num = 32;
        long expected = 2;

        // Act
        long actual = PrimeFactor.FindLargestPrimeFactor(num);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
