using BankApi.Models;
using BankApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers;

/// <summary>
/// Account controller.
/// </summary>
[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly ILogger<AccountController> _logger;
    private readonly IAccountSystem _system;
    /// <summary>
    /// Constructs a AccountController object.
    /// </summary>
    /// <param name="logger">A logger object.</param>
    /// <param name="system">A account system.</param>
    public AccountController(ILogger<AccountController> logger, IAccountSystem system)
    {
        _logger = logger;
        _system = system;
    }
    
    /// <summary>
    /// Creates a Account object.
    /// </summary>
    /// <param name="account">A customer account object.</param>
    /// <returns>A account object.</returns>
    /// <response code="200">Returns a customer object.</response>
    /// <response code="400">If invalid data pass.</response>
    [AllowAnonymous]
    [HttpPost]
    [ProducesResponseType(typeof(CustomerAccount), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CreateUserAccount([FromBody]CustomerAccount account)
    {
        _logger.LogInformation("Receive new Customer account POST Request");
        var createdAccount = _system.CreateNewAccount(account);
        return CreatedAtRoute("", new { id = createdAccount }, createdAccount);
     
    }
}
