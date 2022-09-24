using Accounting.BLL.Otp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.WebApi.Controllers.Otp;

/// <summary>
/// A class for generate and get a otp password
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class OtpController : ControllerBase
{
    private readonly IOtpService _otpService;

    public OtpController(IOtpService otpService)
    {
        _otpService = otpService;
    }

    /// <summary>
    /// Create a otp password
    /// </summary>
    /// <param name="cellPhoneNumber">cell phone number for create a otp code</param>
    /// <returns></returns>
    [HttpPost]
    [Route("getOptCode")]
    public async Task<IActionResult> GetOtpCode(string cellPhoneNumber)
    {
        if (!ModelState.IsValid) return BadRequest(cellPhoneNumber);

        string otp = await _otpService.GetOtpCodeAsync(cellPhoneNumber);

        if (otp == null)
        {
            return NotFound(cellPhoneNumber);
        }

        return Ok(otp);
    }
}
