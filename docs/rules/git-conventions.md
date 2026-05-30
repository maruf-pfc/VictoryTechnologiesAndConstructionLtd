# 📜 Git & Commit Conventions
#rules #git #conventions

This document outlines version control guidelines and standards for VTCLBD project repositories.

---

## 📋 Commit Message Standard (Conventional Commits)

Commit messages must use standard formats to maintain a clear history:

```
<type>(<scope>): <short description>
```

### Supported Types

*   `feat`: Adding a new system feature or module.
*   `fix`: Addressing bugs or build errors.
*   `docs`: Documentation updates.
*   `style`: Formatting updates or style adjustments (without logic changes).
*   `refactor`: Structural code edits (without new features or bug fixes).
*   `test`: Appending test suites or verifying compilation.
*   `chore`: Project configurations or dependency updates.

### Examples

*   `feat(client-dashboard): implement course details and progress rings`
*   `fix(careers-type): resolve zod form defaultValues schema error`
*   `docs(architecture): create database schemas and ER diagrams`

---

## 🎨 Workflow Rules

1.  **Work in Batches**: Do not commit after every file change. Group related changes and commit them once a specific task is complete.
2.  **Use Workspace Commands**: Stage and commit files by running standard Git commands:
    ```bash
    git add .
    git commit -m "feat(module): description of changes"
    ```
3.  **Clean commits**: Remove debug prints, test inputs, and temporary files before staging changes.
