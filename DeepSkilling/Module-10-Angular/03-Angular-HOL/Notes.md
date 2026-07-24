# Angular Hands-On 3 Notes

## ngFor

Repeats HTML for every element inside an array.

Example

*ngFor="let course of courses"

---

## ngIf

Displays HTML only when a condition is true.

Example

*ngIf="course.available"

---

## ng-template

Alternative content when ngIf is false.

---

## Date Pipe

Formats JavaScript Date objects.

Example

{{ today | date:'fullDate' }}

---

## Currency Pipe

Formats currency values.

Example

{{ fee | currency:'INR' }}

---

## Uppercase Pipe

Converts text to uppercase.

Example

{{ name | uppercase }}

---

## Learning Outcome

Learned Angular structural directives and built-in pipes.