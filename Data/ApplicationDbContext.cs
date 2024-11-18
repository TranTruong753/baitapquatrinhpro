using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DomainLayer.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().HasData(
                 new Genre
                 {
                     Id = 1,
                     Name = "Trinh Thám"
                 },
                 new Genre
                 {
                     Id = 2,
                     Name = "Hành Động"
                 },
                 new Genre
                 {
                     Id = 3,
                     Name = "Lãng Mạn"
                 }
             );


        }
    }
}
