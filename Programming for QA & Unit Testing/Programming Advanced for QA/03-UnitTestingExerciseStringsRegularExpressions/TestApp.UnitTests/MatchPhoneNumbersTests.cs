using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = "+35-2-124-5678, +359 2986 5432, +359-2-555 5555";

        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        string expected = "";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string phoneNumbers = string.Empty;

        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        string expected = string.Empty;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 986 5432, +35925555555";

        // Act
        string result = MatchPhoneNumbers.Match(phoneNumbers);
        string expected = "+359-2-124-5678";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
