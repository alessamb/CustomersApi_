using CustomersApi.Models;

namespace CustomersApi.Interfaces
{
    public interface ICustomerDatabase
    {
        Task<bool> CreateCustormers(CustomerDto customer);
    }
}
