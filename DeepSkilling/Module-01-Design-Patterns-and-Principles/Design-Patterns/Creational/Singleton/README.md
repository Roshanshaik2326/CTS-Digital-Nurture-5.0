# Singleton Pattern

## Objective

Understand how the Singleton Design Pattern ensures only one object of a class exists.

---

## Problem Statement

Some application components should never have multiple instances.

Examples:

- Configuration Manager
- Logger
- Cache Manager

Creating multiple instances wastes memory and can lead to inconsistent application state.

---

## Solution

Singleton uses:

- Private Constructor
- Static Instance
- Public Static Method

to guarantee a single instance.

---

## Technologies Used

- C#
- .NET Console Application
- Object-Oriented Programming

---

## Files

- Program.cs
- Notes.md
- README.md
- Singleton-Output.png

---

## How to Run

```bash
dotnet restore
dotnet run
```

---

## Expected Output

```
Getting First Instance...

Configuration Manager Initialized.

===== Application Configuration =====
Application : Cognizant Digital Nurture
Version     : 1.0
Environment : Development

Getting Second Instance...

Result : Only ONE instance exists.
```

---

## Learning Outcome

- Understand Singleton Design Pattern
- Learn private constructors
- Learn static members
- Learn controlled object creation