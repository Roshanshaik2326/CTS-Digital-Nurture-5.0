using NUnit.Framework;

namespace NUnitDemo;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(10, 20);

        // Assert
        Assert.That(result, Is.EqualTo(30));
    }
}