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