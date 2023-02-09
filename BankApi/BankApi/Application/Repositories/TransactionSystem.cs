using BankApi.Models;

namespace BankApi.Repositories;

public class TransactionSystem : ITransactionSystem
{
    public Transaction HandleFirstTransaction(double initialCredit, long customer)
    {
        var transaction = new Transaction();

        transaction.TransactionId = 1;
        transaction.TransactionDateTime = DateTime.Now;
        transaction.TransactionAccountNumber = customer;
        transaction.AmountAdded = initialCredit;
        transaction.AmountDeducted = 0;
        return transaction;
    }
}