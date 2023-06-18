using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_part.MODELS;

namespace backend_part.SERVICES
{
    public class DbAccess : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Innovative> Innovatives { get; set; }
        public DbSet<UserTasks> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=web_app_DB;Trusted_Connection=true; MultipleActiveResultSets=false;TrustServerCertificate=Yes";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User
                {
                    UId = 1,
                    LastName = "Perera",
                    Email = "Perera@gmail.com",
                    City = "Colombo",
                    Description = "Description1",
                    PhoneNo = "0112435564",
                    Role = UserRole.User
                },
                new User
                {
                    UId = 2,
                    LastName = "Adikari",
                    Email = "Adikari@gmail.com",
                    City = "Galle",
                    Description = "Description2",
                    PhoneNo = "0912435564",
                    Role = UserRole.Initial_Lead
                    
                },
                new User
                {
                    UId = 3,
                    LastName = "Suriyasena",
                    Email = "Suriyasena@gmail.com",
                    City = "Mathara",
                    Description = "Description3",
                    PhoneNo = "0412085564",
                    Role = UserRole.Initial_Evaluator
                },
                new User
                {
                    UId = 4,
                    LastName = "Jayasekara",
                    Email = "Jayasekara@gmail.com",
                    City = "kurunagala",
                    Description = "Description4",
                    PhoneNo = "0112365564",
                    Role = UserRole.User
                },
                new User
                {
                    UId = 5,
                    LastName = "Weerawansha",
                    Email = "Weerawansha@gmail.com",
                    City = "Negambo",
                    Description = "Description5",
                    PhoneNo = "0112785564",
                    Role = UserRole.User
                },
                new User
                {
                    UId = 6,
                    LastName = "Jayawardhana",
                    Email = "Jayawardhana@gmail.com",
                    City = "Kaduwela",
                    Description = "Description6",
                    PhoneNo = "0112643564",
                    Role = UserRole.Supervisor
                },

            });
            modelBuilder.Entity<Innovative>().HasData(new Innovative[]
            {
                new Innovative
                {
                    InnovativeId = 1,
                    InnovativeName = "A",
                    Description = "ABCD",
                    LeadId  = "Saman",
                    EvaluatorId = "Kasun",
                    StartDate = DateTime.Now,
                },
            new Innovative
                {
                    InnovativeId = 2,
                    InnovativeName = "B",
                    Description = "PQRS",
                    LeadId = "Nimal",
                    EvaluatorId = "Supun",
                    StartDate = DateTime.Now,
                },
                new Innovative
                {
                    InnovativeId = 3,
                    InnovativeName = "C",
                    Description = "XYZ",
                    LeadId = "Amal",
                    EvaluatorId = "Saranga",
                    StartDate = DateTime.Now,
                },
            });

            modelBuilder.Entity<UserTasks>().HasData(new UserTasks[]
            {
                new UserTasks
                {
                    TaskId = 1,
                    TaskName = "Finalize speaker and topic for the podcast",
                    Description = "Description1",
                    CurrentProgress = CurrentProgrress.New,
                    InnovativeId = 1,
                },
                new UserTasks
                {
                    TaskId = 2,
                    TaskName = "Test recording session",
                    Description = "Description3",
                    CurrentProgress = CurrentProgrress.InProgress,
                    InnovativeId = 2
                },
                new UserTasks
                {
                    TaskId = 3,
                    TaskName = "Task3",
                    Description = "Description3",
                    CurrentProgress = CurrentProgrress.Complete,
                    InnovativeId = 3
                },
                new UserTasks
                {
                    TaskId = 4,
                    TaskName = "Finalize speaker and topic with speaker",
                    Description = "Description4",
                    CurrentProgress = CurrentProgrress.New,
                    InnovativeId = 1
                },
                new UserTasks
                {
                    TaskId = 5,
                    TaskName = "Task5",
                    Description = "Description5",
                    CurrentProgress = CurrentProgrress.Complete,
                    InnovativeId = 2
                },
                new UserTasks
                {
                    TaskId = 6,
                    TaskName = "Final recording session",
                    Description = "Description6",
                    CurrentProgress = CurrentProgrress.InProgress,
                    InnovativeId = 3
                },
                new UserTasks
                {
                    TaskId = 7,
                    TaskName = "Azure general best practices",
                    Description = "Description7",
                    CurrentProgress = CurrentProgrress.New,
                    InnovativeId = 1
                },
                new UserTasks
                {
                    TaskId = 8,
                    TaskName = "Create new voiceCut",
                    Description = "Description8",
                    CurrentProgress = CurrentProgrress.New,
                    InnovativeId = 2
                },
                 new UserTasks
                {
                    TaskId = 9,
                    TaskName = "check previous database",
                    Description = "Description9",
                    CurrentProgress = CurrentProgrress.New,
                    InnovativeId = 3
                },

            });
        }


    }
}
