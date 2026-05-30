# 📱 Design System: Responsive Layouts
#ui #design-system #responsive

The VTCLBD platform uses a mobile-first responsive strategy, ensuring a consistent user experience on screens ranging from smartphones to 4K displays.

---

## 📏 Responsive Breakpoints

Tailwind's default responsive breakpoints are used to adapt layouts across different screen widths:

| Token | Min Width | Target Devices | Layout Behavior |
| :--- | :--- | :--- | :--- |
| **Default** | 0px | Mobile Phones | Stacked single-column layouts, full-width inputs, and hidden sidebars. |
| `sm` | 640px | Large Phones | Increased grid padding and wider cards. |
| `md` | 768px | Tablets | Double-column grids and visible bottom navigation. |
| `lg` | 1024px | Laptops | Three-column grids and desktop sidebar layouts. |
| `xl` | 1280px | Desktops | Maximum width restrictions (`max-w-7xl mx-auto`) [[spacing]]. |

---

## 📱 Navigation Components

*   **Public Views**: Uses a slide-out hamburger menu on mobile, which transitions into a horizontal link list on desktop screens.
*   **Student Learning View**:
    *   *Mobile*: Fixed-height video panel with tabs for lesson selection.
    *   *Desktop*: Split view with a sidebar on the left and content on the right [[frontend-architecture]].

---

## 🎨 Code Conventions

*   Do not define arbitrary container widths. Use Tailwind's grid systems: `grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6`.
*   Ensure text sizes adjust dynamically to prevent long headings from overflowing on mobile screens:
    ```typescript
    className="text-3xl sm:text-4xl font-extrabold"
    ```
