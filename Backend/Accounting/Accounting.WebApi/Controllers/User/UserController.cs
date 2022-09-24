using Accounting.BLL.Users.Interfaces;
using Accounting.Model.Users.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace Accounting.WebApi.Controllers.User;

/// <summary>
/// A class for registration users
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _user;

    public UserController(ILogger<UserController> logger, IUserService user)
    {
        _logger = logger;
        _user = user;
    }

    /// <summary>
    /// Register new users [sample]
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("test-api")]
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

    /// <summary>
    /// Remove a user 
    /// </summary>
    /// <param name="userId">remove user with this id</param>
    /// <returns></returns>
    [Route("remove")]
    [HttpPost]
    public async Task<IActionResult> Remove(int userId)
    {
        if (!ModelState.IsValid) return BadRequest();

        bool isDeleted = await _user.Remove(userId);

        return isDeleted == true ? Ok() : NotFound(userId);
    }

    /// <summary>
    /// Get all system users
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route("getUser")]
    public async Task<IActionResult> GetUsers()
    {
        if (!ModelState.IsValid) return BadRequest();

        return Ok(await _user.GetUsersAsync());
    }
}
