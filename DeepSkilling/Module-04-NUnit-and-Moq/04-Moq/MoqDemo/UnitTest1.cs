using Moq;
using NUnit.Framework;

namespace MoqDemo;

// Interface
public interface IMessageService
{
    string GetMessage();
}

// Class depending on the interface
public class Greeting
{
    private readonly IMessageService _messageService;

    public Greeting(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public string Greet()
    {
        return _messageService.GetMessage();
    }
}

[TestFixture]
public class GreetingTests
{
    [Test]
    public void Greet_ShouldReturnMockMessage()
    {
        // Arrange
        var mockService = new Mock<IMessageService>();

        mockService
            .Setup(x => x.GetMessage())
            .Returns("Hello from Moq!");

        var greeting = new Greeting(mockService.Object);

        // Act
        var result = greeting.Greet();

        // Assert
        Assert.That(result, Is.EqualTo("Hello from Moq!"));
    }
}