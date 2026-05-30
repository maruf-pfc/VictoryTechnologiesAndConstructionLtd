# 🏢 Feature: Portfolio & CMS Content Management
#features #cms

This module manages public-facing landing page text blocks and the firm's architectural/construction project showcase galleries.

---

## 🎨 Content Block Management (CMS)

To avoid hardcoding site copy, the database includes a `ContentBlocks` table. Admins can edit blocks inside the admin panel:

| Identifier | Purpose | Default Value |
| :--- | :--- | :--- |
| `home-hero-title` | Landing Page Main Banner | `"Building Excellence, Engineering Trust"` |
| `about-us-text` | About section HTML content | `"VTCLBD is Bangladesh's premier training..."`|
| `contact-email` | Site footer email anchor | `"contact@vtclbd.com"` |
| `stats-students` | Dynamic statistics number | `"2500+"` |

---

## 🏗️ Project Showcase CRUD

Admins can manage projects using an admin panel dashboard:
*   **Categories**: Enforced as either `Design` (architecture, interiors) or `Construction` (civil, infrastructure).
*   **Media uploads**: Supports primary showcase imagery, video walk-through URLs, and multiple secondary gallery image arrays (stored as comma-separated links).
*   **Client testimonials**: Optional fields to store client partner comments and representative reviewer names.

---

## 💻 Code Implementations

*   **Modal Form Integration**: Page creation and update forms use a unified modal template in `client/app/(admin)/admin/projects/page.tsx` or `cms/page.tsx` [[frontend-architecture]].
*   **Backend Project Service**: Business logic is decoupled inside `ProjectService.cs`.
*   **SEO Meta-Tagging**: Public index and detail views automatically inject project titles and description tags [[project-overview]].
