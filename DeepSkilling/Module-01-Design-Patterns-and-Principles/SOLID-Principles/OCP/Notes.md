# Open/Closed Principle (OCP)

## Definition

Software entities should be open for extension but closed for modification.

## Purpose

Add new functionality without changing existing code.

## Advantages

- Easy to maintain
- Easy to extend
- Reduces bugs
- Promotes abstraction and polymorphism

## Real-world Example

A smartphone allows you to install new applications without modifying the operating system.

## Industry Example

In ASP.NET Core, Middleware and Dependency Injection allow applications to be extended without modifying framework code.

## Key Takeaway

Extend existing behavior through inheritance, interfaces, or composition instead of modifying tested code.