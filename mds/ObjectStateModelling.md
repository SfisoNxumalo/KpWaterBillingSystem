## Object State Modeling for KP Water Billing System

### 1. **WaterReading**
```mermaid
stateDiagram-v2
    [*] --> Draft
    Draft --> Submitted : submitReading()
    Submitted --> Approved : verifyReading()
    Submitted --> Rejected : rejectReading()
    Approved --> Archived : archiveReading()
```

**Explanation:**
- **States**: Draft, Submitted, Approved, Rejected, Archived
- **Transitions**: Water readings start as Drafts, become Submitted, then either Approved or Rejected. Approved readings are archived for historical reference.
- **Functional Requirement Alignment**: Matches FR-002: Allow employees to record and submit readings.


### 2. **Bill**
```mermaid
stateDiagram-v2
    [*] --> Pending
    Pending --> Generated : generateBill()
    Generated --> Sent : sendEmail()
    Sent --> Paid : confirmPayment()
    Sent --> Overdue : paymentMissed()
    Overdue --> Paid : latePayment()
```

**Explanation:**
- **States**: Pending, Generated, Sent, Paid, Overdue
- **Functional Requirement Alignment**: Aligns with FR-005: Automatically generate and send bills.


### 3. **UserAccount**
```mermaid
stateDiagram-v2
    [*] --> Registered
    Registered --> Active : emailVerified()
    Active --> Suspended : tooManyFailedLogins()
    Suspended --> Active : adminReset()
    Active --> Deactivated : userRequest()
```

**Explanation:**
- **States**: Registered, Active, Suspended, Deactivated
- **Functional Requirement Alignment**: Supports security needs and login management.


### 4. **ReadingImage**
```mermaid
stateDiagram-v2
    [*] --> Captured
    Captured --> Uploaded : uploadImage()
    Uploaded --> Linked : linkToReading()
```

**Explanation:**
- **States**: Captured, Uploaded, Linked
- **Functional Requirement Alignment**: Tied to FR-003: Upload image as proof of water reading.


### 5. **Payment**
```mermaid
stateDiagram-v2
    [*] --> Initialized
    Initialized --> Processed : processPayment()
    Processed --> Successful : paymentSuccess()
    Processed --> Failed : paymentFailed()
```

**Explanation:**
- **States**: Initialized, Processed, Successful, Failed
- **Functional Requirement Alignment**: Related to confirming successful bill payment (FR-006).



### 6. **EmailNotification**
```mermaid
stateDiagram-v2
    [*] --> Composed
    Composed --> Queued : queueEmail()
    Queued --> Sent : sendEmail()
    Sent --> Delivered : deliveryConfirmed()
```

**Explanation:**
- **States**: Composed, Queued, Sent, Delivered
- **Functional Requirement Alignment**: Tied to FR-007: Send notifications to clients.



### 7. **Complaint**
```mermaid
stateDiagram-v2
    [*] --> Open
    Open --> InProgress : assignToAgent()
    InProgress --> Resolved : resolveComplaint()
    Resolved --> Closed : closeTicket()
    InProgress --> Escalated : escalateIssue()
```

**Explanation:**
- **States**: Open, InProgress, Resolved, Escalated, Closed
- **Functional Requirement Alignment**: Supports the need for managing customer feedback and disputes.
