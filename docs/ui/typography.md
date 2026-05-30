# 🗚 Design System: Typography
#ui #design-system #typography

The typography system uses highly readable, modern fonts designed for technical software interfaces and engineering portals.

---

## 🔠 Font Families

The layout uses the Next.js `next/font/google` loader to load font assets locally, improving performance and SEO:

*   **Heading Font (Outfit / Manrope)**: Used for landing section headers, page titles, and hero components. Designed for clean legibility at large scale.
*   **Body Font (Inter)**: Clean sans-serif font optimized for readability in long paragraphs, dashboard listings, and system text.
*   **Mono Font (Fira Code / JetBrains Mono)**: Monospace font used for certificate validation IDs, transaction numbers, and timestamp listings.

---

## 📋 Text Hierarchy

Enforced typographic sizing rules:

| Token / Class | Font Size | Weight | Line Height | Target Usage |
| :--- | :--- | :--- | :--- | :--- |
| `text-4xl` to `text-5xl` | 36px - 48px | Extrabold (800) | Tight | Hero titles, landing page banners. |
| `text-2xl` to `text-3xl` | 24px - 30px | Bold (700) | Snug | Section headers, card block titles. |
| `text-base` | 16px | Regular (400) | Relaxed | Paragraph copy, narrative sections. |
| `text-sm` | 14px | Medium (500) | Normal | Dashboard tables, buttons, inputs. |
| `text-xs` | 12px | SemiBold (600) | Tight | Badge labels, secondary descriptions. |

---

## 🎨 Code Conventions

*   Header tags must match semantic structures (single `h1` per view, cascading down to `h2`, `h3`, etc.) [[project-overview]].
*   Use Tailwind properties like `tracking-tight` on header nodes and `leading-relaxed` on paragraph copy to maintain clean visual spacing.
