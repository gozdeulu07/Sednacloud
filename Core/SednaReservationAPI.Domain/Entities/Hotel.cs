using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Hotel : BaseEntitity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        public float StarRating { get; set; }
        public int Star {  get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Room>? Rooms { get; set; }
        public ICollection<RoomType>? RoomTypes { get; set; }
    }
}
