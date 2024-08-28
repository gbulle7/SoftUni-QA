using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        string input = string.Empty;
        string[] expected = Array.Empty<string>();
        string[] actual = CsvParser.ParseCsv(input);
        Assert.AreEqual(expected, actual);
        // Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        string input = "random";
        string[] expected = { "random" };
        string[] actual = CsvParser.ParseCsv(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        string input = "random, string";
        string[] expected = { "random", "string" };
        string[] actual = CsvParser.ParseCsv(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        string input = "    random,   string, with,   white spaces    ";
        string[] expected = { "random", "string", "with", "white spaces" };
        string[] actual = CsvParser.ParseCsv(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}
