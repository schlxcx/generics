# Generics – Generic Repository

**A practical C# exercise for learning generics and type-safe collections.**

![Language](https://img.shields.io/badge/language-C%23-512BD4)
![Framework](https://img.shields.io/badge/framework-.NET-512BD4)
![Type](https://img.shields.io/badge/type-Console%20Application-lightgrey)

## Overview

This project is a simple C# programming exercise focused on understanding and implementing **generics**.

The application demonstrates how to create a reusable repository that can store and manage objects of different types without requiring separate implementations for each data type.

The project was developed as part of a programming exercise and is included in my personal software development portfolio.

## Features

- **Generic Repository** – A reusable `Repository<T>` class that supports different data types.
- **Type Safety** – Ensures that items stored in a repository match its specified generic type.
- **Collection Management** – Add, remove, and retrieve stored items.
- **Flexible Initialization** – Create an empty repository or initialize one with an existing list.
- **Reusable Architecture** – Use the same repository implementation for different types.

## Repository Implementation

The `Repository<T>` class uses a `List<T>` to store its items.

### Available Methods

| Method | Description |
|---|---|
| `Repository()` | Creates an empty repository |
| `Repository(List<T> values)` | Initializes the repository with an existing list |
| `Add(T item)` | Adds an item to the repository |
| `Remove(T item)` | Removes an item and returns whether removal succeeded |
| `GetAll()` | Returns all stored items as `IEnumerable<T>` |

### Example Usage

```csharp
Repository<string> names = new Repository<string>();

names.Add("Alice");
names.Add("Bob");

names.Remove("Alice");

foreach (string name in names.GetAll())
{
    Console.WriteLine(name);
}
```

The repository can also be used with other types, such as `int` like in the Programm.cs file or custom classes.

## Generic Type Constraints

The current implementation does **not** use generic type constraints.

This means that `Repository<T>` can accept any valid C# type as its type argument.

Generic constraints, such as `where T : SomeInterface`, are a related concept but are not implemented in this version.

## Technology Stack

| Category | Technology |
|---|---|
| Language | C# |
| Framework | .NET |
| Main Concept | Generics |
| Data Structure | List<escape><T></escape> |
| Additional Concepts | Collections, Type Safety, IEnumerable<escape><T></escape> |

## Getting Started

### Prerequisites

- A compatible .NET SDK
- Visual Studio, Visual Studio Code, or another C# development environment

### Running the Project

1. Clone or download the repository.
2. Open the C# project in your development environment.
3. Build and run the application.

## Learning Objectives

This project focuses on:

- Understanding generic classes in C#.
- Creating reusable components using type parameters.
- Working with generic collections.
- Implementing methods with generic types.
- Understanding compile-time type safety.
- Using `IEnumerable<T>` to expose collections.

## Project Purpose

This repository serves as a practical learning exercise and a reference in my personal software development portfolio.

It demonstrates fundamental concepts of generic programming in C# through a simple, reusable repository implementation.

The project is intended for educational purposes.

## License

No license has been specified for this project.

Unless a license is added, all rights are reserved by default.