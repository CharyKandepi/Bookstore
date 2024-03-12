using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bookstore.Data
{
    public class EFCoreDbContext:DbContext
    {

        public  EFCoreDbContext(DbContextOptions<EFCoreDbContext> dbContextOptions):base(dbContextOptions)
        {
        
        }

        public DbSet<Category> Categories{ get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Category category = new Category();
            category.Id = 3;
            category.Name = "Physics";
            category.Description = "Seems to Science";

            modelBuilder.Entity<Category>().HasData

                (
                category,
                new Category { Id=4 ,Name = "Chemistry", Description = "Seems to chemicals" }
                );
        }
    }
}
