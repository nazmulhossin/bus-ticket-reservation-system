"use client";

import Legend from "@/components/booking/Legend";
import PageHero from "@/components/booking/PageHero";
import { bookSeats, getBusStops, getSeatPlan } from "@/lib/api";
import { SeatPlan, BusStop, Seat } from "@/types/types";
import { LifeBuoy, Loader2 } from "lucide-react";
import { useRouter, useSearchParams } from "next/navigation";
import { Suspense, useEffect, useState } from "react";

export default function BookingPage() {
  return (
    <Suspense fallback={
      <div className="min-h-screen flex items-center justify-center">
        <Loader2 className="w-12 h-12 animate-spin text-primary" />
      </div>
    }>
      <BookingContent />
    </Suspense>
  )
}

function BookingContent() {
  const router = useRouter();
  const searchParams = useSearchParams();
  const [seatPlan, setSeatPlan] = useState<SeatPlan | null>(null);
  const [busStops, setBusStops] = useState<BusStop[]>([]);
  const [loading, setLoading] = useState(true);
  const [submitting, setSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [selectedSeats, setSelectedSeats] = useState<string[]>([]);
  const [formData, setFormData] = useState({
    boardingPoint: "",
    droppingPoint: "",
    passengerName: "",
    gender: "",
    mobileNumber: ""
  });

  const busScheduleId = searchParams.get("busScheduleId") || "";

  useEffect(() => {
    const fetchData = async () => {
      if (!busScheduleId) {
        setError("Missing bus schedule ID");
        setLoading(false);
        return;
      }

      try {
        setLoading(true);
        setError(null);

        const [seatPlanData, stopsData] = await Promise.all([
          getSeatPlan(busScheduleId),
          getBusStops(busScheduleId)
        ]);

        setSeatPlan(seatPlanData);
        setBusStops(stopsData);
      } catch (err) {
        setError("Failed to load booking information. Please try again.");
        console.error(err);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [busScheduleId]);

  const handleSeatClick = (seat: Seat) => {
    if (seat.status !== "Available") return;

    setSelectedSeats(prev => {
      if (prev.includes(seat.seatId)) {
        return prev.filter(id => id !== seat.seatId);
      } else {
        return [...prev, seat.seatId];
      }
    });
  };

  const getSeatClass = (seat: Seat) => {
    const baseClass = "size-10 border-2 flex justify-center items-center cursor-pointer transition-colors";

    if (selectedSeats.includes(seat.seatId)) {
      return `${baseClass} bg-green-500 text-white border-green-600`;
    }

    if (seat.status === "Booked" && seat.gender === "Female") {
      return `${baseClass} bg-pink-400 border-pink-500 cursor-not-allowed`;
    }

    if (seat.status === "Booked" && seat.gender === "Male") {
      return `${baseClass} bg-purple-400 border-purple-500 cursor-not-allowed`;
    }

    if (seat.status === "Sold" && seat.gender === "Male") {
      return `${baseClass} bg-purple-600 border-purple-700 cursor-not-allowed`;
    }

    if (seat.status === "Sold" && seat.gender === "Female") {
      return `${baseClass} bg-pink-600 border-pink-700 cursor-not-allowed`;
    }

    return `${baseClass} bg-white border-border hover:bg-green-50`;
  };

  const calculateTotal = () => {
    if (!seatPlan) return 0;
    return selectedSeats.length * seatPlan.price;
  };

  const handleSubmit = async () => {
    if (selectedSeats.length === 0) {
      alert("Please select at least one seat");
      return;
    }

    if (!formData.passengerName) {
      alert("Please enter passenger name");
      return;
    }

    if (!formData.boardingPoint || !formData.droppingPoint || !formData.gender || !formData.mobileNumber) {
      alert("Please fill in all required fields");
      return;
    }

    if (!/^01[0-9]{9}$/.test(formData.mobileNumber.replace(/[\s-]/g, ""))) {
      alert("Please enter a valid Bangladeshi mobile number (e.g., 01XXXXXXXXX)");
      return;
    }

    setSubmitting(true);

    console.log('Booking Data:', {
      busScheduleId,
      selectedSeats,
      ...formData
    });

    try {
      const bookingRequest = {
        busScheduleId,
        seatIds: selectedSeats,
        boardingStopCode: formData.boardingPoint,
        droppingStopCode: formData.droppingPoint,
        passengerName: formData.passengerName,
        mobileNumber: "+88" + formData.mobileNumber,
        passengerGender: formData.gender
      };

      const response = await bookSeats(bookingRequest);

      if (response.success) {
        const bookingSummaryEncoded = encodeURIComponent(JSON.stringify(response.bookingSummary));
        router.push(`booking/confirmation?data=${bookingSummaryEncoded}`);
      } else {
        alert(response.message || 'Booking failed. Please try again.');
      }
    } catch (err: any) {
      console.error('Booking error:', err);
      alert(err.message || 'Failed to book seats. Please try again.');
    } finally {
      setSubmitting(false);
    }
  };

  const formatTime = (dateString: string) => {
    const date = new Date(dateString);
    return date.toLocaleTimeString('en-BD', {
      hour: 'numeric',
      minute: '2-digit',
      hour12: true
    });
  };

  // Group seats by row
  const groupSeatsByRow = () => {
    if (!seatPlan) return {};

    const grouped: { [key: number]: Seat[] } = {};
    seatPlan.seats.forEach(seat => {
      if (!grouped[seat.rowNumber]) {
        grouped[seat.rowNumber] = [];
      }
      grouped[seat.rowNumber].push(seat);
    });

    return grouped;
  };

  const seatsByRow = groupSeatsByRow();

  if (loading) {
    return (
      <div className="min-h-screen flex items-center justify-center py-25">
        <div className="text-center">
          <Loader2 className="w-12 h-12 animate-spin text-primary mx-auto mb-4" />
          <p className="text-text-secondary">Loading seat information...</p>
        </div>
      </div>
    );
  }

  if (error || !seatPlan) {
    return (
      <div className="min-h-screen flex items-center justify-center">
        <div className="text-center">
          <p className="text-red-600 mb-4">{error || "Failed to load data"}</p>
          <button onClick={() => window.history.back()} className="btn btn-primary px-6 py-2">
            Go Back
          </button>
        </div>
      </div>
    );
  }

  return (
    <>
      <PageHero title={seatPlan.busName} />
      <section className="custom-container my-12 py-8 border-2 border-border rounded-xl">
        <Legend />
        <div className="flex flex-col md:flex-row gap-15 justify-between mt-6">
          {/* Seat Plan */}
          <div className="text-gray-600 border-2 border-border h-fit min-w-[350px] px-2 py-3">
            <div className="flex justify-end border-b-2 border-border pb-3">
              <LifeBuoy className="size-9" />
            </div>
            <div className="mt-4 space-y-4">
              {Object.entries(seatsByRow).map(([rowNumber, seats]) => (
                <div key={rowNumber} className="grid grid-cols-4 gap-4">
                  {seats.map(seat => (
                    <div key={seat.seatId} onClick={() => handleSeatClick(seat)} className={getSeatClass(seat)}>
                      {seat.seatNumber}
                    </div>
                  ))}
                </div>
              ))}
            </div>
          </div>

          {/* Booking Info */}
          <div className="flex flex-col gap-5">
            <div className="flex flex-col gap-2">
              <label className="font-semibold">Boarding Point<span className="text-red-500">*</span></label>
              <select
                value={formData.boardingPoint}
                onChange={(e) => setFormData({ ...formData, boardingPoint: e.target.value })}
                className="border border-border p-3 rounded-sm focus:outline-none"
              >
                <option value="">Select boarding point</option>
                {busStops.map(stop => (
                  <option key={stop.stopCode} value={stop.stopCode}>
                    {`[${formatTime(stop.arrivalTime)}]`} {stop.stopName}
                  </option>
                ))}
              </select>
            </div>

            <div className="flex flex-col gap-2">
              <label className="font-semibold">Dropping Point<span className="text-red-500">*</span></label>
              <select
                value={formData.droppingPoint}
                onChange={(e) => setFormData({ ...formData, droppingPoint: e.target.value })}
                className="border border-border p-3 rounded-sm focus:outline-none"
              >
                <option value="">Select dropping point</option>
                {busStops.map(stop => (
                  <option key={stop.stopCode} value={stop.stopCode}>
                    {`[${formatTime(stop.arrivalTime)}]`} {stop.stopName}
                  </option>
                ))}
              </select>
            </div>

            <div className="flex flex-col gap-2">
              <label className="font-semibold">Passenger Name<span className="text-red-500">*</span></label>
              <input
                type="text"
                placeholder="Enter passenger name"
                value={formData.passengerName}
                onChange={(e) => setFormData({ ...formData, passengerName: e.target.value })}
                required
                className="border border-border p-3 rounded-sm focus:outline-none"
              />
            </div>

            <div className="flex flex-col gap-2">
              <label className="font-semibold">Gender<span className="text-red-500">*</span></label>
              <div className="flex gap-4">
                <div className="flex gap-1 items-center">
                  <input
                    type="radio"
                    id="male"
                    name="gender"
                    value="male"
                    checked={formData.gender === 'male'}
                    onChange={(e) => setFormData({ ...formData, gender: e.target.value })}
                  />
                  <label htmlFor="male">Male</label>
                </div>
                <div className="flex gap-1 items-center">
                  <input
                    type="radio"
                    id="female"
                    name="gender"
                    value="female"
                    checked={formData.gender === 'female'}
                    onChange={(e) => setFormData({ ...formData, gender: e.target.value })}
                  />
                  <label htmlFor="female">Female</label>
                </div>
                <div className="flex gap-1 items-center">
                  <input
                    type="radio"
                    id="other"
                    name="gender"
                    value="other"
                    checked={formData.gender === 'other'}
                    onChange={(e) => setFormData({ ...formData, gender: e.target.value })}
                  />
                  <label htmlFor="other">Other</label>
                </div>
              </div>
            </div>

            <div className="flex flex-col gap-2">
              <label className="font-semibold">Mobile Number<span className="text-red-500">*</span></label>
              <div className="flex items-center border border-border rounded-sm">
                <span className="h-full flex items-center font-medium px-3 bg-gray-100 text-text-primary border-r border-border select-none">+88</span>
                <input
                  type="tel"
                  placeholder="Enter your mobile number"
                  value={formData.mobileNumber}
                  onChange={(e) => setFormData({ ...formData, mobileNumber: e.target.value })}
                  required
                  className="p-3 flex-1 focus:outline-none"
                />
              </div>
            </div>

            <div className="bg-gray-50 text-text-primary p-4 rounded-sm border-l-3 border-primary">
              <div className="flex justify-between mb-2">
                <span>Seat Fare ({selectedSeats.length} seat{selectedSeats.length !== 1 ? 's' : ''}):</span>
                <span>৳{calculateTotal()}</span>
              </div>
              <div className="flex justify-between mb-2">
                <span>Service Charge:</span>
                <span>৳0</span>
              </div>
              <div className="flex justify-between mb-2">
                <span>PGW Charge:</span>
                <span>৳0</span>
              </div>
              <div className="flex justify-between mb-2">
                <span>Total Discount:</span>
                <span>৳0</span>
              </div>
              <div className="flex justify-between text-gray-800 font-semibold border-t border-gray-300 pt-2 mt-2">
                <span>Total:</span>
                <span>৳{calculateTotal()}</span>
              </div>
            </div>

            <button onClick={handleSubmit} className="btn btn-primary py-3">SUBMIT</button>

            <div className="bg-blue-50 text-sm border border-blue-300 rounded-sm p-3">
              <p>
                I have already verified my phone number, and have a password.{' '}
                <a href="#" className="text-primary hover:underline">Login with password</a>.
              </p>
              <p className="mt-3">
                By logging in you are agreeing to the{' '}
                <a href="#" className="text-primary hover:underline">Terms & Conditions</a> and{' '}
                <a href="#" className="text-primary hover:underline">Privacy Notice</a> of GoBus.
              </p>
            </div>
          </div>
        </div>
      </section>
    </>
  );
}