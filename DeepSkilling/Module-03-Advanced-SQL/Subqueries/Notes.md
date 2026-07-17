# Subqueries Notes

## What is a Subquery?

A subquery is a query inside another SQL query.

Syntax:

SELECT column_name
FROM table_name
WHERE column_name = (
    SELECT column_name
    FROM table_name
);

----------------------------------------

## Types of Subqueries

### 1. Single Row Subquery
Returns exactly one value.

Example:
Find employees earning more than the average salary.

----------------------------------------

### 2. Multiple Row Subquery
Returns multiple values.

Uses:
- IN
- ANY
- ALL

----------------------------------------

### 3. Correlated Subquery
Executed once for every row of the outer query.

----------------------------------------

### 4. EXISTS
Returns TRUE if the subquery returns at least one row.

----------------------------------------

### 5. NOT EXISTS
Returns TRUE if the subquery returns no rows.

----------------------------------------

### 6. Scalar Subquery
Returns a single value and can be used in the SELECT clause.

----------------------------------------

## Interview Questions

Q1. Difference between JOIN and Subquery?

JOIN combines tables.
Subquery uses the result of one query inside another.

Q2. What is a Correlated Subquery?

A subquery executed once for every row processed by the outer query.

Q3. When should EXISTS be used?

When checking whether matching rows exist.

Q4. Difference between IN and EXISTS?

IN compares values.

EXISTS checks whether rows exist.

----------------------------------------

## Key Points

✔ Nested Query
✔ Can return single or multiple rows
✔ Can be used with SELECT, UPDATE, DELETE
✔ Frequently asked in interviews