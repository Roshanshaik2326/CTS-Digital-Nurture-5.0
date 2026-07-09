# Factory Method Pattern

## Definition

Factory Method is a Creational Design Pattern that creates objects without exposing the object creation logic to the client.

## Why use Factory Method?

Instead of creating objects directly using the `new` keyword, object creation is delegated to a factory.

## Components

- Product Interface
- Concrete Products
- Factory Class
- Client

## Advantages

- Loose coupling
- Easy to extend
- Better maintainability
- Centralized object creation

## Disadvantages

- More classes
- Slightly increased complexity

## Real-World Example

An e-commerce application creates different payment objects based on the selected payment method.

## Industry Usage

- Database Providers
- Payment Gateways
- Notification Services
- Report Generation