using Microsoft.EntityFrameworkCore;

using PIMTool.Entities;

namespace PIMTool.DataAccess
{
    public class PIMToolDbContext(DbContextOptions<PIMToolDbContext> options) : DbContext(options)
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Entities.Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Employees)
                .WithMany(e => e.Projects)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectEmployees",
                    j => j.HasOne<Employee>()
                          .WithMany()
                          .HasForeignKey("EmployeeId")
                          .OnDelete(DeleteBehavior.Restrict),
                    j => j.HasOne<Project>()
                          .WithMany()
                          .HasForeignKey("ProjectId")
                          .OnDelete(DeleteBehavior.Restrict)
                );

            modelBuilder.Entity<Entities.Group>()
                .HasOne(g => g.GroupLeader)
                .WithMany()
                .HasForeignKey(g => g.GroupLeaderId);
        }
    }
}