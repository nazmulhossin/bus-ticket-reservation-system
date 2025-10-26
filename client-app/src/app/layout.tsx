import type { Metadata } from "next";
import { Inter } from "next/font/google";
import "./globals.css";
import Link from "next/link";

const inter = Inter({
  subsets: ["latin"],
  display: "swap",
});

export const metadata: Metadata = {
  title: {
    default: "GoBus",
    template: "%s - GoBus",
  },
  description: "GoBus is a smart and efficient Bus Ticket Reservation System designed to simplify online ticket booking, seat selection, and route management.",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className={`${inter.className} antialiased`}>
        <header className="sticky top-0 z-100 bg-background/90 backdrop-blur border-b border-border text-text-primary">
          <div className="custom-container py-4 flex justify-between items-center">
            <div className="flex items-center gap-2"><img src="/bus-logo.png" alt="bus-logo" className="size-7" /> <span className="text-2xl font-bold">GoBus</span></div>
            <nav>
              <ul className="flex gap-8">
                <li><Link href="/">Home</Link></li>
                <li><Link href="/">Routes</Link></li>
                <li><Link href="/">Contact</Link></li>
              </ul>
            </nav>
          </div>
        </header>
        <main className="min-h-screen text-text-primary">
          {children}
        </main>
        <footer className="bg-footerBg text-text-secondary">
          <div className="custom-container py-12">
            <div className="grid grid-cols-[repeat(auto-fit,minmax(250px,1fr))] gap-8 xl:gap-12">
              <div className="footer-section">
                <h4>GoBus</h4>
                <p>GoBus is a smart and efficient Bus Ticket Reservation System designed to simplify online ticket booking, seat selection, and route management.</p>
              </div>
              <div className="footer-section">
                <h4>Quick Links</h4>
                <ul>
                  <li><Link href="#">Help Center</Link></li>
                  <li><Link href="#">FAQ</Link></li>
                  <li><Link href="#">Refund Policy</Link></li>
                </ul>
              </div>
              <div className="footer-section">
                <h4>Company</h4>
                <ul>
                  <li><Link href="#">About Us</Link></li>
                  <li><Link href="#">Careers</Link></li>
                  <li><Link href="#">Contact</Link></li>
                  <li><Link href="#">Privacy Policy</Link></li>
                </ul>
              </div>
              <div className="footer-section">
                <h4>Connect</h4>
                <div className="flex flex-col gap-1">
                  <p><span className="font-semibold">Phone:</span> 01xxxxxxxxx</p>
                  <p><span className="font-semibold">whatsapp:</span> 01xxxxxxxxx</p>
                  <p><span className="font-semibold">Email:</span> info@gobus.com</p>
                </div>
              </div>
            </div>
            <div className="mt-8 pt-8 text-center border-t border-[#2d3748] text-[0.95rem]">
              <p>&copy; 2025 <span className="text-primary">GoBus</span>. All rights reserved</p>
            </div>
          </div>
        </footer>
      </body>
    </html>
  );
}
