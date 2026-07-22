# Swagger and API Documentation Notes

## What is Swagger?

Swagger is a set of tools that helps developers design, document, and test REST APIs.

---

## What is OpenAPI?

OpenAPI is the specification used to describe REST APIs. Swagger implements this specification.

---

## Why Swagger?

- Automatic API documentation
- Interactive API testing
- Better developer experience
- Easy integration with client applications

---

## Swagger UI

Swagger UI provides a browser-based interface where users can:

- View endpoints
- Send requests
- Inspect responses
- Understand request and response models

---

## Swagger Configuration

```csharp
builder.Services.AddSwaggerGen();
```

Enables Swagger generation.

---

## Swagger Middleware

```csharp
app.UseSwagger();

app.UseSwaggerUI();
```

Displays the interactive documentation page.

---

## API Metadata

Swagger supports metadata such as:

- Title
- Version
- Description
- Contact Information

This information is displayed at the top of the documentation page.

---

## Benefits

- Simplifies API testing
- Generates live documentation
- Reduces dependency on external testing tools
- Helps frontend and backend teams collaborate

---

## Summary

Swagger is an essential tool for ASP.NET Core Web API development. It automatically generates interactive API documentation based on your code, making APIs easier to understand, test, and maintain.