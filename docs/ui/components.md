# 🧱 Design System: Core Components
#ui #design-system #components

This document lists the core design system components used across the VTCLBD platform.

---

## 📋 Common Custom Elements

### 🔘 Buttons & Calls-to-Action

Buttons use a consistent pill-shaped/rounded-xl design with smooth hover transitions:

```typescript
// Primary Button
className="px-6 py-3 rounded-xl bg-primary text-primary-foreground font-semibold hover:bg-primary/90 hover:scale-[1.01] active:scale-[0.99] transition-all shadow-md shadow-primary/10"

// Secondary Accent Button
className="px-6 py-3 rounded-xl bg-secondary text-secondary-foreground font-semibold hover:bg-secondary/90 hover:scale-[1.01] active:scale-[0.99] transition-all shadow-md shadow-secondary/10"

// Outline Button
className="px-6 py-3 rounded-xl border border-border text-muted-foreground hover:text-foreground hover:border-primary/40 transition-all"
```

---

### 🗃️ Glassmorphism Cards

Cards use a pure white base, a subtle 1px border, and soft drop shadows to appear elevated:

```typescript
className="rounded-3xl border border-border/80 bg-card p-6 md:p-8 shadow-sm hover:shadow-md hover:border-primary/20 transition-all duration-300 relative overflow-hidden"
```

---

### 🖼️ Fullscreen Frosted Modals (Admin Panel)

To simplify operations, admin CRUD components use full-screen overlay dialogs instead of multi-page forms:

*   **Structure**: Fixed overlay (`fixed inset-0`) with a dark, blurred backdrop (`bg-black/60 backdrop-blur-sm`).
*   **Card Animation**: Slide-up effect on entry (`animate-in fade-in-50 zoom-in-95 duration-200`).
*   **Layout**: Fixed header, scrollable body content (`overflow-y-auto`), and fixed action buttons in the footer.

---

## 🎨 Code Conventions

*   Do not write custom button CSS blocks. Use utility classes to keep interfaces consistent [[colors]].
*   Modals must include close button elements (`RiCloseLine`) in addition to allowing closing by clicking outside the modal content.
