using System.ComponentModel;

namespace CommunityProApp.Enums
{
    public enum OrderStatus
    {   
        [Description("Initialized")]
        Initialized = 1,
        [Description("Paid")]
        Paid = 2,
        [Description("Cancelled")]
        Cancelled = 3,
    }
}
