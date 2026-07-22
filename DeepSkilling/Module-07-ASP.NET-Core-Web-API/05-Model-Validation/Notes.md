# Model Validation Notes

## What is Model Validation?

Model Validation ensures that incoming data satisfies predefined rules before it is processed by the application.

---

## Why Validation?

Validation helps:

- Prevent invalid data
- Improve API reliability
- Reduce runtime errors
- Improve user experience

---

## Data Annotation Attributes

### Required

Ensures a value is provided.

Example

```csharp
[Required]
```

---

### StringLength

Limits the length of text.

```csharp
[StringLength(50)]
```

---

### Range

Restricts numeric values.

```csharp
[Range(18,30)]
```

---

### EmailAddress

Checks email format.

```csharp
[EmailAddress]
```

---

## ModelState

ModelState stores the validation result of the incoming request.

Example

```csharp
if (!ModelState.IsValid)
{
    return BadRequest(ModelState);
}
```

---

## HTTP Response

Valid Request

```
200 OK
```

Invalid Request

```
400 Bad Request
```

---

## Benefits

- Automatic validation
- Cleaner code
- Better API security
- Standardized error responses

---

## Summary

ASP.NET Core uses Data Annotations and ModelState to validate incoming data automatically. Validation ensures only correct and complete data reaches the application's business logic.