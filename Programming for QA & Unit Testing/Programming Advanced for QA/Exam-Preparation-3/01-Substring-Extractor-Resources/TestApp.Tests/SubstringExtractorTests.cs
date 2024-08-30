using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        string input = "This is a string.";
        string startMarker = "is";
        string endMarker = "in";
        string expected = " is a str";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "This is a string.";
        string startMarker = "it";
        string endMarker = "in";
        string expected = "Substring not found";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        string input = "This is a string.";
        string startMarker = "is";
        string endMarker = "it";
        string expected = "Substring not found";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        string input = "This is a string.";
        string startMarker = "hi ";
        string endMarker = "it";
        string expected = "Substring not found";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        Assert.AreEqual(expected, result);
    }

    [TestCase(null)]
    [TestCase("")]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage(string input)
    {
        // Arrange
        string startMarker = "#";
        string endMarker = "$";
        string expected = "Substring not found";

        // Act
        string actual = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        string input = "This is a string.";
        string startMarker = "str";
        string endMarker = "str";
        string expected = "Substring not found";
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);
        Assert.AreEqual(expected, result);
    }
}
