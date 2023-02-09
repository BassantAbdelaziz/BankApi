using BankApi.Models;

namespace BankApi.Repositories;

public interface ICustomerSystem
{
    Customer GetCustomerById(long customerId);
    List<Customer> read(long customerId);
}