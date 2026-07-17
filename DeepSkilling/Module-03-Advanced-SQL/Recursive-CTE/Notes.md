# Recursive CTE

## Definition

A Recursive CTE repeatedly executes itself until a stopping condition is met.

It consists of two parts:

1. Anchor Query
2. Recursive Query

------------------------------------

Syntax

WITH RECURSIVE CTE_Name AS
(
    Anchor Query

    UNION ALL

    Recursive Query
)
SELECT *
FROM CTE_Name;

------------------------------------

Applications

• Employee Hierarchy

• Organization Chart

• Folder Structure

• Tree Traversal

• Bill of Materials

------------------------------------

Interview Questions

Q1. What are the two parts of a Recursive CTE?

Anchor Member and Recursive Member.

Q2. What prevents infinite recursion?

A termination condition.

Q3. Difference between CTE and Recursive CTE?

CTE executes once.

Recursive CTE executes repeatedly until the stopping condition is satisfied.