# MathFunctio Design

## What the app does

MathFunctio is a .NET console application that reads two whole numbers and a mathematical operation from the user, performs the calculation, and prints the result.

Supported operations:
- addition
- subtraction
- multiplication
- division

The calculator logic is separated into a dedicated `Calculator` class so it can be tested independently from console input and output.

## Important behavior

- Only whole numbers are accepted as input.
- Supported operation names are `addition`, `subtraction`, `multiplication`, and `division`.
- The symbols `+`, `-`, `*`, and `/` are also accepted.
- Division by zero is rejected with a clear error message.
- Unsupported operations are rejected with a clear error message.

## Project structure

- `src/MathFunctio` - console application
- `tests/MathFunctio.Tests` - xUnit test project
- `design.md` - project documentation

## How to build

```bash
dotnet build MathFunctio.sln
```

## How to run the app

```bash
dotnet run --project src/MathFunctio/MathFunctio.csproj
```

## How to run the tests

```bash
dotnet test MathFunctio.sln
```
