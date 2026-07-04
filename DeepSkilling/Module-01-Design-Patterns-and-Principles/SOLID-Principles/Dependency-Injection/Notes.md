# Dependency Injection (DI)

## Definition

Dependency Injection is a design pattern that supplies required objects (dependencies) from outside a class instead of letting the class create them.

## Purpose

- Reduce coupling
- Increase flexibility
- Improve testing
- Improve maintainability

## Types of Dependency Injection

1. Constructor Injection ✅ (Most Common)
2. Property Injection
3. Method Injection

## Advantages

- Loose coupling
- Easy unit testing
- Easy maintenance
- Better scalability

## Real-world Example

Food Delivery

Customer doesn't cook food.

Restaurant provides it.

Similarly, dependencies are provided from outside.

## Industry Example

ASP.NET Core has a built-in Dependency Injection container.

Services are registered in Program.cs.

Example:

builder.Services.AddScoped<IEmployeeService, EmployeeService>();

Then injected automatically into Controllers.