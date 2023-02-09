using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BankApi.Models;

[DataContract]
public class CustomerAccount
{
    /// <summary>
    /// Customer-Account-specific identity.
    /// </summary>
    /// <example>"1"</example>
    [Required(ErrorMessage = "The customer account Id is required")]
    public long CustomerId { get; set; }

    [Required(ErrorMessage = "The initial credit is required")]
    public double InitialCredit { get; set; }
}