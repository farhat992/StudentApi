using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace StudentApi
{
    public class DataAccessLayer:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentDB;Integrated Security=true; TrustServerCertificate=True;");
        }
    }
}
