export default function Legend() {
  return (
    <div className="flex flex-wrap gap-8 text-text-secondary pb-4 border-b border-border [&>div]:flex [&>div]:gap-1 [&>div]:items-center">
      <div>
        <div className="bg-purple-400 size-4"></div>
        <span>Booked (M)</span>
      </div>
      <div>
        <div className="bg-pink-400 size-4"></div>
        <span>Booked (F)</span>
      </div>
      <div>
        <div className="border-2 border-border size-4"></div>
        <span>Available</span>
      </div>
      <div>
        <div className="bg-green-500 size-4"></div>
        <span>Selected</span>
      </div>
      <div>
        <div className="bg-purple-600 size-4"></div>
        <span>Sold (M)</span>
      </div>
      <div>
        <div className="bg-pink-600 size-4"></div>
        <span>Sold (F)</span>
      </div>
    </div>
  )
}
