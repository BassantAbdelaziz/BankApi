using BankApi.Models;

namespace BankApi.Repositories;

public interface IAccountSystem
{
/// <summary>
/// Creats a new account of an exsit customer.
/// </summary>
/// <param name="request">An object to hold the required data to create new account.</param>
/// <returns>A account object.</returns>
Account CreateNewAccount(CustomerAccount request);
}
