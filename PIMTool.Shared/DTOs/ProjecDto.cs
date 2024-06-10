using PIMTool.Entities.Enums;

namespace PIMTool.Shared.DTOs
{
    public class ProjectDto : BaseModel
    {
        public int GroupId { get; set; }

        public int ProjectNumber { get; set; }

        public string Name { get; set; }

        public string Customer { get; set; }

        public string Status { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsSelected { get; set; }

        public ProjectDto()
        {
            Name = string.Empty;
            Customer = string.Empty;
            Status = ProjectStatus.NEW.ToString();
            StartDate = DateTime.MinValue;
            EndDate = DateTime.MinValue;
        }

        public ProjectDto(int groupId, int projectNumber, string name, string customer, string status, DateTime startDate, DateTime? endDate)
        {
            GroupId = groupId;
            ProjectNumber = projectNumber;
            Name = name;
            Customer = customer;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"Project ID: {Id}, Name: {Name}, Customer: {Customer}, Status: {Status}, Start Date: {StartDate}, End Date: {EndDate}";
        }
    }
}