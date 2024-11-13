using CustomersApi.Dba;
using CustomersApi.Interfaces;
using CustomersApi.Models;
using Microsoft.AspNetCore.Razor.Hosting;

namespace CustomersApi.Services
{
    public class AddCustomerService : IAddCustomerService
    {
        private readonly ICustomerDatabase _database;

        public AddCustomerService(ICustomerDatabase database) {
          _database = database;
        }
        public async Task<bool> CreateCustomer(CustomerDto customer)
        {
            try
            {
                //Valido que el request tenga datos
                if (customer == null)
                {
                    throw new ArgumentNullException(nameof(customer));
                }
                // conecto a la bda;
                var x = await _database.CreateCustormers(customer);
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }

           
        }

    }
}
