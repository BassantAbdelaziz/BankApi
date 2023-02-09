using BankApi.Models;

namespace BankApi.Repositories;

public interface ITransactionSystem
{
    /// <summary>
    /// Handles first transaction in the new opened.
    /// </summary>
    /// <param name="initialCredit">Initial amount to open new account.</param>
    /// <returns>A first transaction on the account.</returns>
  
    public Transaction HandleFirstTransaction(double initialCredit, long customer);
}
