using System.ComponentModel;

namespace CommunityProApp.Enums
{
    public enum MedicalRecordStatus
    {
        [Description("Initiated")]
        Initiated = 1,
        [Description("Assigned")]
        Assigned = 2,
        [Description("Treated")]
        Treated = 3,
        [Description("Recieved")]
        Recieved = 4,
        [Description("Completed")]
        Completed = 5,

    }
}
