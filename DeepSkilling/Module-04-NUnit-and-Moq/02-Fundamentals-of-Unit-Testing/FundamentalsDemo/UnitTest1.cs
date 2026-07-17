using NUnit.Framework;

namespace FundamentalsDemo;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public bool IsEven(int number) => number % 2 == 0;

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return a / b;
    }
}

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        int a = 10;
        int b = 20;

        // Act
        int result = calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(30));
    }

    [Test]
    public void IsEven_ShouldReturnTrue()
    {
        Assert.That(calculator.IsEven(8), Is.True);
    }

    [Test]
    public void IsEven_ShouldReturnFalse()
    {
        Assert.That(calculator.IsEven(9), Is.False);
    }

    [Test]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
    }
}