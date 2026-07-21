# Entity Framework Core - Complete Notes

## What is Entity Framework Core?

Entity Framework Core (EF Core) is Microsoft's lightweight, open-source Object Relational Mapper (ORM) for .NET applications.

It allows developers to interact with relational databases using C# objects rather than writing SQL queries manually.

---

## Advantages of EF Core

- Faster Development
- Cross Platform
- Supports LINQ
- Automatic CRUD Operations
- Code-First & Database-First Approaches
- Easy Database Migration
- Strong Type Safety
- Improved Productivity

---

# ORM (Object Relational Mapper)

ORM maps C# classes to database tables.

Example

Class

Student

↓

Database Table

Students

Properties become table columns.

---

# DbContext

DbContext acts as the bridge between the application and the database.

Responsibilities

- Tracks Entity Changes
- Executes SQL
- Saves Changes
- Manages Database Connections

---

# DbSet

Represents a database table.

Example

```csharp
public DbSet<Student> Students { get; set; }
```

---

# Code First Approach

Steps

1. Create Entity Class
2. Create DbContext
3. Add Migration
4. Update Database

Commands

```bash
dotnet ef migrations add InitialCreate

dotnet ef database update
```

---

# CRUD Operations

## Create

```csharp
context.Students.Add(student);
context.SaveChanges();
```

---

## Read

```csharp
context.Students.ToList();
```

---

## Update

```csharp
student.Name = "Roshan";
context.SaveChanges();
```

---

## Delete

```csharp
context.Students.Remove(student);
context.SaveChanges();
```

---

# LINQ Queries

## Where()

Filters data.

```csharp
.Where(s => s.Age > 20)
```

---

## FirstOrDefault()

Returns the first matching record.

---

## OrderBy()

Ascending order.

---

## OrderByDescending()

Descending order.

---

## Select()

Returns selected columns.

---

## Count()

Returns total number of records.

---

## Any()

Checks if records exist.

---

# Entity Relationships

## One-to-One

One record relates to one record.

Example

Employee ↔ Passport

---

## One-to-Many

One parent has multiple child records.

Example

Department → Employees

---

## Many-to-Many

Many records relate to many records.

Example

Students ↔ Courses

---

# Navigation Properties

Allow navigation between related entities.

Example

Department

↓

Employees

Employee

↓

Department

---

# Foreign Key

Links two tables.

Example

DepartmentId

---

# Include()

Loads related entities.

```csharp
context.Departments.Include(d => d.Employees);
```

---

# Repository Pattern

Provides an abstraction layer between business logic and database access.

Benefits

- Cleaner Code
- Better Testing
- Reusability
- Maintainability
- Separation of Concerns

---

# Mini Project

Retail Inventory Management System

Features

- Add Products
- Display Products
- Search Products
- Update Prices
- Delete Products

Concepts Used

- DbContext
- DbSet
- LINQ
- CRUD
- SQL Server
- Code First

---

# Best Practices

- Use Repository Pattern
- Keep DbContext Lightweight
- Use LINQ Instead of Raw SQL
- Apply Migrations Carefully
- Use Navigation Properties
- Validate Data Before Saving

---

# Summary

Entity Framework Core is a powerful ORM that simplifies database programming in .NET applications. It enables developers to work with databases using C# classes, supports Code-First development, LINQ querying, CRUD operations, relationships, and enterprise design patterns such as the Repository Pattern.