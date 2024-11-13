using CustomersApi.Models;
using System.Runtime.InteropServices;
using CustomersApi.Interfaces;

namespace CustomersApi.Dba
{
    public class CustomerDatabase : ICustomerDatabase
    {
        //agregar
        //update
        private readonly AppDbContext _context;

        public CustomerDatabase(AppDbContext context)
        { 
            _context = context;
        }

        public async Task<bool> CreateCustormers(CustomerDto customer)
        {
            try
            {
                _context.CustomersDto.AddRange(customer);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex) 
            {
                
            }

            return true;
        }
    }
}
