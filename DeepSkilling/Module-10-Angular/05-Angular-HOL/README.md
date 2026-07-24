# HOL 5 – Reactive Forms in Angular

## Objective

Implement a Reactive Form for student enrollment using Angular Reactive Forms.

## Features Implemented

- Created ReactiveEnrollmentFormComponent
- Configured routing to `/enroll-reactive`
- Used FormBuilder to create a FormGroup
- Implemented built-in validators
  - Required
  - Min Length
  - Email
  - RequiredTrue
- Implemented a custom validator to reject course IDs starting with "XX"
- Implemented an asynchronous email validator
- Used FormArray to dynamically add and remove additional courses
- Displayed validation messages
- Disabled submit button until the form becomes valid

## Technologies Used

- Angular 20
- TypeScript
- Reactive Forms
- Angular Router

## Learning Outcome

Learned how Reactive Forms provide better scalability, maintainability, and validation compared to Template-Driven Forms.