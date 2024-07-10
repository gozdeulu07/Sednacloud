using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Reservation : BaseEntitity
    {
<<<<<<< HEAD
        public Guid UserId { get; set; }
        public Guid RoomId { get; set; }
=======
        public string? UserId { get; set; }
        public string? RoomId { get; set; }
>>>>>>> Berke
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public string? Status { get; set; }
    }
}
