# Dependency Injection (DI)

## Objective

Understand how dependencies can be injected into a class instead of being created inside it.

## Problem

Creating dependencies inside a class leads to tight coupling and makes testing difficult.

## Solution

Use Constructor Injection to receive dependencies from outside the class.

## Project Structure

- IMessageService
- EmailService
- SmsService
- NotificationManager

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

Add `DI-Output.png` after running the project.