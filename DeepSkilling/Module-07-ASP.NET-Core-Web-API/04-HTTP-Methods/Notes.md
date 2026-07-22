# HTTP Methods Notes

## HTTP Methods

HTTP methods define the action a client wants to perform on a resource.

### GET

Retrieves data from the server.

Example:

```
GET /api/product
```

---

### POST

Creates a new resource.

Example:

```
POST /api/product
```

Returns:

```
201 Created
```

---

### PUT

Updates an entire resource.

Example:

```
PUT /api/product/1
```

Returns:

```
204 No Content
```

---

### PATCH

Updates only specific fields of a resource.

Example:

```
PATCH /api/product/1/price
```

---

### DELETE

Deletes a resource.

Example:

```
DELETE /api/product/1
```

Returns:

```
204 No Content
```

---

## IActionResult Methods

- Ok()
- CreatedAtAction()
- NoContent()
- NotFound()
- BadRequest()

---

## REST Principle

Each HTTP method has a specific purpose:

- GET → Read
- POST → Create
- PUT → Replace
- PATCH → Modify
- DELETE → Remove

---

## Summary

HTTP methods are the foundation of RESTful APIs. ASP.NET Core provides attributes such as `[HttpGet]`, `[HttpPost]`, `[HttpPut]`, `[HttpPatch]`, and `[HttpDelete]` to map these operations to controller actions while returning appropriate HTTP status codes.