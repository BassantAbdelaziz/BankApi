namespace BankApi.Models;

public class Transaction
{
    /// <summary>
    /// Transaction-specific identity.
    /// </summary>
    /// <example>"1"</example>
    public int TransactionId { get; set; } 
    
    /// <summary>
    /// Creation date of the transaction.
    /// </summary>
    /// <example>"Ali"</example>
    public DateTime TransactionDateTime { get; set; }
    
    /// <summary>
    /// The account number.
    /// </summary>
    /// <example>"10007891"</example>
    public long TransactionAccountNumber { get; set; }
    
    /// <summary>
    /// The total amount added
    /// </summary>
    /// <example>"50.00"</example>
    public double AmountAdded { get; set; }
    /// <summary>
    ///The total amount deducted
    /// </summary>
    /// <example>"50.00"</example>
    public double AmountDeducted { get; set; }
    
}
