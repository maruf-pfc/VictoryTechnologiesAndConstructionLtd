import { Metadata } from "next";

export const metadata: Metadata = {
  title: "Contact Us",
  description: "Get in touch with Victory Design & Construction Ltd. Call or visit our Dhaka and Cumilla offices for architectural blueprints and engineering consultancy.",
};

export default function ContactLayout({ children }: { children: React.ReactNode }) {
  return <>{children}</>;
}
