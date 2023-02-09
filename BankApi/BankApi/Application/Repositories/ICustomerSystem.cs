using BankApi.Models;

namespace BankApi.Repositories;

public interface ICustomerSystem
{
    Customer GetCustomerById(long customerId);
    Customer readCustomerFromJsonFile(long customerId);
}
