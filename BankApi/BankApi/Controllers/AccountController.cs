using BankApi.Models;
using BankApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly ILogger<AccountController> _logger;
    private readonly IAccountSystem _system;

    public AccountController(ILogger<AccountController> logger, IAccountSystem system)
    {
        _logger = logger;
        _system = system;
    }
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