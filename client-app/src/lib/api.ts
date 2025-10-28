import { BookSeatRequest, BookSeatResponse, BusInfo, BusStop, RouteStop, SeatPlan } from "@/types/types";

const API_BASE_URL = process.env.NEXT_PUBLIC_API_BASE_URL || 'https://localhost:7187/api';

export async function getRouteStopSuggestions(searchTerm: string): Promise<RouteStop[]> {
  if (!searchTerm || searchTerm.length < 1) {
    return [];
  }

  try {
    const response = await fetch(
      `${API_BASE_URL}/Route/route-stops/suggestions?search=${encodeURIComponent(searchTerm)}`,
      {
        method: "GET",
        headers: {
          "Content-Type": "application/json",
        },
      }
    );

    if (!response.ok) {
      console.error("Failed to fetch suggestions");
      return [];
    }

    const data: RouteStop[] = await response.json();
    return data;
  } catch (error) {
    console.error("Error fetching route suggestions:", error);
    return [];
  }
}

export async function searchAvailableBuses(fromCode: string, toCode: string, journeyDate: string): Promise<BusInfo[]> {
  try {
    const response = await fetch(
      `${API_BASE_URL}/Search/available-buses?from=${fromCode}&to=${toCode}&journeyDate=${journeyDate}`,
      {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json',
        },
      }
    );

    if (!response.ok) {
      throw new Error('Failed to fetch available buses');
    }


    const data: BusInfo[] = await response.json();
    return data;
  } catch (error) {
    console.error('Error fetching available buses:', error);
    throw error;
  }
}

export async function getSeatPlan(busScheduleId: string): Promise<SeatPlan> {
  try {
    const response = await fetch(
      `${API_BASE_URL}/Booking/seat-plan/${busScheduleId}`,
      {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json',
        },
      }
    );

    if (!response.ok) {
      throw new Error('Failed to fetch seat plan');
    }

    const data: SeatPlan = await response.json();
    return data;
  } catch (error) {
    console.error('Error fetching seat plan:', error);
    throw error;
  }
}

export async function getBusStops(busScheduleId: string): Promise<BusStop[]> {
  try {
    const response = await fetch(
      `${API_BASE_URL}/Route/bus-schedule/${busScheduleId}/stops`,
      {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json',
        },
      }
    );

    if (!response.ok) {
      throw new Error('Failed to fetch bus stops');
    }

    const data: BusStop[] = await response.json();
    return data;
  } catch (error) {
    console.error('Error fetching bus stops:', error);
    throw error;
  }
}

export async function bookSeats(bookingData: BookSeatRequest): Promise<BookSeatResponse> {
  try {
    const response = await fetch(
      `${API_BASE_URL}/Booking/book-seat`,
      {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(bookingData),
      }
    );

    if (!response.ok) {
      const errorData = await response.json().catch(() => ({}));
      throw new Error(errorData.message || 'Failed to book seats');
    }

    const data: BookSeatResponse = await response.json();
    return data;
  } catch (error) {
    console.error('Error booking seats:', error);
    throw error;
  }
}