import { Bus, ShipWheel } from "lucide-react";

export default function BusCard() {
  return (
    <div className="bg-background p-6 border border-border shadow rounded-xl flex flex-col gap-4 md:flex-row justify-between items-center">
      <div>
        <h3 className="text-[18px] font-semibold mb-2">National Travels</h3>
        <div className="text-[0.85rem] text-text-secondary mb-2">
          <div className="mb-0.5">99-DHA-CHA</div>
          <div className="border border-border w-fit px-2 py-0.5 rounded-sm flex items-center gap-1"><ShipWheel className="size-4" /> NON AC</div>
        </div>
        <div className="text-primary text-[0.85rem]">Cancellation policy</div>
      </div>

      <div className="flex gap-12 items-center border-t-2 border-b-2 border-border py-3">
        <div className="w-25">
          <p className="text-text-secondary text-[0.8rem] mb-1">Starting</p>
          <p className="font-semibold">6:00 AM</p>
          <p className="text-text-secondary text-[0.8rem]">Kallyanpur</p>
        </div>
        <div className="flex flex-col items-center">
          <div className="mb-[-2px]">
            <Bus className="text-text-secondary" />
          </div>
          <div className="border border-border w-full"></div>
          <div className="text-text-secondary text-[0.9rem] mt-1">Seats Left: <span className="text-primary">36</span></div>
        </div>
        <div className="w-25 text-right">
          <p className="text-text-secondary text-[0.8rem] mb-1">Arrival</p>
          <div className="font-semibold">1:30 PM</div>
          <div className="text-text-secondary text-[0.8rem]">Chapai Nawabganj</div>
        </div>
      </div>

      <div className="price-section">
        <div className="text-success text-[0.8rem] px-2 py border border-success rounded-sm mb-2">No Extra Charge</div>
        <div className="text-primary text-xl font-semibold mb-2">৳700</div>
        <button className="btn btn-primary text-[0.8rem] px-4 py-1.5">VIEW SEATS</button>
      </div>
    </div>
  )
}
