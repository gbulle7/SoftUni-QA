using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        Dictionary<string, int> inputDict = new Dictionary<string, int> { { "apple", 2 } };
        string inputFruit = "apple";
        int expectedQuantity = 2;
        int result = Fruits.GetFruitQuantity(inputDict, inputFruit);
        Assert.That(result, Is.EqualTo(expectedQuantity));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        Dictionary<string, int> inputDict = new Dictionary<string, int> { { "apple", 2 } };
        string inputFruit = "banana";
        int expectedQuantity = 0;
        int result = Fruits.GetFruitQuantity(inputDict, inputFruit);
        Assert.That(result, Is.EqualTo(expectedQuantity));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        {
            Dictionary<string, int> inputDict = new Dictionary<string, int> { };
            string inputFruit = "apple";
            int expectedQuantity = 0;
            int result = Fruits.GetFruitQuantity(inputDict, inputFruit);
            Assert.That(result, Is.EqualTo(expectedQuantity));
        }
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        {
            Dictionary<string, int>? inputDict = null;
            string inputFruit = "apple";
            int expectedQuantity = 0;
            int result = Fruits.GetFruitQuantity(inputDict, inputFruit);
            Assert.That(result, Is.EqualTo(expectedQuantity));
        }
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        {
            Dictionary<string, int> inputDict = new Dictionary<string, int> { { "apple", 2 } };
            string inputFruit = null!;
            int expectedQuantity = 0;
            int result = Fruits.GetFruitQuantity(inputDict, inputFruit);
            Assert.That(result, Is.EqualTo(expectedQuantity));
        }
    }
}
