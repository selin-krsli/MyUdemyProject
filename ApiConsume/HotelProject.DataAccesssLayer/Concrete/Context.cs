using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesssLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0BF7VC9\\SQLEXPRESS;Database=ApiDb;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Room>(entry =>
            {
                entry.ToTable("Rooms", tb =>
                {
                    tb.HasTrigger("RoomIncrease");
                    tb.HasTrigger("RoomDecrease");
                });
            });
            builder.Entity<Guest>(entry =>
            {
                entry.ToTable("Guests", tb =>
                {
                    tb.HasTrigger("GuestIncrease");
                    tb.HasTrigger("GuestDecrease");

                });
            });
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Contact> Contacts { get; set; }    
        public DbSet<SendMessage> SendMessages { get; set; }
    }
}
