using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIMTool.Entities
{
    [Table("ProjectEmployees")]
    public class ProjectEmployee
    {
        public int ProjectId { get; set; }

        public int EmployeeId { get; set; }

        public virtual Project Project { get; set; }

        public virtual Employee Employee { get; set; }

        [Timestamp]
        public byte[]? Timestamp { get; set; }

        public ProjectEmployee()
        {
            Project = new Project();
            Employee = new Employee();
        }
    }
}