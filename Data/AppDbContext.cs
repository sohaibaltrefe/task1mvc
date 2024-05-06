using Microsoft.EntityFrameworkCore;
using task1mvc.Models;

namespace task1mvc.Data
{
    public class AppDbContext : DbContext

    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=.;database=Task1mvc;trusted_connection=true;TrustserverCertificate=true");
        }
    }
}
