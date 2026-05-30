# 🛠️ Tech Stack
#architecture #tech-stack

The VTCLBD ecosystem leverages modern, high-performance tech stacks chosen for developer speed, runtime performance, and cloud-native scaling capabilities.

---

## 💻 Frontend Client Stack

| Technology | Purpose | Key Details |
| :--- | :--- | :--- |
| **Next.js 16** | Core Web Framework | App Router, static site generation (SSG), server-side rendering (SSR), and Turbopack compiler. |
| **React 19** | UI Library | Hooks, client-side rendering, portal interfaces, and high-performance DOM reconciliation. |
| **Zustand 5** | State Management | Persisted local storage auth state (`buildcraft-auth`). |
| **React Query 5** | Server State Sync | Cache management, refetching patterns, mutations, and optimistic UI. |
| **Tailwind CSS 4** | Styling Engine | Modern utility styling, custom brand variables, and component transitions. |
| **GSAP 3** | Animation Engine | Timeline-driven banner transitions, page entry staggers, and hover micro-animations. |
| **React Hook Form 7** | Form Handling | Controlled input states, Zod schema validations, and submission lifecycles. |
| **Zod 4** | Schema Validation | Type-safe form parsing and API body validation schemas. |

---

## ⚙️ Backend Web API Stack

| Technology | Purpose | Key Details |
| :--- | :--- | :--- |
| **ASP.NET Core 10** | Web API Engine | REST API controller routing, CORS policies, JWT-based security middleware. |
| **EF Core 10** | Object-Relational Mapper | Code-First database schemas, LINQ queries, and migrations tracking. |
| **ASP.NET Core Identity**| Identity Management | ApplicationUser schema extends IdentityUser. BCrypt hashed passwords. |
| **JWT (JSON Web Tokens)**| Authorization | Token generation, Claims parsing, and Authorization attribute roles checking. |
| **Npgsql** | PostgreSQL Driver | Native .NET database connectivity provider for PostgreSQL. |

---

## 🗄️ Infrastructure & Cloud Services

| Technology | Purpose | Key Details |
| :--- | :--- | :--- |
| **Neon PostgreSQL** | Primary Database | Serverless PostgreSQL database with branch management and connection pooling. |
| **Cloudinary** | Media Asset Storage | Handles project imagery, curriculum videos, and downloadable resources. |
| **Docker & Compose** | Containerization | Multi-stage build recipes for frontend and backend microservices. |
| **GitHub Actions** | CI/CD Pipeline | Auto-runs linter checks, type checking, and compilation builds on PR/Push events. |

---

## 🔗 Related Architecture Links

*   **Architecture Flow**: [[project-overview]]
*   **Client Core**: [[frontend-architecture]]
*   **Server Core**: [[backend-architecture]]
*   **Database Schema**: [[database-schema]]
