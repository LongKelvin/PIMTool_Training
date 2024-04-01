using System.ComponentModel.DataAnnotations;

namespace PIMTool.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}
