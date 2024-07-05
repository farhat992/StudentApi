using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentApi;

    public class DBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentDb;Trusted_Connection=True;");
        }
       

    }



