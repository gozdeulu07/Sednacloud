using Microsoft.Extensions.DependencyInjection;
using SednaReservationAPI.Application.Abstractions;
using SednaReservationAPI.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Persistence
{
    public static class CustomerRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<ICustomerService, CustomerService>();
        }
    }
}
