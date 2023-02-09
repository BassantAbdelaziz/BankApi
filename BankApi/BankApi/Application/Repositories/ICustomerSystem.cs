using BankApi.Models;

namespace BankApi.Repositories;

public interface ICustomerSystem
{
    /// <summary>
    /// Gets customer by it's Id.
    /// </summary>
    /// <param name="customerId">A customer Id.</param>
    /// <returns>A customer object.</returns>
    Customer GetCustomerById(long customerId);
    
    /// <summary>
    /// Reads all customer from json file by it's Id.
    /// </summary>
    /// <param name="customerId">A customer Id.</param>
    /// <returns>A customer object.</returns>
    Customer readCustomerFromJsonFile(long customerId);
}
