using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TestApp.UnitTests;

public class PersonTests
{
    // TODO: write the setup method
    private Person _person;

    [SetUp]
    public void SetUp()
    {
        _person = new Person();
    }

    // TODO: finish test
    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new List<Person>()
        {
            new Person()
            {
                Name = "Alice",
                Id = "A001",
                Age = 35
            },

            new Person()
            {
                Name = "Bob",
                Id = "B002",
                Age = 30
            }
        };

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(resultPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < resultPeopleList.Count; i++)
        {
            Assert.That(resultPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(resultPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(resultPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        string[] peopleData = { "Alice A001 35", "Bob B002 30" };
        string expected = "Bob with ID: B002 is 30 years old."
                          + Environment.NewLine
                          + "Alice with ID: A001 is 35 years old.";

        // Act
        List<Person> resultPeopleList = this._person.AddPeople(peopleData);
        string result = _person.GetByAgeAscending(resultPeopleList);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

        //Method 2
        ////Arrange
        //List<Person> people = new List<Person>()
        //{
        //    new Person()
        //    {
        //        Name = "Alice",
        //        Id = "A001",
        //        Age = 35
        //    },
        //    new Person ()
        //    {
        //        Name = "Bob",
        //        Id = "B002",
        //        Age = 30
        //    }
        //};

        //string expected = "Bob with ID: B002 is 30 years old."
        //                  + Environment.NewLine
        //                  + "Alice with ID: A001 is 35 years old.";

        ////Act
        //string result = person.GetByAgeAscending(people);

        ////Assert
        //Assert.That(result, Is.EqualTo(expected));
    }
}
