# Dependency Inversion Principle (DIP)

## Definition

High-level modules should not depend on low-level modules.
Both should depend on abstractions.

## Purpose

Reduce coupling between classes.

## Advantages

- Flexible
- Easy to extend
- Easy to test
- Promotes loose coupling

## Real-world Example

A TV works with any HDMI-compatible device without changing the TV itself.

## Industry Example

ASP.NET Core uses interfaces extensively for services, repositories, and logging.

## Key Takeaway

Depend on interfaces, not concrete classes.