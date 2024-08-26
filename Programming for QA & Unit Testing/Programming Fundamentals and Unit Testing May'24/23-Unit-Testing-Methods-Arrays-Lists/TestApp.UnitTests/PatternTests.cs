using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] numbers = { 1, 2, 1, 3, 4, 10, 12, 15 };
        int[] expected = { 1, 15, 2, 12, 3, 10, 4 };

        // Act
        int[] actual = Pattern.SortInPattern(numbers);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actual = Pattern.SortInPattern(numbers);

        // Assert
        Assert.AreEqual(numbers, actual);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] numbers = { 15 };

        // Act
        int[] actual = Pattern.SortInPattern(numbers);

        // Assert
        Assert.AreEqual(numbers, actual);
    }
}
