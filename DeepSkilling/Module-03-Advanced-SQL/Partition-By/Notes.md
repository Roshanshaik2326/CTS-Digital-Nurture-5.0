# PARTITION BY

## Definition

PARTITION BY divides rows into groups before applying a window function.

Unlike GROUP BY, it does not combine rows.

-----------------------------------

Syntax

SELECT
column,
SUM(column)
OVER(PARTITION BY column)
FROM table;

-----------------------------------

Advantages

• Department-wise calculations

• Running totals

• Average Salary

• Employee Analytics

• Reporting

-----------------------------------

Difference

GROUP BY

✔ Returns one row per group

PARTITION BY

✔ Returns every row
✔ Adds calculated values to each row

-----------------------------------

Interview Questions

Q1. Difference between GROUP BY and PARTITION BY?

GROUP BY reduces rows.

PARTITION BY keeps all rows.

Q2. Can PARTITION BY be used without OVER()?

No.