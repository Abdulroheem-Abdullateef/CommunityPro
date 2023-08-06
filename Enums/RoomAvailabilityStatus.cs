using System.ComponentModel;

namespace CommunityProApp.Enums
{
    public enum RoomAvailabilityStatus
    {
        [Description("Available")]
        Available = 1,
        [Description("CheckedIn")]
        CheckedIn = 2,
        [Description("NotAvailable")]
        NotAvailable = 3,
        [Description("Booked")]
        Booked = 4,
    }
}
