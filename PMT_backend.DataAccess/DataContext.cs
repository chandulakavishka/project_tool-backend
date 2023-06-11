using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMT_backend.Models;

namespace PMT_backend.DataAccess
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

    }
}
