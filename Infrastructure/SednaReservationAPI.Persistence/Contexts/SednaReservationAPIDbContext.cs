using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SednaReservationAPI.Domain.Entities;
using SednaReservationAPI.Domain.Entities.Common;
using System;

namespace SednaReservationAPI.Persistence.Contexts
{
    public class SednaReservationAPIDbContext : IdentityDbContext<Customer, Role, Guid>
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

<<<<<<< HEAD
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Customer
            var hasher = new PasswordHasher<Customer>();
            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                Email = "admin@hotmail.com",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "ADMIN@HOTMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456")
            };
            builder.Entity<Customer>().HasData(customer);

            // Room Types
            builder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Tek Kişilik", Description = "Tek kişilik oda" },
                new RoomType { Id = 2, Name = "İki Kişilik", Description = "İki kişilik oda" },
                new RoomType { Id = 3, Name = "Üç Kişilik", Description = "Üç kişilik oda" }
=======
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


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customer
            //var hasher = new PasswordHasher<Customer>();
            //var customer = new Customer
            //{
            //    Id = Guid.NewGuid(),
            //    Email = "admin@hotmail.com",
            //    UserName = "admin",
            //    NormalizedUserName = "ADMIN",
            //    NormalizedEmail = "ADMIN@HOTMAIL.COM",
            //    EmailConfirmed = true,
            //    PasswordHash = hasher.HashPassword(null, "123456")
            //};
            //builder.Entity<Customer>().HasData(customer);

            // Room Types
            builder.Entity<RoomType>().HasData(
                new RoomType { Id = Guid.NewGuid(), Name = "Tek Kişilik", Description = "Tek kişilik oda" },
                new RoomType { Id = Guid.NewGuid(), Name = "İki Kişilik", Description = "İki kişilik oda" },
                new RoomType { Id = Guid.NewGuid(), Name = "Üç Kişilik", Description = "Üç kişilik oda" }
>>>>>>> Berke
            );

            // Hotels
            builder.Entity<Hotel>().HasData(
<<<<<<< HEAD
                new Hotel { Id = Guid.NewGuid(), Name = "Su Hotel", Description = "Civardaki en uygun fiyatlı otel", Address = "1", StarRating = 4 },
                new Hotel { Id = Guid.NewGuid(), Name = "Ateş Hotel", Description = "Civardaki en lüks otel", Address = "2", StarRating = 4 },
                new Hotel { Id = Guid.NewGuid(), Name = "Toprak Hotel", Description = "Civardaki en lüks otel", Address = "3", StarRating = 4 },
                new Hotel { Id = Guid.NewGuid(), Name = "Tahta Hotel", Description = "Hava olmasın", Address = "4", StarRating = 4 }
=======
                new Hotel { Id = Guid.NewGuid(), Name = "Su Hotel", Description = "Civardaki en uygun fiyatlı otel", Address = "1", Star = 5, StarRating = 4 },
                new Hotel { Id = Guid.NewGuid(), Name = "Ateş Hotel", Description = "Civardaki en lüks otel", Address = "2", Star = 3, StarRating = 4 },
                new Hotel { Id = Guid.NewGuid(), Name = "Toprak Hotel", Description = "Civardaki en lüks otel", Address = "3", Star = 3, StarRating = 4 },
                new Hotel { Id = Guid.NewGuid(), Name = "Tahta Hotel", Description = "Hava olmasın", Address = "4", Star = 3, StarRating = 4 }
>>>>>>> Berke
            );

            // Rooms
            builder.Entity<Room>().HasData(
<<<<<<< HEAD
                new Room { Id = Guid.NewGuid(), RoomTypeId = 1, HotelId = Guid.NewGuid(), BasePrice = 3500, Status = "Aktif" },
                new Room { Id = Guid.NewGuid(), RoomTypeId = 2, HotelId = Guid.NewGuid(), BasePrice = 3500, Status = "Boş" },
                new Room { Id = Guid.NewGuid(), RoomTypeId = 2, HotelId = Guid.NewGuid(), BasePrice = 3500, Status = "Boş" },
                new Room { Id = Guid.NewGuid(), RoomTypeId = 1, HotelId = Guid.NewGuid(), BasePrice = 3500, Status = "Boş" }
=======
                new Room { Id = Guid.NewGuid(), RoomTypeId = "asdasdasdsa", HotelId = "asdasdasdsa", BasePrice = 3500, Status = "Aktif" },
                new Room { Id = Guid.NewGuid(), RoomTypeId = "asdasdasdsa", HotelId = "asdasdasdsa", BasePrice = 3500, Status = "Boş" },
                new Room { Id = Guid.NewGuid(), RoomTypeId = "asdasdasdsa", HotelId = "asdasdasdsa", BasePrice = 3500, Status = "Boş" },
                new Room { Id = Guid.NewGuid(), RoomTypeId = "asdasdasdsa", HotelId = "asdasdasdsa", BasePrice = 3500, Status = "Boş" }
>>>>>>> Berke
            );

            // Reservations
            builder.Entity<Reservation>().HasData(
<<<<<<< HEAD
                new Reservation { Id = Guid.NewGuid(), UserId = customer.Id, RoomId = Guid.NewGuid(), CheckIn = DateTime.UtcNow, CheckOut = new DateTime(2024, 7, 6, 11, 0, 0, DateTimeKind.Utc), CreatedAt = DateTime.UtcNow, TotalPrice = 5000, Status = "Dolu", Deleted = false },
                new Reservation { Id = Guid.NewGuid(), UserId = customer.Id, RoomId = Guid.NewGuid(), CheckIn = DateTime.UtcNow, CheckOut = new DateTime(2024, 7, 5, 11, 0, 0, DateTimeKind.Utc), CreatedAt = DateTime.UtcNow, TotalPrice = 7500, Status = "Dolu", Deleted = false },
                new Reservation { Id = Guid.NewGuid(), UserId = customer.Id, RoomId = Guid.NewGuid(), CheckIn = DateTime.UtcNow, CheckOut = new DateTime(2024, 8, 5, 11, 0, 0, DateTimeKind.Utc), CreatedAt = DateTime.UtcNow, TotalPrice = 8000, Status = "Dolu", Deleted = false }
=======
                new Reservation { Id = Guid.NewGuid(), UserId = "asdasdasdsa", RoomId = "asdasdasdsa", CheckIn = DateTime.UtcNow, CheckOut = new DateTime(2024, 7, 6, 11, 0, 0, DateTimeKind.Utc), CreatedDate = DateTime.UtcNow, TotalPrice = 5000, Status = "Dolu", Deleted = false },
                new Reservation { Id = Guid.NewGuid(), UserId = "asdasdasdsa", RoomId = "asdasdasdsa", CheckIn = DateTime.UtcNow, CheckOut = new DateTime(2024, 7, 5, 11, 0, 0, DateTimeKind.Utc), CreatedDate = DateTime.UtcNow, TotalPrice = 7500, Status = "Dolu", Deleted = false },
                new Reservation { Id = Guid.NewGuid(), UserId = "asdasdasdsa", RoomId = "asdasdasdsa", CheckIn = DateTime.UtcNow, CheckOut = new DateTime(2024, 8, 5, 11, 0, 0, DateTimeKind.Utc), CreatedDate = DateTime.UtcNow, TotalPrice = 8000, Status = "Dolu", Deleted = false }
>>>>>>> Berke
            );

            // Payments
            builder.Entity<Payment>().HasData(
<<<<<<< HEAD
                new Payment { Id = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, UpdatedAt = new DateTime(2024, 7, 6, 11, 0, 0, DateTimeKind.Utc), PaymentMethod = "Online", Amount = 7500, ReservationId = Guid.NewGuid(), Date = new DateTime(2024, 7, 6, 11, 0, 0, DateTimeKind.Utc), Status = "Dolu", Deleted = false }
            );
        }
=======
                new Payment { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, UpdatedDate = new DateTime(2024, 7, 6, 11, 0, 0, DateTimeKind.Utc), PaymentMethod = "Online", Amount = 7500, ReservationId = "asdsadasd", Date = new DateTime(2024, 7, 6, 11, 0, 0, DateTimeKind.Utc), Status = "Dolu", Deleted = false }
            );
        }



>>>>>>> Berke
    }
}
