import { RouteStop } from "@/types/types";

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