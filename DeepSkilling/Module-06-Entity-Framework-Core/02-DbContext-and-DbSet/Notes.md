# DbContext and DbSet Notes

## What is DbContext?

DbContext is the primary class in Entity Framework Core that manages database connections and operations.

Responsibilities:

- Database Connection
- CRUD Operations
- Change Tracking
- Query Execution
- Saving Changes

Example:

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
}

--------------------------------------------

## What is DbSet?

DbSet represents a database table.

Example:

DbSet<Student> Students

Students table

↓

Student Objects

--------------------------------------------

## Entity

An Entity is a C# class mapped to a database table.

Example:

Student

↓

Students Table

Properties become Columns.

--------------------------------------------

## Connection String

Example:

Server=localhost,1433;
Database=StudentDB;
User Id=sa;
Password=********;
TrustServerCertificate=True;

--------------------------------------------

## Code First Workflow

Create Entity

↓

Create DbContext

↓

Configure Connection

↓

Migration

↓

Database Created

--------------------------------------------

## Advantages

- Strong Type Safety
- Easy CRUD
- Automatic Table Creation
- LINQ Support
- Better Maintainability

--------------------------------------------

## Summary

DbContext manages the database connection while DbSet represents database tables. Together they form the foundation of Entity Framework Core applications.