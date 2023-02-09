using BankApi.Models;

namespace BankApi.Repositories;

public class TransactionSystem : ITransactionSystem
{

    /// <summary>
    /// creates first transaction in the new opened account.
    /// </summary>
    /// <param name="initialCredit">Initial amount to open new account.</param>
    /// <param name="accountNumber">The account number.</param>
    /// <returns>A first transaction on the account.</returns>
    public Transaction CreateFirstTransaction(double initialCredit, long accountNumber)
    {
        var transaction = new Transaction();

        transaction.TransactionId = 1;
        transaction.TransactionDateTime = DateTime.Now;
        transaction.TransactionAccountNumber = accountNumber;
        transaction.AmountAdded = initialCredit;
        transaction.AmountDeducted = 0;
        return transaction;
    }
}
