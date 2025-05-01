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
- **[KP Water Billing System App](/KPWaterBillingSystemAPP.md)**

### Repository Pattern

For the KP Water Billing System, I chose Dependency Injection (DI) over the Factory pattern to keep the system flexible and easier to maintain. With DI, I can easily swap out different repository implementations (like InMemoryDB or SqlDb) without affecting the rest of the code. This helps in adapting to different storage solutions without changing the core logic. I also used generics in the repositories to avoid repeating code for different entity types (like Employee and Customer). This approach keeps things cleaner, ensures type safety, and makes it easier to manage and scale the system as it grows.

- **[Repository Pattern implementation](App/KpWaterBillingSystem/KpWaterBillingSystem/src/Repository/)**


## API DOCUMENTATION
- **[KP Water Management API](/APIDocumentation.md)**
