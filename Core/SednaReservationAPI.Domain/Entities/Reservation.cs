using SednaReservationAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Domain.Entities
{
    public class Reservation : BaseEntitity
    {
        public string? UserId { get; set; }
        public string? RoomId { get; set; }
        public string? RoomTypeId { get; set; }
        public string? HotelId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalPrice { get; set; }
        public string? Status { get; set; }
        
        [ForeignKey("RoomId")]
        public ICollection<Room>? Rooms { get; set; }

        [ForeignKey("RoomId")]
        public ICollection<RoomType>? RoomTypes {  get; set; } 
    }
}
