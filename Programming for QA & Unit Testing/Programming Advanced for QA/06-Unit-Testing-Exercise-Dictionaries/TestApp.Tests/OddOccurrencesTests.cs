using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();
        string expected = string.Empty;

        // Act
        string result = OddOccurrences.FindOdd(input);

        //
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "test", "test" };
        string expected = string.Empty;

        // Act
        string result = OddOccurrences.FindOdd(input);

        //
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "test2" };
        string expected = "test2";

        // Act
        string result = OddOccurrences.FindOdd(input);

        //
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "test", "test2" };
        string expected = "test test2";

        // Act
        string result = OddOccurrences.FindOdd(input);

        //
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "apple", "banana", "Apple", "apPle", "Banana", "BANANA" };
        string expected = "apple banana";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
