# Transactions

## Definition
A transaction is a sequence of SQL statements executed as a single unit of work.

## Commands

### START TRANSACTION
Begins a transaction.

### COMMIT
Permanently saves all changes.

### ROLLBACK
Undoes all changes since the transaction started.

### SAVEPOINT
Creates a checkpoint inside a transaction.

### ROLLBACK TO SAVEPOINT
Reverts only to the specified savepoint.

## ACID Properties

- Atomicity
- Consistency
- Isolation
- Durability

## Uses

- Banking systems
- Online payments
- E-commerce orders
- Inventory management