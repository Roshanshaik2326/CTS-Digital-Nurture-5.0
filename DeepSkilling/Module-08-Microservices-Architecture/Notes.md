# Module 08 Notes

## What is a Microservice?

A Microservice is an independently deployable service that performs a single business function. Multiple microservices communicate through APIs to form a complete application.

### Characteristics

- Independent Deployment
- Loose Coupling
- High Scalability
- Fault Isolation
- Technology Independent

---

# JWT (JSON Web Token)

JWT is a compact and secure token used for Authentication and Authorization.

A JWT consists of three parts:

1. Header
2. Payload
3. Signature

Example

xxxxx.yyyyy.zzzzz

---

# Authentication

Authentication verifies the identity of a user.

Example:

Username + Password

↓

JWT Token Generated

---

# Authorization

Authorization determines what resources a user can access.

Example

Admin → Full Access

User → Limited Access

---

# JWT Authentication Flow

Client

↓

Login API

↓

JWT Generated

↓

Client stores Token

↓

Client sends Token in Authorization Header

↓

Protected API validates Token

↓

Response

---

# Advantages of JWT

- Stateless Authentication
- Secure
- Compact
- Easy to Scale
- Widely Supported

---

# HTTP Authorization Header

Authorization: Bearer <JWT Token>

---

# Important Classes

- JwtBearerDefaults
- JwtSecurityToken
- JwtSecurityTokenHandler
- SigningCredentials
- SymmetricSecurityKey
- TokenValidationParameters

---

# Namespace Used

Microsoft.AspNetCore.Authentication.JwtBearer

Microsoft.IdentityModel.Tokens

System.IdentityModel.Tokens.Jwt

---

# Applications

- Banking APIs
- E-commerce Platforms
- Social Media Applications
- Cloud Applications
- Enterprise Applications