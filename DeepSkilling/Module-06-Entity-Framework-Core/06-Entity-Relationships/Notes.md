# Entity Relationships Notes

## What are Entity Relationships?

Entity relationships define how tables are connected in a relational database.

## Types of Relationships

### One-to-One

One record is associated with exactly one other record.

### One-to-Many

One parent record can have many child records.

Example:

Department → Employees

### Many-to-Many

Many records from one table relate to many records from another.

Example:

Students ↔ Courses

## Navigation Properties

Navigation properties allow moving between related entities.

Example:

Department

↓

Employees

Employee

↓

Department

## Foreign Key

A foreign key links one table to another.

Example:

DepartmentId

## Include()

Loads related data together with the main entity.

Example:

```csharp
context.Departments.Include(d => d.Employees)
```

## Summary

Entity relationships allow EF Core to represent relational database structures using C# classes and navigation properties.