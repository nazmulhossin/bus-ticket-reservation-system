import BookingInfo from "@/components/seat/BookingInfo";
import Legend from "@/components/seat/Legend";
import PageHero from "@/components/seat/PageHero";
import SeatPlan from "@/components/seat/SeatPlan";

export default function page() {
  return (
    <>
      <PageHero />
      <section className="custom-container my-12 py-8 border-2 border-border rounded-xl">
        <Legend />
        <div className="flex flex-col md:flex-row gap-15 justify-between mt-6">
          <SeatPlan />
          <BookingInfo />
        </div>
      </section>
    </>
  )
}
