using BankApi.Models;

namespace BankApi.Repositories;

public interface IAccountSystem
{

Account CreateNewAccount(CustomerAccount request);
}