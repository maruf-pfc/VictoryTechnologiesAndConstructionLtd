# ⚙️ Backend Services & Components
#backend #architecture #services

The backend codebase is organized around controller routes, dependency injection interfaces, and database service classes.

---

## 🏗️ Dependency Injection Mapping

Interfaces decouple controller endpoints from the underlying business logic. Service classes are registered in `Program.cs` as scoped dependencies:

```csharp
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
```

---

## 📋 Core Service Class Details

### 👤 UserService (`UserService.cs`)
*   **Role**: Manages Identity profiles and role assignments.
*   **Key Logic**: Implements cascading deletions. When a user account is deleted, the service removes their active enrollments, course progress records, and payment history to maintain database integrity [[database-schema]].

### 🎓 CourseService (`CourseService.cs`)
*   **Role**: Manages courses, modules, video lessons, and curriculum resources.
*   **Key Logic**: The `GetEnrolledCoursesAsync` query checks for active student enrollments:
    ```csharp
    public async Task<IEnumerable<CourseResponseDto>> GetEnrolledCoursesAsync(string userId)
    {
        var enrolledCourseIds = await _context.Enrollments
            .Where(e => e.UserId == userId && e.IsActive)
            .Select(e => e.CourseId)
            .ToListAsync();

        if (enrolledCourseIds.Count == 0) return Enumerable.Empty<CourseResponseDto>();

        return await _context.Courses.Where(c => enrolledCourseIds.Contains(c.Id))...
    ```
    This early return prevents query anomalies when a user has no active enrollments [[api-structure]].

### 💳 PaymentService (`PaymentService.cs`)
*   **Role**: Processes transaction submissions and enrollment activations.
*   **Key Logic**:
    *   `SubmitPaymentAsync` creates a new payment record with a status of `Pending`.
    *   `ApprovePaymentAsync` updates the payment status to `Success` and creates a corresponding record in the `Enrollments` table [[payments]].

---

## 🎨 Code Conventions

*   All database queries must be asynchronous (`ToListAsync`, `FirstOrDefaultAsync`, `SaveChangesAsync`) to avoid blocking the thread pool under heavy traffic.
*   Use DTOs (Data Transfer Objects) instead of returning raw database models to prevent leaking internal database schemas.
