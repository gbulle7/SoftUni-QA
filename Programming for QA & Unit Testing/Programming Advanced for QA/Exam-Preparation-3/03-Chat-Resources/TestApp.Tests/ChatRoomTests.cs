using System;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        string sender = "Tom";
        string message = "Random message";
        string expectedDate = DateTime.Now.Date.ToString("d");
        string expected = $"Chat Room Messages:{Environment.NewLine}Tom: Random message - Sent at {expectedDate}";

        // Act
        _chatRoom.SendMessage(sender, message);
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        string expected = string.Empty;

        // Act
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string expectedDate = DateTime.Now.Date.ToString("d");

        string expected = $"Chat Room Messages:{Environment.NewLine}" +
                        $"Tom: Hello! - Sent at {expectedDate}{Environment.NewLine}" +
                        $"George: My name is George. - Sent at {expectedDate}{Environment.NewLine}" +
                        $"Jack: Good. - Sent at {expectedDate}";

        // Act
        _chatRoom.SendMessage("Tom", "Hello!");
        _chatRoom.SendMessage("George", "My name is George.");
        _chatRoom.SendMessage("Jack", "Good.");

        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.AreEqual(expected, actual);
    }
}