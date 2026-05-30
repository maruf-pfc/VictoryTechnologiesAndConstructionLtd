# 📜 Naming Conventions
#rules #naming

This document outlines naming conventions across the frontend and backend systems.

---

## 💻 Frontend System (TypeScript / CSS)

*   **Files & Folders**: Use kebab-case for directories and component files: `course-card.tsx`, `auth-store.ts`.
*   **Routing Layouts**: Group Next.js layout folders using parentheses: `(admin)`, `(dashboard)`, `(public)`.
*   **Variables & Functions**: Use camelCase for variables, state parameters, and functions: `enrolledCourseIds`, `getEnrolledCourses()`.
*   **TypeScript Types & Interfaces**: Use PascalCase for custom types and interface models: `CourseResponseDto`, `ApiResponse<T>`.

---

## ⚙️ Backend System (.NET / C#)

*   **Controllers & Services**: Use PascalCase: `CourseController`, `PaymentService`.
*   **Method Declarations**: Use PascalCase for method signatures. Append the `Async` suffix to asynchronous methods: `GetEnrolledCoursesAsync(string userId)`.
*   **Models & Database Schema**: Use PascalCase for database classes and properties: `ApplicationUser`, `CourseId`.
*   **Local Variables**: Use camelCase for local parameters and variables: `enrolledCourseIds`.

---

## 🎨 Code Conventions

*   Ensure folder names and import paths match casing exactly. Case-insensitive systems can compile mismatched paths locally, which will then fail in containerized environments like Docker builds [[deployment]].
