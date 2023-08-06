using System.Collections.Generic;

namespace CommunityProApp.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public ICollection<HotelBooking> HotelBookings { get; set; } = new List<HotelBooking>();
    }
}
