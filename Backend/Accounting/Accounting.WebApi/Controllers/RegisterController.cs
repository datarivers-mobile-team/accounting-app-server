using Accounting.BLL.Users.Interfaces;
using Accounting.Model.Users.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers;

/// <summary>
/// A class for registration users
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class RegisterController : ControllerBase
{
    private readonly ILogger<RegisterController> _logger;
    private readonly IUser _user;

    public RegisterController(ILogger<RegisterController> logger,IUser user)
    {
        _logger = logger;
        _user = user;
    }

    /// <summary>
    /// Register new users [sample]
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> RegisterUser()
    {
        return Ok("Registration is Succeed!");
    }

    /// <summary>
    /// Register new users
    /// </summary>
    /// <param name="register">user information for registration</param>
    /// <returns></returns>
    [HttpPost]
    [AutoValidateAntiforgeryToken]    
    public async Task<IActionResult> RegisterUser(RegisterDto register)
    {
        if (!ModelState.IsValid) return BadRequest();

        await _user.RegisterAsync(register);

        return Ok();
    }
}
