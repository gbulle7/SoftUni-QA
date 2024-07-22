using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> list = new() { 2 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> newList = new() { 1, 2 };

        // Act
        List<int> result = GaussTrick.SumPairs(newList);
        List<int> list = new() { 3 };

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> newList = new() { 1, 2, 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(newList);
        List<int> list = new() { 4, 2 };

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> newList = new() { 10, 5, 3, 6, 12, 21 };

        // Act
        List<int> result = GaussTrick.SumPairs(newList);
        List<int> list = new() { 31, 17, 9 };

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> newList = new() { 1, 2, 3, 11, 4, 2, 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(newList);
        List<int> list = new() { 4, 4, 7, 11 };

        // Assert
        CollectionAssert.AreEqual(list, result);
    }
}
