using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SednaReservationAPI.Application.Abstractions;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Persistence.Concretes;
using SednaReservationAPI.Persistence.Contexts;
using SednaReservationAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SednaReservationAPIDbContext>(options => options.UseNpgsql("User ID=root;Password=sednacloud;Host=localhost;Port=5432;Database=SednaReservationAPIDb;"));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IHotelReadRepository, HotelReadRepository>();
            services.AddScoped<IHotelWriteRepository, HotelWriteRepository>();
            services.AddScoped<IPaymentReadRepository, PaymentReadRepository>();
            services.AddScoped<IPaymentWriteRepository, PaymentWriteRepository>();
            services.AddScoped<IReservationReadRepository, ReservationReadRepository>();
            services.AddScoped<IReservationWriteRepository, ReservationWriteRepository>();
            services.AddScoped<IReviewReadRepository, ReviewReadRepository>();
            services.AddScoped<IReviewWriteRepository, ReviewWriteRepository>();
            services.AddScoped<IRoomReadRepository, RoomReadRepository>();
            services.AddScoped<IRoomWriteRepository, RoomWriteRepository>();
            services.AddScoped<IRoomTypeReadRepository, RoomTypeReadRepository>();
            services.AddScoped<IRoomTypeWriteRepository, RoomTypeWriteRepository>();
        }
    }
}
