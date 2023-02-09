using BankApi.Models;

namespace BankApi.Repositories;

public interface ITransactionSystem
{
    /// <summary>
    /// creates first transaction in the new opened account.
    /// </summary>
    /// <param name="initialCredit">Initial amount to open new account.</param>
    /// <param name="accountNumber">The account number.</param>
    /// <returns>A first transaction on the account.</returns>
    public Transaction CreateFirstTransaction(double initialCredit, long customer);
}
