using System.ComponentModel.DataAnnotations.Schema;

namespace PIMTool.Entities
{
    [Table("ProjectGroups")]
    public class Group : BaseEntity
    {
        public int GroupLeaderId { get; set; }

        [ForeignKey("GroupLeaderId")]
        public virtual Employee GroupLeader { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public Group()
        {
            Projects = [];
            GroupLeader = new Employee();
        }
    }
}