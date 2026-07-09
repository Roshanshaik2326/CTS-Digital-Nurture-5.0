# Singleton Design Pattern

## Definition

Singleton is a Creational Design Pattern that ensures only one instance of a class exists throughout the application's lifetime.

## Why do we use it?

Some application components should exist only once.

Examples:

- Configuration Manager
- Logger
- Cache Manager
- Printer Spooler

## Characteristics

- Private Constructor
- Static Instance
- Public Static Method

## Advantages

- Saves memory
- Global access point
- Controlled object creation
- Easy maintenance

## Disadvantages

- Difficult to unit test
- Can introduce global state
- Thread safety must be considered

## Real-World Example

A college has only one Principal.

Every student and teacher communicates with the same Principal.

## Industry Usage

- ASP.NET Core Configuration
- Logging Services
- Memory Cache
- Configuration Manager

## Conclusion

Singleton ensures that exactly one object is created and shared across the entire application.