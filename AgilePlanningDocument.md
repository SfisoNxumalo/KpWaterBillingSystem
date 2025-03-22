### **KP Water Billing System – Agile Planning Document**  

---

## **1. Introduction**  
This document outlines the Agile planning process for the KP Water Billing System. It includes the breakdown of functional requirements into user stories, creation of a product backlog, sprint planning, and test scenarios. The goal of this project is to digitize the process of recording water readings and generating customer bills to improve efficiency and accuracy.  

---

## **2. Traceability**  
The table below shows the connection between functional requirements and user stories to ensure alignment with stakeholder needs:  

| Requirement ID | Functional Requirement | User Story ID | User Story Description | Priority (MoSCoW) | Status |  
|---------------|-------------------------|---------------|------------------------|--------------------|--------|  
| FR-001        | The system shall allow employees to record water readings. | US-001         | As an employee, I want to record water readings so that I can capture accurate data. | Must-Have         | To Do   |  
| FR-002        | The system shall allow uploading of proof images. | US-002         | As an employee, I want to upload an image of the reading so that I have proof of data entry. | Must-Have         | To Do   |  
| FR-003        | The system shall automatically generate monthly bills. | US-003         | As a system, I want to generate monthly bills so that customers receive accurate billing. | Must-Have         | To Do   |  
| FR-004        | The system shall allow customers to view billing history. | US-004         | As a customer, I want to view my billing history so that I can track my water usage. | Should-Have       | To Do   |  
| FR-005        | The system shall notify customers about their bills. | US-005         | As a system, I want to notify customers via email so that they are aware of their bill. | Must-Have         | To Do   |  
| FR-006        | The system shall allow employees to update readings. | US-006         | As an employee, I want to update water readings so that I can correct mistakes. | Should-Have       | To Do   |  
| FR-007        | The system shall allow customers to report incorrect bills. | US-007         | As a customer, I want to report incorrect bills so that they can be corrected. | Could-Have        | To Do   |  
| FR-008        | The system shall provide a dashboard for admins. | US-008         | As an admin, I want to access a dashboard so that I can monitor system performance. | Could-Have        | To Do   |  

---

## **3. Product Backlog**  
The product backlog is prioritized using the MoSCoW method and includes effort estimates:  

- **[Backlog](Backlog.md)**
---

## **4. Sprint Planning**  
### **Sprint Goal:**  
Deliver a working system that allows employees to record water readings, upload proof images, and automatically generate and email bills to customers.


## **5. Test Cases**  
### **Functional Test Cases:**  

| Test Case ID | ID Requirement | Description | Steps | Expected Result | Actual Result | Status |  
|--------------|----------------|-------------|-------|-----------------|----------------|--------|  
| TC-001        | FR-001          | Record water readings | 1. Open app, 2. Enter readings, 3. Submit | Readings saved | – | – |  
| TC-002        | FR-002          | Upload proof image | 1. Open app, 2. Upload image, 3. Submit | Image saved | – | – |  
| TC-003        | FR-003          | Generate monthly bill | 1. Trigger billing, 2. Check email | Bill received | – | – |  
| TC-004        | FR-004          | View billing history | 1. Open app, 2. Navigate to history | Billing history displayed | – | – |  
| TC-005        | FR-005          | Send email notification | 1. Generate bill, 2. Check email | Email received | – | – |  

### **Non-Functional Test Cases:**  

| Test Case ID | Description | Steps | Expected Result | Status |  
|--------------|-------------|-------|-----------------|--------|  
| TC-NF-001     | Performance Test | 1. Simulate 1,000 users accessing system at once | Response time ≤ 2 seconds | – |  
| TC-NF-002     | Security Test | 1. Attempt unauthorized access | Access denied | – |  

---


## **7. Conclusion**  
This Agile Planning Document outlines the steps taken to convert system requirements into a structured and actionable plan. The traceability between user stories, functional requirements, and test cases ensures alignment with stakeholder needs. The sprint goal is achievable, and the product backlog will guide future sprints for continuous improvement.