# Entity Framework Core Notes

## Definition

Entity Framework Core (EF Core) is Microsoft's modern Object Relational Mapper (ORM) used for interacting with relational databases through C# objects.

Instead of writing SQL queries manually, developers perform database operations using C# classes and LINQ.

---

# What is ORM?

ORM (Object Relational Mapping) is a technique that maps database tables to C# classes.

Example:

Database Table

Students

↓

Entity Class

Student.cs

↓

Database Records become C# Objects

---

# Features of EF Core

- Lightweight
- Open Source
- Cross Platform
- High Performance
- LINQ Support
- Automatic Change Tracking
- Migrations
- Relationship Mapping
- Dependency Injection Support

---

# EF Core Workflow

Entity Classes

↓

DbContext

↓

Database Provider

↓

SQL Server Database

---

# Development Approaches

## Code First

- Create C# classes
- Generate database automatically
- Uses Migrations

## Database First

- Existing database
- Generate C# models from database

---

# Advantages

- Less SQL coding
- Better maintainability
- Strong type checking
- Faster development
- Easy CRUD operations
- Better productivity

---

# Packages Used

Microsoft.EntityFrameworkCore.SqlServer

Provides SQL Server support for EF Core.

Microsoft.EntityFrameworkCore.Tools

Provides migration and database update tools.

---

# Applications

- Enterprise Applications
- E-Commerce Systems
- Inventory Management
- Banking Applications
- Hospital Management Systems
- Student Management Systems

---

# Summary

Entity Framework Core is a modern ORM that simplifies database programming in .NET applications by mapping C# classes to database tables and allowing developers to perform database operations using LINQ and C# instead of writing raw SQL queries.