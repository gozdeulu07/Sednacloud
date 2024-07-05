using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SednaReservationAPI.Persistence.Contexts;
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
            services.AddDbContext<SednaReservationAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=sednacloud;Host=localhost;Port=5432;Database=SednaReservationAPIDb;"));
        }
    }
}
