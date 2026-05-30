# 📜 Architecture Principles
#rules #architecture #principles

This document outlines core architectural principles to guide future development and maintenance of the VTCLBD platform.

---

## 🏛️ Core Principles

### 1. Separation of Concerns (SoC)
Keep layers distinct:
*   **Controller Layer**: Handles API routing, parses parameters, and returns standardized DTO responses [[api-structure]].
*   **Service Layer**: Encapsulates business logic (such as calculating progress percentages or deleting related database records) [[backend-docs]].
*   **Data Layer**: Manages the database context and seeds initial database states [[database-schema]].

### 2. Client-Server Decoupling
*   The client communicates with the server exclusively via HTTP requests, passing JSON payloads.
*   The backend should not depend on client layout states or page routes.
*   Client authentication states are managed locally, and authorization tokens are passed dynamically in request headers [[authentication-flow]].

### 3. Single Source of Truth
*   System settings and landing page copy are stored in the database's content blocks rather than hardcoded in the frontend [[cms]].
*   Core design system values (such as brand colors) are managed through centralized variables [[colors]].
*   Authentication state is managed by the Zustand store, which handles the session token and user profile details.

---

## 🎨 Code Conventions

*   Do not mix business logic directly inside controller action methods. Delegate these operations to service classes.
*   Avoid nesting logic deep within components. Split complex structures into reusable sub-components.
