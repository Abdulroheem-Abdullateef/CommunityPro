using System.ComponentModel;

namespace CommunityProApp.Enums
{
    public enum UserType
    {
        [Description("Admin")]
        Admin = 1,
        [Description("AppUser")]
        AppUser = 2,

    }
}
