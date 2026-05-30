# ♿ Design System: Accessibility
#ui #design-system #accessibility

This document outlines accessibility standards to keep the VTCLBD platform usable for all visitors.

---

## 🎨 Color Contrast Standards

Color combinations must meet WCAG AA standards, requiring a contrast ratio of at least 4.5:1 for normal text and 3:1 for large text:

*   **Dark text on light background**: Slate Grey (`--foreground`) on warm white (`--background`) yields a contrast ratio > 10:1.
*   **White text on primary blue**: Primary foreground on primary blue yields a contrast ratio > 5.5:1.
*   **Avoid yellow text on white**: Warning text must use dark backgrounds or darker amber shades (`text-amber-700` on `bg-amber-50` border) [[colors]].

---

## 📋 Interactive HTML Elements

1.  **Form Labels**: Input tags must be linked to corresponding `<label>` tags or use explicit `aria-label` attributes.
2.  **Keyboard Navigation**: Interactive elements (buttons, links, inputs) must display visible focus outlines (`focus-visible:ring-2 focus-visible:ring-primary`) when focused.
3.  **Dynamic Modals**: Full-screen modals must handle focus management by trapping focus within the modal and returning focus to the trigger element when closed [[components]].

---

## 🎨 Code Conventions

*   All image tags (`<img>` or Next.js `<Image>`) must include descriptive `alt="..."` attributes for screen readers.
*   Avoid using color as the only way to convey information (for example, error fields should display descriptive text messages, not just a red border).
