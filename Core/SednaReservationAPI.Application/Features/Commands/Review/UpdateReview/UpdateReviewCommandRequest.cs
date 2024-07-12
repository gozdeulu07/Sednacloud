using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Commands.Review.UpdateReview
{
    public class UpdateReviewCommandRequest : IRequest<UpdateReviewCommandResponse>
    {
        public string Id { get; set; }
        public Guid HotelId { get; set; }
        public Guid UserId { get; set; }
        public float Rating { get; set; }
        public string? Comment { get; set; }
    }
}
