"use client";

import BusCard from "@/components/buses/BusCard";
import PageHero from "@/components/buses/SearchPageHero";
import { searchAvailableBuses } from "@/lib/api";
import { BusInfo } from "@/types/types";
import { Bus, Loader2 } from "lucide-react";
import { useSearchParams } from "next/navigation";
import { Suspense, useEffect, useState } from "react";

export default function SearchPage() {
  return (
    <Suspense fallback={
      <div className="min-h-screen flex items-center justify-center">
        <Loader2 className="w-12 h-12 animate-spin text-primary" />
      </div>
    }>
      <SearchResults />
    </Suspense>
  );
}

function SearchResults() {
  const searchParams = useSearchParams();
  const [buses, setBuses] = useState<BusInfo[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const from = searchParams.get('from');
  const to = searchParams.get('to');
  const date = searchParams.get('date');
  const fromName = searchParams.get('fromName');
  const toName = searchParams.get('toName');

  useEffect(() => {
    const fetchBuses = async () => {
      if (!from || !to || !date) {
        setError('Missing search parameters');
        setLoading(false);
        return;
      }

      try {
        setLoading(true);
        setError(null);
        const data = await searchAvailableBuses(from, to, date);
        setBuses(data);
      } catch (err) {
        setError('Failed to load buses. Please try again.');
        console.error(err);
      } finally {
        setLoading(false);
      }
    };

    fetchBuses();
  }, [from, to, date]);

  if (loading) {
    return (
      <div className="min-h-screen flex items-center justify-center py-25">
        <div className="text-center">
          <Loader2 className="w-12 h-12 animate-spin text-primary mx-auto mb-4" />
          <p className="text-text-secondary">Searching for available buses...</p>
        </div>
      </div>
    );
  }

  if (error) {
    return (
      <div className="flex items-center justify-center py-25">
        <div className="text-center">
          <p className="text-red-600 mb-4">{error}</p>
          <button onClick={() => window.location.reload()} className="btn btn-primary px-6 py-2">
            Try Again
          </button>
        </div>
      </div>
    );
  }

  return (
    <div>
      <PageHero fromName={fromName!} toName={toName!} date={date!} busFound={buses.length} />
      <div className="custom-container py-10">
        {buses.length === 0 ? (
          <div className="bg-background rounded-lg shadow-md p-12 text-center">
            <Bus className="w-16 h-16 text-text-secondary mx-auto mb-4" />
            <h2 className="text-xl font-semibold text-text-primary mb-2">No Buses Found</h2>
            <p className="text-text-secondary">
              No buses available for the selected route and date. Please try a different date or route.
            </p>
          </div>
        ) : (
          <div className="space-y-5">
            {buses.map((busInfo) => (
              <BusCard key={busInfo.busScheduleId} busInfo={busInfo} fromName={fromName!} toName={toName!} />
            ))}
          </div>
        )}
      </div>
    </div>
  );
}
