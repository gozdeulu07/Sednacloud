using Microsoft.AspNetCore.Identity;
using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Customer : IdentityUser<Guid>
    {
        public string fullName { get; set; } = string.Empty;
        public Customer() { 
        Id = Guid.NewGuid();
      
        }
  

    }
}
