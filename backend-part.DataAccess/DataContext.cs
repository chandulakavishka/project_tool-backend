using backend_part.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend_part.DataAccess
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" },
                new IdentityRole() { Name = "Initiative Lead", ConcurrencyStamp = "3", NormalizedName = "Initiative Lead" },
                new IdentityRole() { Name = "Initiative Evaluator", ConcurrencyStamp = "4", NormalizedName = "Initiative Evaluator" },
                new IdentityRole() { Name = "Supervisor", ConcurrencyStamp = "5", NormalizedName = "Supervisor" }
                );
        }
        public DbSet<UserComment> Comments => Set<UserComment>();
        public DbSet<UserTask> Tasks => Set<UserTask>();
        public DbSet<AddUserTask> TaskUser => Set<AddUserTask>();

    }
}
