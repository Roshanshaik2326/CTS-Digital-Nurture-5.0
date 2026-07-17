# SQL MERGE (MySQL)

## Definition

SQL Server provides the MERGE statement to perform INSERT, UPDATE, and DELETE in a single statement.

MySQL does not support MERGE.

Instead, MySQL uses:

INSERT ... ON DUPLICATE KEY UPDATE

This is called an UPSERT operation.

--------------------------------------

Syntax

INSERT INTO table(...)
VALUES(...)
ON DUPLICATE KEY UPDATE
column=value;

--------------------------------------

Advantages

• Insert if record does not exist

• Update if record already exists

• Single statement

• Faster synchronization

--------------------------------------

Interview Questions

Q1. Does MySQL support MERGE?

No.

Q2. Which command replaces MERGE in MySQL?

INSERT ... ON DUPLICATE KEY UPDATE

Q3. What is UPSERT?

Insert if absent, otherwise update.