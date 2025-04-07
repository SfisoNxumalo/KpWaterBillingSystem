### Activity Workflow Modeling for KP Water Billing System

#### 1. **User Registration**
```mermaid
flowchart TD
  subgraph User
    A[Start] --> B[Fill Registration Form]
    B --> C[Submit Form]
  end

  subgraph System
    C --> D[Validate Form Fields]
    D --> E{Is data valid?}
    E -- No --> F[Show Error Message]
    E -- Yes --> G[Create User Account]
    G --> H[Send Confirmation Email]
    H --> I[End]
  end
```
**Explanation:** This workflow ensures that only valid data is stored. It addresses usability and performance by validating before storage.

---

#### 2. **Login Process**
```mermaid
flowchart TD
  subgraph User
    A[Start] --> B[Enter Username/Password]
    B --> C[Click Login]
  end

  subgraph System
    C --> D[Validate Credentials]
    D --> E{Are credentials valid?}
    E -- No --> F[Show Login Error]
    E -- Yes --> G[Grant Access]
    G --> H[Log Login Event]
    H --> I[End]
  end
```
**Explanation:** This flow confirms secure access and helps with traceability (audit logs).

---

#### 3. **Capture Water Reading**
```mermaid
flowchart TD
  subgraph Employee
    A[Start] --> B[Open Mobile App]
    B --> C[Select Household]
    C --> D[Enter Reading & Take Picture]
    D --> E[Submit Reading]
  end

  subgraph System
    E --> F[Validate Input]
    F --> G{Is reading valid?}
    G -- No --> H[Show Error Message]
    G -- Yes --> I[Save to DB]
    I --> J[End]
  end
```
**Explanation:** Supports data accuracy, aligns with FR for reading capture.

---

#### 4. **Generate Monthly Bill**
```mermaid
flowchart TD
  A[Start] --> B[Fetch Readings]
  B --> C[Calculate Usage]
  C --> D[Apply Rates]
  D --> E[Generate PDF Bill]
  E --> F[Save Bill to DB]
  F --> G[End]
```
**Explanation:** This batch job automates billing, improves performance and scalability.

---

#### 5. **Email Bill to Client**
```mermaid
flowchart TD
  A[Start] --> B[Check Unsent Bills]
  B --> C[Fetch Email Address]
  C --> D[Send Email with PDF Attachment]
  D --> E[Log Email Status]
  E --> F[End]
```
**Explanation:** Meets stakeholder concern for paperless and timely billing.

---

#### 6. **Edit Water Reading**
```mermaid
flowchart TD
  subgraph Employee
    A[Start] --> B[Select Past Reading]
    B --> C[Edit Entry]
    C --> D[Submit Changes]
  end

  subgraph System
    D --> E[Validate Updated Data]
    E --> F{Is update valid?}
    F -- No --> G[Reject Edit]
    F -- Yes --> H[Update Record in DB]
    H --> I[End]
  end
```
**Explanation:** Supports maintainability and error correction.

---

#### 7. **System Audit Log Recording**
```mermaid
flowchart TD
  A[Start] --> B[Detect System Event]
  B --> C[Log Event to Audit Table]
  C --> D[Assign Timestamp/UserID]
  D --> E[End]
```
**Explanation:** Addresses security, maintainability and traceability.

---

#### 8. **Delete User Account (Admin Only)**
```mermaid
flowchart TD
  subgraph Admin
    A[Start] --> B[Search for User]
    B --> C[Select User Account]
    C --> D[Click Delete]
  end

  subgraph System
    D --> E[Check Admin Privileges]
    E --> F{Authorized?}
    F -- No --> G[Show Error Message]
    F -- Yes --> H[Remove User and Related Data]
    H --> I[Log Deletion]
    I --> J[End]
  end
```
**Explanation:** Enforces secure user management, satisfies stakeholder security needs.
