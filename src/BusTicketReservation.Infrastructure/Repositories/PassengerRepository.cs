using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Domain.Entities;
using BusTicketReservation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BusTicketReservation.Infrastructure.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly ApplicationDbContext _db;

        public PassengerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Passenger?> GetByMobileNumberAsync(string mobileNumber)
        {
            return await _db.Passengers
                .FirstOrDefaultAsync(p => p.MobileNumber == mobileNumber);
        }

        public async Task<Passenger> AddAsync(Passenger passenger)
        {
            await _db.Passengers.AddAsync(passenger);
            return passenger;
        }
    }
}
