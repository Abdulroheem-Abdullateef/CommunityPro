using CommunityProApp.Enums;
using System.Collections.Generic;

namespace CommunityProApp.Entities
{
    public class Room : BaseEntity
    {
        public string RoomNumber { get; set; }

        public int RoomTypeId { get; set; }

        public RoomType Type { get; set; }

        public RoomAvailabilityStatus Status { get; set; }

        public ICollection<HotelBooking> HotelBookings { get; set; } = new List<HotelBooking>();
    }
}
