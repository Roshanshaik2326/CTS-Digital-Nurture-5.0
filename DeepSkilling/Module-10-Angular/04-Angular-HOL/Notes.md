# Angular Hands-On 4 Notes

## Template-Driven Forms

Template-driven forms are created mainly inside HTML using Angular directives.

They are suitable for small and medium-sized forms.

---

## FormsModule

FormsModule enables template-driven forms.

Import:

```typescript
import { FormsModule } from '@angular/forms';
```

---

## ngModel

Synchronizes HTML controls with TypeScript variables.

Example

```html
<input [(ngModel)]="studentName">
```

---

## NgForm

Represents the complete form.

Example

```html
<form #enrollForm="ngForm">
```

---

## Validation

### Required

```html
required
```

### Minimum Length

```html
minlength="3"
```

### Email

```html
email
```

---

## Form States

Angular automatically applies:

- ng-valid
- ng-invalid
- ng-pristine
- ng-dirty
- ng-touched
- ng-untouched

These classes are useful for styling.

---

## Error Messages

Validation errors are displayed only after the control has been touched.

Example

```html
*ngIf="nameCtrl.touched && nameCtrl.errors?.['required']"
```

---

## Form Submission

The form is submitted using:

```typescript
onSubmit(form: NgForm)
```

The submitted values are available using:

```typescript
form.value
```

---

## Reset Form

The form is reset using:

```typescript
form.resetForm()
```

---

## Learning Outcome

Learned how to build Template-Driven Forms using Angular, perform validation, display error messages, submit forms, and reset form data.