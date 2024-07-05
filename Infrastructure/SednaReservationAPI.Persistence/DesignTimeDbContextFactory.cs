﻿using SednaReservationAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
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
            dbContextOptionsBuilder.UseNpgsql("User ID=root;Password=sednacloud;Host=localhost;Port=5432;Database=SednaReservationAPIDb;");
            return new(dbContextOptionsBuilder.Options);
        }
    }
}