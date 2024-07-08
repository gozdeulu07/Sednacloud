using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SednaReservationAPI.Application.Repositories;
using SednaReservationAPI.Domain.Entities;

namespace SednaReservationAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        public CustomersController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            /*
            await _customerWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), Name = "Berke Alpaslan", Age = 22, Email = "alpaslanberke@gmail.com", Gender = "Male", Password = "sednacloud", Phone = "+905373914979", CreatedAt = DateTime.UtcNow}
            });
            await _customerWriteRepository.SaveAsync();
            return Ok("Customer Added Successfully!");
            */
            Customer customer = await _customerReadRepository.GetByIdAsync("6481e9ab-6c14-4aeb-ac05-0979dfec8194", false);
            customer.Name = "Berke";
            await _customerWriteRepository.SaveAsync();
            return Ok("Manipulation Success!");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Customer customer = await _customerReadRepository.GetByIdAsync(id);
            return Ok(customer);
        }
    }
}
