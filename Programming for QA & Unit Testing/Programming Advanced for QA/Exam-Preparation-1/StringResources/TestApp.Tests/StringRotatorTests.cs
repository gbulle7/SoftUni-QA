using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        string input = string.Empty;
        string expected = string.Empty;
        string actual = StringRotator.RotateRight(input, 1);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        string input = "hello";
        string expected = "hello";
        int positions = 0;
        string actual = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        string input = "hello";
        string expected = "lohel";
        int positions = 2;
        string actual = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        string input = "hello";
        string expected = "ohell";
        int positions = -1;
        string actual = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        string input = "hello";
        string expected = "llohe";
        int positions = 8;
        string actual = StringRotator.RotateRight(input, positions);
        Assert.AreEqual(expected, actual);
    }
}
