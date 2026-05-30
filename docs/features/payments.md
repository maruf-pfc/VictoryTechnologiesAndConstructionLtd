# 💳 Feature: Payment Verification & Enrollment Activation
#features #payments

This module manages the manual payment submission, transaction verification, and course enrollment activation workflow.

---

## 🔁 Enrollment Purchase Pipeline

```mermaid
sequenceDiagram
    participant Student
    participant Frontend as Next.js Client
    participant API as Web API Server
    participant Admin as Admin Panel Dashboard

    Student->>Frontend: Selects Course & Clicks Enroll
    Frontend->>Student: Prompts with bKash/Nagad Instructions & Form
    Student->>Frontend: Submits Transaction ID, Method, and Sender Number
    Frontend->>API: POST /api/payment/request
    API->>API: Creates Pending PaymentRecord (Status = Pending)
    Admin->>API: GET /api/payment/admin/pending
    API-->>Admin: Returns pending transaction requests
    Admin->>Admin: Verifies receipt on bkash portal
    alt Valid Transaction
        Admin->>API: POST /api/payment/admin/approve/{id}
        API->>API: Sets Status = Success, Creates Enrollment (IsActive = true)
        API-->>Admin: HTTP 200 (Success)
        Student->>Frontend: Refreshes Dashboard (Course is now unlocked!)
    else Invalid Transaction
        Admin->>API: POST /api/payment/admin/reject/{id}
        API->>API: Sets Status = Rejected
        API-->>Admin: HTTP 200 (Rejected)
    end
```

---

## 💻 Code Implementations

*   **Payment Request Handler**: Handled inside `PaymentController.cs` under endpoint `/api/payment/request`.
*   **Database Record**: Defined as `PaymentRecord.cs` mapping transaction reference indexes.
*   **Safety Isolation**: Students can query only their own transactions, while admins have global access to review pending payments.
