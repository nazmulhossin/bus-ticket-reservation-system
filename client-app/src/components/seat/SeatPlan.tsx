import { LifeBuoy } from "lucide-react";

export default function SeatPlan() {
  return (
    <div className="text-text-secondary border-2 border-border h-fit min-w-[350px] px-2 py-3">
      <div className="flex justify-end border-b-2 border-border pb-3">
        <LifeBuoy className="size-9" />
      </div>
      <div className="grid grid-cols-4 gap-4 mt-4 [&>div]:size-10 [&>div]:border-2 [&>div]:border-border [&>div]:flex [&>div]:justify-center [&>div]:items-center [&>div]:cursor-pointer">
        <div>A1</div>
        <div>A2</div>
        <div>A3</div>
        <div>A4</div>

        <div>B5</div>
        <div>B6</div>
        <div>B7</div>
        <div>B8</div>
      </div>
    </div>
  )
}
