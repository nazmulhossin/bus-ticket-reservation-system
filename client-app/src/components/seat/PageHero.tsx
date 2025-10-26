export default function PageHero() {
  return (
    <section className="relative flex justify-center items-center text-center">
      <img src="/bus-hero.jpg" alt="bus-hero" className="h-[150px] w-full object-cover opacity-10" />
      <div className="absolute z-10">
        <h1 className="text-4xl font-bold mb-4">Hanif Enterprise</h1>
      </div>
    </section>
  )
}
