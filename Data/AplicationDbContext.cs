using Microsoft.EntityFrameworkCore;
using Models;

namespace connect_to_database.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Categoryes> categoryes { get; set; }
        public DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoryes>().HasData(
                new Categoryes { id = 1, movie_Name = "Hary Potter", category = 5, collection = 50}
             );
            modelBuilder.Entity<Student>().HasData(
                new Student { id = 1, age = 20, clas = "Vi", name = "Sudipta" }
             );
        }

        
    }
}
