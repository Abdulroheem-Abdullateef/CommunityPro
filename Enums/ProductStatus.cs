using System.ComponentModel;

namespace CommunityProApp.Enums
{
    public enum ProductStatus
    {
        [Description("Available")]
        Available = 1,
        [Description("OutOfStock")]
        OutOfStock = 2,
    }
}
