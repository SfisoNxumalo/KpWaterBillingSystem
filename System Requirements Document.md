
# **2. System Requirements Document (SRD)**

## **2.1 Functional Requirements**

1. The system shall allow water meter readers to log in securely and record water readings via a mobile app.
2. The system shall allow users to upload a photo of the meter reading as proof.
3. The system shall store recorded readings in a centralized database.
4. The system shall automatically calculate monthly water bills based on recorded readings and predefined rates.
5. The system shall generate and email bills to customers at the end of each billing cycle.
6. The system shall allow homeowners to view and dispute their bills through a web portal.
7. The system shall integrate with third-party payment providers to allow digital bill payments.
8. The system shall allow administrators to update water tariffs dynamically.
9. The system shall generate reports on water usage trends and billing history.
10. The system shall notify users via SMS and email about overdue payments.

### **Acceptance Criteria for Critical Requirements**
- **Billing Accuracy:** Bills generated must be within a 1% error margin of manually calculated values.
- **Real-Time Updates:** Data entered by water meter readers should be stored and reflected in the backend within 5 seconds.
- **Security:** Users must authenticate with two-factor authentication (2FA) before accessing sensitive billing data.

## **2.2 Non-Functional Requirements**

### **Usability**
- The mobile app shall provide an intuitive UI for water meter readers with offline functionality for data entry.

### **Deployability**
- The system shall be deployable on AWS Cloud and support horizontal scaling.

### **Maintainability**
- The system shall include API documentation for third-party integrations.

### **Scalability**
- The system shall support 10,000+ registered customers and process at least 1,000 concurrent requests.

### **Security**
- All user data shall be encrypted using AES-256 encryption.

### **Performance**
- The system shall generate and send 1,000+ invoices within 30 minutes at the end of each billing cycle.

---
