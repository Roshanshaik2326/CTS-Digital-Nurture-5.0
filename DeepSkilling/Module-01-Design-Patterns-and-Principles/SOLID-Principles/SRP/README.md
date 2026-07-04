# Single Responsibility Principle (SRP)

## Objective

Implement the **Single Responsibility Principle (SRP)**, the first principle of SOLID.

## Definition

A class should have **only one responsibility** or **one reason to change**.

## Problem

When a class performs multiple responsibilities, it becomes difficult to maintain, test, and extend.

## Solution

Separate each responsibility into its own class.

## Project Structure

- `Invoice` → Business logic
- `InvoiceRepository` → Database operations
- `InvoicePrinter` → Printing operations

## Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming

## Expected Output

```
Total Amount: 1000
Invoice saved to database.
Invoice printed successfully.

```


## Output

![Program Output](SRP_Output.png)