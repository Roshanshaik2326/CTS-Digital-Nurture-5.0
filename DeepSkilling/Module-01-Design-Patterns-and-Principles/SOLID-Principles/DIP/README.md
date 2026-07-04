# Dependency Inversion Principle (DIP)

## Objective

Understand how high-level modules can depend on abstractions instead of concrete implementations.

## Problem

Directly depending on concrete classes makes applications difficult to extend and maintain.

## Solution

Use interfaces to decouple high-level and low-level modules.

## Project Structure

- IMessageService
- EmailService
- SmsService
- Notification

## Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming

## How to Run

```bash
dotnet restore
dotnet run
```

## Output

Add `DIP-Output.png` after running the program.