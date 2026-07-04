# Interface Segregation Principle (ISP)

## Definition

Clients should not be forced to depend on methods they do not use.

## Purpose

Split large interfaces into smaller, more specific interfaces.

## Advantages

- Better flexibility
- Easier maintenance
- Avoids unnecessary implementations
- Promotes clean architecture

## Real-world Example

Restaurant Employees

Chef → Cooks

Cashier → Takes Payments

Cleaner → Cleans

Each employee performs only the required tasks.

## Industry Example

ASP.NET Core uses many small interfaces like:

- ILogger
- IDisposable
- IConfiguration
- IHostedService

Each interface has a focused responsibility.

## Key Takeaway

Many small interfaces are better than one large interface.