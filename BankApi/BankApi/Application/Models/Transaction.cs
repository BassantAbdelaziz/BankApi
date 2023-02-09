namespace BankApi.Models;

public class Transaction
{
    /// <summary>
    /// Customer-specific identity.
    /// </summary>
    /// <example>"1"</example>
    public int TransactionId { get; set; } 
    
    /// <summary>
    /// Name of the customer.
    /// </summary>
    /// <example>"Ali"</example>
    public DateTime TransactionDateTime { get; set; }
    
    /// <summary>
    /// The initial amount of credit.
    /// </summary>
    /// <example>"20.000"</example>
    public long TransactionAccountNumber { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public double AmountAdded { get; set; }
    /// <summary>
    ///
    /// </summary>
    public double AmountDeducted { get; set; }
    
}