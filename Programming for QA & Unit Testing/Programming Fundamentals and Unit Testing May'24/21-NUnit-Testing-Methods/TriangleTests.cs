using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        int input = 0;
        string expect = "";
        string actual = Triangle.PrintTriangle(input);
        Assert.AreEqual(expect, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        int input = 3;
        string expect = "1\r\n1 2\r\n1 2 3\r\n1 2\r\n1";
        string actual = Triangle.PrintTriangle(input);
        Assert.AreEqual(expect, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        int input = 5;
        string expect = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4\r\n1 2 3 4 5\r\n1 2 3 4\r\n1 2 3\r\n1 2\r\n1";
        string actual = Triangle.PrintTriangle(input);
        Assert.AreEqual(expect, actual);
    }
}
