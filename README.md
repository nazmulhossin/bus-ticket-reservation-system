# Bus Ticket Reservation System
A **full-stack bus ticket reservation system** built using **ASP.NET Core Web API** and **Next.js**, following **Clean Architecture principles**.  
It allows users to search available buses, view seat layouts, and book seats securely.

## Features
- **Search Buses:** Search available buses by route and date
- **Seat Layout:** View seat layout with status (Available/Booked/Sold)
- **Booking System:** Book seats with passenger details

## Tech Stack
### Backend
- ASP.NET Core 9 Web API
- Entity Framework Core
- PostgreSQL

### Frontend
- Next.js 16
- TypeScript
- Tailwind CSS


## Quick Start
### Prerequisites
The deployment environment must satisfy the following prerequisites:
- .NET 8.0 SDK or later
- Node.js 18+
- PostgreSQL
- Visual Studio

### Backend Setup
1. **Clone the repository:**
   ```sh
   git clone https://github.com/nazmulhossin/bus-ticket-reservation-system.git
   ```
   Open the solution file in Visual Studio: `src/BusTicketReservation.sln`
   
2. **Configuration Settings**
   
   Edit the `appsettings.json` file located at: `BusTicketReservation.WebApi/appsettings.json`  
   Update the following settings:

   ```env
    {
      "ConnectionStrings": {
        // Replace the empty string in "DefaultConnection" with your PostgreSQL connection string
        // Example: "Host=localhost;Port=5432;Database=BusTicketDb;Username=your_postgres_username;Password=yourpassword"
        "DefaultConnection": ""
      },
    
      "AllowedOrigins": [
        "http://localhost:3000"
        // If your frontend runs from a different URL, just add it here
      ]
    }
   ```

3. **Run database migrations:** 

   Run the Entity Framework Core migration to create the database schema.
   
   1. Open Package Manager Console (`Tools → NuGet Package Manager → Package Manager Console`)
   2. Ensure the Default Project is set to `BusTicketReservation.Infrastructure`
   3. Run:
      
       ```sh
       Update-Database
       ```

4. **Build and Run the Application**
        
     - Press `Ctrl + F5` to build and run without debugging
     - Or press `F5` to run with debugging
   
   Once the application is running, open your browser and navigate to:
   ```sh
   https://localhost:7187/swagger/index.html
   ```
   Update the URL above if your application is configured to run on a different port.

### Frontend Setup
Navigate to the frontend directory `/client-app`.
1. **Configure environment variables:**

   Create a `.env` file in `/client-app` and add:
   ```sh
    NEXT_PUBLIC_API_BASE_URL=YOUR_API_BASE_URL
   ```
   Replace `YOUR_API_BASE_URL` with the actual backend API URL (e.g., https://localhost:7187/api).
2. **Install dependencies and run the app:**

   Open a terminal in `/client-app` and run:
   ```env
    npm install
    npm run dev
   ```
   The app should now be running at `http://localhost:3000` by default.
