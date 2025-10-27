import Link from "next/link";

interface PageHeroProps {
  fromName: string;
  toName: string;
  date: string;
  busFound: number;
}

export default function PageHero({ fromName, toName, date, busFound }: PageHeroProps) {
  return (
    <section className="relative h-[150px] flex justify-center text-center">
      <img src="/bus-hero.jpg" alt="bus-hero" className="w-full object-cover opacity-5" />
      <div className="custom-container absolute z-10 size-full">
        <div className="size-full flex flex-col justify-between py-2">
          <div className="w-full flex justify-between items-center">
            <div className="text-left py-2 rounded-sm">
              <h2 className="font-medium mb-1">Onward</h2>
              <p className="font-semibold text-[18px]">{fromName} To {toName} On {new Date(date!).toLocaleDateString("en-GB", { day: "2-digit", month: "short", year: "numeric" })}</p>
            </div>
            <Link href="/" className="btn btn-primary px-4 py-2">MODIFY SEARCH</Link>
          </div>

          <div className="flex justify-between">
            <div className="font-semibold">
              Total Buses Found: {busFound}
            </div>
            <div className="font-semibold">
              Total Operators Found: -
            </div>
            <div className="font-semibold">
              Total Seats Available: -
            </div>
          </div>
        </div>
      </div>
    </section>
  )
}
