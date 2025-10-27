"use client";

import ConfirmedMessage from "@/components/booking/ConfirmedMessage"
import { BookingSummary } from "@/types/types";
import { Loader2 } from "lucide-react";
import { useSearchParams } from "next/navigation";
import { Suspense, useEffect, useState } from "react";

export default function ConfirmationPage() {
  return (
    <Suspense fallback={
      <div className="min-h-screen flex items-center justify-center">
        <Loader2 className="w-12 h-12 animate-spin text-primary" />
      </div>
    }>
      <ConfirmationContent />
    </Suspense>
  );
}

function ConfirmationContent() {
  const searchParams = useSearchParams();
  const [bookingSummary, setBookingSummary] = useState<BookingSummary | null>(null);

  useEffect(() => {
    const data = searchParams.get('data');
    if (data) {
      try {
        const decoded = JSON.parse(decodeURIComponent(data));
        setBookingSummary(decoded);
      } catch (error) {
        console.error('Error parsing booking data:', error);
      }
    }
  }, [searchParams]);

  const formatDate = (dateString: string) => {
    const date = new Date(dateString);
    return date.toLocaleDateString('en-BD', {
      day: 'numeric',
      month: 'long',
      year: 'numeric'
    });
  };

  const formatTime = (dateString: string) => {
    const date = new Date(dateString);
    return date.toLocaleTimeString('en-BD', {
      hour: 'numeric',
      minute: '2-digit',
      hour12: true
    });
  };

  const handleDownload = () => {
    window.print();
  };

  if (!bookingSummary) {
    return (
      <div className="min-h-screen flex items-center justify-center">
        <div className="text-center">
          <Loader2 className="w-12 h-12 animate-spin text-primary mx-auto mb-4" />
          <p className="text-text-secondary">Loading booking confirmation...</p>
        </div>
      </div>
    );
  }

  return (
    <section className="custom-container py-8 [&>div]:mb-7">
      <ConfirmedMessage />
      <div>
        <div className="text-primary font-semibold mb-3 pb-1.5 border-b-2 border-border">PASSENGER INFORMATION</div>
        <div className="grid grid-cols-[repeat(auto-fit,minmax(200px,1fr))] gap-5">
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Passenger Name</div>
            <div className="font-medium">{bookingSummary.passengerName}</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Mobile Number</div>
            <div className="font-medium">{bookingSummary.mobileNumber}</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Gender</div>
            <div className="font-medium">{bookingSummary.gender}</div>
          </div>
        </div>
      </div>

      <div>
        <div className="text-primary font-semibold mb-3 pb-1.5 border-b-2 border-border">BUS INFORMATION</div>
        <div className="grid grid-cols-[repeat(auto-fit,minmax(200px,1fr))] gap-5">
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Bus Company</div>
            <div className="font-medium">{bookingSummary.companyName}</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Bus Name</div>
            <div className="font-medium">{bookingSummary.busName}</div>
          </div>
          <div>
            <div className="text-sm font-medium mb-1">Seat Number{bookingSummary.seatNumbers.length > 1 ? 's' : ''}</div>
            <div className="font-medium">{bookingSummary.seatNumbers.join(', ')}</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Total Price</div>
            <div className="font-medium">৳{bookingSummary.totalPrice}</div>
          </div>
        </div>
      </div>

      <div>
        <div className="text-primary font-semibold mb-3 pb-1.5 border-b-2 border-border">JOURNEY DETAILS</div>
        <div className="grid grid-cols-[repeat(auto-fit,minmax(200px,1fr))] gap-5">
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Date</div>
            <div className="font-medium">{formatDate(bookingSummary.journeyDate)}</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Time</div>
            <div className="font-medium">{formatTime(bookingSummary.boardingTime)}</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Boarding Point</div>
            <div className="font-medium">{bookingSummary.boardingStop}</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Dropping Point</div>
            <div className="font-medium">{bookingSummary.droppingStop}</div>
          </div>
        </div>
      </div>

      <div className="flex justify-end mt-12">
        <button onClick={handleDownload} className="btn btn-primary px-8 py-3">PRINT TICKET</button>
      </div>
    </section>
  )
}
