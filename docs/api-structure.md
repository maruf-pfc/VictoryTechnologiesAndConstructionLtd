# ⛓️ API Structure
#api #backend

The VTCLBD Web API communicates using standard HTTP status codes, structured JSON responses, and role-enforced Bearer tokens.

---

## 📦 Global Response DTO (`ApiResponse<T>`)

Every API endpoint responds using a standardized payload wrapper:

```json
{
  "success": true,
  "message": "Enrolled courses retrieved.",
  "data": [
    {
      "id": "a8391b63-0766-4898-bfc1-1f210f474ebf",
      "title": "Modern Interior Design Mastery",
      "price": 4999.00
    }
  ]
}
```

---

## 📑 Core Endpoints Directory

### 👤 Authentication (`/api/auth/*`)

| Method | Endpoint | Auth | Description |
| :--- | :--- | :--- | :--- |
| **POST** | `/api/auth/register` | Public | Register user account. Default role: `"User"`. |
| **POST** | `/api/auth/login` | Public | Authenticate user. Returns JWT and claims profile. |
| **GET** | `/api/auth/profile` | Bearer | Fetch authenticated user's details and active role. |

### 🎓 Courses & Training Curriculum (`/api/course/*`)

| Method | Endpoint | Auth | Description |
| :--- | :--- | :--- | :--- |
| **GET** | `/api/course` | Public | List published courses. Append `?publishedOnly=false` for Admin views. |
| **GET** | `/api/course/{id}` | Public | Fetch a course detail. |
| **GET** | `/api/course/enrolled` | Student | List courses the user is currently enrolled in. |
| **POST** | `/api/course` | Admin | Create new course. |
| **PUT** | `/api/course/{id}` | Admin | Edit existing course specifications. |
| **DELETE** | `/api/course/{id}` | Admin | Cascading deletion of a course. |

### 🎬 Course Modules & Lessons (`/api/coursemodule/*`)

| Method | Endpoint | Auth | Description |
| :--- | :--- | :--- | :--- |
| **GET** | `/api/coursemodule/by-course/{courseId}`| Public | List all curriculum modules for a course. |
| **POST** | `/api/coursemodule` | Admin | Add new module to a course. |
| **PUT** | `/api/coursemodule/{id}` | Admin | Update module details/order. |
| **DELETE** | `/api/coursemodule/{id}` | Admin | Delete a module. |
| **POST** | `/api/coursemodule/lessons` | Admin | Append a video lesson to a module. |

### 🏢 Portfolio Showcase (`/api/project/*`)

| Method | Endpoint | Auth | Description |
| :--- | :--- | :--- | :--- |
| **GET** | `/api/project` | Public | Retrieve active gallery projects. |
| **GET** | `/api/project/{id}` | Public | Fetch project details. |
| **POST** | `/api/project` | Admin | Create a portfolio project. |
| **PUT** | `/api/project/{id}` | Admin | Edit portfolio project specifications. |
| **DELETE** | `/api/project/{id}` | Admin | Remove a portfolio project. |

### 💳 Payments & Enrollment (`/api/payment/*`)

| Method | Endpoint | Auth | Description |
| :--- | :--- | :--- | :--- |
| **POST** | `/api/payment/request` | Student | Submit transaction proof for manual verification. |
| **GET** | `/api/payment/admin/pending` | Admin | List all pending payments. |
| **POST** | `/api/payment/admin/approve/{id}`| Admin | Approve payment, activating course enrollment. |
| **POST** | `/api/payment/admin/reject/{id}` | Admin | Reject invalid transaction reference. |

---

## 🔗 Related Interface Links

*   **Authentication**: [[authentication-flow]]
*   **Database Map**: [[database-schema]]
