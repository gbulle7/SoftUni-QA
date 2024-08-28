using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        string taskTitle = "Task1";
        DateTime taskDate = DateTime.Parse("02.01.2025");
        string expected = "[ ] Task1 - Due: 01/02/2025";

        _toDoList.AddTask(taskTitle, taskDate);
        string result = _toDoList.DisplayTasks();

        Assert.That(result.Contains(expected), Is.True);
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        string taskName = "Task1";
        DateTime dueDate = DateTime.Parse("02.01.2025");

        string expectedTextForAddedAndCompletedTask = "[✓] Task1 - Due: 01/02/2025";

        _toDoList.AddTask(taskName, dueDate);
        _toDoList.CompleteTask(taskName);

        string result = _toDoList.DisplayTasks(); //получавам всички задачи в списъка

        Assert.That(result.Contains(expectedTextForAddedAndCompletedTask), Is.True);
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        string taskTitle = "Task1";
        DateTime taskDate = DateTime.Parse("02.01.2025");
 
        _toDoList.AddTask(taskTitle, taskDate);
        
        string result = _toDoList.DisplayTasks();

        Assert.That(() => _toDoList.CompleteTask("Task2"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        string result = _toDoList.DisplayTasks();

        Assert.That(result, Is.EqualTo("To-Do List:"));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        //Arrange
        string firstTaskName = "First Task";
        DateTime firstTaskDueDate = DateTime.Parse("01.01.2025");

        string secondTaskName = "Second Task";
        DateTime secondTaskDueDate = DateTime.Parse("02.02.2025");

        string expected = "To-Do List:" + System.Environment.NewLine
            + "[✓] First Task - Due: 01/01/2025" + System.Environment.NewLine
            + "[ ] Second Task - Due: 02/02/2025";

        //Act
        _toDoList.AddTask(firstTaskName, firstTaskDueDate);
        _toDoList.AddTask(secondTaskName, secondTaskDueDate);
        _toDoList.CompleteTask(firstTaskName);

        string result = _toDoList.DisplayTasks();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
