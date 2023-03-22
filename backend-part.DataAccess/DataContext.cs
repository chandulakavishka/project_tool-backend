
using backend_part.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_part.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-O596UUO;database=AppDB;Integrated Security=true; MultipleActiveResultSets=true; TrustServerCertificate=true;");
        }
        public DbSet<User> Users => Set<User>();
        public DbSet<UserComment> Comments => Set<UserComment>();
        public DbSet<UserTask> Tasks => Set<UserTask>();


    }
}
