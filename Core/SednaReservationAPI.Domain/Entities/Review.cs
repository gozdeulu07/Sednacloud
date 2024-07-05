using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Review : BaseEntitity
    {
        public Guid HotelId { get; set; }
        public Guid UserId { get; set; }
        public float Rating { get; set; }
        public string? Comment { get; set; }
    }
}
