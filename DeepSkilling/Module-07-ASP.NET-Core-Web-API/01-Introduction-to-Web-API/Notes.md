# ASP.NET Core Web API Notes

## What is ASP.NET Core Web API?

ASP.NET Core Web API is a framework used to create HTTP services that can be accessed by web applications, mobile apps, desktop applications, and other services.

It enables communication between clients and servers using REST principles.

---

# Why Web APIs?

Web APIs allow different applications to exchange data over the internet.

Example

Mobile App

↓

Web API

↓

Database

---

# Advantages

- Cross Platform
- High Performance
- Lightweight
- Open Source
- RESTful Architecture
- Built-in Dependency Injection
- Easy JSON Support
- Swagger Integration

---

# Client-Server Architecture

Client

↓

HTTP Request

↓

Web API

↓

Database

↓

HTTP Response

↓

Client

---

# What is REST?

REST stands for

Representational State Transfer

REST is an architectural style used to build web services.

Characteristics

- Stateless
- Client-Server
- Cacheable
- Uniform Interface
- Layered System

---

# HTTP Methods

GET

Retrieve data.

POST

Create new data.

PUT

Update existing data.

PATCH

Partially update data.

DELETE

Delete data.

---

# HTTP Status Codes

200 OK

Request successful.

201 Created

Resource created successfully.

400 Bad Request

Invalid request.

401 Unauthorized

Authentication required.

404 Not Found

Resource not found.

500 Internal Server Error

Unexpected server error.

---

# JSON

JSON (JavaScript Object Notation) is the standard format for exchanging data in Web APIs.

Example

```json
{
    "id": 1,
    "name": "Roshan",
    "department": "CSE"
}
```

---

# Controller

Controllers receive HTTP requests and return HTTP responses.

Example

```csharp
[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
}
```

---

# Routing

Routing maps URLs to controller actions.

Example

```
/api/hello
```

---

# IActionResult

Represents the HTTP response returned by an API action.

Common Methods

- Ok()
- Created()
- BadRequest()
- NotFound()
- NoContent()

---

# Swagger

Swagger is an interactive API documentation and testing tool.

Benefits

- API Documentation
- Test Endpoints
- View Request/Response
- Simplifies Development

---

# Project

HelloAPI

Features

- GET Endpoint
- Controller
- Routing
- Swagger Testing

---

# Summary

ASP.NET Core Web API is Microsoft's framework for building modern RESTful APIs. It enables communication between applications using HTTP and JSON, provides built-in support for controllers, routing, dependency injection, and integrates with Swagger for API testing and documentation.