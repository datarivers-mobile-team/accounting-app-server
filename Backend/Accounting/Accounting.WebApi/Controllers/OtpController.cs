using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers;

/// <summary>
/// A class for generate and get a otp password
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class OtpController : ControllerBase
{
    [HttpGet]
    [Route("optCode")]
    public async Task<IActionResult> GenerateOtpCode(string cellPhoneNumber)
    {
        //TODO : create a randome opt id
        return Ok();
    }

    [HttpPost]
    [Route("getOptCode")]
    public async Task<IActionResult> GetOtpCode(string cellPhoneNumber)
    {
        //TODO : find otp code for send cell phone number
        return Ok();
    }
}
