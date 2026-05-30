# 🎬 Design System: Web Animations
#ui #design-system #animations

Animations in the VTCLBD platform use GSAP (GreenSock Animation Platform) for complex multi-element sequences and Tailwind utility keyframes for simple hover transitions.

---

## 📽️ GSAP Landing Page Sequences

The public homepage uses GSAP timelines to animate sections as they enter the viewport:

1.  **Banner Showcase**: Title fades in and slides up (`y: 30`) over 0.8 seconds, followed by subtitle fade-in and call-to-action button entry.
2.  **Staggered Lists**: Grids (like featured courses and projects) use staggered start delays (`stagger: 0.1`) so cards animate in sequence rather than all at once.
3.  **ScrollTriggers**: Animations are bound to scroll depth using `ScrollTrigger`, which triggers entry transitions when sections enter the viewport.

---

## 📋 Micro-Animations & Interactions

*   **Hover Scaling**: Buttons scale slightly on hover (`hover:scale-[1.01] active:scale-[0.99]`) and use smooth easing (`transition-all duration-200`) [[components]].
*   **Icon Slides**: Link details components slide icons on hover, for example, moving arrows slightly right and up:
    ```typescript
    className="group-hover:translate-x-0.5 group-hover:-translate-y-0.5 transition-transform duration-200"
    ```
*   **Spinner Spinners**: Loading states use continuous rotation transitions:
    ```typescript
    className="animate-spin border-4 border-primary border-t-transparent"
    ```

---

## 🎨 Code Conventions

*   Do not animate properties that trigger browser layout recalculations (like `width`, `height`, `top`, or `left`). Stick to GPU-accelerated properties (`transform`, `opacity`, `scale`).
*   GSAP effects must clean up on component unmount to prevent memory leaks in React:
    ```typescript
    useEffect(() => {
      const ctx = gsap.context(() => {
        // Init GSAP timelines here
      });
      return () => ctx.revert(); // Purges listeners and inline styles
    }, []);
    ```
