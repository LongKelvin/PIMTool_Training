using System.ComponentModel.DataAnnotations.Schema;

namespace PIMTool.Models
{
    [Table("ProjectEmployee")]
    public class ProjectEmployee : BaseEntity
    {
        public int ProjectId { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}