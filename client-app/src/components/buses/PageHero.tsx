export default function PageHero() {
  return (
    <section className="relative h-[150px] flex justify-center text-center">
      <img src="/bus-hero.jpg" alt="bus-hero" className="w-full object-cover opacity-5" />
      <div className="custom-container absolute z-10 size-full">
        <div className="size-full flex flex-col justify-between py-2">
          <div className="w-full flex justify-between items-center">
            <div className="text-left py-2 rounded-sm">
              <h2 className="font-medium mb-1">Onward</h2>
              <p className="font-semibold text-xl">Dhaka To Rajshahi On 23 Oct 2025</p>
            </div>
            <button className="btn btn-primary px-4 py-2">MODIFY SEARCH</button>
          </div>

          <div className="flex justify-between">
            <div className="font-semibold">
              Total Buses Found: 162
            </div>
            <div className="font-semibold">
              Total Operators Found: 5489
            </div>
            <div className="font-semibold">
              Total Seats Available: 5489
            </div>
          </div>
        </div>
      </div>
    </section>
  )
}
