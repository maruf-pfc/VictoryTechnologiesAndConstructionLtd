# 📏 Design System: Spacing & Layout
#ui #design-system #spacing

VTCLBD layouts follow a consistent 8px grid system to ensure visual harmony across landing pages, dashboards, and modal overlays.

---

## 📐 Layout Containers

The maximum width of public and dashboard content pages is restricted using Tailwind's layout utilities:

*   **Public Landing Pages**: Enforced at `max-w-7xl mx-auto px-4 sm:px-6 lg:px-8`.
*   **Student Learning View**: Structured as a double-column layout:
    *   *Left Sidebar*: Fixed-width sidebar (`w-80`) housing modules and lesson lists.
    *   *Right Content*: Flexible column (`flex-1`) containing the video player and markdown resources.

---

## 📋 Grid Spacing System

Common spacing guidelines for layout margins and padding:

| Utility Token | Pixel Value | Target Usage |
| :--- | :--- | :--- |
| `gap-3` / `p-3` | 12px | Thumbnail grids, tiny cards, input lists. |
| `gap-6` / `p-6` | 24px | Default card internal padding, dashboard list gaps. |
| `gap-10` / `p-10` | 40px | Section content splits, double-column margins. |
| `py-16` / `py-24` | 64px - 96px | Hero banner height padding, homepage section separation. |

---

## 🎨 Code Conventions

*   Do not use arbitrary margin values in components (e.g., `mt-[17px]`). Stick to standard Tailwind values (`mt-4`, `mt-5`, etc.).
*   Components must support responsive padding switches, for example: `p-4 sm:p-6 md:p-8` to ensure a consistent look across screen sizes [[responsive-rules]].
