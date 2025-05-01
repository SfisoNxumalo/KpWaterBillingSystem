# KP Water Billing System - Test Cases

| Test Case ID | Requirement ID | Description | Steps | Expected Result | Actual Result | Status |
|-------------|----------------|-------------|-------|------------------|---------------|--------|
| TC-001 | FR-001 | Record water reading | 1. Log in. 2. Select house ID. 3. Enter reading. 4. Take picture. 5. Submit | Reading is saved and validated | ... | ... |
| TC-002 | FR-002 | Upload proof of reading | 1. Log in. 2. Take picture. 3. Submit | Picture is uploaded successfully | ... | ... |
| TC-003 | FR-003 | Generate monthly bill | 1. Record all readings. 2. Generate bill | Bill is generated correctly | ... | ... |
| TC-004 | FR-004 | Send bill to customer | 1. Generate bill. 2. Send email. | Bill is sent to customer email | ... | ... |
| TC-005 | FR-005 | Register new house | 1. Log in. 2. Enter house details. 3. Submit | House is registered successfully | ... | ... |
| TC-006 | FR-006 | Update customer details | 1. Log in. 2. Select customer. 3. Update details. 4. Submit | Customer details are updated | ... | ... |
| TC-007 | FR-007 | View billing history | 1. Log in. 2. Select history. | Display billing history | ... | ... |
| TC-008 | FR-008 | Generate usage report | 1. Collect data. 2. Generate report | Report is generated and displayed | ... | ... |

## Non-Functional Test Cases

**Performance Test**
- **Test Case:** Simulate 1,000 concurrent users generating bills.
- **Expected Result:** System handles load without crashing; response time ≤ 3 seconds.

**Security Test**
- **Test Case:** Attempt to access customer data without authentication.
- **Expected Result:** System denies access and logs unauthorized attempt.

