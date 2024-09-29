using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Action Book",
                    Author = "John Doe",
                    Price = 29.99m
                },
                new Book
                {
                    Id = 2,
                    Title = "The Sci-Fi Adventure",
                    Author = "Jane Smith",
                    Price = 34.99m
                },
                new Book
                {
                    Id = 3,
                    Title = "The History of Time",
                    Author = "Emily Johnson",
                    Price = 19.99m
                }
            );
        }
    }
}
