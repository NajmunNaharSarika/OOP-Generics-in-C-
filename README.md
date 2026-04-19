# 🚗 Vehicle Management System — OOP & Generics in C#

> A **C# .NET** console application demonstrating core Object-Oriented Programming principles — inheritance, abstraction, interfaces, generics, and polymorphism — applied to a real-world vehicle classification system.

---

## 📋 Table of Contents

- [Overview](#overview)
- [OOP Concepts Demonstrated](#oop-concepts-demonstrated)
- [Project Structure](#project-structure)
- [Class Hierarchy](#class-hierarchy)
- [Key Components](#key-components)
- [Getting Started](#getting-started)
- [Sample Output](#sample-output)
- [Design Summary](#design-summary)

---

## Overview

This project models a vehicle management system with two main categories — **two-wheelers** (Motorcycle) and **four-wheelers** (Car). It showcases how abstract base classes, interface contracts, sealed classes, and generic implementations can work together to produce a clean and extensible architecture. Each vehicle type supports design feature tracking (exterior / interior) and exposes details through generic repository interfaces.

---

## OOP Concepts Demonstrated

| Concept | Where Applied |
|---|---|
| **Abstract Class** | `vechicle` — defines the base contract with `abstract Details()` |
| **Inheritance** | `TwoWheeler → Motorcycl`, `fourWheeler → Car` |
| **Sealed Class** | `Car` and `Motorcycl` — cannot be further subclassed |
| **Interface** | `IextoriorDedign`, `IintoriorDesign`, `IgenericDetail<T>`, `IvechicleDetail<T>` |
| **Generics** | `GenericDetailImpl<T>`, `VechicleDetailImpl<T>`, `IgenericDetail<T>`, `IvechicleDetail<T>` |
| **Generic Constraints** | `where T : vechicle` on `IvechicleDetail<T>` |
| **Polymorphism** | `Details()` overridden differently in `TwoWheeler` and `fourWheeler` |
| **Enum** | `vechicleType` — Personal, Family, Business |
| **params keyword** | `addextoriorDedign(params string[])`, `addIintoriorDesign(params string[])` |

---

## Project Structure

```
exam/
│
├── exam/                          # Core namespace
│   ├── vechicle.cs                # Abstract base class for all vehicles
│   ├── Class1.cs                  # Enum — vechicleType (personal, family, business)
│   ├── TwoWheelar.cs              # TwoWheeler : vechicle, IextoriorDedign
│   ├── IextoriorDedign.cs         # Interface — exterior design features
│   └── IintoriorDesign.cs         # Interface — interior design features
│
├── Car.cs                         # sealed Car : fourWheeler
├── fourWheeler.cs                 # fourWheeler : vechicle, IintoriorDesign
├── Motorcycle.cs                  # sealed Motorcycl : TwoWheeler
│
├── IgenericDetail.cs              # Generic interface (unconstrained)
├── GenericDetailImpl.cs           # Implements IgenericDetail<T> with type-check
├── IvechicleDetail.cs             # Generic interface constrained to vechicle
├── VechicleDetailImpl.cs          # Implements IvechicleDetail<T> — calls Details()
│
└── Program.cs                     # Entry point — demo of Motorcycle and Car
```

---

## Class Hierarchy

```
                        vechicle  (abstract)
                       .----------.
                  TwoWheeler   fourWheeler
                  IextoriorDedign  IintoriorDesign
                       |               |
                   Motorcycl         Car
                   (sealed)         (sealed)


Interfaces:
  IextoriorDedign  ->  addextoriorDedign(), getextoriorDedign()
  IintoriorDesign  ->  addIintoriorDesign(), getIintoriorDesign()
  IgenericDetail<T>   ->  getDetail<T>(T obj)
  IvechicleDetail<T>  ->  GetDetail<T>(T obj) where T : vechicle

Generic Implementations:
  GenericDetailImpl<T>    ->  runtime type-check via (obj is vechicle)
  VechicleDetailImpl<T>   ->  compile-time safe, calls obj.Details() directly
```

---

## Key Components

### `vechicle` — Abstract Base Class
```csharp
public abstract class vechicle
{
    public string Model { get; set; }
    public int YearMake { get; set; }
    public int CC { get; set; }
    public int Noofgear { get; set; }
    public vechicleType VechicleType { get; set; }

    public abstract string Details();
}
```
Every vehicle must implement `Details()`, enforcing a consistent reporting contract across all subtypes.

---

### `TwoWheeler` — Two-Wheeler Base
Extends `vechicle` and implements `IextoriorDedign`. Adds motorcycle-specific properties and tracks exterior design features in a `List<string>`.

```csharp
public class TwoWheeler : vechicle, IextoriorDedign
{
    public void addextoriorDedign(params string[] design) { ... }
    public string getextoriorDedign() { ... }
    public override string Details() { ... }
}
```

---

### `fourWheeler` — Four-Wheeler Base
Extends `vechicle` and implements `IintoriorDesign`. Adds door/seat count and tracks interior design features.

```csharp
public class fourWheeler : vechicle, IintoriorDesign
{
    public int NoofDoor { get; set; }
    public int Noofseat { get; set; }
    public void addIintoriorDesign(params string[] design) { ... }
    public string getIintoriorDesign() { ... }
    public override string Details() { ... }
}
```

---

### Two Generic Approaches — `IgenericDetail<T>` vs `IvechicleDetail<T>`

| Interface | Constraint | Safety |
|---|---|---|
| `IgenericDetail<T>` | None | Runtime type-check (`obj is vechicle`) |
| `IvechicleDetail<T>` | `where T : vechicle` | Compile-time safe — calls `Details()` directly |

`VechicleDetailImpl<T>` is the cleaner approach as it eliminates runtime casting entirely.

---

### `vechicleType` — Enum
```csharp
public enum vechicleType
{
    personal = 1,
    family,
    business
}
```

---

## Getting Started

### Prerequisites

- [Visual Studio 2019+](https://visualstudio.microsoft.com/)
- .NET Framework 4.7.2

### Run the Project

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/VehicleManagementSystem.git
   cd VehicleManagementSystem
   ```

2. **Open in Visual Studio**
   - Open `exam.csproj`
   - Build: `Ctrl + Shift + B`
   - Run: `Ctrl + F5`

3. **Or build via CLI**
   ```bash
   msbuild exam.csproj /p:Configuration=Release
   ```

---

## Sample Output

```
R1v 2022, 3, 4, personal, seff, 433, 33, 6, air cool, aa, avs
horn, led light

bmw, 3, 2022, 4, 5, 4
music, led
```

The first block shows the Motorcycle's `Details()` output via `GenericDetailImpl`, followed by its exterior design features. The second block shows the Car's details via `VechicleDetailImpl` and its interior design features.

---

## Design Summary

```
Program
  |
  |-- Motorcycl  -->  GenericDetailImpl<Motorcycl>.getDetail()
  |                   uses runtime (obj is vechicle) check
  |                   + IextoriorDedign  ->  exterior design list
  |
  `-- Car  -------->  VechicleDetailImpl<Car>.GetDetail()
                      compile-time safe via (where T : vechicle)
                      + IintoriorDesign  ->  interior design list
```

---

*Built with C# · .NET Framework 4.7.2*
