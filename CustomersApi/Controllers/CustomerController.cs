using CustomersApi.Interfaces;
using CustomersApi.Models;
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
       
        [HttpPost()]
        public async Task<bool> CreateCustomer(CustomerDto customer)
        {
            //Valido que el request sea correcto
            //Agrego los datos a bda
            //retorno que todo esta ok
            var  s = await _addCustomer.CreateCustomer(customer);
            return true;
        }
    }
}
