using MediatR;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Features.Queries.Review;
using SednaReservationAPI.Application.Repositories;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewReadRepository _reviewReadRepository;
        private readonly IReviewWriteRepository _reviewWriteRepository;
        private readonly IMediator _mediator;

        public ReviewController(IReviewReadRepository reviewReadRepository, IReviewWriteRepository reviewWriteRepository, IMediator mediator)
        {
            _reviewReadRepository = reviewReadRepository;
            _reviewWriteRepository = reviewWriteRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> getReview([FromQuery] GetAllReviewQueryRequest getAllReviewQueryRequest)
        {
            List<GetAllReviewQueryResponse> response = await _mediator.Send(getAllReviewQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")] 
        public async Task<IActionResult> getReviewById([FromQuery] GetByIdReviewQueryRequest getByIdReviewQueryRequest) 
        {
            GetByIdReviewQueryResponse response = await _mediator.Send(getByIdReviewQueryRequest);
            return Ok(response);
        }


    }
}
