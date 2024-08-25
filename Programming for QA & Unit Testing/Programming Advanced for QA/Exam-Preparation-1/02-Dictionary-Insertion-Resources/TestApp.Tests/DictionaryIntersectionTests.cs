using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> input1 = new Dictionary<string, int>();
        Dictionary<string, int> input2 = new Dictionary<string, int>();
        Dictionary<string, int> expected = new Dictionary<string, int>();
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> input1 = new Dictionary<string, int>();
        Dictionary<string, int> input2 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
        Dictionary<string, int> expected = new Dictionary<string, int>();
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> input1 = new Dictionary<string, int> { { "c", 1}, { "d", 2} };
        Dictionary<string, int> input2 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
        Dictionary<string, int> expected = new Dictionary<string, int>();
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        Dictionary<string, int> input1 = new Dictionary<string, int> { { "a", 1 }, { "b", 3 } };
        Dictionary<string, int> input2 = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
        Dictionary<string, int> expected = new Dictionary<string, int> { { "a", 1 } };
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> input1 = new Dictionary<string, int> { { "a", 1 }, { "b", 3 } };
        Dictionary<string, int> input2 = new Dictionary<string, int> { { "a", 4 }, { "b", 2 } };
        Dictionary<string, int> expected = new Dictionary<string, int> {};
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);
        Assert.AreEqual(expected, actual);
    }
}
