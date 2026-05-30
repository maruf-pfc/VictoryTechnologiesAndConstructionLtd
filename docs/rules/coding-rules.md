# 📜 Coding Standards & Conventions
#rules #conventions

This document defines core coding standards for the VTCLBD project to maintain code quality, ease maintenance, and support AI-assisted development.

---

## 🎨 Global Development Guidelines

1.  **Strict Type Safety**: Any type casting (`as any`) or un-typed responses are prohibited. All models and payloads must use TypeScript interfaces or .NET DTO models [[api-structure]].
2.  **Async/Await Execution**: All database queries, client-side API requests, and file system operations must use asynchronous methods to prevent thread pool starvation.
3.  **Strict Linting Rules**: Keep builds warning-free. Address code analysis warnings during local development before pushing to remote branches [[deployment]].

---

## 🔗 Related Guide Links

*   **Frontend Standards**: [[frontend-rules]]
*   **Backend Standards**: [[backend-rules]]
*   **Naming Conventions**: [[naming-conventions]]
*   **Git Guidelines**: [[git-conventions]]
*   **Architecture Principles**: [[architecture-principles]]
