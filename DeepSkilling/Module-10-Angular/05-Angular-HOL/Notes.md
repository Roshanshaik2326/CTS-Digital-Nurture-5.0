# HOL 5 Notes – Reactive Forms

## Reactive Forms

Reactive Forms are model-driven forms where the form structure is created inside the TypeScript file.

Advantages

- Better validation
- Easier testing
- Dynamic controls
- Suitable for large applications
- More scalable than Template-Driven Forms

---

## Important Classes

### FormBuilder

Creates forms with less code.

Example

this.fb.group({})

---

### FormGroup

Represents the complete form.

Example

studentForm = this.fb.group({...})

---

### FormControl

Represents one input field.

Example

new FormControl('')

---

### FormArray

Stores a dynamic collection of controls.

Useful when users can add multiple values.

---

## Validators Used

- Validators.required
- Validators.minLength()
- Validators.email
- Validators.requiredTrue

---

## Custom Validator

Used to reject Course IDs beginning with XX.

---

## Async Validator

Checks whether an email already exists.

Returns a Promise after a simulated delay.

---

## Form Methods

- addCourse()
- removeCourse()
- onSubmit()

---

## Route

/enroll-reactive

---

## Outcome

Successfully created a complete Reactive Form with synchronous validation, asynchronous validation, and dynamic FormArray controls.