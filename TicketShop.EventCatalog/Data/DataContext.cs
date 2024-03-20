using Microsoft.EntityFrameworkCore;
using TicketShop.EventCatalog.Models;

namespace TicketShop.EventCatalog.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Events)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        CategoryId = 1,
                        Name = "Sports"
                    }, new Category
                    {
                        CategoryId = 2,
                        Name = "Concerts"
                    }
                );


            modelBuilder.Entity<Event>().HasData(
                    new Event
                    {
                        EventId = 1,
                        Date = DateTime.Now,
                        Name = "Beyonce in concert",
                        Artist = "Beyonce",
                        Price = 300,
                        CategoryId = 2,
                    }, new Event
                    {
                        EventId = 2,
                        Date = DateTime.Now,
                        Name = "Guns N Roses Tour",
                        Artist = "GNR",
                        Price = 500,
                        CategoryId = 2,
                    }, new Event
                    {
                        EventId = 3,
                        Date = DateTime.Now,
                        Name = "Persona Live Concert",
                        Artist = "ATLUS",
                        Price = 400,
                        CategoryId = 2,
                    }, new Event
                    {
                        EventId = 4,
                        Date = DateTime.Now,
                        Name = "Xenoblade Orchestra",
                        Artist = "MonolithSoft",
                        Price = 500,
                        CategoryId = 2,
                    }, new Event
                    {
                        EventId = 5,
                        Date = DateTime.Now,
                        Name = "AC Milan vs Inter FC",
                        Artist = "None",
                        Price = 700,
                        CategoryId = 2,
                    }
                );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
