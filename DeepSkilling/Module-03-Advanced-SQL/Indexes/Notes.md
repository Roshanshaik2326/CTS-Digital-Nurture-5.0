# SQL Indexes

## Definition

An Index is a database object that improves the speed of data retrieval operations.

Indexes are created on one or more columns.

-----------------------------------------

Advantages

• Faster searching

• Faster sorting

• Faster joins

• Better query performance

-----------------------------------------

Disadvantages

• Requires extra storage

• Slows INSERT, UPDATE and DELETE operations

-----------------------------------------

Types

1. Primary Index
2. Unique Index
3. Composite Index
4. Clustered Index (SQL Server)
5. Non-Clustered Index

-----------------------------------------

Syntax

CREATE INDEX index_name
ON table(column);

CREATE UNIQUE INDEX index_name
ON table(column);

DROP INDEX index_name
ON table;

-----------------------------------------

Interview Questions

Q1. Why do we use indexes?

To improve query performance.

Q2. Can a table have multiple indexes?

Yes.

Q3. Does an index speed up INSERT?

No. It slightly slows INSERT because the index must also be updated.