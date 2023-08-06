using System.ComponentModel;

namespace CommunityProApp.Enums
{
    public enum BookingStatus
    {
        [Description("Initialized")]
        Initialized,
        [Description("Paid")]
        Paid,
        [Description("Cancelled")]
        Cancelled
    }
}
