import { BusInfo } from "@/types/types";
import { Bus, ShipWheel } from "lucide-react";
import { useRouter } from "next/navigation";

interface BusCardProps {
  busInfo: BusInfo;
  fromName: string;
  toName: string;
}

export default function BusCard({ busInfo, fromName, toName }: BusCardProps) {
  const router = useRouter();

  const formatTime = (dateString: string) => {
    const date = new Date(dateString);
    return date.toLocaleTimeString('en-BD', {
      hour: 'numeric',
      minute: '2-digit',
      hour12: true
    });
  };

  const handleViewSeats = () => {
    const params = new URLSearchParams({
      busScheduleId: busInfo.busScheduleId
    });

    router.push(`/bus/booking?${params.toString()}`);
  };

  return (
    <div className="bg-background p-6 border border-border shadow rounded-xl flex flex-col gap-4 md:flex-row justify-between items-center">
      <div>
        <h3 className="text-[18px] font-semibold mb-2">{busInfo.busName}</h3>
        <div className="text-[0.85rem] text-text-secondary mb-2">
          <div className="mb-0.5">{busInfo.routeName}</div>
          <div className="border border-border w-fit px-2 py-0.5 rounded-sm flex items-center gap-1"><ShipWheel className="size-4" /> {busInfo.busType}</div>
        </div>
        <div className="text-primary text-[0.85rem]">Cancellation policy</div>
      </div>

      <div className="flex gap-12 items-center border-t-2 border-b-2 border-border py-3">
        <div className="w-25">
          <p className="text-text-secondary text-[0.8rem] mb-1">Starting</p>
          <p className="font-semibold">{formatTime(busInfo.startTime)}</p>
          <p className="text-text-secondary text-[0.8rem]">{fromName}</p>
        </div>
        <div className="flex flex-col items-center">
          <div className="mb-[-2px]">
            <Bus className="text-text-secondary" />
          </div>
          <div className="border border-border w-full"></div>
          <div className="text-text-secondary text-[0.9rem] mt-1">Seats Left: <span className="text-primary">{busInfo.seatsLeft}</span></div>
        </div>
        <div className="w-25 text-right">
          <p className="text-text-secondary text-[0.8rem] mb-1">Arrival</p>
          <div className="font-semibold">{formatTime(busInfo.arrivalTime)}</div>
          <div className="text-text-secondary text-[0.8rem]">{toName}</div>
        </div>
      </div>

      <div className="price-section">
        <div className="text-success text-[0.8rem] px-2 py border border-success rounded-sm mb-2">No Extra Charge</div>
        <div className="text-primary text-xl font-semibold mb-2">৳{busInfo.price}</div>
        <button onClick={handleViewSeats} className="btn btn-primary text-[0.8rem] px-4 py-1.5">VIEW SEATS</button>
      </div>
    </div>
  )
}
