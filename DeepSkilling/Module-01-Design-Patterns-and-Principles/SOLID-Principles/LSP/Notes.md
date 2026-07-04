# Liskov Substitution Principle (LSP)

## Definition

Objects of a derived class should be replaceable with objects of the base class without affecting program correctness.

## Purpose

Ensure inheritance does not break application behavior.

## Advantages

- Better inheritance design
- Prevents runtime errors
- Improves maintainability

## Real-world Example

Birds

Sparrow → Can fly

Penguin → Cannot fly

Do not force Penguin to implement flying.

## Industry Example

Interfaces are used to separate capabilities instead of forcing unnecessary behavior through inheritance.

## Key Takeaway

Use inheritance only when the child truly behaves like the parent.