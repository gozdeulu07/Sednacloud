using SednaReservationAPI.Application.Abstractions;
using SednaReservationAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Persistence.Concretes
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomers()
        => new()
        {
            new() {Id = Guid.NewGuid(), FullName = "Berke Alpaslan", Email = "alpaslanberke@gmail.com", Password = "BaraCuda", PhoneNumber = 053739914979, Age = 22, Gender = "Male"}
        };
    }
}
