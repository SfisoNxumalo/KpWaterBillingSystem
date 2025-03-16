# KP Water Billing System - Use Case Specifications

## 1. Record Water Reading
**Actor:** Employee
- **Description:** Allows an employee to record a house’s water reading.
- **Preconditions:** Employee is logged into the app.
- **Postconditions:** Reading is saved in the database.
- **Basic Flow:**
  1. Employee logs into the app.
  2. Employee selects the house ID.
  3. Employee enters water reading.
  4. Employee takes a picture as proof.
  5. System validates and saves the data.
- **Alternative Flow:**
  - If reading is not validated, system prompts for correction.

## 2. Upload Proof of Reading
**Actor:** Employee
- **Description:** Allows an employee to upload a picture of the water reading.
- **Preconditions:** Employee has recorded the reading.
- **Postconditions:** Picture is stored in the system.
- **Basic Flow:**
  1. Employee selects house ID.
  2. Employee takes a picture of the reading.
  3. System uploads and saves the picture.
- **Alternative Flow:**
  - If upload fails, system prompts to retry.

## 3. Generate Monthly Bill
**Actor:** System
- **Description:** Automatically generates a bill based on water readings.
- **Preconditions:** All readings are recorded and validated.
- **Postconditions:** Bill is generated and stored.
- **Basic Flow:**
  1. System calculates bill from recorded readings.
  2. System generates a bill.
  3. Bill is stored in the system.
- **Alternative Flow:**
  - If calculation fails, system logs an error.

## 4. Send Bill to Customer
**Actor:** System
- **Description:** Automatically sends a bill to the customer via email.
- **Preconditions:** Bill is generated.
- **Postconditions:** Email is sent.
- **Basic Flow:**
  1. System retrieves customer email.
  2. System attaches bill.
  3. System sends email.
- **Alternative Flow:**
  - If email fails, system logs the failure.

## 5. Register New House
**Actor:** Administrator
- **Description:** Allows an admin to register a new house.
- **Preconditions:** Admin is logged into the system.
- **Postconditions:** House is registered.
- **Basic Flow:**
  1. Admin logs into the system.
  2. Admin enters house details.
  3. System validates and saves data.
- **Alternative Flow:**
  - If validation fails, system prompts correction.

## 6. Update Customer Details
**Actor:** Administrator
- **Description:** Allows an admin to update customer details.
- **Preconditions:** Admin is logged into the system.
- **Postconditions:** Customer details are updated.
- **Basic Flow:**
  1. Admin logs into the system.
  2. Admin selects customer profile.
  3. Admin updates details.
  4. System saves updated details.
- **Alternative Flow:**
  - If validation fails, system prompts correction.

## 7. View Billing History
**Actor:** Customer
- **Description:** Allows a customer to view their billing history.
- **Preconditions:** Customer is logged into the app.
- **Postconditions:** Billing history is displayed.
- **Basic Flow:**
  1. Customer logs into the app.
  2. Customer selects billing history.
  3. System retrieves and displays data.
- **Alternative Flow:**
  - If no data is available, system displays an error.

## 8. Generate Usage Report
**Actor:** System
- **Description:** Generates a usage report for admin review.
- **Preconditions:** System has collected sufficient data.
- **Postconditions:** Report is available.
- **Basic Flow:**
  1. System compiles usage data.
  2. System generates a report.
  3. Report is stored.
- **Alternative Flow:**
  - If data is incomplete, system logs an error.

