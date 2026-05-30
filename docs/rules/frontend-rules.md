# 📜 Frontend Rules
#rules #frontend

These guidelines define frontend coding standards for the React 19 and Next.js 16 (App Router) codebase.

---

## 🎨 Next.js Page Structure

1.  **Rendering Directive**: Specify client components using the `"use client";` directive at the top of the file.
2.  **React Hook Form Integration**: Form schemas must map to DTO types. Define default form state objects explicitly:
    ```typescript
    const form = useForm<JobRequestDto>({
      resolver: zodResolver(jobSchema),
      defaultValues: {
        title: "",
        department: "",
        requirements: ""
      }
    });
    ```
    This matches form schemas to validation structures and prevents compiler type errors.
3.  **JSX Component Structure**:
    *   Place hooks at the top of the component.
    *   Organize helper functions (like classes or visual formatting logic) below state declarations.
    *   Clean up side effects (like GSAP contexts or scroll listeners) on unmount [[animation-rules]].

---

## 🎨 Server State Sync (React Query)

*   Always define query keys as arrays: `queryKey: ["progress", courseId]`.
*   Handle query loading states cleanly inside component returns to prevent screen flicker [[frontend-architecture]].
*   Use standard catch blocks to handle API errors and display descriptive error messages to the user.
