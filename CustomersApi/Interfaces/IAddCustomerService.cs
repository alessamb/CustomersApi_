using CustomersApi.Models;

namespace CustomersApi.Interfaces
{
    public interface IAddCustomerService
    {
        Task<bool> CreateCustomer(CustomerDto customer);
    }
}
