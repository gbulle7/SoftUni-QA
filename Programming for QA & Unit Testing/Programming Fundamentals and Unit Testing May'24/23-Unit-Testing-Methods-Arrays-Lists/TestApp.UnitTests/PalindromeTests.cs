using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> wordsList = new() { "aha", "sos" };

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsTrue(result);
        
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> wordsList = new() { "lol" };

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> wordsList = new() { "nope" };

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> wordsList = new() { "Heh", "rWawR" };

        // Act
        bool result = Palindrome.IsPalindrome(wordsList);

        // Assert
        Assert.IsTrue(result);
    }
}
