# Core Unit Testing Techniques

## TestCase Attribute

[TestCase] allows the same test method to run with different inputs.

Example

[TestCase(2,3,5)]
[TestCase(10,20,30)]

-------------------------------------

Advantages

• Reduces duplicate code

• Easier maintenance

• Better test coverage

-------------------------------------

Assertions Used

Assert.That()

Is.EqualTo()

-------------------------------------

Interview Questions

Q1. What is TestCase?

Runs the same test multiple times with different data.

Q2. Why use parameterized tests?

To avoid writing repetitive test methods.

Q3. What is the advantage of TestCase?

Improves code reusability and increases test coverage.