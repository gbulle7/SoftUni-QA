using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PlanetTests
{
    // TODO: finish test
    private Planet planet;

    [SetUp]
    public void SetUp()
    {
        planet = new Planet("Earth", 12742, 149600000, 1);
    }

    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(planet.Diameter / 2, 2);

        // Act
        double actualGravity = planet.CalculateGravity(mass);

        // Assert
        Assert.That(actualGravity, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        //Аrrange
        //string expectedInfo = $"Planet: {planet.Name}"
        //                    + Environment.NewLine
        //                    + $"Diameter: {planet.Diameter} km"
        //                    + Environment.NewLine
        //                    + $"Distance from the Sun: {planet.DistanceFromSun} km"
        //                    + Environment.NewLine
        //                    + $"Number of Moons: {planet.NumberOfMoons}";
        string expectedInfo = $"Planet: Earth"
                            + Environment.NewLine
                            + $"Diameter: 12742 km"
                            + Environment.NewLine
                            + $"Distance from the Sun: 149600000 km"
                            + Environment.NewLine
                            + $"Number of Moons: 1";

        //Act
        string resultInfo = planet.GetPlanetInfo();

        //Assert
        Assert.That(resultInfo, Is.EqualTo(expectedInfo));
    }
}
