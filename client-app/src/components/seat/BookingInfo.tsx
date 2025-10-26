export default function BookingInfo() {
  return (
    <div className="flex flex-col gap-5">
      <div className="flex flex-col gap-2">
        <label className="font-semibold">Boarding Point<span className="text-red-500">*</span></label>
        <select className="border border-border p-3 rounded-sm">
          <option>06:00 AM - Kallyanpur counter</option>
          <option>07:00 AM - Mirpur counter</option>
          <option>08:00 AM - Gulshan counter</option>
        </select>
      </div>

      <div className="flex flex-col gap-2">
        <label className="font-semibold">Dropping Point<span className="text-red-500">*</span></label>
        <select className="border border-border p-3 rounded-sm">
          <option>Select dropping point</option>
          <option>10:30 AM - Baneshore Counter</option>
          <option>11:30 AM - Rajshahi Counter</option>
          <option>01:00 PM - Rajabari Counter</option>
        </select>
      </div>

      <div className="flex flex-col gap-2">
        <label className="font-semibold">Gender<span className="text-red-500">*</span></label>
        <div className="flex gap-4 [&>div]:flex [&>div]:gap-1">
          <div className="gender-option">
            <input type="radio" id="male" name="gender" value="male" />
            <label htmlFor="male">Male</label>
          </div>
          <div className="gender-option">
            <input type="radio" id="female" name="gender" value="female" />
            <label htmlFor="female">Female</label>
          </div>
          <div className="gender-option">
            <input type="radio" id="other" name="gender" value="other" />
            <label htmlFor="other">Other</label>
          </div>
        </div>
      </div>

      <div className="flex flex-col gap-2">
        <label className="font-semibold">Mobile Number<span className="text-red-500">*</span></label>
        <input type="tel" placeholder="Enter your mobile number" required className="border border-border p-3 rounded-sm" />
      </div>

      <div className="bg-gray-50 text-text-secondary p-4 rounded-sm border-l-3 border-primary [&>div]:flex [&>div]:justify-between [&>div]:mb-2">
        <div>
          <span>Seat Fare:</span>
          <span>৳700</span>
        </div>
        <div>
          <span>Service Charge:</span>
          <span>৳0</span>
        </div>
        <div>
          <span>PGW Charge:</span>
          <span>৳0</span>
        </div>
        <div>
          <span>Total Discount:</span>
          <span>৳0</span>
        </div>
        <div className="text-text-primary font-semibold border-t border-border pt-2">
          <span>Total:</span>
          <span>৳700</span>
        </div>
      </div>

      <button className="btn btn-primary font-semibold py-3">SUBMIT</button>

      <div className="bg-blue-100 text-sm border border-blue-300 rounded-sm p-3">
        <p>I have already verified my phone number, and have a password. <a href="#" className="text-primary">Login with password</a>.</p>
        <p className="mt-3">By logging in you are agreeing to the <a href="#" className="text-primary">Terms & Conditions</a> and <a href="#" className="text-primary">Privacy Notice</a> of GoBus.</p>
      </div>
    </div>
  )
}
