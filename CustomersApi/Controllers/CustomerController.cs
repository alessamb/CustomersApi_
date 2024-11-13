using CustomersApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
      
        private readonly IUpdateCustomerService _updateCustomer;
        private readonly IAddCustomerService _addCustomer;


        public CustomerController(IUpdateCustomerService updateCustomer, IAddCustomerService addCustomer)
        {
            
            _updateCustomer = updateCustomer;
            _addCustomer = addCustomer;

        }

        [HttpGet("id")]
        public async Task<bool> GetCustomer()
        {
            throw new NotImplementedException();
        }
        public async Task<IActionResult> GetCustomers()
        {

            throw new NotImplementedException();
        }

        public async Task<Boolean> DeleteCustomer()
        {
            throw new NotImplementedException();

        }
        public async Task<IActionResult> CreateCustomer( )
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> UpdateCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
