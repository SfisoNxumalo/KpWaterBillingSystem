## Architecture Diagrams
### Context Diagram
```mermaid
graph TD;
    User -->|Reads Water Meter & Uploads Data| Backend
    Backend -->|Stores Data| Database
    Backend -->|Generates Bills| BillingSystem
    BillingSystem -->|Emails Bills| Customer
    %% Apply Styles for Better Readability
  style User fill:#FF8C00,stroke:#5A3D00,stroke-width:2px,color:#000;
  style Backend fill:#008080,stroke:#005F5F,stroke-width:3px,color:#FFF;
  style BillingSystem fill:#1E90FF,stroke:#0057A0,stroke-width:2px,color:#FFF;
  style Customer fill:#DC143C,stroke:#A00026,stroke-width:3px,color:#FFF;
  style Database fill:#32CD32,stroke:#228B22,stroke-width:2px,color:#000;
```

### Container Diagram
```mermaid
graph TD;
    subgraph Mobile App
        A[Water Meter Input]
        B[Photo Capture]
    end
    subgraph Backend
        C[API Gateway]
        D[Database]
        E[Billing Service]
        F[Email Service]
    end
    A --> C
    B --> C
    C --> D
    C --> E
    E --> F
    F -->|Sends Bill| Customer

    %% Apply Styles for Better Readability
  style A fill:#FF8C00,stroke:#5A3D00,stroke-width:2px,color:#000;
  style B fill:#008080,stroke:#005F5F,stroke-width:3px,color:#FFF;
  style C fill:#FFD700,stroke:#B8860B,stroke-width:2px,color:#000;
  style D fill:#1E90FF,stroke:#0057A0,stroke-width:2px,color:#FFF;
  style E fill:#DC143C,stroke:#A00026,stroke-width:3px,color:#FFF;
  style F fill:#32CD32,stroke:#228B22,stroke-width:2px,color:#000;
  style Customer fill:#4682B4,stroke:#2C4F76,stroke-width:2px,color:#FFF;
```

# KP Water Billing System Architecture

## Overview
The **KP Water Billing System** is designed to digitize and automate water meter readings, storage, and billing. This document outlines the architecture of the system using C4 diagrams.

## C4 Model Diagram

```mermaid
C4Context
  title KP Water Billing System Context Diagram
  Person(employee, "Water Meter Reader", "Records water readings using the mobile app.")
  Person(customer, "Customer", "Receives water bills via email.")
  System(kp_system, "KP Water Billing System", "Automates water meter reading and billing process.")
  
  employee -> kp_system : Uploads water readings and images
  kp_system -> customer : Sends monthly water bill via email

C4Container
  title KP Water Billing System Container Diagram
  Person(employee, "Water Meter Reader", "Records water readings using the mobile app.")
  Person(customer, "Customer", "Receives water bills via email.")
  
  System_Boundary(kp_system, "KP Water Billing System") {
    Container(mobile_app, "Mobile App", "Flutter", "Allows employees to capture and upload water readings.")
    Container(backend, "Backend API", "Node.js & Express", "Handles business logic and database operations.")
    Container(database, "Database", "PostgreSQL", "Stores water meter readings and customer data.")
    Container(billing_service, "Billing Service", "Node.js", "Generates water bills based on recorded readings.")
    Container(email_service, "Email Service", "AWS SES", "Sends water bills to customers via email.")
  }
  
  employee -> mobile_app : Records meter reading
  mobile_app -> backend : Uploads data
  backend -> database : Stores data
  backend -> billing_service : Triggers billing process
  billing_service -> email_service : Sends bill notification
  email_service -> customer : Receives bill via email

