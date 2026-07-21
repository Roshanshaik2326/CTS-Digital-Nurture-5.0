# CRUD Operations Notes

## CRUD

CRUD stands for:

- Create
- Read
- Update
- Delete

These are the four basic operations performed on a database.

---

## Create

```csharp
context.Students.Add(student);
context.SaveChanges();
```

Adds a new record to the database.

---

## Read

```csharp
var students = context.Students.ToList();
```

Retrieves all records from the Students table.

---

## Update

```csharp
student.Department = "Information Technology";
context.SaveChanges();
```

Modifies an existing record.

---

## Delete

```csharp
context.Students.Remove(student);
context.SaveChanges();
```

Deletes a record from the database.

---

## SaveChanges()

Persists all pending changes to the database.

---

## Summary

Entity Framework Core simplifies CRUD operations by allowing developers to work with C# objects instead of writing SQL queries.