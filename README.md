# 🤖 Robot Wars

A C# simulation of a robot navigating a 5x5 grid arena, following movement instructions and reporting its final position and penalties for boundary collisions. Built to demonstrate good design, testability, and separation of concerns.

---

## 📋 Problem Description

A robot is placed in a 5x5 grid arena with an initial position and heading (N, S, E, or W). It receives a sequence of instructions:

- `L` = Rotate Left 90°
- `R` = Rotate Right 90°
- `M` = Move forward 1 step in current direction

Robots can't move outside the arena. Any such attempt adds a **penalty**, and the position remains unchanged.

---

## 🧠 Solution Design

### 🔧 Core Concepts

- `Direction` — Enum representing the four cardinal directions.
- `Position` — Holds the X/Y coordinates and heading.
- `Arena` — Represents the 5x5 grid and checks boundary rules.
- `Robot` — Holds current position, executes instructions, and tracks penalties.

### 🧪 Unit Testing

The logic is fully testable using [NUnit](https://nunit.org/), and test coverage includes all edge cases and the four specified scenarios.

---

## ✅ Example Scenarios

| Initial Position | Instructions         | Final Position | Penalties |
|------------------|----------------------|----------------|-----------|
| `0, 2, E`        | `MLMRMMMRMMRR`       | `4, 1, N`      | `0`       |
| `4, 4, S`        | `LMLLMMLMMMRMM`      | `0, 1, W`      | `1`       |
| `2, 2, W`        | `MLMLMLMRMRMRMRM`    | `2, 2, N`      | `0`       |
| `1, 3, N`        | `MMLMMLMMMMM`        | `0, 0, S`      | `3`       |

---

## 🚀 Getting Started

### 🛠 Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (.NET 6 or later recommended)
- Visual Studio or any C# IDE

### 🔧 Build & Run Tests

1. Open the solution in Visual Studio
2. Restore NuGet packages
3. Build the solution
4. Open **Test Explorer** and run all tests

Or via CLI:

```bash
dotnet restore
dotnet build
dotnet test
