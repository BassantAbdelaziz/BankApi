namespace BankApi.Models;

public class Account
{
    /// <summary>
    /// Customer-Account-specific identity.
    /// </summary>
    /// <example>"1"</example>
    public long AccountId { get; set; }

    /// <summary>
    /// Account-specific identity.
    /// </summary>
    /// <example>"1"</example>

    public long AccountNumber { get; set; }

    /// <summary>
    /// The total amount that the customer has in his account.
    /// </summary>
    /// <example>"20.000"</example>

    public double Balance { get; set; }

    /// <summary>
    /// The creation date of the account
    /// </summary>
    public DateTime CreationDate { get; set; }
    /// <summary>
    /// The list of all account Transactions
    /// </summary>

    public List<Transaction> Transactions { get; set; }
}