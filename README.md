# KP Water Billing System

## Introduction
The **KP Water Billing System** is a digital solution designed to replace the manual, paper-based water meter reading and billing process in our community. Currently, employees record water readings on paper, manually generate bills, and send them to customers. 

## Solution
The **KP Water Billing System** provides a streamlined digital approach:
- Employees enter readings using a **mobile app**.
- A **photo of the meter reading** is captured as proof.
- The system automatically stores the data in a **cloud database**.
- Bills are generated **at the end of the month** and sent to customers via **email**.
- Customers can view their **billing history and usage reports** through a web dashboard.

## Documentation
- **[System Specification](SPECIFICATION.md)**: Contains a detailed breakdown of the system's scope, feasibility, and requirements.
- **[Architecture Documentation](ARCHITECTURE.md)**: Includes C4 diagrams and technical system architecture details.
- **[Stake Holder Analysis](StakeholderAnalysisTable.md)**
- **[System Requirements](SystemRequirementsDocument.md)**:
- **[Use Case Specifications](UseCaseSpecifications.md)**
- **[Use Case Diagram](UseCase.md)**
- **[Test Case](TestCaseDevelopment.md)**

##### Agile Development
- **[Agile Planning Document](AgilePlanningDocument.md)**
- **[Sprint Planning](SprintPlanning.md)**
- **[User Story](UserStory.md)**
- **[Product Backlog](backlog.md)**
- **[Reflections](AgileReflection.md)**

##### Kanban Board Implementation
- **[Template Analysis and selection](template_analysis.md)**
- **[Custom Kanban Board](CustomKanbanBoardCreation.md)**
- **[Kanban Board Explanation](kanban_explanation.md)**
- **[Reflections](kanban_reflection.md)**

##### Object State Modeling and Activity Workflow Modeling
- **[Object State Modelling](ObjectStateModelling.md)**
- **[Activity Diagram](ActivityDiagram.md)**
- **[Reflections](ObjectModellingReflection.md)**



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

### Repository Pattern

For the KP Water Billing System, I chose Dependency Injection (DI) over the Factory pattern to keep the system flexible and easier to maintain. With DI, I can easily swap out different repository implementations (like InMemoryDB or SqlDb) without affecting the rest of the code. This helps in adapting to different storage solutions without changing the core logic. I also used generics in the repositories to avoid repeating code for different entity types (like Employee and Customer). This approach keeps things cleaner, ensures type safety, and makes it easier to manage and scale the system as it grows.

- **[Repository Pattern implementation](App/KpWaterBillingSystem/KpWaterBillingSystem/src/Repository/)**