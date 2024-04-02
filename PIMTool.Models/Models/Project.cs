using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using PIMTool.Models.Enums;

namespace PIMTool.Models
{
    [Table("Projects")]
    public class Project : BaseEntity
    {
        public int GroupId { get; set; }

        [Required]
        public int ProjectNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer { get; set; }

        [Required]
        [StringLength(3)]
        public string Status { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }

        public Project()
        {
            Name = string.Empty;
            Customer = string.Empty;
            Status = ProjectStatus.NEW.ToString();
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
            Group = new Group();
            ProjectEmployees = [];
        }
    }
}
