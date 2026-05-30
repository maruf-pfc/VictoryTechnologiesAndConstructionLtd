# 🏢 Feature: Careers & Jobs Pipeline
#features #careers

This module displays open career roles at the firm, lists requirements and salary ranges, and provides an application link to a Google Form.

---

## 💼 Recruitment Pipeline Workflow

1.  **Job Posting**: Admin creates a job post in the admin panel by specifying title, department, job type (Full-time, Part-time, Contract), location, salary range, details description, requirements (newline separated), and the Google Form application URL.
2.  **Public Showcase**: The public `/career` page fetches active jobs via `jobService.getAll(true)`.
3.  **Search & Filters**: Users can filter job postings on the client side by department, job type, or keywords.
4.  **Submission**: Clicking "Apply Now" redirects applicants to the designated Google Form link configured for the job.

---

## 💻 Code Implementations

*   **Public Careers Interface**: `client/app/(public)/career/page.tsx`
*   **Job Entity DTO**: `JobResponseDto` containing matching form parameters [[api-structure]].
*   **Admin Job Controls**: Backend `JobController.cs` routes CRUD requests, utilizing `[Authorize(Roles = "Admin")]` for mutations.
*   **Form Conventions**: Forms use React Hook Form with Zod schema validation matching `JobResponseDto` exactly to prevent TypeScript type errors.
