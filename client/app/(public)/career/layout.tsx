import { Metadata } from "next";

export const metadata: Metadata = {
  title: "Careers",
  description: "Join VTCLBD. Explore job vacancies, civil engineering career paths, and internship positions at Victory Design & Construction Ltd.",
};

export default function CareerLayout({ children }: { children: React.ReactNode }) {
  return <>{children}</>;
}
