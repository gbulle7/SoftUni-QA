using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] chars = { '0', '1', 'a', 'b' };
        char[] expected = { 'a', 'b' };

        // Act
        char[] actual = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] chars = { 'a', 'b' };
        char[] expected = { 'a', 'b' };

        // Act
        char[] actual = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] chars = Array.Empty<char>();

        // Act
        char[] actual = Fake.RemoveStringNumbers(chars);

        // Assert
        Assert.AreEqual(chars, actual);
    }
}
