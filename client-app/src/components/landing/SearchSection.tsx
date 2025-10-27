"use client";

import { useDebounce } from "@/hooks/useDebounce";
import { getRouteStopSuggestions } from "@/lib/api";
import { RouteStop } from "@/types/types";
import { Loader2, MapPin } from "lucide-react";
import { useRouter } from "next/navigation";
import { useEffect, useRef, useState } from "react";

export default function SearchSection() {
  const router = useRouter();
  const [fromInput, setFromInput] = useState("");
  const [toInput, setToInput] = useState("");
  const [date, setDate] = useState("");

  const [fromCode, setFromCode] = useState("");
  const [toCode, setToCode] = useState("");

  const [fromSuggestions, setFromSuggestions] = useState<RouteStop[]>([]);
  const [toSuggestions, setToSuggestions] = useState<RouteStop[]>([]);

  const [showFromDropdown, setShowFromDropdown] = useState(false);
  const [showToDropdown, setShowToDropdown] = useState(false);

  const [isLoadingFrom, setIsLoadingFrom] = useState(false);
  const [isLoadingTo, setIsLoadingTo] = useState(false);
  const [isSearching, setIsSearching] = useState(false);

  const fromRef = useRef<HTMLDivElement>(null);
  const toRef = useRef<HTMLDivElement>(null);

  const debouncedFromInput = useDebounce(fromInput, 300);
  const debouncedToInput = useDebounce(toInput, 300);

  // Fetch suggestions for "From" field
  useEffect(() => {
    const fetchFromSuggestions = async () => {
      if (debouncedFromInput.length > 0 && !fromCode) {
        setIsLoadingFrom(true);
        const suggestions = await getRouteStopSuggestions(debouncedFromInput);
        setFromSuggestions(suggestions);
        setIsLoadingFrom(false);
        setShowFromDropdown(true);
      } else {
        setFromSuggestions([]);
        setShowFromDropdown(false);
      }
    };

    fetchFromSuggestions();
  }, [debouncedFromInput, fromCode]);

  // Fetch suggestions for "To" field
  useEffect(() => {
    const fetchToSuggestions = async () => {
      if (debouncedToInput.length > 0 && !toCode) {
        setIsLoadingTo(true);
        const suggestions = await getRouteStopSuggestions(debouncedToInput);
        setToSuggestions(suggestions);
        setIsLoadingTo(false);
        setShowToDropdown(true);
      } else {
        setToSuggestions([]);
        setShowToDropdown(false);
      }
    };

    fetchToSuggestions();
  }, [debouncedToInput, toCode]);

  // Close dropdowns when clicking outside
  useEffect(() => {
    const handleClickOutside = (event: MouseEvent) => {
      if (fromRef.current && !fromRef.current.contains(event.target as Node)) {
        setShowFromDropdown(false);
      }
      if (toRef.current && !toRef.current.contains(event.target as Node)) {
        setShowToDropdown(false);
      }
    };

    document.addEventListener("mousedown", handleClickOutside);
    return () => document.removeEventListener("mousedown", handleClickOutside);
  }, []);

  const handleFromSelect = (e: React.MouseEvent, stop: RouteStop) => {
    setFromInput(stop.stopName);
    setFromCode(stop.stopCode);
    setShowFromDropdown(false);
  };

  const handleToSelect = (e: React.MouseEvent, stop: RouteStop) => {
    setToInput(stop.stopName);
    setToCode(stop.stopCode);
    setShowToDropdown(false);
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();

    if (!fromInput || !toInput || !date) {
      alert("Please select valid departure and arrival cities, and a date");
      return;
    }

    setIsSearching(true);
    try {
      // Redirect to search results page with query parameters
      const searchParams = new URLSearchParams({
        from: fromCode,
        to: toCode,
        date: date,
        fromName: fromInput,
        toName: toInput
      });

      router.push(`buses/search?${searchParams.toString()}`);
    } catch (error) {
      console.error("Search error:", error);
      alert("Failed to search buses. Please try again.");
    } finally {
      setIsSearching(false);
    }
  };

  return (
    <section className="relative mt-[-10rem] mb-16 mx-auto">
      <div className="max-w-6xl mx-auto bg-background rounded-lg px-8 py-12 shadow-md">
        <form onSubmit={handleSubmit} className="grid grid-cols-1 md:grid-cols-4 gap-6 items-end">
          {/* From Field */}
          <div className="flex flex-col relative" ref={fromRef}>
            <label htmlFor="from" className="font-semibold mb-2">From</label>
            <div className="relative">
              <MapPin className="absolute left-3 top-1/2 transform -translate-y-1/2 text-text-secondary w-5 h-5" />
              <input
                type="text"
                id="from"
                placeholder="Departure city"
                value={fromInput}
                onChange={(e) => {
                  setFromInput(e.target.value);
                  setFromCode("");
                }}
                onFocus={() => fromSuggestions.length > 0 && setShowFromDropdown(true)}
                required
                autoComplete="off"
                className="border border-border rounded-md p-3 pl-10 w-full focus:outline-none focus:ring-1 focus:ring-primary"
              />
              {isLoadingFrom && (
                <Loader2 className="absolute right-3 top-1/2 transform -translate-y-1/2 text-text-secondary w-5 h-5 animate-spin" />
              )}
            </div>

            {/* From Suggestions Dropdown */}
            {showFromDropdown && fromSuggestions.length > 0 && (
              <div className="absolute top-full left-0 right-0 mt-1 bg-background border border-border rounded-md shadow-lg z-50 max-h-60 overflow-y-auto">
                {fromSuggestions.map((stop) => (
                  <div
                    key={stop.stopCode}
                    onMouseDown={(e) => handleFromSelect(e, stop)}
                    className="w-full text-left px-4 py-3 hover:bg-green-50 transition-colors flex items-center gap-2 border-b border-border last:border-b-0 cursor-pointer"
                  >
                    <MapPin className="w-4 h-4 text-text-secondary" />
                    <div>
                      <p className="font-medium text-text-primary">{stop.stopName}</p>
                      <p className="text-xs text-text-secondary">{stop.stopCode}</p>
                    </div>
                  </div>
                ))}
              </div>
            )}
          </div>

          {/* To Field */}
          <div className="flex flex-col relative" ref={toRef}>
            <label htmlFor="to" className="font-semibold mb-2">To</label>
            <div className="relative">
              <MapPin className="absolute left-3 top-1/2 transform -translate-y-1/2 text-text-secondary w-5 h-5" />
              <input
                type="text"
                id="to"
                placeholder="Arrival city"
                value={toInput}
                onChange={(e) => {
                  setToInput(e.target.value);
                  setToCode('');
                }}
                onFocus={() => toSuggestions.length > 0 && setShowToDropdown(true)}
                required
                autoComplete="off"
                className="border border-border rounded-md p-3 pl-10 w-full focus:outline-none focus:ring-1 focus:ring-primary"
              />
              {isLoadingTo && (
                <Loader2 className="absolute right-3 top-1/2 transform -translate-y-1/2 text-text-secondary w-5 h-5 animate-spin" />
              )}
            </div>

            {/* To Dropdown */}
            {showToDropdown && toSuggestions.length > 0 && (
              <div className="absolute top-full left-0 right-0 mt-1 bg-background border border-border rounded-md shadow-lg z-50 max-h-60 overflow-y-auto">
                {toSuggestions.map((stop) => (
                  <div
                    key={stop.stopCode}
                    onMouseDown={(e) => handleToSelect(e, stop)}
                    className="w-full text-left px-4 py-3 hover:bg-green-50 transition-colors flex items-center gap-2 border-b border-border last:border-b-0 cursor-pointer"
                  >
                    <MapPin className="w-4 h-4 text-text-secondary" />
                    <div>
                      <p className="font-medium text-text-primary">{stop.stopName}</p>
                      <p className="text-xs text-text-secondary">{stop.stopCode}</p>
                    </div>
                  </div>
                ))}
              </div>
            )}
          </div>

          {/* Date Field */}
          <div className="flex flex-col">
            <label htmlFor="date" className="font-semibold mb-2">Journey Date</label>
            <input
              type="date"
              id="date"
              value={date}
              onChange={(e) => setDate(e.target.value)}
              min={new Date().toISOString().split('T')[0]}
              required
              className="border border-border rounded-md p-3 focus:outline-none focus:ring-1 focus:ring-primary"
            />
          </div>

          {/* Submit Button */}
          <button type="submit" className="btn btn-primary py-3">SEARCH BUSES</button>
        </form>
      </div>
    </section>
  );
}
