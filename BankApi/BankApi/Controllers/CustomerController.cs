using BankApi.Models;
using BankApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers;

/// <summary>
/// customer controller.
/// </summary>
[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly ICustomerSystem _system;

    /// <summary>
    /// Constructs a CustomereController object.
    /// </summary>
    /// <param name="logger">A logger object.</param>
    /// <param name="system">A customer system.</param>
    public CustomerController(ICustomerSystem system, ILogger<CustomerController> logger)
    {
        _system = system;
        _logger = logger;
    }

    /// <summary>
    /// Retrieves a customer object.
    /// </summary>
    /// <param name="customerId">A customer Id.</param>
    /// <returns>A customer object.</returns>
    /// <response code="200">Returns a customer object.</response>
    /// <response code="404">If no customer with the provided Id exists.</response>
    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(typeof(Customer), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetCustomerAccount(long customerId )
    {
        _logger.LogInformation("Receive new Customer account POST Request");
        var createdAccount = _system.readCustomerFromJsonFile(customerId);
            return Ok(createdAccount);
        
        
    }
}
