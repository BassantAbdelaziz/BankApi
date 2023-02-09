using System;
using System.Text.Json.Serialization;
using BankApi.Application.Repositories.Exceptions;
using BankApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BankApi.Repositories;

public class CustomerSystem : ICustomerSystem
{
    protected readonly string FilesDirectory;

    public CustomerSystem(string filesDirectory = "/Application/Repositories/customerData/")
    {
        FilesDirectory = Directory.GetCurrentDirectory() + filesDirectory;

    }

    public Customer GetCustomerById(long customerId)
    {
        try
        {
            List<Customer> allCustomer = CustomersData();
            var customer= allCustomer.FirstOrDefault(x=>x.CustomerId == customerId);
            if (customer == null)
                throw new NotFoundException(
                    $"No Customer Exist with this ID {customerId} .");
            return customer;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       

    }

    public List<Customer> read(long customerId)
    {
        string JsonFile = "customerData.json";
        List<Customer> customers;

        string json = File.ReadAllText($"{FilesDirectory}/{JsonFile}");
        customers = JsonConvert.DeserializeObject<List<Customer>>(json);
        List<Customer> newOne = customers;
        return newOne;

    }
    

    private static List<Customer> CustomersData()
    {
        return new List<Customer>()
        {
            new()
            {
                CustomerId = 1, Name = "Ali", Accounts = new List<Account>
                {
                    new Account()
                    {
                        AccountId = 1,
                        AccountNumber = 12000162,
                        Balance = 300.00,
                        CreationDate = DateTime.Now,
                        Transactions = new List<Transaction>()
                        {
                            new Transaction()
                            {
                                TransactionId = 1,
                                TransactionAccountNumber = 12000162,
                                TransactionDateTime =DateTime.Now,
                                AmountAdded =50.000,
                                AmountDeducted = 00.00,
                            },
                            new Transaction()
                            {
                                TransactionId = 1,
                                TransactionAccountNumber = 12000162,
                                TransactionDateTime =DateTime.Now,
                                AmountAdded =00.00 ,
                                AmountDeducted =10.000,
                            }
                        }
                    },
                    new Account()
                    {
                        AccountId = 2,
                        AccountNumber = 12000163,
                        Balance = 00.00,
                        CreationDate = DateTime.Now
                    }
                }
            },
            new()
            {
                CustomerId = 2, Name = "Sara", Accounts = new List<Account>
                {
                    new Account()
                    {
                        AccountId = 3,
                        AccountNumber = 12000166,
                        Balance = 300.00,
                        CreationDate = DateTime.Now,
                        Transactions = new List<Transaction>()
                        {
                            new Transaction()
                            {
                                TransactionId = 1,
                                TransactionAccountNumber = 12000162,
                                TransactionDateTime =DateTime.Now,
                                AmountAdded =50.000,
                                AmountDeducted = 00.00,
                            }
                        }
                        
                    },
                    
                }
            },
            new()
            {
                CustomerId = 3, Name = "Ahmed", Accounts = new List<Account>
                {
                    new Account()
                    {
                        AccountId = 4,
                        AccountNumber = 12000167,
                        Balance = 200.00,
                        CreationDate = DateTime.Now
                    },
                }
            },
        };

    }
}