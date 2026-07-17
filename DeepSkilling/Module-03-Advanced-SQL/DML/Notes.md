# Data Manipulation Language (DML)

## Objective

Data Manipulation Language (DML) is used to manipulate the data stored inside database tables. Unlike DDL, which defines the database structure, DML focuses on inserting, retrieving, updating, and deleting records.

---

# DML Commands

## 1. INSERT

The `INSERT` statement is used to add new records into a table.

### Syntax

```sql
INSERT INTO table_name (column1, column2, ...)
VALUES (value1, value2, ...);
```

### Example

```sql
INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (1, 'HR');
```

---

## 2. SELECT

The `SELECT` statement retrieves data from one or more tables.

### Syntax

```sql
SELECT * FROM table_name;
```

### Example

```sql
SELECT * FROM Employees;
```

---

## 3. UPDATE

The `UPDATE` statement modifies existing records.

### Syntax

```sql
UPDATE table_name
SET column_name = value
WHERE condition;
```

### Example

```sql
UPDATE Employees
SET Salary = 80000
WHERE EmployeeID = 101;
```

---

## 4. DELETE

The `DELETE` statement removes records from a table.

### Syntax

```sql
DELETE FROM table_name
WHERE condition;
```

### Example

```sql
DELETE FROM Employees
WHERE EmployeeID = 104;
```

---

## 5. WHERE Clause

The `WHERE` clause filters rows based on a specified condition.

### Example

```sql
SELECT *
FROM Employees
WHERE Salary > 65000;
```

---

## 6. ORDER BY

The `ORDER BY` clause sorts query results in ascending or descending order.

### Ascending

```sql
SELECT *
FROM Employees
ORDER BY Salary ASC;
```

### Descending

```sql
SELECT *
FROM Employees
ORDER BY Salary DESC;
```

---

## 7. LIMIT

The `LIMIT` clause restricts the number of rows returned.

### Example

```sql
SELECT *
FROM Employees
LIMIT 3;
```

---

# Advantages of DML

- Allows insertion of new records.
- Updates existing information.
- Deletes unnecessary data.
- Retrieves data efficiently.
- Supports filtering and sorting.
- Essential for daily database operations.

---

# Difference Between DDL and DML

| DDL | DML |
|-----|-----|
| Defines database structure | Manipulates data |
| Uses CREATE, ALTER, DROP | Uses INSERT, UPDATE, DELETE, SELECT |
| Affects tables and schema | Affects records inside tables |
| Usually auto-committed | Can be committed or rolled back using transactions |

---

# Commands Practiced

- INSERT
- SELECT
- UPDATE
- DELETE
- WHERE
- ORDER BY
- LIMIT

---

# Conclusion

In this exercise, DML operations were performed on the `CompanyDB` database. Records were inserted into the `Departments` and `Employees` tables, updated, deleted, filtered, sorted, and retrieved using various SQL queries. These operations form the foundation for advanced SQL concepts such as Joins, Subqueries, Views, and Window Functions.