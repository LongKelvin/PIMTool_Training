using Microsoft.EntityFrameworkCore;

using PIMTool.Models;

namespace PIMTool.DataAccess
{
    public class PIMToolDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Models.Group> Groups { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }

        public PIMToolDbContext(DbContextOptions<PIMToolDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProjectEmployee>()
                .HasKey(pe => new { pe.ProjectId, pe.EmployeeId });

            modelBuilder.Entity<ProjectEmployee>()
                .HasOne(pe => pe.Project)
                .WithMany(p => p.ProjectEmployees)
                .HasForeignKey(pe => pe.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProjectEmployee>()
                .HasOne(pe => pe.Employee)
                .WithMany(e => e.ProjectEmployees)
                .HasForeignKey(pe => pe.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Models.Group>()
                .HasOne(g => g.GroupLeader)
                .WithMany()
                .HasForeignKey(g => g.GroupLeaderId);

            //var sampleData = new SampleData.SampleData();
            //sampleData.CreateSampleData(modelBuilder);

        }
    }
}