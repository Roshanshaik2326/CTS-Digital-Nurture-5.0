# Fundamentals of Unit Testing

## Unit Testing

Unit testing verifies that an individual unit of code works correctly.

-------------------------------------

AAA Pattern

Arrange

Prepare test data.

Act

Execute the method.

Assert

Verify expected output.

-------------------------------------

Common Assertions

Assert.That(value, Is.EqualTo())

Assert.That(value, Is.True)

Assert.That(value, Is.False)

Assert.Throws<Exception>()

-------------------------------------

SetUp

Runs before every test.

Used to initialize objects.

-------------------------------------

Interview Questions

Q1. What is the AAA pattern?

Arrange, Act and Assert.

Q2. What is SetUp?

A method executed before every test.

Q3. How do you test exceptions?

Using Assert.Throws().