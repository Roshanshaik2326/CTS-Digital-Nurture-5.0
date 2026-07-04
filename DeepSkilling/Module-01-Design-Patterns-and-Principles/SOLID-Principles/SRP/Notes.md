# Single Responsibility Principle (SRP)

## Definition

A class should have only one responsibility or one reason to change.

## Why use SRP?

- Easier to maintain
- Easier to test
- Better code organization
- Reduces coupling
- Improves readability

## Real-World Example

A restaurant has different people for different responsibilities:

- Chef → Cooking
- Cashier → Billing
- Delivery Person → Delivery

Each person performs one responsibility.

## Industry Example

In ASP.NET Core applications:

- Controller → Handles HTTP requests
- Service → Contains business logic
- Repository → Handles database operations

Each class has a single responsibility.

## Key Takeaway

One class = One responsibility.