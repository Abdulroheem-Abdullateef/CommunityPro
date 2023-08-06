using CommunityProApp.Entities;
using System.Collections.Generic;

namespace CommunityProApp.Interfaces.Repositories
{
    public interface IHotelBookingRepository : IRepository<HotelBooking>
    {
        public IEnumerable<HotelBooking> GetByRoomId(int roomId);
    }
}
