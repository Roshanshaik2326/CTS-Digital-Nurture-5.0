# Module 05 - Logging Frameworks

## Introduction

Logging is the process of recording events that occur during the execution of an application. It helps developers monitor system behavior, identify issues, and troubleshoot problems efficiently.

---

# Importance of Logging

- Helps identify bugs and errors
- Simplifies debugging
- Monitors application health
- Maintains audit trails
- Supports performance analysis
- Improves software maintenance

---

# Common Logging Levels

| Level | Purpose |
|--------|---------|
| Trace | Very detailed diagnostic information |
| Debug | Information useful during development |
| Information | General application events |
| Warning | Potential issues that do not stop execution |
| Error | Errors affecting application functionality |
| Critical/Fatal | Severe failures that may terminate the application |

---

# Logging Frameworks Covered

## 1. Log4Net

- Apache logging framework
- XML-based configuration
- Supports multiple appenders
- Suitable for enterprise applications

### Features

- Console logging
- File logging
- Database logging
- Email logging

---

## 2. NLog

- Open-source .NET logging framework
- Easy configuration
- High performance
- Multiple logging targets

### Features

- Console Target
- File Target
- Database Target
- Event Log Target

---

## 3. Serilog

- Structured logging framework
- Modern .NET applications
- Rich formatting support
- Multiple sinks

### Common Sinks

- Console
- File
- SQL Server
- Seq
- Elasticsearch
- Azure

---

# Logging Best Practices

- Use appropriate logging levels.
- Write meaningful log messages.
- Avoid logging sensitive information.
- Log exceptions with complete details.
- Rotate log files regularly.
- Monitor logs continuously.
- Store logs securely.

---

# Advantages of Logging

- Faster debugging
- Better monitoring
- Easier maintenance
- Improved application reliability
- Supports auditing
- Helps identify performance issues

---

# Interview Questions

### 1. What is logging?

Logging is the process of recording application events during execution.

### 2. Why is logging important?

It helps monitor applications, debug issues, and maintain software effectively.

### 3. Name three popular .NET logging frameworks.

- Log4Net
- NLog
- Serilog

### 4. What is structured logging?

Structured logging stores log information in a structured format, making it easier to search and analyze.

### 5. What are common logging levels?

Trace, Debug, Information, Warning, Error, and Critical/Fatal.

### 6. What is an Appender in Log4Net?

An Appender specifies where log messages are written, such as the console, a file, or a database.

### 7. What is a Target in NLog?

A Target defines the destination where log messages are stored.

### 8. What is a Sink in Serilog?

A Sink is the destination where Serilog writes log messages.

### 9. Why should sensitive information never be logged?

To protect user privacy, maintain security, and comply with data protection regulations.

### 10. Which logging framework supports structured logging?

Serilog.