using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class EFCoreDbContext:DbContext
    {

        public  EFCoreDbContext(DbContextOptions<EFCoreDbContext> dbContextOptions):base(dbContextOptions)
        {
        
        }

        public DbSet<Category> Categories{ get; set; }
    }
}
