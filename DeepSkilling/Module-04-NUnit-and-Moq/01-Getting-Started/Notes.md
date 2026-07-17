# Getting Started with NUnit

## What is NUnit?

NUnit is an open-source unit testing framework for .NET applications.

It helps developers automatically test application code.

---------------------------------------

Common Attributes

[TestFixture]

Marks a class containing test methods.

[Test]

Marks a test method.

[SetUp]

Runs before every test.

[TearDown]

Runs after every test.

---------------------------------------

Assertions

Assert.That(actual, Is.EqualTo(expected));

Used to verify expected output.

---------------------------------------

Command

dotnet test

Runs all test cases.

---------------------------------------

Interview Questions

Q1. What is NUnit?

A unit testing framework for .NET.

Q2. Which command runs tests?

dotnet test

Q3. Which attribute marks a test method?

[Test]