---

# **3. Reflection: Challenges Faced in Balancing Stakeholder Needs**

## **3.1 Identifying Stakeholder Priorities**
Balancing the needs of **municipality administrators** (who prioritize revenue collection), **residents** (who prioritize transparency and fair billing), and **IT teams** (who need system stability) was challenging. Each group had different expectations regarding system performance and usability.

## **3.2 Resolving Conflicting Requirements**
- **Accuracy vs. Speed:** The finance team wanted instant billing, while IT teams needed time for data validation. A compromise was achieved by allowing preliminary bills to be issued with an option for adjustment.
- **Security vs. Usability:** Two-factor authentication (2FA) improved security but could slow down meter readers. We implemented biometric login for mobile users to balance security and ease of access.

## **3.3 Technical Constraints**
- Ensuring **offline support** for meter readers was necessary but required additional storage and synchronization logic.
- Handling high system load during **billing cycles** was a challenge, leading to the adoption of **batch processing for invoice generation**.

## **3.4 Conclusion**
Through careful requirement elicitation and iterative feedback, the system design aimed to satisfy all stakeholders while maintaining usability, security, and performance.

