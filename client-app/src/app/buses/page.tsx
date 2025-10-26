import BusCard from "@/components/buses/BusCard";
import PageHero from "@/components/buses/PageHero";

export default function page() {
  return (
    <div>
      <PageHero />
      <section className="custom-container py-12 flex flex-col gap-4">
        <BusCard />
      </section>
    </div>
  )
}
