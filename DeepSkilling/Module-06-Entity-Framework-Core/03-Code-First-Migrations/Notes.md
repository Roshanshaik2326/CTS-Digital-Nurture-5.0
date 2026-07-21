# Code First Migrations Notes

## What is a Migration?

A Migration is a version-controlled description of changes to your database schema.

## Common Commands

Create Migration

dotnet ef migrations add MigrationName

Update Database

dotnet ef database update

Remove Last Migration

dotnet ef migrations remove

## Why Migrations?

- Version control for database schema
- Automatic SQL generation
- Easy collaboration
- Safe schema evolution

## Summary

Migrations allow developers to evolve the database schema alongside application code without manually writing SQL.