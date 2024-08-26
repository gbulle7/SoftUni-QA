using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
            // Arrange
            int[] numbers = new[] { 1, 2, 3 };
            int[] expected = new[] { 1, 2, 3 };

            // Act
            int[] result = Duplicates.RemoveDuplicates(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new[] { 1, 2, 3, 1, 3, 4 };
        int[] expected = new[] { 1, 2, 3, 4 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = new[] { 5, 5, 5, 5, 5, 5 };
        int[] expected = new[] { 5 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
