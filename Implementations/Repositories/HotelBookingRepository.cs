using CommunityProApp.Context;
using CommunityProApp.Entities;
using CommunityProApp.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CommunityProApp.Implementations.Repositories
{
    public class HotelBookingRepository : BaseRepository<HotelBooking>, IHotelBookingRepository
    {
        public HotelBookingRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<HotelBooking> GetByRoomId(int roomId)
        {
            var bookings = _context.HotelBookings.Where(b => b.RoomId == roomId).ToList();
            return bookings;
        }
        
    }
}
