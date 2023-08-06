using System.ComponentModel;

namespace CommunityProApp.Enums
{
    public enum BookAvailabilityStatus
    {
        [Description("Available")]
        AVAILABLE = 1,
        [Description("Unavailable")]
        UNAVAILABLE = 2,
    }
}
