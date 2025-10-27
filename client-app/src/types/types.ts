export interface RouteStop {
  stopName: string;
  stopCode: string;
}

export interface SearchFormData {
  from: string;
  fromCode: string;
  to: string;
  toCode: string;
  date: string;
}

export interface BusInfo {
  busScheduleId: string;
  companyName: string;
  busName: string;
  busType: string;
  startTime: string;
  arrivalTime: string;
  seatsLeft: number;
  price: number;
  routeName: string;
}

export interface Seat {
  seatId: string;
  seatNumber: string;
  rowNumber: number;
  status: 'Available' | 'Booked' | 'Sold';
  gender: string | null;
}

export interface SeatPlan {
  busScheduleId: string;
  busName: string;
  companyName: string;
  price: number;
  seats: Seat[];
}

export interface BusStop {
  stopName: string;
  stopCode: string;
  stopOrder: number;
  arrivalTime: string;
}

export interface BookSeatRequest {
  busScheduleId: string;
  seatIds: string[];
  boardingStopCode: string;
  droppingStopCode: string;
  passengerName: string;
  mobileNumber: string;
  passengerGender: string;
}

export interface BookingSummary {
  passengerName: string;
  mobileNumber: string;
  gender: string;
  companyName: string;
  busName: string;
  seatNumbers: string[];
  boardingStop: string;
  droppingStop: string;
  boardingTime: string;
  droppingTime: string;
  journeyDate: string;
  totalPrice: number;
  bookingDate: string;
}

export interface BookSeatResponse {
  success: boolean;
  message: string;
  bookingSummary: BookingSummary;
}