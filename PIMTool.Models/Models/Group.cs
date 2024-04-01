using System.ComponentModel.DataAnnotations.Schema;

namespace PIMTool.Models
{
    [Table("Group")]
    public class Group : BaseEntity
    {
        public int GroupLeaderId { get; set; }

        [ForeignKey("GroupLeaderId")]
        public virtual Employee GroupLeader { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
