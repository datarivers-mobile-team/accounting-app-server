using Accounting.BLL.Users.Interfaces;
using Accounting.Model.Users.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace Accounting.WebApi.Controllers;

/// <summary>
/// A class for registration users
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly ILogger<AccountController> _logger;
    private readonly IAccount _user;

    public AccountController(ILogger<AccountController> logger, IAccount user)
    {
        _logger = logger;
        _user = user;
    }

    /// <summary>
    /// Register new users [sample]
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult RegisterUser()
    {
        return Ok("Registration is Succeed!");
    }

    /// <summary>
    /// Register new users
    /// </summary>
    /// <param name="register">user information for registration</param>
    /// <returns></returns>
    [Route("register")]
    [HttpPost]
    public async Task<IActionResult> RegisterUser(RegisterDto register)
    {
        if (!ModelState.IsValid) return BadRequest();

        await _user.RegisterAsync(register);

        return Ok();
    }

    /// <summary>
    /// Login users
    /// </summary>
    /// <param name="cellPhoneNumber">cell phone number for login</param>
    /// <returns></returns>
    [Route("login")]
    [HttpPost]
    public async Task<IActionResult> Login(string cellPhoneNumber)
    {
        if (!ModelState.IsValid) return BadRequest();

        bool isLogin = await _user.Login(cellPhoneNumber);

        if (isLogin)
            return Ok();

        return Unauthorized();
    }
}
