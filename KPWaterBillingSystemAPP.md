# KP Water Billing System

## 1. Project Overview  
The KP Water Billing System automates the process of recording water meter readings and generating customer bills. It replaces manual, paper‑based workflows with a robust, maintainable C# application using well‑known design patterns.

---

## 2. Language & Tools

- **Language**: C# (.NET 6)  
  - **Justification**:  
    - Strong support for object‑oriented principles (interfaces, inheritance, encapsulation).  
    - Excellent tooling and ecosystem (LINQ, dependency injection, testing frameworks).  
    - Ideal for building scalable, maintainable backend services.

- **Testing Framework**: NUnit  
- **Build & Run**:  
  ```bash
  dotnet build
  dotnet test

  
```markdown
# KP Water Billing System

## 1. Project Overview  
The KP Water Billing System automates the process of recording water meter readings and generating customer bills. It replaces manual, paper‑based workflows with a robust, maintainable C# application using well‑known design patterns.

---

## 2. Language & Tools

- **Language**: C# (.NET 6)  
  - **Justification**:  
    - Strong support for object‑oriented principles (interfaces, inheritance, encapsulation).  
    - Excellent tooling and ecosystem (LINQ, dependency injection, testing frameworks).  
    - Ideal for building scalable, maintainable backend services.

- **Testing Framework**: NUnit  
- **Build & Run**:  
  ```bash
  dotnet build
  dotnet test
  ```

---

## 3. Key Design Decisions & Creational Pattern Justifications

| Pattern            | Classes / Interfaces                              | Why Used                                                                                               |
|--------------------|----------------------------------------------------|--------------------------------------------------------------------------------------------------------|
| **Simple Factory** | `UserSimpleFactoryPattern`                         | Centralizes creation of `Employee` vs. `Customer` objects.                                              |
| **Factory Method** | `IReportFactoryMethodPattern`<br>`EmployeeReportFactoryMethodPattern`<br>`CustomerReportFactoryMethodPattern` | Allows each user type to define its own report creation logic.                                         |
| **Abstract Factory** | `IUserReportAbstractFactoryPattern`<br>`EmployeeAbstractFactoryPattern`<br>`CustomerAbstractFactoryPattern` | Bundles creation of related objects (`IUser` + `IReport`) for different roles in a single factory.    |
| **Builder**        | `IBillBuilderPattern`<br>`BillBuilderPattern`<br>`BillingDirectorPattern` | *Used Builder for `Bill` because bills have optional fields (due date, multiple readings, custom notes).* |
| **Prototype**      | `CustomerPrototypePattern`<br>`BillPrototypePattern` | Enables cloning of existing templates (e.g., default customer settings or bill layouts) with minimal effort. |
| **Singleton**      | `BillingManagerSingletonPattern`                   | Ensures a single shared instance for billing configuration (rate per unit) and calculation logic.      |


## 4. How to Run

1. **Clone** the repository.  
2. **Build** the solution:  
   ```bash
   dotnet build
   ```  
3. **Execute Tests**:  
   ```bash
   dotnet test
   ```  
## 5. Next Steps

- Integrate with a database using Entity Framework Core.  
- Add a REST API layer with ASP.NET Core.  
