using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string input = "this is a random text";
        string[] bannedWords = new string[] { "blabla", "no"};
        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string input = "this is a random text";
        string[] bannedWords = new string[] { "is", "text"};
        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo("th** ** a random ****"));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string input = "this is a random text";
        string[] bannedWords = new string[] { };
        //string[] bannedWords = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string input = "this is a random text";
        string[] bannedWords = new string[] { " " };
        //string[] bannedWords = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(bannedWords, input);

        // Assert
        Assert.That(result, Is.EqualTo("this*is*a*random*text"));
    }
}
