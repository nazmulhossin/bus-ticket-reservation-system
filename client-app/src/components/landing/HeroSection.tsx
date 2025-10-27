export default function HeroSection() {
  return (
    <section className="relative h-[400px] flex justify-center text-center">
      <img src="/bus-hero.jpg" alt="bus-hero" className="w-full object-cover opacity-10" />
      <div className="absolute z-10 mt-16">
        <h1 className="text-5xl font-bold mb-4">Book Your Bus Tickets Online</h1>
        <p className="text-xl">Find and book the best bus at unbeatable prices</p>
      </div>
    </section>
  )
}
