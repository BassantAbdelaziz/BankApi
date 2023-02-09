using BankApi.Repositories;

namespace BankApi.Models;
[Serializable]

public class Customer
{
    /// <summary>
    /// Customer-specific identity.
    /// </summary>
    /// <example>"1"</example>
    public int CustomerId { get; set; }

    /// <summary>
    /// Name of the customer.
    /// </summary>
    /// <example>"Ali"</example>
    public string Name { get; set; }
    /// <summary>
    /// Last of the customer.
    /// </summary>
    /// <example>"aziz"</example>
    public string Surname { get; set; }
    
    /// <summary>
    /// List of user Account.
    /// </summary>
    public List<Account> Accounts { get; set; }
}