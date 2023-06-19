
using backend_part.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_part.Data
{
    public class DataContext: DbContext

    {
        //public DataContext()
        //{
        //}

        //public DataContext(DbContextOptions<DataContext> options): base(options) 
        //{
                
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-NEBKU4K;database=AppDB;Integrated Security=true; MultipleActiveResultSets=true; TrustServerCertificate=true;");
        
        }
        public virtual DbSet<User> Users => Set<User>(); 
        public virtual DbSet<Meeting> Meeting { get; set; }
        public virtual DbSet<RatingModel> Rating { get; set; }
        public virtual DbSet<MeetingNotes> MeetingNotes { get; set; }
        public virtual DbSet<SharePoint> SharePoints { get; set; }
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; }
        public virtual DbSet<ViewProjectMeeting> ViewProjects { get; set; }
        public virtual DbSet<Innovative> Innovatives { get; set; }
        

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Define a view
            modelBuilder.Entity<ViewProjectMeeting>()
             .ToView("ViewProjectMeeting"); //db view name

           
    

        }

    

}
}
