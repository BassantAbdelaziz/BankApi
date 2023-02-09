using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BankApi.Models;

public class CustomerAccount
{
    /// <summary>
    /// Customer-Account-specific identity.
    /// </summary>
    /// <example>"1"</example>
    [Required(ErrorMessage = "The customer account Id is required")]
    public long CustomerId { get; set; }
    /// <summary>
    /// Initial amount to open new account.
    /// </summary>
    /// <example>"0.00"</example>
    [Required(ErrorMessage = "The initial credit is required")]
    public double InitialCredit { get; set; }
}
