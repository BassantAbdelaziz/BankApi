using BankApi.Models;

namespace BankApi.Repositories;

public interface ITransactionSystem
{
    public Transaction HandleFirstTransaction(double initialCredit, long customer);
}