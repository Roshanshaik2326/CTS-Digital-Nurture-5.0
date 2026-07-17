using NUnit.Framework;

namespace CoreUnitTestingDemo;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Multiply(int a, int b) => a * b;

    public bool IsPositive(int number) => number > 0;
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

    [TestCase(10, 20, 30)]
    [TestCase(5, 5, 10)]
    [TestCase(-5, 5, 0)]
    [TestCase(100, 200, 300)]
    public void Add_TestCases(int a, int b, int expected)
    {
        Assert.That(calculator.Add(a, b), Is.EqualTo(expected));
    }

    [TestCase(2, 3, 6)]
    [TestCase(5, 5, 25)]
    [TestCase(7, 8, 56)]
    public void Multiply_TestCases(int a, int b, int expected)
    {
        Assert.That(calculator.Multiply(a, b), Is.EqualTo(expected));
    }

    [TestCase(10, true)]
    [TestCase(-10, false)]
    [TestCase(0, false)]
    public void IsPositive_TestCases(int number, bool expected)
    {
        Assert.That(calculator.IsPositive(number), Is.EqualTo(expected));
    }
}