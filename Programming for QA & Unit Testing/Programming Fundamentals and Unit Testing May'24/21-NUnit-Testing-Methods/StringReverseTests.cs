using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        string expect = "";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expect, actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";
        string expect = "a";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expect, actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "cat";
        string expect = "tac";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expect, actual);
    }
}
