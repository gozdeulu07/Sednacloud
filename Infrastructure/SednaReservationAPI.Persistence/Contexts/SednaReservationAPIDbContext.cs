using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SednaReservationAPI.Domain.Entities;
using SednaReservationAPI.Domain.Entities.Common;
using SednaReservationAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Persistence.Contexts
{
    public class SednaReservationAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public SednaReservationAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntitity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    EntityState.Deleted => data.Entity.DeletedDate = DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = Guid.NewGuid(), Name = "Hotel A", Address = "Address A", Phone = "1234567890", Email = "hotelA@example.com", Description = "Description A", StarRating = 5, Star = 3,  ImageUrl = "imageA.jpg" },
                new Hotel { Id = Guid.NewGuid(), Name = "Hotel B", Address = "Address B", Phone = "0987654321", Email = "hotelB@example.com", Description = "Description B", StarRating = 4, Star = 5, ImageUrl = "imageB.jpg" },
                new Hotel { Id = Guid.NewGuid(), Name = "Hotel C", Address = "Address B", Phone = "0987654321", Email = "hotelC@example.com", Description = "Description C", StarRating = 4.2f , Star = 5, ImageUrl = "imageB.jpg" },
                new Hotel { Id = Guid.NewGuid(), Name = "Hotel D", Address = "Address B", Phone = "0987654321", Email = "hotelD@example.com", Description = "Description D", StarRating = 3.7f, Star = 2, ImageUrl = "imageB.jpg" },
                new Hotel { Id = Guid.NewGuid(), Name = "Hotel E", Address = "Address B", Phone = "0987654321", Email = "hotelE@example.com", Description = "Description E", StarRating = 1.5f, Star = 4, ImageUrl = "imageB.jpg" },
                new Hotel { Id = Guid.NewGuid(), Name = "Hotel F", Address = "Address B", Phone = "0987654321", Email = "hotelF@example.com", Description = "Description F", StarRating = 3.9f, Star = 1, ImageUrl = "imageB.jpg" },
                new Hotel { Id = Guid.NewGuid(), Name = "Hotel G", Address = "Address B", Phone = "0987654321", Email = "hotelG@example.com", Description = "Description G", StarRating = 4.8f, Star = 5, ImageUrl = "imageB.jpg" }
            // Add more sample hotels as needed
            );
            
        }
    }
}
