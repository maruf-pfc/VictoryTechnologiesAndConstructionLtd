# 🎨 Design System: Colors
#ui #design-system #colors

The VTCLBD application uses a curated modern color palette. Color values are defined as global OKLCH CSS variables in `globals.css` for runtime theme support.

---

## 🎨 Core Brand Palette

The primary colors are selected to project trust, professional construction quality, and engineering excellence:

*   **Primary Brand Blue (`#135c7c`)**:
    *   OKLCH Value: `oklch(0.49 0.09 225)`
    *   Tailwind Token: `var(--primary)`
    *   Usage: Main headers, primary CTAs, active status outlines, hover highlights.
*   **Secondary Brand Cyan (`#39c2e3`)**:
    *   OKLCH Value: `oklch(0.76 0.12 215)`
    *   Tailwind Token: `var(--secondary)`
    *   Usage: Accent details, gradients, progress rings, progress bar fills.

---

## 🎨 Global Theme Tokens

Below is the CSS custom property map loaded in `:root`:

```css
:root {
    --background: oklch(0.99 0.003 220);         /* Warm Off-White */
    --foreground: oklch(0.18 0.01 240);          /* Dark Slate Grey */

    --card: oklch(1 0 0);                        /* Pure White Card Background */
    --card-foreground: oklch(0.18 0.01 240);

    --primary: oklch(0.49 0.09 225);             /* Primary Brand Blue */
    --primary-foreground: oklch(0.985 0 0);      /* White text on Primary */

    --secondary: oklch(0.76 0.12 215);           /* Secondary Brand Cyan */
    --secondary-foreground: oklch(0.18 0.01 240);/* Dark text on Secondary */

    --muted: oklch(0.96 0.005 240);              /* Soft Background Grey */
    --muted-foreground: oklch(0.45 0.01 240);    /* Secondary / Subtitle Text */

    --border: oklch(0.92 0.005 240);             /* Subtle Card Borders */
}
```

---

## 🎨 Code Conventions

*   Do not use raw color hex values in markup. Use Tailwind utility values like `bg-primary`, `text-secondary`, or `border-border`.
*   Ensure text on background elements meets color contrast standards [[accessibility]].
