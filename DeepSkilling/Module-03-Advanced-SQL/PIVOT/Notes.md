# SQL PIVOT

## Definition

PIVOT converts rows into columns.

MySQL does not provide a built-in PIVOT operator.

Instead, we use CASE statements with aggregate functions.

-----------------------------------------

SQL Server

PIVOT

↓

MySQL

CASE + SUM()
CASE + COUNT()
CASE + MAX()

-----------------------------------------

Advantages

• Reports

• Dashboards

• Cross Tab Reports

• Data Analysis

-----------------------------------------

Interview Questions

Q1. Does MySQL support PIVOT?

No.

Q2. How is PIVOT implemented in MySQL?

Using CASE expressions with aggregate functions.