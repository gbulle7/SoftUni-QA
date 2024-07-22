using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> numbers = new() { 11 };

        // Act
        int expected = 11;
        int actual = MaxNumber.FindMax(numbers);
        
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new() { 11, 1, 21 };

        // Act
        int expected = 21;
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new() { -3, -12, -1 ,-34 };

        // Act
        int expected = -1;
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new() { 11, 2, -3, -31, 12 };

        // Act
        int expected = 12;
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new() { 11, 11, 4, 12, 13, 14, 14 };

        // Act
        int expected = 14;
        int actual = MaxNumber.FindMax(numbers);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
