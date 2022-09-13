using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers;

/// <summary>
/// A class for registration users
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class RegisterController : ControllerBase
{
    private readonly ILogger<RegisterController> logger;

    public RegisterController(ILogger<RegisterController> logger)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Register new users 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> RegisterUser()
    {
        return Ok("Registration is Succeed!");
    }
}
