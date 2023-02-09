using System.Text.Json;
using BankApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BankApi.Repositories;

public class AccountSystem : IAccountSystem
{
    private readonly ICustomerSystem _customerSystem;
    private readonly ITransactionSystem _transactionSystem;
    protected readonly string FilesDirectory;


    public AccountSystem(ICustomerSystem customerSystem, ITransactionSystem transactionSystem, string filesDirectory = "/Application/Repositories/customerData/")
    {
        _customerSystem = customerSystem;
        _transactionSystem = transactionSystem;
        FilesDirectory = Directory.GetCurrentDirectory() + filesDirectory;
    }

    public Account CreateNewAccount(CustomerAccount request)
    {
        var customers = _customerSystem.read(request.CustomerId);
        var customer = customers.First(x => x.CustomerId == request.CustomerId);
        var AccountId = GenerateNewAccountId(customer);      
        var AccountNumber = GenerateNewAccountNumber(customer);

        customer.Accounts.Add( new Account()
        {
            AccountId = AccountId,
            AccountNumber = AccountNumber,
            Balance = request.InitialCredit,
            CreationDate = DateTime.Now,
            Transactions = request.InitialCredit > 0
                ? new List<Transaction> { _transactionSystem.HandleFirstTransaction(request.InitialCredit, AccountNumber) }
                : new List<Transaction>()
        });

        string json = JsonConvert.SerializeObject(customers, Formatting.Indented);
        string JsonFile = "customerData.json";
        File.WriteAllText(
            $"{FilesDirectory}/{JsonFile}",
            json);

        return GetLastCreatedAccount(customer);
    }

    private long GenerateNewAccountNumber(Customer customer)
    {
        return ++GetLastCreatedAccount(customer).AccountNumber;
    }

    private long GenerateNewAccountId(Customer customer)
    {
        return ++GetLastCreatedAccount(customer).AccountId;
    }

    private Account GetLastCreatedAccount(Customer customer)
    {
        return customer.Accounts.Last();
    }
}
