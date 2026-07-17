# Moq

## What is Moq?

Moq is a popular .NET mocking framework used in unit testing.

It creates fake implementations of interfaces and classes.

-------------------------------------

Why use Moq?

• Avoid database dependency

• Avoid API dependency

• Faster testing

• Isolated unit tests

-------------------------------------

Common Methods

Mock<T>()

Creates a mock object.

Setup()

Defines method behavior.

Returns()

Specifies the return value.

Object

Gets the mocked object.

-------------------------------------

Interview Questions

Q1. What is Moq?

A mocking framework for .NET.

Q2. Why is mocking used?

To isolate dependencies during unit testing.

Q3. What does Setup() do?

Defines the expected behavior of a mocked method.

Q4. What is mock.Object?

It returns the mocked implementation to be used by the class under test.