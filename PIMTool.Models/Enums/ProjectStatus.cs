using System.ComponentModel;

namespace PIMTool.Entities.Enums
{
    public enum ProjectStatus
    {
        [Description("New")]
        NEW,
        [Description("Planned")]
        PLA,
        [Description("In Progress")]
        INP,
        [Description("Finished")]
        FIN
    }
}
