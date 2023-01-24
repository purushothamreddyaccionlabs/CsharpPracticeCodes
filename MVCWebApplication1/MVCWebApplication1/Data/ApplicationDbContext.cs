using Microsoft.EntityFrameworkCore;
using MVCWebApplication1.Models;

namespace MVCWebApplication1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
