using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Room : BaseEntitity
    {
        public string? HotelId { get; set; }
        public string? RoomTypeId { get; set; }
        public decimal? BaseAdultPrice { get; set; }
        public decimal? BaseChildPrice { get; set; }
        public decimal? AdultPrice { get; set; }
        public decimal? ChildPrice { get; set; }
        public string? Status { get; set; }
        public ICollection<Customer>? Customers { get; set; }
        public ICollection<Hotel>? Hotels { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
