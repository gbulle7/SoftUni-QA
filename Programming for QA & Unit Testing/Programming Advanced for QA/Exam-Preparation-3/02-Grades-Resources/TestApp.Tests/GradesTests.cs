using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> studentsWithGrades = new Dictionary<string, int>()
        {
            ["Ivan"] = 3,
            ["George"] = 6,
            ["Tom"] = 5,
        };
        string expected = $"George with average grade 6.00{Environment.NewLine}" +
                          $"Tom with average grade 5.00{Environment.NewLine}" +
                          $"Ivan with average grade 3.00";

        // Act 
        string actual = Grades.GetBestStudents(studentsWithGrades);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> studentsWithGrades = new Dictionary<string, int>();
        string expected = string.Empty;

        // Act 
        string actual = Grades.GetBestStudents(studentsWithGrades);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> studentsWithGrades = new Dictionary<string, int>()
        {
            ["Ivan"] = 3,
            ["George"] = 6,
        };
        string expected = $"George with average grade 6.00{Environment.NewLine}" +
                          $"Ivan with average grade 3.00";

        // Act 
        string actual = Grades.GetBestStudents(studentsWithGrades);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> studentsWithGrades = new Dictionary<string, int>()
        {
            ["Ivan"] = 6,
            ["George"] = 6,
            ["Tom"] = 6,
            ["Brady"] = 6,
        };
        string expected = $"Brady with average grade 6.00{Environment.NewLine}" +
                          $"George with average grade 6.00{Environment.NewLine}" +
                          $"Ivan with average grade 6.00";

        // Act 
        string actual = Grades.GetBestStudents(studentsWithGrades);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
