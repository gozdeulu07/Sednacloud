using SednaReservationAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SednaReservationAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SednaReservationAPIDbContext>
    {
        public SednaReservationAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<SednaReservationAPIDbContext> dbContextOptionsBuilder = new();
<<<<<<< HEAD:Infrastructure/SednaReservationAPI.Persistence/DesignTimeDbContextFactory.cs
            dbContextOptionsBuilder.UseNpgsql("User ID=root;Password=sednacloud;Host=localhost;Port=5432;Database=SednaReservationAPIDb;");
=======
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
>>>>>>> d1371c61e354aca86f5290ef28a20d23571cc567:Infrastructure/SednaReservationAPI.Persistence/Contexts/DesignTimeDbContextFactory.cs
            return new(dbContextOptionsBuilder.Options);
        }
    }
}