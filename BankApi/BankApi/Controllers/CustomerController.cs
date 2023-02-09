using BankApi.Models;
using BankApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BankApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly ICustomerSystem _system;

    public CustomerController(ICustomerSystem system, ILogger<CustomerController> logger)
    {
        _system = system;
        _logger = logger;
    }

    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(typeof(Customer), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetCustomerAccount(long customerId )
    {
        _logger.LogInformation("Receive new Customer account POST Request");
        var createdAccount = _system.read(customerId);
            return Ok(createdAccount);
        
        
    }
}