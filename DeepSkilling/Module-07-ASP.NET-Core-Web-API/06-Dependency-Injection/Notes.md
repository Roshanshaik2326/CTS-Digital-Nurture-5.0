# Dependency Injection Notes

## What is Dependency Injection?

Dependency Injection (DI) is a design pattern that provides required objects to a class instead of allowing the class to create them directly.

---

## Why Use DI?

- Loose coupling
- Easier testing
- Better maintainability
- Reusable services
- Cleaner architecture

---

## Interface

An interface defines a contract that a service must implement.

Example

```csharp
public interface IEmployeeService
{
    List<Employee> GetEmployees();
}
```

---

## Service

A service contains the business logic of the application.

---

## Constructor Injection

Dependencies are provided through the controller constructor.

```csharp
public EmployeeController(IEmployeeService employeeService)
{
    this.employeeService = employeeService;
}
```

---

## Registering Services

```csharp
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
```

---

## Service Lifetimes

### Singleton

One instance for the entire application.

### Scoped

One instance per HTTP request.

### Transient

New instance every time it is requested.

---

## Summary

Dependency Injection is one of the core features of ASP.NET Core. It promotes loose coupling by separating business logic into services and letting the framework automatically provide dependencies to controllers.