using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
        //Assert.AreEqual(string.Empty, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] numbers = { 42 };
        //int[] numbers2 = new int[1];
        //numbers2[0] = 42;
        //int[] numbers3 = new int[1] { 42 };
        //int[] numbers4 = new int[] { 42 };

        // Act
        string result = Reverse.ReverseArray(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        int[] numbers = new[] { 1, 2, -3 };
        string actual = Reverse.ReverseArray(numbers);
        Assert.AreEqual("-3 2 1", actual);
    }
}
