using MediatR;
using SednaReservationAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SednaReservationAPI.Application.Features.Queries.Payment
{
    // Bütün ödemeleri getir.
    public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQueryRequest, List<GetAllPaymentQueryResponse>>
    {
        readonly IPaymentReadRepository paymentReadRepository;
    public GetAllPaymentQueryHandler(IPaymentReadRepository paymentReadRepository)
        {
            this.paymentReadRepository = paymentReadRepository;
        }

       public Task<List<GetAllPaymentQueryResponse>> Handle(GetAllPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            var payments = this.paymentReadRepository.GetAll(false)
               .Select(h => new GetAllPaymentQueryResponse
               {
                   Id = h.Id.ToString(),
                   ReservationId = h.ReservationId,
                   Amount = h.Amount,
                   Status = h.Status,
                   PaymentMethod = h.PaymentMethod,
                   Date = h.Date
               })
               .ToList();

            return Task.FromResult(payments);
        }
    }

    public class GetAllPaymentQueryRequest : IRequest<List<GetAllPaymentQueryResponse>>
    {
    }

    public class GetAllPaymentQueryResponse
    {   
         public string Id { get; set; } = string.Empty;
        public string ReservationId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string? Status { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime Date { get; set; }
    }

 // Id'ye göre ödemeyi getir.

    public class GetByIdPaymentQueryHandler : IRequestHandler<GetByIdPaymentQueryRequest, GetByIdPaymentQueryResponse>
    {
        readonly IPaymentReadRepository _paymentReadRepository;
        public GetByIdPaymentQueryHandler(IPaymentReadRepository paymentReadRepository)
        {
            _paymentReadRepository = paymentReadRepository;
        }

        public async Task<GetByIdPaymentQueryResponse> Handle(GetByIdPaymentQueryRequest request, CancellationToken cancellationToken)
        {
            var odeme = await _paymentReadRepository.GetByIdAsync(request.id); // getByIdFonksiyonunu kullanarak id parametresini gönderip odemenin icine bilgileri aktardık


            var response = new GetByIdPaymentQueryResponse
            {
                Id = odeme.Id.ToString(),
                ReservationId = odeme.ReservationId,
                Amount = odeme.Amount,
                Status = odeme.Status,
                PaymentMethod = odeme.PaymentMethod,
                Date = odeme.Date
            };

            return response;
        }
    }

    public class GetByIdPaymentQueryRequest : IRequest<GetByIdPaymentQueryResponse>
    {
        public string id = string.Empty; 
    }

    public class GetByIdPaymentQueryResponse
    {
        public string Id { get; set; } = string.Empty;
        public string ReservationId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string? Status { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime Date { get; set; }
    }

}

