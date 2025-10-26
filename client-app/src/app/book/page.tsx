export default function page() {
  return (
    <section className="custom-container py-8 [&>div]:mb-7">
      <div>
        <div className="text-primary font-semibold mb-3 pb-1.5 border-b-2 border-border">PASSENGER INFORMATION</div>
        <div className="grid grid-cols-[repeat(auto-fit,minmax(200px,1fr))] gap-5">
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Passenger Name</div>
            <div className="font-medium">Md Nazmul Hossain</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Mobile Number</div>
            <div className="font-medium">+880 1712-345678</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Gender</div>
            <div className="font-medium">Male</div>
          </div>
        </div>
      </div>

      <div>
        <div className="text-primary font-semibold mb-3 pb-1.5 border-b-2 border-border">BUS INFORMATION</div>
        <div className="grid grid-cols-[repeat(auto-fit,minmax(200px,1fr))] gap-5">
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Bus Company</div>
            <div className="font-medium">National Travels</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Bus Name</div>
            <div className="font-medium">NT Express Premium</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Seat Number</div>
            <div className="font-medium">E-4</div>
          </div>
        </div>
      </div>

      <div>
        <div className="text-primary font-semibold mb-3 pb-1.5 border-b-2 border-border">JOURNEY DETAILS</div>
        <div className="grid grid-cols-[repeat(auto-fit,minmax(200px,1fr))] gap-5">
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Date</div>
            <div className="font-medium">23 October 2025</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Time</div>
            <div className="font-medium">6:30 AM</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Boarding Point</div>
            <div className="font-medium">Kallyanpur Counter</div>
          </div>
          <div>
            <div className="text-sm font-medium text-text-secondary mb-1">Dropping Point</div>
            <div className="font-medium">Chapai Nawabganj</div>
          </div>
        </div>
      </div>

      <div className="flex justify-end mt-12">
        <button className="btn btn-primary px-8 py-3">CONFIRM BOOKING</button>
      </div>
    </section>
  )
}
