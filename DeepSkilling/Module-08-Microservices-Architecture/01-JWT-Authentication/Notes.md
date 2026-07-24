# Exercise Notes

## JWT

JSON Web Token is a secure token used to authenticate users.

## Workflow

User Login

↓

Validate Credentials

↓

Generate JWT

↓

Return Token

↓

Client stores Token

↓

Client sends Token with every request

↓

Server validates Token

↓

Access Granted

## Authentication Middleware

The middleware validates incoming JWT tokens before allowing access to secured endpoints.

## Benefits

- Stateless
- Secure
- Fast
- Scalable