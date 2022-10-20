using Accounting.BLL.Account.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers.Account;

/// <summary>
/// A class for Account API
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    /// <summary>
    /// This method for create new accoutn
    /// </summary>
    /// <param name="account">account fields for create new one</param>
    /// <returns></returns>
    [HttpPost]
    [Route("add")]
    public async Task<IActionResult> CreateAccount(Accounting.Model.Account.Entities.Account account)
    {
        if (!ModelState.IsValid) return BadRequest(account);

        await _accountService.CreateAccount(account);

        return Ok(account);
    }
}
