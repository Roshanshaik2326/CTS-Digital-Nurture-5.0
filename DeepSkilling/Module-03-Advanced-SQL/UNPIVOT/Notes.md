# SQL UNPIVOT

## Definition

UNPIVOT converts columns into rows.

Unlike PIVOT, it reduces the number of columns and increases the number of rows.

MySQL does not support UNPIVOT directly.

Instead, we use UNION ALL.

----------------------------------------

SQL Server

UNPIVOT

↓

MySQL

UNION ALL

----------------------------------------

Advantages

• Data Normalization

• Data Cleaning

• Reporting

• Analytics

----------------------------------------

Interview Questions

Q1. Does MySQL support UNPIVOT?

No.

Q2. Which statement is used instead?

UNION ALL.

Q3. Difference between PIVOT and UNPIVOT?

PIVOT converts rows into columns.

UNPIVOT converts columns into rows.