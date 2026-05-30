# 📜 Backend Rules
#rules #backend

These guidelines define backend coding standards for the ASP.NET Core 10 Web API and EF Core database configurations.

---

## 🎨 API Controller Layout

1.  **Attribute Routing**: Use standard attribute routing on controllers:
    ```csharp
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    ```
2.  **Explicit Routing**: Annotate controller actions explicitly: `[HttpGet("enrolled")]` or `[HttpPost("request")]` [[api-structure]].
3.  **Authentication & Authorization Policies**: Add `[Authorize(Roles = "Admin")]` or `[Authorize]` attributes to controllers and actions that require authentication.

---

## 🎨 Service and Database Access

*   **Dependency Injection**: Decouple logic by injecting service interfaces instead of concrete classes into controllers [[backend-docs]].
*   **Asynchronous Queries**: Write database queries asynchronously using `ToListAsync()`, `AnyAsync()`, or `SaveChangesAsync()`.
*   **Prevent Database Query Anomalies**: Add safety validation checks to queries (for example, checking for empty arrays before running database lookups) [[database-schema]].

---

## 🎨 Exception Handling & Logging

*   Do not return stack traces or raw database error details to the client.
*   Log error exceptions on the backend, and return formatted, user-friendly responses using the standard `ApiResponse<T>` DTO.
