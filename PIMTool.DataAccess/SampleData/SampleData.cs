using PIMTool.Entities;
using PIMTool.Entities.Enums;

namespace PIMTool.DataAccess.SampleData
{
    public static class SampleData
    {
        public static void InitializeData(PIMToolDbContext context)
        {
            CreateSampleData(context);
        }

        private static void CreateSampleData(PIMToolDbContext context)
        {
            CreateSampleEmployeeData(context);
            CreateSampleGroupData(context);
            CreateSampleProjectData(context);
        }

        private static void CreateSampleEmployeeData(PIMToolDbContext context)
        {
            if (!context.Employees.Any())
            {
                var listEmployees = new List<Employee>
                {
                    new() {
                        Visa = "JDV",
                        FirstName = "John",
                        LastName = "Doe",
                        BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, kind: DateTimeKind.Utc)
                    },
                    new() {
                        Visa = "JSV",
                        FirstName = "Jane",
                        LastName = "Smith",
                        BirthDate = new DateTime(1995, 5, 10, 0, 0, 0, kind: DateTimeKind.Utc)
                    }
                };

                context.Employees.AddRange(listEmployees);
                context.SaveChanges();
            }
        }

        private static void CreateSampleGroupData(PIMToolDbContext context)
        {
            if (!context.Groups.Any())
            {
                if (!context.Employees.Any())
                {
                    CreateSampleEmployeeData(context);
                }

                var listEmployees = context.Employees.ToList();

                var listGroups = new List<Group>
                {
                    new() {
                        GroupLeaderId = listEmployees[0].Id,
                        GroupLeader=listEmployees[0],
                        GroupName = "PS-EC"
                    },
                     new() {
                        GroupLeaderId = listEmployees[1].Id,
                        GroupLeader=listEmployees[1],
                        GroupName= "ETAS-EC"
                    },
                };

                context.Groups.AddRange(listGroups);
                context.SaveChanges();
            }
        }

        private static void CreateSampleProjectData(PIMToolDbContext context)
        {
            if (!context.Projects.Any())
            {
                if (!context.Employees.Any())
                {
                    CreateSampleEmployeeData(context);
                }

                if (!context.Groups.Any())
                {
                    CreateSampleGroupData(context);
                }

                var listGroups = context.Groups.ToList();

                var listProjects = new List<Project>
                {
                     new() {
                        GroupId = listGroups[0].Id,
                        ProjectNumber = 1001,
                        Name = "Project A",
                        Customer = "ABC Company",
                        Status = ProjectStatus.NEW.ToString(),
                        StartDate = new DateTime(2024, 1, 1, 0, 0, 0, kind: DateTimeKind.Utc),
                        EndDate = null // Assuming project has not ended yet
                    },
                    new() {
                        GroupId = listGroups[1].Id,
                        ProjectNumber = 1002,
                        Name = "Project B",
                        Customer = "XYZ Corporation",
                        Status = ProjectStatus.INP.ToString(),
                        StartDate = new DateTime(2024, 2, 1, 0, 0, 0, kind: DateTimeKind.Utc),
                        EndDate = new DateTime(2024, 10, 30, 0, 0, 0, kind: DateTimeKind.Utc)
                    }
                };

                context.Projects.AddRange(listProjects);
                context.SaveChanges();
            }
        }
    }
}