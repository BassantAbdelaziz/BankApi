using System.Text.Json;
using BankApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BankApi.Repositories;

public class AccountSystem : IAccountSystem
{
    private readonly ICustomerSystem _customerSystem;
    private readonly ITransactionSystem _transactionSystem;

    public AccountSystem(ICustomerSystem customerSystem, ITransactionSystem transactionSystem)
    {
        _customerSystem = customerSystem;
        _transactionSystem = transactionSystem;
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

        List<Customer> newList = customers.ToList();

        string json = JsonConvert.SerializeObject(newList, Formatting.Indented);

        // Write the entire JSON string to the file, replacing any existing content
        File.WriteAllText(
            "/home/bassant/RiderProjects/BankApi/BankApi/Application/Repositories/customerData/customerData.json",
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