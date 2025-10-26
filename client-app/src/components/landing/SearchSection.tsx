export default function SearchSection() {
  return (
    <section className="relative mt-[-10rem] mb-16 mx-auto">
      <div className="max-w-6xl mx-auto bg-background rounded-lg px-8 py-12 shadow-md">
        <form className="grid grid-cols-1 md:grid-cols-4 gap-6 items-end">
          <div className="flex flex-col">
            <label htmlFor="from" className="font-semibold mb-2">From</label>
            <input type="text" id="from" placeholder="Departure city" required className="border border-border rounded-md p-3" />
          </div>
          <div className="flex flex-col">
            <label htmlFor="to" className="font-semibold mb-2">To</label>
            <input type="text" id="to" placeholder="Arrival city" required className="border border-border rounded-md p-3" />
          </div>
          <div className="flex flex-col">
            <label htmlFor="date" className="font-semibold mb-2">Journey Date</label>
            <input type="date" id="date" required className="border border-border rounded-md p-3"/>
          </div>
          <button type="submit" className="btn btn-primary py-3">Search Buses</button>
        </form>
      </div>
    </section>
  )
}
