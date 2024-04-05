using Microsoft.EntityFrameworkCore;

using PIMTool.Entities;

namespace PIMTool.DataAccess.SampleData
{
    internal static class SampleData
    {
        public static void CreateSampleData(ModelBuilder modelBuilder)
        {
            CreateSampleEmployeeData(modelBuilder);
            CreateSampleGroupData(modelBuilder);
            CreateSampleProjectData(modelBuilder);
            CreateSampleProjectEmployeeData(modelBuilder);
        }

        private static void CreateSampleEmployeeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Visa = "JDV1",
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, kind: DateTimeKind.Utc)
            },
            new Employee
            {
                Id = 2,
                Visa = "JSV2",
                FirstName = "Jane",
                LastName = "Smith",
                BirthDate = new DateTime(1995, 5, 10, 0, 0, 0, kind: DateTimeKind.Utc)
            });
        }

        private static void CreateSampleProjectData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
            new Project
            {
                Id = 1,
                GroupId = 1, // Assuming you have a Group with Id = 1
                ProjectNumber = 1001,
                Name = "Project A",
                Customer = "ABC Company",
                Status = "NEW",
                StartDate = new DateTime(2022, 1, 1, 0, 0, 0, kind: DateTimeKind.Utc),
                EndDate = null // Assuming project has not ended yet
            },
            new Project
            {
                Id = 2,
                GroupId = 2, // Assuming you have a Group with Id = 2
                ProjectNumber = 1002,
                Name = "Project B",
                Customer = "XYZ Corporation",
                Status = "INP",
                StartDate = new DateTime(2022, 2, 1, 0, 0, 0, kind: DateTimeKind.Utc),
                EndDate = new DateTime(2022, 6, 30, 0, 0, 0, kind: DateTimeKind.Utc)
            });
        }

        private static void CreateSampleGroupData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
            new Group
            {
                Id = 1,
                GroupLeaderId = 1, // Assuming you have an Employee with Id = 1
                GroupLeader = new Employee
                {
                    Id = 1,
                    Visa = "JDV1",
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, kind: DateTimeKind.Utc)
                }
            },
            new Group
            {
                Id = 2,
                GroupLeaderId = 2, // Assuming you have an Employee with Id = 2
                GroupLeader = new Employee
                {
                    Id = 2,
                    Visa = "JSV2",
                    FirstName = "Jane",
                    LastName = "Smith",
                    BirthDate = new DateTime(1985, 5, 10, 0, 0, 0, kind: DateTimeKind.Utc)
                }
            });
        }

        private static void CreateSampleProjectEmployeeData(ModelBuilder modelBuilder)
        {
            // Sample data for ProjectEmployees
            modelBuilder.Entity<ProjectEmployee>().HasData(
                new ProjectEmployee
                {
                    ProjectId = 1, // Assuming you have a Project with Id = 1
                    EmployeeId = 1, // Assuming you have an Employee with Id = 1
                    Project = new Project
                    {
                        Id = 1,
                        GroupId = 1, // Assuming you have a Group with Id = 1
                        ProjectNumber = 1001,
                        Name = "Project A",
                        Customer = "ABC Company",
                        Status = "NEW",
                        StartDate = new DateTime(2022, 1, 1, 0, 0, 0, kind: DateTimeKind.Utc),
                        EndDate = null // Assuming project has not ended yet
                    },
                    Employee = new Employee
                    {
                        Id = 1,
                        Visa = "JDV1",
                        FirstName = "John",
                        LastName = "Doe",
                        BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, kind: DateTimeKind.Utc)
                    }
                },
                new ProjectEmployee
                {
                    ProjectId = 2, // Assuming you have a Project with Id = 2
                    EmployeeId = 2, // Assuming you have an Employee with Id = 2
                    Project = new Project
                    {
                        Id = 2,
                        GroupId = 2, // Assuming you have a Group with Id = 2
                        ProjectNumber = 1002,
                        Name = "Project B",
                        Customer = "XYZ Corporation",
                        Status = "INP",
                        StartDate = new DateTime(2022, 2, 1, 0, 0, 0, kind: DateTimeKind.Utc),
                        EndDate = new DateTime(2022, 6, 30, 0, 0, 0, kind: DateTimeKind.Utc) // Assuming project ended on June 30, 2022
                    },
                    Employee = new Employee
                    {
                        Id = 2,
                        Visa = "JSV2",
                        FirstName = "Jane",
                        LastName = "Smith",
                        BirthDate = new DateTime(1985, 5, 10, 0, 0, 0, kind: DateTimeKind.Utc)
                    }
                }

            );
        }
    }
}