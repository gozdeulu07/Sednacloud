using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Payment : BaseEntitity
    {
<<<<<<< HEAD
        public Guid ReservationId { get; set; }
=======
        public string ReservationId { get; set; }
>>>>>>> Berke
        public decimal Amount { get; set; }
        public string? Status { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
