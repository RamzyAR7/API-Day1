using API_Day1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace API_Day1.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; } // Changed access modifier to public  

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
