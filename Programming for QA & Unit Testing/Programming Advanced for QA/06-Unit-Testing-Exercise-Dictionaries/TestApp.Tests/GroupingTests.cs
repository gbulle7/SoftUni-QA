using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 3, 4, 2, 6, 1 };

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo($"Odd numbers: 3, 1{Environment.NewLine}Even numbers: 4, 2, 6"));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 8, 4, 2, 6 };

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo($"Even numbers: 8, 4, 2, 6"));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        {
            // Arrange
            List<int> input = new List<int> { 5, 3, 1 };

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo($"Odd numbers: 5, 3, 1"));
        }

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        {
            // Arrange
            List<int> input = new List<int> { -3, -4, -2, -6, -1 };

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo($"Odd numbers: -3, -1{Environment.NewLine}Even numbers: -4, -2, -6"));
        }
    }
}
