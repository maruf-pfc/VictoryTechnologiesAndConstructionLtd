# 🔐 Feature: Authentication & Role-Based Access Control (RBAC)
#features #auth

This module enforces user login sessions, registers student users, and restricts API endpoints and client pages according to active roles.

---

## 👥 Roles Definition Matrix

The application supports three primary roles:

| Role Name | Authority Scope | Target Access |
| :--- | :--- | :--- |
| **Admin** | High | Admin CRUD overlays, system settings, manual payment approval, and course publishing. |
| **Student**| Medium | Student learning dashboard, active courses lessons, progress tracking, and certificate access. |
| **User** | Low | Public landing views. Profile status, but cannot access dashboard routes without active course enrollments. |

---

## 🛠️ Code Implementations

### 👤 Backend User Model (`ApplicationUser.cs`)

The custom user class extends ASP.NET Core Identity with fields for profiles and track histories:

```csharp
public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string Role { get; set; } = "User"; // Default Role
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
```

### 🔒 Client Authorization Guard (React 19 / Next.js 16)

Page routing checks rely on hydration checks inside specific layouts to prevent authorization leakage.

```typescript
// Example from app/(dashboard)/layout.tsx
"use client";

import { useEffect, useState } from "react";
import { useRouter } from "next/navigation";
import { useAuthStore } from "@/stores/auth.store";

export default function DashboardLayout({ children }: { children: React.ReactNode }) {
  const router = useRouter();
  const { user, isAuthenticated } = useAuthStore();
  const [mounted, setMounted] = useState(false);

  useEffect(() => {
    setMounted(true);
  }, []);

  useEffect(() => {
    if (mounted && (!isAuthenticated || user?.role !== "Student")) {
      router.push("/auth/login");
    }
  }, [mounted, isAuthenticated, user, router]);

  if (!mounted || !isAuthenticated) {
    return <div className="min-h-screen flex items-center justify-center">Loading...</div>;
  }

  return <>{children}</>;
}
```

---

## 🔗 Related Architecture Links

*   **Security Architecture**: [[authentication-flow]]
*   **API Configuration**: [[api-structure]]
