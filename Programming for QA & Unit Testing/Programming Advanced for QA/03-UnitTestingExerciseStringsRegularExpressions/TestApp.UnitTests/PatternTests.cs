using NUnit.Framework;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("test 11", 2, "tEsT 11tEsT 11")]
    [TestCase("123", 1, "123")]
    [TestCase("asd", 3, "aSdaSdaSd")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input,
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    private void GeneratePatternedStringTest()
    {
        Pattern.GeneratePatternedString(string.Empty, 3);
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // With lambda anonymous function
        //var expected = Pattern.GeneratePatternedString(string.Empty, 3);
        //Assert.That(() => expected, Throws.ArgumentException);

        var exception = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(string.Empty, 3));
        Assert.AreEqual("Input string cannot be empty, and repetition factor must be positive.", exception.Message);

        // With private void method
        //var exception = Assert.Throws<ArgumentException>(GeneratePatternedStringTest);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString("abc", -1));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString("abc", 0));
    }
}
